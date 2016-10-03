using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {1, 2, 3, 4};
            Console.WriteLine("The first number of the arr is " + arr[0]); 
            arr[0] = 8;
            Console.WriteLine("The first number of the arr is now " + arr[0]);
            Console.WriteLine("*******");
            /////////Iterate/////////////////
            string[] myCars = new string[4] { "Mitsubishi Outlander", "Toyota Camry", "Dodge Challenger", "Nissan 300zx"};
            //We can use the Array's property of Length to help determine where to end our loop
            //Length in this case denotes the size we specified
            for (int idx = 0; idx < myCars.Length; idx++)
            {
                Console.WriteLine("I own a {0}", myCars[idx]);
            }
            Console.WriteLine("*******");
            /////////Iterate--- For Each/////////////////  
            string[] myCars1 = new string[4] { "Mitsubishi Outlander", "Toyota Camry", "Dodge Challenger", "Nissan 300zx"};
            foreach (string car in myCars1)
            {
                //We no longer need the index as the variable car is already the indexed value
                Console.WriteLine("I own a {0}", car);
            }
            Console.WriteLine("*******");
            ////////2-D Array////////////////////////////////
            // Multidimensional array declaration
            int [,] array2D = new int[4,2];
            int[,,] array3D = new int[2,2,4] {
                {
                    {45,1,16,17},{21,28,32,76}
                },{
                    {11,0,5,42},{66,99,33,1212}
                }
                };
            //Directly accessing a multidimensional array
            Console.WriteLine(array2D[0,1]); //prints 0
            Console.WriteLine(array3D[1,0,3]); //prints 42
            Console.WriteLine("*******");
            
            // array except without the need for uniform inner array sizes.
            // Jagged array declaration
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[4]; 
            jaggedArray[2] = new int[2];
            int[][] jaggedArray2 = new int[][] {
                new int[] {1,3,5,7,9},
                new int[] {0,2},
                new int[] {11,22,33,44}
            };
            // Short-hand form
            int[][] jaggedArray3 = {
                new int[] {1,3,5,7,9},
                new int[] {0,2},
                new int[] {11,22,33,44}
            };
            // You can even mix jagged and multi-dimensional arrays
            int[][,] jaggedArray4 = new int[3][,] 
            {
                new int[,] { {1,3}, {5,7} },
                new int[,] { {0,2}, {4,6}, {8,10} },
                new int[,] { {11,22}, {99,88}, {0,9} } 
            };
            // Working through each array in a jagged array
            foreach(int[] innerArr in jaggedArray){
                Console.WriteLine("Inner array length is {0}", innerArr.Length);
            }
            // Accessing a jagged array
            Console.WriteLine(jaggedArray3[2][3]); //prints 44
            Console.WriteLine(jaggedArray2[0][1]); //prints 3

        }
    }
}
