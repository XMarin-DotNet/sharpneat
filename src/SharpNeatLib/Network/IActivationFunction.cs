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
        /// The activation function.
        /// </summary>
        double Fn(double x);

        /// <summary>
        /// A vectorised version of the activation function.
        /// Each value in the provided array has the activation function applied to it, the results 
        /// are stored in the same array, thus overwriting the inputs values with output values.
        /// </summary>
        void Fn(double[] x);
    }
}
