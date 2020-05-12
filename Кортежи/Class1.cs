using System;
using System.Collections.Generic;
using System.Text;

namespace Кортежи
{
    class Class1
    {
        public string[] ShowCities(Tuple<string, int, string>[] city)
        {
            string[] arr = new string[5];
            string s = "";
            int n = 0;
            for (int i = 0; i < 12; i++)
            {
                if(i == 0)
                {
                    arr[n] = city[i].Item1;
                    s = city[i].Item1;
                    n++;
                }
                else
                {
                    if (s != city[i].Item1)
                    {
                        arr[n] = city[i].Item1;
                        s = city[i].Item1;
                        n++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return arr;
        }
        public void Minimal(Tuple<string, int, string>[] city)            
        {
            int minimal = 100;
            string s1 = null;
            string s2 = null;
            for (int i = 0; i < 12; i++)
            {
                if (city[i].Item2 < minimal)
                {
                    minimal = city[i].Item2;
                    s1 = city[i].Item1;
                    s2 = city[i].Item3;
                }
            }
            Console.WriteLine("Самые близкие города: " + s1 + " и " + s2);
        }
    }
}