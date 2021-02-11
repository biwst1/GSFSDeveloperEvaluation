using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeOne
{
    public sealed class Resistor
    {
        public string RingColorName { get; set; }
        public int SignificantFigure { get; set; }
        public int MultiplierPower { get; set; }        
        public string Tolerance { get; set; }
        public int TemperatureCoefficient { get; set; }
    }
}
