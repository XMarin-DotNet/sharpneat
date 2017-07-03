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

using System;

namespace SharpNeat.Network
{
    /// <summary>
    /// Represents a single entry in an IActivationFunctionLibrary.
    /// </summary>
    public struct ActivationFunctionEntry
    {
        readonly int _idx;
        readonly string _name;
        readonly Func<double,double> _fn;
        
        #region Constructor

        /// <summary>
        /// Construct with the provided index, name, and activation function.
        /// </summary>
        public ActivationFunctionEntry(int idx, string name, Func<double,double> fn)
        {
            _idx = idx;
            _name = name;
            _fn = fn;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the index assigned to the function in the owning function library.
        /// </summary>
        public int Idx
        {
            get { return _idx; }
        }

        /// <summary>
        /// Function name, can be used as a unique identifier.
        /// </summary>
        public string Name
        {
            get { return _name; }
        }

        /// <summary>
        /// Gets the activation function.
        /// </summary>
        public Func<double, double> Fn
        {
            get { return _fn; }
        }

        #endregion
    }
}
