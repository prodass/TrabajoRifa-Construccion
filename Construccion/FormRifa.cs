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

        private void validarEntradas(string nombrePersona, string apellidoPersona, string numeroRifa)
        {
            bool formatoNombreNoEsValido = !Regex.Match(nombrePersona, @"^[A-Za-z]{3,10}$|^[A-Za-z]{3,10}\s[A-Za-z]{3,10}$").Success;
            bool formatoApellidoNoEsValido = !Regex.Match(apellidoPersona, @"^[A-Za-z]{3,13}$|^[A-Za-z]{3,13}\s[A-Za-z]{3,13}$").Success;
            bool formatoNumeroNoEsValido = !Regex.Match(numeroRifa, @"^(?:0|[1-9]\d{0,2})$").Success;

            if (formatoNombreNoEsValido)
            {
                mostrarMensaje("El nombre ingresado no es valido!", "Error de formato");
                tboxNombre.Clear();
            }
            if (formatoApellidoNoEsValido)
            {
                mostrarMensaje("El apellido ingresado no es valido!", "Error de formato");
                tboxApellido.Clear();
            }
            if (formatoNumeroNoEsValido)
            {
                mostrarMensaje("El numero ingresado no es valido!", "Error de formato");
                tboxNumero.Clear();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            validarEntradas(tboxNombre.Text, tboxApellido.Text, tboxNumero.Text);

            if (Persona.numeroRifaEstaDisponible(tboxNumero.Text))
            {
                mostrarMensaje($"El numero {tboxNumero.Text} ha sido asignado a {tboxNombre.Text} {tboxApellido.Text}.", "Sistema de rifas");

                Persona.registrarPersona(tboxNombre.Text, tboxApellido.Text, tboxNumero.Text);
            }
            else
            {
                mostrarMensaje("El numero solicitado ya ha sido ingresado, por favor, ingrese otro!", "Sistema de rifas");
            }
        }
    }
}
