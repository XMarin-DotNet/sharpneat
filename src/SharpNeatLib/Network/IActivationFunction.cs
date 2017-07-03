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

namespace SharpNeat.Network
{
    /// <summary>
    /// Neural net node activation function.
    /// </summary>
    public interface IActivationFunction
    {
        /// <summary>
        /// Unique identifier string.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Calculates the output value for the specified input value.
        /// </summary>
        double Fn(double x);
    }
}
