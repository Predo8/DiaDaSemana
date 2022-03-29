using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaDaSemana
{
    class MenuOp
    {
        public string Menu()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            return string.Format("========================= Dia da Semana!!: ====================================" +
                    "\nDigite um número da semana:" +
                    "\n1 - Domingo " +
                    "\n2 - Segunda" +
                    "\n3 - Terça" +
                    "\n4 - Quarta" +
                    "\n5 - Quinta" +
                    "\n6 - Sexta" +
                    "\n7 - Sabado " +
                    "\n8 - Fechar o Programa." +
                    "\n============================================================================================");
        }
        public void MostrarMenu()
        {
            Console.WriteLine(Menu());
        }
    }
}
