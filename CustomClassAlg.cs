using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class CustomClassAlg
    {
        public static void LinearEquation(string equation)
        {
            int a, b, c; // initial a,b,c
            char[] parsedig = { 'x', '+', '-', '=', ' ' };
            string[] digit = equation.Split(parsedig); // parse a,b,c
            char[] check = equation.ToCharArray();  // copy equals in char array
            if (check[check.Length - 1] == ('x'))   // checking how queals looks like. 2x+5=5 or 5=5+2x by last digit x
            {
                a = int.Parse(digit[2]); 
                b = int.Parse(digit[1]);
                c = int.Parse(digit[0]);
            }
            else
            {

                c = int.Parse(digit[3]);
                b = int.Parse(digit[2]);
                a = int.Parse(digit[0]);
            }
            foreach (char d in check)   // check + or - in equals
            {
                if (Equals(d, '+'))
                    Console.WriteLine($"X = {(c - b) / a}");
                if (Equals(d, '-'))
                    Console.WriteLine($"X = {(c + b) / a}");
            }

        }
    }
}
