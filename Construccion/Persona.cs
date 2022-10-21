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
    internal class Persona
    {
        private string _nombre;
        private string _apellido;
        private int _numeroRifa;

        public Persona(){}

        public Persona(string nombre, string apellido, int numeroRifa)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._numeroRifa = numeroRifa;
        }

        public static List<Persona> listaPersonas = new List<Persona>()
        {
            new Persona("Pablo","Rodas",350),
        };

        public static void registrarPersona(string nombre, string apellido, string numeroRifa)
        {
            int numeroRifaEntero = Convert.ToInt32(numeroRifa);

            listaPersonas.Add(new Persona(nombre, apellido, numeroRifaEntero));
        }

        public static bool numeroRifaEstaDisponible(string numeroElegido)
        {
            int numeroRifaAEntero = Convert.ToInt32(numeroElegido);
            bool estaDisponible = true;

            for (int i = 0; i < Persona.listaPersonas.Count; i++)
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
