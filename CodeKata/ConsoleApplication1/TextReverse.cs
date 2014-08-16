using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class TextReverse
    {
        public string Reverse(string input)
        {
            string output = "";
            for (int i = 0; i < input.Length ; i++)
            {
                output += input[input.Length - i - 1];
            }
            return output;
        }
    }
