using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaActividades
{
    public partial class UcActividad : UserControl
    {
        // Constructor
        public UcActividad()
        {
            InitializeComponent();
        }

        //propiedades
        public string Nombre
        {
            get { return txtNombre.Text; }
        }

        public double Costo
        {
            get { return double.Parse(txtCosto.Text); }
        }

        public string NombreResponsable
        {
            get { return txtResponsable.Text; }
        }

        public string Telefono
        {
            get { return txtTelefono.Text; }
        }


        // Método para validar
        public bool Validar()
        {
            bool correcto = true;

            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese el nombre.");
                correcto = false;
            }

            if (string.IsNullOrWhiteSpace(txtCosto.Text))
            {
                errorProvider1.SetError(txtCosto, "Ingrese el costo.");
                correcto = false;
            }
            else if (!decimal.TryParse(txtCosto.Text, out decimal costo))
            {
                errorProvider1.SetError(txtCosto, "Ingrese un número válido.");
                correcto = false;
            }
            else if (costo < 0)
            {
                errorProvider1.SetError(txtCosto, "El costo no puede ser negativo.");
                correcto = false;
            }

            if (string.IsNullOrWhiteSpace(txtResponsable.Text))
            {
                errorProvider1.SetError(txtResponsable, "Ingrese el responsable.");
                correcto = false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                errorProvider1.SetError(txtTelefono, "Ingrese el teléfono.");
                correcto = false;
            }

            return correcto;
        }

        public void Limpiar()
        {
            txtNombre.Clear();
            txtCosto.Clear();
            txtResponsable.Clear();
            txtTelefono.Clear();

            errorProvider1.Clear();
        }
    }
}

    

