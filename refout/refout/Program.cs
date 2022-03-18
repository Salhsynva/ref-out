using System;

namespace refout
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task1
            int[] numbers = { 13, 45, 3 };
            int number = 1;
            int[] newArray = AddNumberToArray(numbers, number);
            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region task2
            //string name = "Hikmet Abbasov";
            //string newName = WithoutSpace(name);
            //Console.WriteLine(newName);
            #endregion

            #region task3
            //string numberstr = Console.ReadLine();
            //int number = Convert.ToInt32(numberstr);
            //Console.WriteLine(FindSquareRoot(number));
            #endregion


        }
        static int[] AddNumberToArray(int[] array, int number)
        {
            int[] newArray = new int[array.Length + 1];
            int j = 0;
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[j];
                j++;
                if (i == newArray.Length - 1)
                    newArray[i] = array[j];
            }
            return newArray;

        }

        static string WithoutSpace(string name)
        {
            string newName = " ";
            foreach (var item in name)
            {
                if (item != ' ')
                    newName += item;
            }
            return newName;
        }

        static int FindSquareRoot(int number)
        {
            if (number >= 0)
            {
                for (int i = 0; i <= number; i++)
                {
                    if (i * i == number)
                        return i;
                    else if (i * i > number)
                        return i - 1;
                }
            }
            return -1;
        }


        }
    }
}
