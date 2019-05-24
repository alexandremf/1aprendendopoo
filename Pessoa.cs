using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AprendendoPoo
{
    class Pessoa
    {
        public string nome;
        public int idade;
        public bool viva = true;

         public bool EstaViva (string vive)
        {
           if (vive = "não")
            {
                this.viva = false;
                
            }

            return false;
        }
    }
}
