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

        private bool formatoNombreEsValido()
        {
            bool formatoEsValido = Regex.Match(tboxNombre.Text, @"^[A-Za-z]{3,10}$|^[A-Za-z]{3,10}\s[A-Za-z]{3,10}$").Success;

            return formatoEsValido;
        }
        private bool formatoApellidoEsValido()
        {
            bool formatoEsValido = Regex.Match(tboxApellido.Text, @"^[A-Za-z]{3,13}$|^[A-Za-z]{3,13}\s[A-Za-z]{3,13}$").Success;
          
            return formatoEsValido;
        }
        private bool formatoNumeroEsValido()
        {
            bool formatoEsValido = Regex.Match(tboxNumero.Text, @"^(?:0|[1-9]\d{0,2})$").Success;

            return formatoEsValido;
        }

        private void tboxNombre_TextChanged(object sender, EventArgs e)
        {
            cambiarEstadoBoton();
        }
        private void tboxApellido_TextChanged(object sender, EventArgs e)
        {
            cambiarEstadoBoton();
        }
        private void tboxNumero_TextChanged(object sender, EventArgs e)
        {
            cambiarEstadoBoton();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (GestionRifa.numeroRifaEstaDisponible(tboxNumero.Text))
            {
                mostrarMensaje($"El numero {tboxNumero.Text} ha sido asignado a {tboxNombre.Text} {tboxApellido.Text}.", "Sistema de rifas");

                GestionRifa.registrarNuevaRifa(tboxNombre.Text, tboxApellido.Text, tboxNumero.Text);
            }
            else
            {
                mostrarMensaje("El numero solicitado ya ha sido ingresado, por favor, ingrese otro!", "Sistema de rifas");
            }
        }
        
        private void mostrarMensaje(string mensajeCuerpo, string mensajeTitulo)
        {
            MessageBox.Show(mensajeCuerpo, mensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void cambiarEstadoBoton()
        {
            if (formatoNombreEsValido() && formatoApellidoEsValido() && formatoNumeroEsValido())
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