
namespace SharpNeat.EA
{
    /// <summary>
    /// A high level strategy that incorporates both the selection and reproduction stages of 
    /// an evolutionary algorithm.
    /// </summary>
    /// <typeparam name="TGenome"></typeparam>
    public interface IDifferentialReproductionStrategy<TGenome>
    {
        /// <summary>
        /// Accepts a population of genomes and updates it into a new population.
        /// The new population is based on selection from the starting population, removal of genomes that are no longer wanted (elitism)
        /// and reproduction of new genomes from the selected genomes. 
        /// 
        /// Encapsulating these stages of an evolutionary algorithm within a single strategy interface allows for simpler 'plugging-in' of
        /// different evolutionary algorithm strategies.
        /// </summary>
        /// <param name="population">The current population.</param>
        void Invoke(Population<TGenome> population);
    }
}
