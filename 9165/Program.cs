using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9165
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static int What1(Node<int> lst)
        {
            if (lst == null) return 0;
            return lst.GetValue() + What1(lst.GetNext());
        }

        static int What2(Node<int> lst)
        {
            if (lst == null) return 0;
            return 1 + What2(lst.GetNext());
        }

        static int What3(Node<int> lst)
        {
            if (!lst.HasNext()) return lst.GetValue();
            else return Math.Max(lst.GetValue(), What3(lst.GetNext()));
        }

        static bool What4(Node<char> lst, char c)
        {
            if (lst == null) return false;
            if (lst.GetValue() == c) return true;
            return What4(lst.GetNext(), c);
        }



    }
}
