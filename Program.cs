using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AprendendoPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.nome = "Alexande Mateus dos Santos Ferreira";
            p1.idade = 21;
            p1.viva = "não";

            Console.WriteLine(p1.viva);

        }
    }
}
