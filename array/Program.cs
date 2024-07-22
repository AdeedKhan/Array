namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[0]);

            string[] cars2 = { "Volvo", "BMW", "Ford", "Mazda" };
            cars2[0] = "Opel";
            Console.WriteLine(cars2[0]);

            string[] cars3 = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars3.Length);

            // Declare an array
            string[] cars4;
            // Add values, using new
            cars4 = new string[] { "Volvo", "BMW", "Ford" };
            // This would cause an error: cars = {"Volvo", "BMW", "Ford"};

            Console.WriteLine(cars4[1]);
            Console.WriteLine();

            //For Loop Through an Array
            Console.WriteLine("For Loop Through an Array");
            string[] fcars = { "Volvo", "BMW", "Ford", "Mazda" };
            for (int i = 0; i < fcars.Length; i++)
            {
                Console.WriteLine(fcars[i]);
            }

            Console.WriteLine();
            //Foreach Loop Through an Array
            Console.WriteLine("Foreach Loop Through an Array");
            string[] fecars = { "volvo", "bmw", "ford" };
            foreach (string fei in fecars)
            {
                Console.WriteLine(fei);
            }Console.WriteLine();

            // Sort a string
            Console.WriteLine("Sort a string Array");
            string[] scars = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(scars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }Console.WriteLine();

            // Sort an int
            Console.WriteLine("Sort an int Array");
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }Console.WriteLine();

            //System.Linq Namespace
            Console.WriteLine("System.Linq Namespace") ;
            int[] myslNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myslNumbers.Max());  
            Console.WriteLine(myslNumbers.Min());  
            Console.WriteLine(myslNumbers.Sum());  


        }
    }
}

