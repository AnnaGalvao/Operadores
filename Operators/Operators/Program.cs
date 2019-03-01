using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            // aritméticos

            //add
            int c = a + b;
            //Console.WriteLine

            //sub
            int subt = a - b;

            //mult
            int mult = a * b;

            //divis
            int divis = a / b;

            //rest (resto da divisao) 
            int rest = 5 % 2;

            //primary
            //incremento x++
            //decremento x--

            //oeradores comparativos

            if (a > b)
                Console.WriteLine("a > b");

            if (b < a)
                Console.WriteLine("b < a");

            //=> operador lambida
            if (a >= b) // maior igual
                Console.WriteLine("a >= b");

            if (b <= a) // menor igual
                Console.WriteLine("b <= a");

            //equals
            if (a == b)
                Console.WriteLine("a == b");

            //not
            if (a != b)
                Console.WriteLine("a != b");

            //logicos
            //XOR - logicos exclusivo - um ou outro
            if (true ^ false)
                Console.WriteLine("true");

            //condicionais

            //AND aglutinar e verificar se duas condições são verdadeiras
            if (true && true)
                Console.WriteLine("True");

            //OR (ou uma ou outra)
            if (false || true)
                Console.WriteLine("true");
        }
    }
}
