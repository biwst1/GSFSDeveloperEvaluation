using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeOne
{
    public interface ICalculateOhmValues
    {
        /// <summary>
        /// Calculates the Ohm value of a resistor based on the band colors.
        /// </summary>
        /// <param name="bandColors">array of band colors</param>
        /// <returns>ohm value in the string format as "resistance tolerance temperature-coefficient"</returns>
        string CalculateOhmValue(string[] bandColors);
    }
}
