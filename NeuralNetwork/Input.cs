using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANN
{
    public class Input
    {
        public float Weight { get; set; }
        public float Value { get; set; }

        public Input()
        {
            this.Weight = 0.00f;
            this.Value = 0.00f;
        }

        public Input(float initialWeight, float value)
        {
            this.Weight = initialWeight;
            this.Value = value;
        }
    }
}
