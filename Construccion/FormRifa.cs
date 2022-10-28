using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construccion
{
    public partial class FormRifa : Form
    {
        public FormRifa()
        {
            InitializeComponent();
        }

        private void mostrarMensaje(string mensajeCuerpo, string mensajeTitulo)
        {
            MessageBox.Show(mensajeCuerpo, mensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool formatoDeEntradaEsValido(string nombrePersona, string apellidoPersona, string numeroRifa)
        {
            bool formatoNombreEsValido = Regex.Match(nombrePersona, @"^[A-Za-z]{3,10}$|^[A-Za-z]{3,10}\s[A-Za-z]{3,10}$").Success;
            bool formatoApellidoEsValido = Regex.Match(apellidoPersona, @"^[A-Za-z]{3,13}$|^[A-Za-z]{3,13}\s[A-Za-z]{3,13}$").Success;
            bool formatoNumeroEsValido = Regex.Match(numeroRifa, @"^(?:0|[1-9]\d{0,2})$").Success;
            bool formatoDeEntradaValido = false;

            if (!formatoNombreEsValido)
            {
                mostrarMensaje("El nombre ingresado no es valido!", "Error de formato");
                tboxNombre.Clear();
            }
            else if (!formatoApellidoEsValido)
            {
                mostrarMensaje("El apellido ingresado no es valido!", "Error de formato");
                tboxApellido.Clear();
            }
            else if (!formatoNumeroEsValido)
            {
                mostrarMensaje("El numero ingresado no es valido!", "Error de formato");
                tboxNumero.Clear();
            }
            else
            {
                formatoDeEntradaValido = true;
            }

            return formatoDeEntradaValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (formatoDeEntradaEsValido(tboxNombre.Text, tboxApellido.Text, tboxNumero.Text))
            {
                if (NumeroRifa.numeroRifaEstaDisponible(tboxNumero.Text))
                {
                    mostrarMensaje($"El numero {tboxNumero.Text} ha sido asignado a {tboxNombre.Text} {tboxApellido.Text}.", "Sistema de rifas");

                    NumeroRifa.registrarNuevaPersona(tboxNombre.Text, tboxApellido.Text, tboxNumero.Text);
                }
                else
                {
                    mostrarMensaje("El numero solicitado ya ha sido ingresado, por favor, ingrese otro!", "Sistema de rifas");
                }
            }
        }

        private void tboxNombre_TextChanged(object sender, EventArgs e)
        {
            bool formatoNombreEsValido = Regex.Match(tboxNombre.Text, @"^[A-Za-z]{3,10}$|^[A-Za-z]{3,10}\s[A-Za-z]{3,10}$").Success;
            bool activarBoton = true;

            if (!formatoNombreEsValido)
            {
                activarBoton = false;
            }

            cambiarEstadoBoton(activarBoton);
        }
        private void tboxApellido_TextChanged(object sender, EventArgs e)
        {
            bool formatoApellidoEsValido = Regex.Match(apellidoPersona, @"^[A-Za-z]{3,13}$|^[A-Za-z]{3,13}\s[A-Za-z]{3,13}$").Success;
            bool formatoEsValido = true;

            if (Regex.Match(tboxApellido.Text, @"^[A-Za-z]{3,13}$|^[A-Za-z]{3,13}\s[A-Za-z]{3,13}$").Success)
            {
                formatoEsValido = true;
            }

            cambiarEstadoBoton(formatoEsValido);
        }
        private void tboxNumero_TextChanged(object sender, EventArgs e)
        {
            bool formatoEsValido = true;

            if (Regex.Match(tboxNumero.Text, @"^(?:0|[1-9]\d{0,2})$").Success)
            {
                formatoEsValido = false;
            }

            cambiarEstadoBoton(formatoEsValido);
        }
        private void cambiarEstadoBoton(bool formatoEsValido)
        {
            if (formatoEsValido)
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }
    }
}