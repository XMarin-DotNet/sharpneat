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
    /// The softsign sigmoid.
    /// This is a variant of softsign that has a steeper slope at and around the origin that 
    /// is intended to be a similar slope to that of LogisticFunctionSteep.
    /// </summary>
    public class SoftSignSteep : IActivationFunction
    {
        /// <summary>
        /// Default instance provided as a public static field.
        /// </summary>
        public static readonly IActivationFunction __DefaultInstance = new SoftSignSteep();

        /// <summary>
        /// Gets the unique ID of the function. Stored in network XML to identify which function a network or neuron 
        /// is using.
        /// </summary>
        public string FunctionId
        {
            get { return this.GetType().Name; }
        }

        /// <summary>
        /// Calculates the output value for the specified input value.
        /// </summary>
        public double Calculate(double x)
        {
            return 0.5 + (x / (2.0 * ( 0.2 + Math.Abs(x))));
        }
    }
}
