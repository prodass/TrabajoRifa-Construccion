using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construccion
{
    public class Rifa
    {
        private string _nombre;
        private string _apellido;
        public int _numeroRifa;

        public Rifa(){}

        public Rifa(string nombre, string apellido, int numeroRifa)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._numeroRifa = numeroRifa;
        }

    }
}
