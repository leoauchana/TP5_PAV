using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pav.Ut3.Tp5.Interfaces;
using Pav.Ut3.Tp5.Modelo;
using Pav.Ut3.Tp5.Persistencia;
using Pav.Ut3.Tp5.Presentadores;
namespace Pav.Ut3.Tp5.Vistas
{
    public partial class DetalleSectorView : Form, IDetalleSector
    {
        private DetalleSectorPresenter _detalleSector;
        public DetalleSectorView(int nroSector)
        {
            _detalleSector = new DetalleSectorPresenter(this);
            InitializeComponent();
            CargarDatos(nroSector);
        }

        public void CargarDatos(int nroSector)
        {
            var listaAnimales = _detalleSector.DevolverListaAnimales(nroSector, out Empleado? empleado);
            if (listaAnimales == null || empleado is null)
            {
                MostrarMensaje("Error de mostrado");
            }
            else
            {
                var tipoAlimentacion = Repositorio.Instance.Sectores[nroSector - 1].TipoAlimentacion;
                Color color = _detalleSector.DevolverColor(tipoAlimentacion);
                BackColor = color;
                dgvEspecies.BackgroundColor = color;
                lblNumSector.Text = $"{nroSector}";
                lblNomEmpleado.Text = empleado?.Nombre;
                foreach (Mamifero animal in listaAnimales!)
                {
                    dgvEspecies.Rows.Add(animal.Especie!.Nombre, animal.Edad, animal.Peso, animal.Origen!.Nombre);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
