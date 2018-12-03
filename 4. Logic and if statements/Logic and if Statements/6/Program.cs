using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int skaicius = 46;
            int skaiciausKvadratas = skaicius * skaicius;
            int skaiciausKubas = skaicius * skaicius * skaicius;

            Console.WriteLine("{0} kvadratas yra {1}, o pakeltas treciuoju laipsniu {2}", skaicius, skaiciausKvadratas, skaiciausKubas);


            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);

            Console.Read();
        }
    }
}
