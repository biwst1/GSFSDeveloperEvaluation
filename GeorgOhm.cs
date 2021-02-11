using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;

namespace ChallengeOne
{
    public abstract class GeorgOhm : ICalculateOhmValues
    {
        private List<Resistor> resistors = new List<Resistor>();
        public GeorgOhm()
        {
            CreateResistorTable();
        }

        private void CreateResistorTable()
        {
            Resistor resistor = new Resistor { MultiplierPower = 999, RingColorName = "None", SignificantFigure = -1, TemperatureCoefficient = 999, Tolerance = "\u00B1" + "20%" };
            resistors.Add(resistor);
            resistor = new Resistor { MultiplierPower = 999, RingColorName = "None", SignificantFigure = -1, TemperatureCoefficient = 999, Tolerance = "\u00B1" + "20%" };
            resistors.Add(resistor);
            resistor = new Resistor { MultiplierPower = -3, RingColorName = "Pink", SignificantFigure = -1, TemperatureCoefficient = 999, Tolerance = "" };
            resistors.Add(resistor);
            resistor = new Resistor { MultiplierPower = -2, RingColorName = "Silver", SignificantFigure = -1, TemperatureCoefficient = 999, Tolerance = "\u00B1" + "10%" };
            resistors.Add(resistor);
            resistor = new Resistor { MultiplierPower = -1, RingColorName = "Gold", SignificantFigure = -1, TemperatureCoefficient = 999, Tolerance = "\u00B1" + "5%" };
            resistors.Add(resistor);
            resistor = new Resistor { MultiplierPower = 0, RingColorName = "Black", SignificantFigure = 0, TemperatureCoefficient = 250, Tolerance = "" };
            resistors.Add(resistor);
            resistor = new Resistor { MultiplierPower = 1, RingColorName = "Brown", SignificantFigure = 1, TemperatureCoefficient = 100, Tolerance = "\u00B1" + "1%" };
            resistors.Add(resistor);
            resistor = new Resistor { MultiplierPower = 2, RingColorName = "Red", SignificantFigure = 2, TemperatureCoefficient = 50, Tolerance = "\u00B1" + "2%" };
            resistors.Add(resistor);
            resistor = new Resistor { MultiplierPower = 3, RingColorName = "Orange", SignificantFigure = 3, TemperatureCoefficient = 15, Tolerance = "\u00B1" + "0.05%" };
            resistors.Add(resistor);
            resistor = new Resistor { MultiplierPower = 4, RingColorName = "Yellow", SignificantFigure = 4, TemperatureCoefficient = 25, Tolerance = "\u00B1" + "0.02%" };
            resistors.Add(resistor);
            resistor = new Resistor { MultiplierPower = 5, RingColorName = "Green", SignificantFigure = 5, TemperatureCoefficient = 20, Tolerance = "\u00B1" + "0.5%" };
            resistors.Add(resistor);
            resistor = new Resistor { MultiplierPower = 6, RingColorName = "Blue", SignificantFigure = 6, TemperatureCoefficient = 10, Tolerance = "\u00B1" + "0.25%" };
            resistors.Add(resistor);
            resistor = new Resistor { MultiplierPower = 7, RingColorName = "Violet", SignificantFigure = 7, TemperatureCoefficient = 5, Tolerance = "\u00B1" + "0.1%" };
            resistors.Add(resistor);
            resistor = new Resistor { MultiplierPower = 8, RingColorName = "Grey", SignificantFigure = 8, TemperatureCoefficient = 1, Tolerance = "\u00B1" + "0.01%" };
            resistors.Add(resistor);
            resistor = new Resistor { MultiplierPower = 9, RingColorName = "White", SignificantFigure = 9, TemperatureCoefficient = 999, Tolerance = "" };
            resistors.Add(resistor);
        }

        protected Resistor FindResistor(string bandColor)
        {
            return resistors.Where(r => r.RingColorName.Equals(bandColor, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
        }

        protected abstract string CalculateOhmValue();
        public string CalculateOhmValue(string[] bandColors)
        {
            int length = bandColors.Length;            
            if (length > 3 && length < 7)
            {
                GeorgOhm georgOhm = GeorgOhmFactory.CreateStripGeorgOhm(bandColors);
                if (georgOhm != null)
                {
                    return georgOhm.CalculateOhmValue();
                }
            }

            return string.Empty;
        }
    }
}
