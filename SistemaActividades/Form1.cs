using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaActividades.Modelo;
using SistemaActividades.Negocio;

namespace SistemaActividades
{
    /// <summary>
    /// EVELYN PAMELA GUTIERREZ RUIZ 14/09/2026
    /// ESTA CLASE ES EL FORMULARIO PRINCIPAL DE LA APLICACIÓN, DONDE SE PUEDEN AGREGAR ACTIVIDADES Y MOSTRARLAS EN UNA LISTA.
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        //ACTIVIDAD NEGOCIO
        ActividadNegocio negocio = new ActividadNegocio();

        // Constructor
        public FrmPrincipal()
        {
            InitializeComponent();

            dgvActividades.Columns.Add("Id", "Id");
            dgvActividades.Columns.Add("Nombre", "Nombre");
            dgvActividades.Columns.Add("Tipo", "Tipo");
            dgvActividades.Columns.Add("Costo", "Costo");
            dgvActividades.Columns.Add("Responsable", "Responsable");
           
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        //boton agregar actividad
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            ucActividad1.LimpiarErrores();

            Actividad actividad;

            if (cmbTipoActividad.Text == "Cine")
            {
                actividad = new Cine
                {
                    Nombre = ucActividad1.Nombre,
                    Sala = 1
                };
            }
            else if (cmbTipoActividad.Text == "Boliche")
            {
                actividad = new Boliche
                {
                    Nombre = ucActividad1.Nombre,
                    NumeroPistas = 10
                };
            }
            else if (cmbTipoActividad.Text == "Videojuegos")
            {
                actividad = new Videojuegos
                {
                    Nombre = ucActividad1.Nombre,
                    ConsolaPrincipal = "PlayStation"
                };
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de actividad.");
                return;
            }

            string error = negocio.Registrar(
                actividad,
                ucActividad1.CostoTexto,
                ucActividad1.NombreResponsable,
                ucActividad1.Telefono
            );

            if (error == "Nombre")
            {
                ucActividad1.MostrarError("Nombre", "Escribe el nombre de la actividad.");
                return;
            }

            if (error == "Costo")
            {
                ucActividad1.MostrarError("Costo", "Escribe un costo válido mayor a cero.");
                return;
            }

            if (error == "Responsable")
            {
                ucActividad1.MostrarError("Responsable", "Escribe el nombre del responsable.");
                return;
            }

            if (error == "Telefono")
            {
                ucActividad1.MostrarError("Telefono", "Escribe el teléfono.");
                return;
            }

            MessageBox.Show("Actividad registrada correctamente.");

            ucActividad1.Limpiar();
            //LIMPIAR COMBO
            cmbTipoActividad.SelectedIndex = -1;
        }
        


        //boton MOSTRAR actividades
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvActividades.Rows.Clear();

            foreach (Actividad actividad in negocio.ObtenerActividades())
            {
                dgvActividades.Rows.Add(
                    actividad.Id,
                    actividad.Nombre,
                    actividad.GetType().Name,
                    actividad.costo,
                    actividad.Responsable.Nombre
                );
            }

        }
    }
    
}

