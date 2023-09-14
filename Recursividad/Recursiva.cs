using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PracticaRecursividad
{
    public class Recursiva
    {
        public int numero { get; set; }
        public int numero2 { get; set; }

        public Recursiva()
        {

        }


        public long Factorial(int numero)
        {
            if (numero == 0 || numero == 1)
            {
                return 1;
            }

            return numero * Factorial(numero - 1);
        }


        public long Fibonacci(int numero)
        {
            if (numero <= 1) 
            { 
                return numero;
            }

            return Fibonacci(numero - 1) + Fibonacci(numero - 2);
        }

        public long MaximoComunDivisor(int num1, int num2)
        {
            if (num2 == 0)
                return num1;

            return MaximoComunDivisor(num2, num1 % num2);
        }
    }
}
