namespace ArraysPracticeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var productStock = new[] { 3, 5, 23, 77, 6, 10 };

            // Length
            /*            Console.WriteLine("Length: " + productStock.Length);*/

            // IndexOf()
            /*     var index = Array.IndexOf(productStock, 23);
                 Console.WriteLine(index);*/

            // Clear
            /* Array.Clear(productStock, 0, 2);

             foreach (var product in productStock)
                 Console.WriteLine(product);*/

            // Copy
            int[] newArray = new int[3];

        /*    Array.Copy(productStock, newArray, 3);
            Console.WriteLine("Effect of Copy Method");

            foreach(var num in newArray)
            {
                Console.WriteLine(num);
            }*/

            // Sort
            Array.Sort(productStock);

            Console.WriteLine("Effect of Sort Method");
            foreach( var num in productStock)
            {
                Console.WriteLine(num);
            }

            // Reverse()

            Array.Reverse(productStock);

            Console.WriteLine("Effect of Reverse Method");







            /*    // Jagged Arrays
                var matrix = new int[3, 5]
                {
                    { 1, 2, 3, 4, 5},
                    { 6, 7, 8, 9, 10},
                    { 11, 12, 13, 14, 15},
                };

                var item = matrix[0, 0];

        }*/
        }
        }
}