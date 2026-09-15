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
    public partial class FrmPrincipal : Form
    {
        ActividadNegocio negocio = new ActividadNegocio();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ucActividad1.Validar())
            {
                return;
            }

            try
            {
                Actividad actividad;

                Responsable responsable = new Responsable(
                    ucActividad1.NombreResponsable,
                    ucActividad1.Telefono
                );

                if (cmbTipoActividad.Text == "Cine")
                {
                    actividad = new Cine
                    {
                        Nombre = ucActividad1.Nombre,
                        costo = ucActividad1.Costo,
                        Responsable = responsable,
                        Sala = 1
                    };
                }
                else if (cmbTipoActividad.Text == "Boliche")
                {
                    actividad = new Boliche
                    {
                        Nombre = ucActividad1.Nombre,
                        costo = ucActividad1.Costo,
                        Responsable = responsable,
                        NumeroPistas = 10
                    };
                }
                else
                {
                    actividad = new Videojuegos
                    {
                        Nombre = ucActividad1.Nombre,
                        costo = ucActividad1.Costo,
                        Responsable = responsable,
                        ConsolaPrincipal = "PlayStation"
                    };
                }

                negocio.Registrar(actividad);

                MessageBox.Show("Actividad registrada correctamente.");

                Limpiar();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

       public void Limpiar()
        {
            ucActividad1.Limpiar();
            cmbTipoActividad.SelectedIndex = -1;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvActividades.Rows.Clear();

            foreach (Actividad actividad in negocio.ObtenerTodas())
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

