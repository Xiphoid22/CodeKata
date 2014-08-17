using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TextReverse : IBackwardsTalkKata
    {
        public string Revert(string word)
        {
            string output = "";
            for (int i = 0; i < word.Length ; i++)
            {
                output += word[word.Length - i - 1];
            }
            return output;
        }
    }

    public interface IBackwardsTalkKata
    {
        string Revert(string word);
    }