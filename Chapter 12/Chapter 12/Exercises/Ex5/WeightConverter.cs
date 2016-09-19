using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_12.Exercises.Ex5
{
    static class WeightConverter
    {
        public static double ConvertWeightTo(string from, string to, string num)
        {
            from = from.ToLower();
            to = to.ToLower();
            try
            {
                double value = double.Parse(num);
                if (value < 0)
                    throw new Exception("Number can not be negative");

                if (from == "grams")
                {
                    if (to == "kilograms")
                        return GramsToKilograms(value);
                    if (to == "pounds")
                        return GramsToPounds(value);
                    if (to == "ounces")
                        return GramsToOunces(value);
                    else
                        return value;
                }
                else if (from == "kilograms")
                {
                    if (to == "grams")
                        return KilogramsToGrams(value);
                    if (to == "pounds")
                        return KilogramsToPounds(value);
                    if (to == "ounces")
                        return KilogramsToOunces(value);
                    else
                        return value;
                }
                else if (from == "pounds")
                {
                    if (to == "grams")
                        return PoundsToGrams(value);
                    if (to == "kilograms")
                        return PoundsToKilograms(value);
                    if (to == "ounces")
                        return PoundsToOunces(value);
                    else
                        return value;
                }
                else if (from == "ounces")
                {
                    if (to == "grams")
                        return OuncesToGrams(value);
                    if (to == "pounds")
                        return OuncesToPounds(value);
                    if (to == "kilograms")
                        return OuncesToKilograms(value);
                    else
                        return value;
                }
                else
                {
                    throw new Exception("Invalid or usupported input.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric value");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }

        const double GRAM_KILO = 1000d;
        const double GRAM_POUND = 453.592d;
        const double GRAM_OUNCE = 0.035274d;
        const double KILO_LBS = 2.20462262185d;
        const double KILO_OUNCE = 0.0283495231d;
        const double LBS_OUNCE = 16d;

        #region Grams
        public static double GramsToKilograms(double grams)
        {
            return grams / GRAM_KILO;
        }

        public static double GramsToPounds(double grams)
        {
            return grams / GRAM_POUND;
        }

        public static double GramsToOunces(double grams)
        {
            return grams * GRAM_OUNCE;
        }
        #endregion

        #region Kilograms
        public static double KilogramsToGrams(double kilograms)
        {
            return kilograms * GRAM_KILO;
        }

        public static double KilogramsToPounds(double kilograms)
        {
            return kilograms * KILO_LBS;
        }

        public static double KilogramsToOunces(double kilograms)
        {
            return kilograms / KILO_OUNCE;
        }
        #endregion

        #region Pounds
        public static double PoundsToGrams(double pounds)
        {
            return pounds * GRAM_POUND;
        }

        public static double PoundsToKilograms(double pounds)
        {
            return pounds / KILO_LBS;
        }

        public static double PoundsToOunces(double pounds)
        {
            return pounds * LBS_OUNCE;
        }
        #endregion

        #region Ounces
        public static double OuncesToGrams(double ounces)
        {
            return ounces / GRAM_OUNCE;
        }

        public static double OuncesToKilograms(double ounces)
        {
            return ounces / KILO_OUNCE;
        }

        public static double OuncesToPounds(double ounces)
        {
            return ounces / LBS_OUNCE;
        }
        #endregion
    }
}
