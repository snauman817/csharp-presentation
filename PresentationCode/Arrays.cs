using System;

namespace PresentationCode
{
    public class Arrays
    {
        public static void Main()
        {
            int[] arr = {1, 2, 3, 4, 5};

            foreach(int num in arr){
                Console.WriteLine(num);
            }

            Console.WriteLine("------");

            for(int i = 0; i < arr.Length; i++){
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("------");

            int counter = 0;
            while(counter < arr.Length){
                Console.WriteLine(arr[counter]);
                counter++;
            }
        }
    }
}