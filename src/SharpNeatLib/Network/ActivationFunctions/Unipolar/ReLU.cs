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
using Redzen.Numerics;

namespace SharpNeat.Network
{
    /// <summary>
    /// Rectified linear activation unit (ReLU).
    /// </summary>
    public class ReLU : IActivationFunction
    {
        /// <summary>
        /// Default instance provided as a public static field.
        /// </summary>
        public static readonly IActivationFunction __DefaultInstance = new ReLU();

        public string FunctionId => this.GetType().Name;

        public string FunctionString => "";

        public string FunctionDescription => "Leaky Rectified Linear Unit (ReLU)";

        public double Calculate(double x)
        {
            double y;
            if (x > 0.0) {
                y = x;
            } else {
                y = 0;
            }
            return y;
        }

        public float Calculate(float x)
        {
            float y;
            if (x > 0.0) {
                y = x;
            } else {
                y = 0;
            }
            return y;
        }
    }
}
