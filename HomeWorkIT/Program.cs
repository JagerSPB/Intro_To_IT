using System;

namespace HomeWorkIT
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] arrayOrig = new string[7] { "Text1", "AnyText", "if", "false", "res", "var", "49559"};
            string[] arrayNew = new string[arrayOrig.Length];

            void noMoreThan3Array(string[] arr1, string[] arr2)
            {
                int count = 0;
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i].Length <= 3)
                    {
                        arr2[count] = arr1[i];
                            count++;
                    }
                }
            }
     
            
            noMoreThan3Array(arrayOrig, arrayNew);
        

        }
    }
}