using System;
using System.Collections.Generic;
using System.Text;

namespace Subsdictive
{
    class Registro
    {
        private string nick="";
        private DateTime inicio=DateTime.Now;
        private int minutos=0;

        public string Nick
        {
            get
            {
                return nick;
            }
            set
            {
                nick = value;
            }
        }

        public DateTime Inicio
        {
            get
            {
                return inicio;
            }
            set
            {
                inicio = value;
            }
        }

        public int Minutos
        {
            get
            {
                return minutos;
            }
            set
            {
                minutos = value;
            }
        }

        public Registro()
        {
        }
    }
}
