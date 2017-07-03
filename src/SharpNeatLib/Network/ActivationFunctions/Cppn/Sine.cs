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
    /// Sine activation function with doubled period.
    /// </summary>
    public class Sine : IActivationFunction
    {
        public string Id => "Sine";

        public double Fn(double x)
        {
            return Math.Sin(2.0 * x);
        }
    }
}
