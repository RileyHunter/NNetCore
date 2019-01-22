using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuralNetCore.Structure;

namespace NeuralNetCore.Functions.InputFunctions
{
    abstract class AbstractInputFunction
    {
        abstract public double Base(IEnumerable<Synapse> input);
    }
}
