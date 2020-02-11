using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuadas {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite um número: ");

            int n;
            int r;
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 11; i++) {
                r = n * i;
                Console.WriteLine(i + "x" + n + "=" + r);

            }
            Console.ReadLine();

        }
    }
}
