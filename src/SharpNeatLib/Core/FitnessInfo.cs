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
namespace SharpNeat.Core
{
    public struct FitnessInfo
    {
        /// <summary>
        /// A default/null/empty FitnessInfo structure.
        /// </summary>
        public static readonly FitnessInfo Empty = new FitnessInfo(null);

        /// <summary>
        /// An array of fitness scores. Most problem tasks will yield just a single fitness value, here we allow for 
        /// multiple fitness values per evaluation to allow for multiple objectives and/or auxiliary 
        /// fitness scores that are for reporting only.
        /// </summary>
        public double[] FitnessArray;

        #region Constructor

        public FitnessInfo(double[] fitnessArray)
        {
            this.FitnessArray = fitnessArray;
        }

        #endregion
    }
}