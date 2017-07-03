/* ***************************************************************************
 * This file is part of SharpNEAT - Evolution of Neural Networks.
 * 
 * Copyright 2004-2016 Colin Green (sharpneat@gmail.com)
 *
 * SharpNEAT is free software; you can redistribute it and/or modify
 * it under the terms of The MIT License (MIT).
 *
 * You should have received a copy of the MIT License
 * along with SharpNEAT; if not, see https://opensource.org/licenses/MIT.
 */

using System.Collections.Generic;
using Redzen.Numerics;

namespace SharpNeat.Network
{
    /// <summary>
    /// Default implementation of an IActivationFunctionLibrary. 
    /// Also provides static factory methods to create libraries with commonly used activation functions.
    /// </summary>
    public class DefaultActivationFunctionLibrary : IActivationFunctionLibrary
    {
        readonly List<IActivationFunction> _fnList;
        readonly Dictionary<string,IActivationFunction> _fnById;
        readonly DiscreteDistribution _dist;

        #region Constructors

        public DefaultActivationFunctionLibrary() : this(4)
        {}

        public DefaultActivationFunctionLibrary(int capacity)
        {
            _fnList = new List<IActivationFunction>(capacity);
            _fnById = new Dictionary<string,IActivationFunction>(capacity);
        }

        private DefaultActivationFunctionLibrary(DiscreteDistribution dist) : this (dist.Probabilities.Length)
        {
            _dist = dist;
        }

        #endregion

        #region IActivationFunctionLibrary Members

        /// <summary>
        /// Gets the function with the specified ID string.
        /// </summary>
        public IActivationFunction GetFunction(int idx)
        {
            return _fnList[idx];
        }

        /// <summary>
        /// Gets the function with the specified ID string.
        /// </summary>
        public IActivationFunction GetFunction(string id)
        {
            return _fnById[id];
        }

        /// <summary>
        /// Randomly select a function based on each function's selection probability.
        /// </summary>
        public IActivationFunction GetRandomFunction(IRandomSource rng)
        {
            return _fnList[_dist.Sample(rng)];
        }

        /// <summary>
        /// Randomly select a function based on each function's selection probability.
        /// Returns the index of the function in the function library.
        /// </summary>
        public int GetRandomFunctionIndex(IRandomSource rng)
        {
            return _dist.Sample(rng);
        }

        /// <summary>
        /// Gets a list of all functions in the library.
        /// </summary>
        public IList<IActivationFunction> GetFunctionList()
        {
            return _fnList.AsReadOnly();
        }

        #endregion

        #region Private Methods

        private void AddEntry(IActivationFunction activationFn)
        {
            _fnList.Add(activationFn);
            _fnById.Add(activationFn.Id, activationFn);
        }

        #endregion

        #region Public Static Factory Methods

        /// <summary>
        /// Create an IActivationFunctionLibrary for use with NEAT.
        /// NEAT uses the same activation function for all neurons/nodes therefore this factory method
        /// creates an IActivationFunction containing only the single provided IActivationFunction.
        /// </summary>
        public static IActivationFunctionLibrary CreateLibraryNeat(IActivationFunction activationFn)
        {
            var dist = new DiscreteDistribution(new double[] { 1.0 });
            var lib = new DefaultActivationFunctionLibrary(dist);
            lib.AddEntry(activationFn);
            return lib;
        }

        /// <summary>
        /// Create an IActivationFunctionLibrary for use with CPPNs.
        /// </summary>
        public static IActivationFunctionLibrary CreateLibraryCppn()
        {
            var dist = new DiscreteDistribution(new double[] { 0.25, 0.25, 0.25, 0.25 });
            var lib = new DefaultActivationFunctionLibrary(dist);
            lib.AddEntry(new Linear());
            lib.AddEntry(new BipolarSigmoid());
            lib.AddEntry(new Gaussian());
            lib.AddEntry(new Sine());
            return lib;
        }

        #endregion
    }
}
