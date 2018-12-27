using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace RageQuit
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string outpurString = null;
            string tempString = null;
            List<char> listChar = new List<char>();
            int repeat = 0;
            bool flagNumber = false;
            bool flagIsNumber = false;
            char upperChar ;
            foreach (var item in inputString)
            {
                flagIsNumber = char.IsNumber(item);
                if (flagIsNumber)
                {
                    if (repeat>0)
                    {
                        repeat *= 10;

                    }
                    repeat += int.Parse(item.ToString());

                    flagNumber = true;
                }


                if(!flagIsNumber)
                {
                    if (flagNumber)
                    {
//                        outpurString += String.Concat(Enumerable.Repeat(tempString, repeat));
//                        for (int i = 0; i < repeat; i++)
//                        {
//                            outpurString += tempString;
//                        }
                        StringBuilder sb = new StringBuilder();
                        for (uint i = 0; i < repeat; i++)
                            sb.Append(tempString);

                        outpurString+= sb.ToString();
                        tempString = null;
                        flagNumber = false;
                    }
                    repeat = 0;
                    upperChar = char.ToUpper(item); 
                    tempString += upperChar;
                    if (!listChar.Contains(upperChar))
                    {
                        listChar.Add(upperChar);
                    }
                }


            }
            outpurString += String.Concat(Enumerable.Repeat(tempString, repeat));

            Console.WriteLine("Unique symbols used: {0}",listChar.Count());
            Console.WriteLine(outpurString);
        }
    }
}
