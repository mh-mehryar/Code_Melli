using System;
using System.Linq;

namespace Melli_Code
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            
            string code;
            do
            {
                System.Console.WriteLine("Please Enter your Melli_Code :");
                code = Console.ReadLine();
            } while (code.Length != 10);

            // spell(code);
           System.Console.WriteLine(spell(code));
            
        }

        //Method for convert string to array;
        public static bool spell(string codeMelli)
        {
            int[] list = new int[10];
            for (int i = 0; i < 10; i++)
            {
                list[i] = int.Parse(codeMelli.Substring(i, 1));
            }
            // foreach (var item in list)
            // {
            //     System.Console.WriteLine(item);
            // }
           bool spe = division(list);
           return spe;
        }


        public static bool division(int[] listCode)
        {
            int count = 10;
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                listCode[i] = listCode[i]*count;
                count--;
            }
            // foreach (var item in listCode)
            // {
            //     System.Console.WriteLine(item);
            // }
            for (int i = 0; i < 9; i++)
            {
                sum = sum +listCode[i];
            }
            
            bool result = check(sum,listCode[9]);
            // System.Console.WriteLine(result);
            return result;
        }


        public static bool check(int summary,int controller)
        {
            int remain = summary % 11;
            if (remain < 2)
            {
                if (summary == controller)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(controller == (11 - remain))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}

