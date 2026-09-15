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
    /// <summary>
    /// EVELYN PAMELA GUTIERREZ RUIZ 14/09/2026
    /// ESTA CLASE ES EL CONTROL DE USUARIO QUE PERMITE INGRESAR LOS DATOS DE UNA ACTIVIDAD, INCLUYENDO EL NOMBRE, TIPO, COSTO Y RESPONSABLE.
    /// </summary>
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

        public string CostoTexto
        {
            get
            {
                return txtCosto.Text;
            }
        }

        public string NombreResponsable
        {
            get { return txtResponsable.Text; }
        }

        public string Telefono
        {
            get { return txtTelefono.Text; }
        }

        //metodo limpiar
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

    

