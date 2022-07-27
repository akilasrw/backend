

namespace Aeroclub.Cargo.Common.Extentions
{
    public static class UnitConversionExtension
    {

        public static double GramToKilogramConversion(this double weight, bool isReverse = false)
        {
            if (isReverse)
                return weight * 1000;
            else
                return weight / 1000;
        }

        public static double PoundToKilogramConversion(this double weight, bool isReverse = false)
        {
            if (isReverse)
                return weight * 2.2046226218;
            else
                return weight / 2.2046226218;
        }

        public static double MeterToCmConversion(this double volume, bool isReverse = false)
        {
            if (isReverse)
                return volume / 100;
            else
                return volume * 100;
        }

        public static double InchToCmConversion(this double volume, bool isReverse = false)
        {
            if (isReverse)
                return volume / 2.54;
            else
                return volume * 2.54;
        }

    }
}
