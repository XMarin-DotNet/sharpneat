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
    /// A very close approximation of the logistic function that avoids use of exp() and is therefore
    /// typically much faster to compute, while giving an alomost identical sigmoid curve.
    /// 
    /// This function was obtained from:
    ///    http://stackoverflow.com/a/34448562/15703
    /// 
    /// 
    /// This might be based on the Pade approximant:
    ///   https://en.wikipedia.org/wiki/Pad%C3%A9_approximant
    ///   https://math.stackexchange.com/a/107666
    /// 
    /// Or perhaps the maple minimax approximation:
    ///   http://www.maplesoft.com/support/helpJP/Maple/view.aspx?path=numapprox/minimax
    ///   
    /// This is a variant that has a steeper slope at and around the origin that is intended to be a similar
    /// slope to that of LogisticFunctionSteep.
    ///   
    /// </summary>
    public class PolynomialApproximantSteep : IActivationFunction
    {
        /// <summary>
        /// Default instance provided as a public static field.
        /// </summary>
        public static readonly IActivationFunction __DefaultInstance = new PolynomialApproximantSteep();

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
            x = x * 4.9;
            double x2 = x*x;
            double e = 1.0 + Math.Abs(x) + (x2 * 0.555) + (x2 * x2 * 0.143);

            double f = (x > 0) ? (1.0 / e) : e;
            return 1.0 / (1.0 + f);
        }
    }
}
