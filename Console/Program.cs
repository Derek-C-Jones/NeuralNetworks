using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ANN;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic ANN:");
            NeuralNetwork basicNetwork = new NeuralNetwork();

            Console.WriteLine("Creating inputs...");
            Input tempInput = new Input();
            tempInput.Weight = 1.00f;
            tempInput.Value = 2.00f;
            basicNetwork.addInput(tempInput);
            tempInput.Weight = 1.50f;
            tempInput.Value = 1.00f;
            basicNetwork.addInput(tempInput);
            tempInput.Weight = 1.20f;
            tempInput.Value = 2.10f;
            basicNetwork.addInput(tempInput);
            tempInput.Weight = 0.90f;
            tempInput.Value = 1.70f;
            basicNetwork.addInput(tempInput);

            Console.WriteLine("Calculating activation value...");
            basicNetwork.calculateActivationValue();
            Console.WriteLine("Activation value: " + basicNetwork.ActivationValue);

            Console.ReadKey();
        }
    }
}
