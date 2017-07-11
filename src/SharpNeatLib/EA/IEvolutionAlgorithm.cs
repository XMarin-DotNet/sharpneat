using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpNeat.EA
{
    public interface IEvolutionAlgorithm
    {
        /// <summary>
        /// Gets evolutionary algorithm statistics.
        /// </summary>
        EAStatistics EAStats { get; }

        /// <summary>
        /// Perform one generation of the evolutionary algorithm.
        /// </summary>
        void PerformOneGeneration();
    }
}
