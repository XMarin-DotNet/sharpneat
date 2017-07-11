using SharpNeat.Genome.Neat;
using SharpNeat.Network;

namespace SharpNeat.Genome.HyperNeat
{
    public class CppnNeuronGene : NeuronGene
    {
        readonly int _activationFnId;

        #region Constructors

        /// <summary>
        /// Copy constructor.
        /// </summary>
        /// <param name="copyFrom">NeuronGene to copy from.</param>
        /// <param name="copyConnectivityData">Indicates whether or not top copy connectivity data for the neuron.</param>
        public CppnNeuronGene(CppnNeuronGene copyFrom, bool copyConnectivityData)
            : base(copyFrom, copyConnectivityData)
        {
            _activationFnId = copyFrom._activationFnId;
        }

        /// <summary>
        /// Construct new NeuronGene with the specified innovationId, neuron type 
        /// and activation function ID.
        /// </summary>
        public CppnNeuronGene(uint innovationId, NodeType neuronType, int activationFnId)
            : base(innovationId, neuronType)
        {
            _activationFnId = activationFnId;
        }

        #endregion

        #region Properties

        /// <summary>
        /// An activation function ID that corresponds to an entry in the IActivationFunctionLibrary
        /// in the current genome factory.
        /// </summary>
        public override int ActivationFnId => _activationFnId;

        #endregion
    }
}
