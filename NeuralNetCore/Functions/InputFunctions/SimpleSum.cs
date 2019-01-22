using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuralNetCore.Structure;

namespace NeuralNetCore.Functions.InputFunctions
{
    class SimpleSum : AbstractInputFunction
    {
        override public double Base(IEnumerable<Synapse> input)
        {
            var output = 0d;
            foreach (Synapse synapse in input)
            {
                output += synapse.Activity;
            }
            return output;
        }
    }
}
