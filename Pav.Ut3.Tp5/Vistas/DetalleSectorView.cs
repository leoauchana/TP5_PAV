using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pav.Ut3.Tp5.Modelo;
using Pav.Ut3.Tp5.Persistencia;
namespace Pav.Ut3.Tp5.Vistas
{
    public partial class DetalleSectorView : Form
    {

        public DetalleSectorView(int nroSector)
        {
            InitializeComponent();
            CargarDatos(nroSector);
        }

        private void CargarDatos(int nroSector)
        {
            if (nroSector <= 0) return;
            var sector = Repositorio.Instance.Sectores[nroSector - 1];
            if (sector is null) return;
            if (sector.TipoAlimentacion.Equals(TipoAlimentacion.CARNIVORO)) BackColor = Color.IndianRed;
            if (sector.TipoAlimentacion.Equals(TipoAlimentacion.HERBIVORO)) BackColor = Color.DarkOliveGreen;
            if (sector.Animales.Count == 0) BackColor = Color.Gray;
            lblNumSector.Text = $"{sector.Numero}";
            lblNomEmpleado.Text = sector.Empleado?.Nombre;
            foreach (Mamifero animal in sector.Animales)
            {
                dgvEspecies.Rows.Add(animal.Especie!.Nombre, animal.Edad, animal.Peso, animal.Origen!.Nombre);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
