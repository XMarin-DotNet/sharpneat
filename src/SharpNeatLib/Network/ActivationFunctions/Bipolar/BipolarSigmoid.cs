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
using Redzen.Numerics;
using SharpNeat.Utility;

namespace SharpNeat.Network
{
    /// <summary>
    /// Bipolar sigmoid activation function. Output range is -1 to 1 instead of the more normal 0 to 1.
    /// </summary>
    public class BipolarSigmoid : IActivationFunction
    {
        /// <summary>
        /// Default instance provided as a public static field.
        /// </summary>
        public static readonly IActivationFunction __DefaultInstance = new BipolarSigmoid();

        /// <summary>
        /// Gets the Gets the unique ID of the function. Stored in network XML to identify which function a network or neuron 
        /// is using.
        /// </summary>
        public string FunctionId
        {
            get { return this.GetType().Name; }
        }

        /// <summary>
        /// Gets a human readable string representation of the function. E.g 'y=1/x'.
        /// </summary>
        public string FunctionString
        {
            get { return "y = 2.0/(1.0 + exp(-4.9*x)) - 1.0"; }
        }

        /// <summary>
        /// Gets a human readable verbose description of the activation function.
        /// </summary>
        public string FunctionDescription
        {
            get { return "Bipolar steepened sigmoid.\r\nEffective xrange->[-1,1] yrange->[-1,1]"; }
        }

        /// <summary>
        /// Calculates the output value for the specified input value.
        /// </summary>
        public double Calculate(double x)
        {
            return (2.0 / (1.0 + Math.Exp(-4.9 * x))) - 1.0;
        }

        /// <summary>
        /// Calculates the output value for the specified input value.
        /// This single precision overload of Calculate() will be used in neural network code 
        /// that has been specifically written to use floats instead of doubles.
        /// </summary>
        public float Calculate(float x)
        {
            return (2f / (1f + (float)Math.Exp(-4.9f * x))) - 1f;
        }
    }
}
