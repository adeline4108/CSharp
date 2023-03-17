using System;
namespace cs_lab1
{
    public class Program
    {
        public static void Main()
        {
            StreetCleaner streetCleaner = new StreetCleaner();
            StreetCleaner streetCleaner1 = new StreetCleaner(8);
            StreetCleaner streetCleaner2 = new StreetCleaner(4, new int[]{1});

            streetCleaner.PrintFields();
            streetCleaner.KeyboardValues();
            streetCleaner.RandomValues();
        }
    }
}