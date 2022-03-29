using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace diaDaSemana
{
    class Menu
    {
        public string Hora()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            string date = DateTime.Now.ToString("dd-MM-yyyy");
            string hora = DateTime.Now.ToString("HH:mm:ss");
            return string.Format($"Hoje é dia: {date} e são {hora}");
        }
        public void ApresentarHora()
        {
           Console.WriteLine(Hora());
        }
    }
}