using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeOne
{
    public class GeorgOhmFactory
    {
        public static GeorgOhm CreateStripGeorgOhm(string[] bandColors)
        {
            int length = bandColors.Length;
            switch (length)
            {
                case 4:
                    return new FourStripGeorgOhm(bandColors);
                case 5:
                    return new FiveStripGeorgOhm(bandColors);
                case 6:
                    return new SixStripGeorgOhm(bandColors);
                default:
                    return null;
            }
        }
    }
    public sealed class FourStripGeorgOhm : GeorgOhm
    {
        private string[] bandColors;
        public FourStripGeorgOhm(string[] bandColors)
        {
            this.bandColors = bandColors;
        }
        protected override string CalculateOhmValue()
        {
            string valueString = string.Empty;
            Resistor resistor = FindResistor(bandColors[0]);
            if (resistor != null)
            {
                valueString += resistor.SignificantFigure >= 0 ? resistor.SignificantFigure.ToString() : "";
                resistor = FindResistor(bandColors[1]);
                if (resistor != null)
                {
                    valueString += resistor.SignificantFigure >= 0 ? resistor.SignificantFigure.ToString() : "";
                    int value = 0;
                    if (int.TryParse(valueString, out value))
                    {
                        resistor = FindResistor(bandColors[2]);
                        if (resistor != null)
                        {
                            value = value * (int)(resistor.MultiplierPower < 999 ? Math.Pow(10, resistor.MultiplierPower) : 0);
                            resistor = FindResistor(bandColors[3]);
                            if (resistor != null)
                            {
                                return $"{value} {resistor.Tolerance}";
                            }
                        }
                    }
                }
            }

            return string.Empty;
        }        
    }

    public sealed class FiveStripGeorgOhm : GeorgOhm
    {
        private string[] bandColors;
        public FiveStripGeorgOhm(string[] bandColors)
        {
            this.bandColors = bandColors;
        }
        protected override string CalculateOhmValue()
        {
            string valueString = string.Empty;
            Resistor resistor = FindResistor(bandColors[0]);
            if (resistor != null)
            {
                valueString += resistor.SignificantFigure >= 0 ? resistor.SignificantFigure.ToString() : "";
                resistor = FindResistor(bandColors[1]);
                if (resistor != null)
                {
                    valueString += resistor.SignificantFigure >= 0 ? resistor.SignificantFigure.ToString() : "";
                    resistor = FindResistor(bandColors[2]);
                    if (resistor != null)
                    {
                        valueString += resistor.SignificantFigure >= 0 ? resistor.SignificantFigure.ToString() : "";
                        int value = 0;
                        if (int.TryParse(valueString, out value))
                        {
                            resistor = FindResistor(bandColors[3]);
                            if (resistor != null)
                            {
                                value = value * (int)(resistor.MultiplierPower < 999 ? Math.Pow(10, resistor.MultiplierPower) : 0);
                                resistor = FindResistor(bandColors[4]);
                                if (resistor != null)
                                {
                                    return $"{value} {resistor.Tolerance}";
                                }
                            }
                        }
                    }
                }
            }            

            return string.Empty;
        }
    }

    public sealed class SixStripGeorgOhm : GeorgOhm
    {
        private string[] bandColors;
        public SixStripGeorgOhm(string[] bandColors)
        {
            this.bandColors = bandColors;
        }
        protected override string CalculateOhmValue()
        {
            string valueString = string.Empty;
            Resistor resistor = FindResistor(bandColors[0]);
            if (resistor != null)
            {
                valueString += resistor.SignificantFigure >= 0 ? resistor.SignificantFigure.ToString() : "";
                resistor = FindResistor(bandColors[1]);
                if (resistor != null)
                {
                    valueString += resistor.SignificantFigure >= 0 ? resistor.SignificantFigure.ToString() : "";
                    resistor = FindResistor(bandColors[2]);
                    if (resistor != null)
                    {
                        valueString += resistor.SignificantFigure >= 0 ? resistor.SignificantFigure.ToString() : "";
                        int value = 0;
                        if (int.TryParse(valueString, out value))
                        {
                            resistor = FindResistor(bandColors[3]);
                            if (resistor != null)
                            {
                                value = value * (int)(resistor.MultiplierPower < 999 ? Math.Pow(10, resistor.MultiplierPower) : 0);
                                Resistor resistor4 = FindResistor(bandColors[4]);
                                Resistor resistor5 = FindResistor(bandColors[5]);
                                if (resistor4 != null && resistor5 != null)
                                {
                                    return $"{value} {resistor4.Tolerance} {resistor5.TemperatureCoefficient}";
                                }
                            }
                        }
                    }
                }
            }

            return string.Empty;
        }
    }
}
