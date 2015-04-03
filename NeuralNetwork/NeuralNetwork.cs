using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANN
{
    public class NeuralNetwork
    {
        private float activationValue;
        public float ActivationValue 
        { 
            get 
            {
                return activationValue;
            } 
        }
        private List<Input> inputs;

        public NeuralNetwork()
        {
            this.inputs = new List<Input>();
        }

        public void addInput(Input newInput)
        {
            this.inputs.Add(newInput);
        }

        public void calculateActivationValue()
        {
            float activationValue = 0.00f;
            foreach (Input input in this.inputs)
            {
                activationValue += input.Weight * input.Value;
            }
            this.activationValue = activationValue;
        }
    }
}
