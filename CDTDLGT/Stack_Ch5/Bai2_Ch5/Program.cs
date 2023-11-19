using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_Ch5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ket qua: "+TinhGiaTri("6 2 / 3 + 7 4 - *"));
            Console.WriteLine(  isTrue("{}}"));
        }

        static int TinhGiaTri(string t)
        {
            string[] a = t.Split(' ');
            Stack s = new Stack();
           
            for (int i = 0; i < a.Length; i++)
            {
                
                switch (a[i])
                {
                   
                    case "+":
                        int x = s.Pop();
                        int y = s.Pop();
                        s.Push(x + y);
                        break;
                    case "-":
                        x = s.Pop();
                        y = s.Pop();
                        s.Push(y - x);
                        break;
                    case "*":
                        x = s.Pop();
                        y = s.Pop();
                        s.Push(x * y);
                        break;
                    case "/":
                        x = s.Pop();
                        y = s.Pop();
                        s.Push(y /x);
                        break;
                    default:
                        s.Push(int.Parse(a[i]));
                        break;
                }
                
            }
            return s.Top.Data;
        }

        static bool isTrue(string str)
        {
            Stack s = new Stack();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ('(') || str[i] == ('{') || str[i] == ('[') || str[i] == (')') || str[i] == ('}') || str[i] == (']'))
                {
                    s.Push(str[i]);
                }
                else if (s.Top == null)
                {
                    return false;
                }
                else
                {
                    if ((str[i] == '(' && s.Pop() != ')') || (str[i] == '[' && s.Pop() != ']') || (str[i] == '{' && s.Pop() != '}'))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
