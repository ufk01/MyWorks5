using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingMaxNumber
{
    internal class Program
    {
     
        public static void SortingNumbers(ArrayList arr)
        {
            
            for (int j = 0; j < arr.Count; j++)
            {
                for (int i = j; i < arr.Count; i++)
                {
                    if (Convert.ToInt32(arr[j]) > Convert.ToInt32(arr[i]))
                    {
                        String tempInt =(String) arr[j];
                        arr[j] = arr[i];
                        arr[i] = tempInt;
                    }
                }
                Console.Write(arr[j] +" ");
            }
        }
     
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            LinkedList<int> list = new LinkedList<int>();

            String filePath = @"C:\\Users\\LEGION\\OneDrive\\Desktop\\NumberFile.txt";
            String data ;
           
            if (!File.Exists(filePath))
            {
                Console.WriteLine("There is no file");
                Console.ReadLine();
            }
            else
            {
                StreamReader sr = new StreamReader(filePath);
                while (true)
                {
                    data = sr.ReadLine();
                    if(data==null)
                    {
                        break; ;
                    }
                    else
                    {
                        arr.Add(data);                      
                    }
                }
            }
            Console.WriteLine("Sorting of Numbers are:");
            SortingNumbers(arr);
            Console.ReadLine();
            Console.WriteLine("The smallest number is:");
            Console.WriteLine(arr[0]);


            Console.ReadLine();


        }
    }
}
