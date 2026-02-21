using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_3.Classes
{
    internal class Counter
    {
        private string str;
        public Counter(string str)
        {
            this.str = str;
        }
        public void print()
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach (var item in str)
            {
                if (dic.ContainsKey(item))
                {
                    dic[item]++;
                }
                else
                {
                    dic.Add(item, 1);
                }
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
