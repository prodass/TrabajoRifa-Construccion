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
    internal class NumeroRifa
    {
        private string _nombre;
        private string _apellido;
        private int _numeroRifa;

        public NumeroRifa(){}

        public NumeroRifa(string nombre, string apellido, int numeroRifa)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._numeroRifa = numeroRifa;
        }

        public static List<NumeroRifa> listaPersonas = new List<NumeroRifa>()
        {
            new NumeroRifa("Pablo","Rodas",350),
        };

        public static void registrarNuevaPersona(string nombre, string apellido, string numeroRifa)
        {
            int numeroRifaEntero = Convert.ToInt32(numeroRifa);

            listaPersonas.Add(new NumeroRifa(nombre, apellido, numeroRifaEntero));
        }

        public static bool numeroRifaEstaDisponible(string numeroElegido)
        {
            int numeroRifaAEntero = Convert.ToInt32(numeroElegido);
            bool estaDisponible = true;

            for (int i = 0; i < NumeroRifa.listaPersonas.Count; i++)
            {
                if (listaPersonas[i]._numeroRifa.Equals(numeroRifaAEntero))
                {
                    estaDisponible = false;
                }
            }

            return estaDisponible;
        }
    }
}
