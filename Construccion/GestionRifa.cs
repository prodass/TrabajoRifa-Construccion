using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;

namespace Construccion
{
    internal class GestionRifa
    {
        const string DIRECCION_ARCHIVO = @"D:/ListaDeRifasVendidas.txt";

        public static bool numeroRifaEstaDisponible(string numeroElegido)
        {
            const int NUMERO_DE_RIFA = 2;

            bool estaDisponible = true;

            using (StreamReader archivoTexto = new StreamReader(DIRECCION_ARCHIVO))
            {
                string lineaArchivo = archivoTexto.ReadLine();

                while (lineaArchivo != null)
                {
                    string[] datosRifa = lineaArchivo.Split(' ');

                    if (datosRifa[NUMERO_DE_RIFA].Equals(numeroElegido))
                    {
                        estaDisponible = false;
                    }

                    lineaArchivo = archivoTexto.ReadLine();
                }
                
            }

            return estaDisponible;
        }

        public static void registrarNuevaRifa(string nombre, string apellido, string numeroRifa)
        {
            using (StreamWriter sw = new StreamWriter(DIRECCION_ARCHIVO, true))
            {
                sw.WriteLine($"{nombre} {apellido} {numeroRifa} {DateTime.Now}");
            }
        }
    }
}