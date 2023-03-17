namespace cs_lab1
{
    public class StreetCleaner
    {
        public int numberOfBrooms;
        public int[] degreeOfWear = new int[5];
        public static int numberOfStreetCleaners;

        public StreetCleaner()
        {
            numberOfBrooms = 8;
            degreeOfWear = new int[5]{1,2,3,4,5};
            numberOfStreetCleaners = 10;
            numberOfStreetCleaners++;
        }

        public StreetCleaner(int NumberOfBrooms)
        {
            this.numberOfBrooms = NumberOfBrooms;
            numberOfStreetCleaners++;
        }
        public StreetCleaner(int NumberOfBrooms, int[] DegreeOfWear)
        {
            this.numberOfBrooms = NumberOfBrooms;
            this.degreeOfWear = DegreeOfWear;
            numberOfStreetCleaners++;
        }
        public StreetCleaner(int NumberOfBrooms, int[] DegreeOfWear, int NumberOfStreetCleaners)
        {
            this.numberOfBrooms = NumberOfBrooms;
            this.degreeOfWear = DegreeOfWear;
            numberOfStreetCleaners = NumberOfStreetCleaners;
            numberOfStreetCleaners++;
        }
        public StreetCleaner(StreetCleaner streetCleaner)
        {
            numberOfBrooms = streetCleaner.numberOfBrooms;
            degreeOfWear = streetCleaner.degreeOfWear;
            numberOfStreetCleaners++;
        }

        public void PrintFields()
        {
            string[] degreeOfWearResult = degreeOfWear.Select(i => i.ToString()).ToArray();
            Console.WriteLine($"Number of brooms: {numberOfBrooms}");
            Console.WriteLine($"Degrees of wear: {String.Join(",", degreeOfWearResult)}");
            Console.WriteLine($"Number of street cleaners {numberOfStreetCleaners}");
        }

        public void KeyboardValues()
        {

            do
            {
                Console.WriteLine("Enter number of brooms:");
                Console.ReadLine();

                if (numberOfBrooms < 0 && numberOfBrooms > 10)
                {
                    Console.WriteLine("Number of brooms must be positive or cannot be more than 10!");
                }

            } while (numberOfBrooms >= 10);

            Console.WriteLine("Enter degree of wear: ");
            int degreeOfWearLoop = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (degreeOfWearLoop < 0 && degreeOfWearLoop > 5)
                {
                    Console.WriteLine("Number of degree must be positive or cannot be more than 5!");
                }

            } while (degreeOfWearLoop >= 5);

            do
            {
                Console.WriteLine("Enter number of street cleaners: ");
                Console.ReadLine();
                if (numberOfStreetCleaners < 0 && numberOfStreetCleaners > 10)
                {
                    Console.WriteLine("Number of street cleaners must be positive or less than 10!");
                }
            } while (numberOfStreetCleaners > 10);
        }

        public void RandomValues()
        {
            Random rand = new Random();
            
            int[] numberOfBrooms = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] degreeOfWear = { 1, 2, 3, 4, 5 };
            int[] numberOfStreetCleaners = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int numberOfBroomsRandomValue = rand.Next(numberOfBrooms.Length);
            int degreeOfWearRandomValue = rand.Next(degreeOfWear.Length);
            int numberOfStreetCleanersRandomValue = rand.Next(numberOfStreetCleaners.Length);

            Console.WriteLine($"Random number of brooms: {numberOfBroomsRandomValue}");
            Console.WriteLine($"Random number of wear: {degreeOfWearRandomValue}");
            Console.WriteLine($"Random number of streeet cleaners: {numberOfStreetCleanersRandomValue}");
        }

        public void SumOfWearOfBrooms()
        {
           //int sumOfWearOfBrooms; 
           
        }
    }
}