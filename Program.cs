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
            StreetCleaner streetCleaner3 = new StreetCleaner();
            StreetCleaner streetCleaner4 = new StreetCleaner();

            StreetCleaner[] streetCleaners = new StreetCleaner[5];
            
            
            streetCleaner.PrintFields();
            streetCleaner.KeyboardValues();
            streetCleaner.RandomValues();

            Console.WriteLine($"Total number of street cleaners is : {StreetCleaner.numberOfStreetCleaners}");
        }
    }
}