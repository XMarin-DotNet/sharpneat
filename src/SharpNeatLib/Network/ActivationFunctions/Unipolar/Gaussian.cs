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
    /// Gaussian activation function. Output range is 0 to 1, that is, the tails of the Gaussian
    /// distribution curve tend towards 0 as abs(x) -> Infinity and the Gaussian peak is at x = 0.
    /// </summary>
    public class Gaussian : IActivationFunction
    {
        /// <summary>
        /// Default instance provided as a public static field.
        /// </summary>
        public static readonly IActivationFunction __DefaultInstance = new Gaussian();

        /// <summary>
        /// Gets the unique ID of the function. Stored in network XML to identify which function a network or neuron 
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
            get { return "y = e^(-(x*2.5)^2)"; }
        }

        /// <summary>
        /// Gets a human readable verbose description of the activation function.
        /// </summary>
        public string FunctionDescription
        {
            get { return "Gaussian.\r\nEffective xrange->[-1,1] yrange->[0,1]"; }
        }

        /// <summary>
        /// Calculates the output value for the specified input value.
        /// </summary>
        public double Calculate(double x)
        {
            return Math.Exp(-Math.Pow(x * 2.5, 2.0));
        }

        /// <summary>
        /// Calculates the output value for the specified input value.
        /// This single precision overload of Calculate() will be used in neural network code 
        /// that has been specifically written to use floats instead of doubles.
        /// </summary>
        public float Calculate(float x)
        {
            return (float)Math.Exp(-Math.Pow(x * 2.5f, 2.0));
        }
    }
}
