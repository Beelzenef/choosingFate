using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chooseURFate
{
    class GestorEventos
    {
        static int acciones = 0;

        public static bool ContarAcciones(int clicks)
        {
            acciones = 0;
            Random rnd = new Random();
            
            acciones = rnd.Next(5, 8);
            if (clicks == acciones)
            {
                return true;
            }
            return false;
        }
    }
}
