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
    /// A sigmoid formed by two sub-sections of the y=x^2 curve.
    /// 
    /// The extremes are implemented as per the leaky ReLU, i.e. there is a linear slop to 
    /// ensure there is at least a gradient to follow at the extremes.
    /// </summary>
    public class QuadraticSigmoid : IActivationFunction
    {
        /// <summary>
        /// Default instance provided as a public static field.
        /// </summary>
        public static readonly IActivationFunction __DefaultInstance = new QuadraticSigmoid();

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
            const double t = 0.999;
            const double a = 0.00001;

            double sign = Math.Sign(x);
            x = Math.Abs(x);

            double y = 0;
            if(x >= 0 && x < t) {
                y = t - ((x - t) * (x - t));
            }
            else //if (x >= t) 
            {
                y = t + (x - t) * a;
            }

            return (y * sign * 0.5) + 0.5;
        }
    }
}
