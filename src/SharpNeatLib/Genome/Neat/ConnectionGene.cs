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
using SharpNeat.Network;

namespace SharpNeat.Genome.Neat
{
    /// <summary>
    /// A gene that represents a single connection between neurons in NEAT.
    /// </summary>
    public class ConnectionGene : INetworkConnection
    {
        #region Auto Properties

        public uint Id { get; }
        public uint SourceNodeId { get; }
        public uint TargetNodeId { get; }
        public double Weight { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this gene has been mutated. This allows the mutation routine to avoid mutating
        /// genes it has already operated on. These flags are reset for all Connection genes within a NeatGenome on exiting
        /// the mutation routine.
        /// </summary>
        public bool IsMutated { get; set; }

        #endregion

        /// <summary>
        /// Used by the connection mutation routine to flag mutated connections so that they aren't
        /// mutated more than once.
        /// </summary>
        bool _isMutated = false;

        #region Constructors

        /// <summary>
        /// Copy constructor.
        /// </summary>
        public ConnectionGene(ConnectionGene copyFrom)
        {
            this.Id = copyFrom.Id;
            this.SourceNodeId = copyFrom.SourceNodeId;
            this.TargetNodeId = copyFrom.TargetNodeId;
            this.Weight = copyFrom.Weight;
        }

        /// <summary>
        /// Construct a new ConnectionGene with the specified source and target neurons and connection weight.
        /// </summary>
        public ConnectionGene(uint id, uint sourceNodeId, uint targetNodeId, double weight)
        {
            this.Id = id;
            this.SourceNodeId = sourceNodeId;
            this.TargetNodeId = targetNodeId;
            this.Weight = weight;
        }

        /// <summary>
        /// Construct a new ConnectionGene with the specified source and target neurons and connection weight.
        /// </summary>
        public ConnectionGene(uint id, ConnectionEndpoints connection, double weight)
        {
            this.Id = id;
            this.SourceNodeId = connection.SourceId;
            this.TargetNodeId = connection.TargetId;
            this.Weight = weight;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Creates a copy of the current gene. Virtual method that can be overridden by sub-types.
        /// </summary>
        public virtual ConnectionGene CreateCopy()
        {
            return new ConnectionGene(this);
        }

        #endregion
    }
}
