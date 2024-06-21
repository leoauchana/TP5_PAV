using Pav.Ut3.Tp5.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pav.Ut3.Tp5.Vistas
{
    public partial class pnlSector : UserControl
    {
        private SectoresView? _sector;
        public pnlSector(Sector sector)
        {
            InitializeComponent();
            ActualizarDatos(sector);
        }
        public void ActualizarDatos(Sector sector)
        {
            if (sector is null) return;
            lblCantAnimales.Text = $"{sector.Animales.Count}";
            lblNroSector.Text = $"{sector.Numero}";
            lblUbicacion.Text = sector.Ubicacion();
            lblEmpleado.Text = sector.Empleado!.Nombre;
            lblEspecies.Text = sector.EspeciesText();
            if (sector.TipoAlimentacion.Equals(TipoAlimentacion.CARNIVORO)) BackColor = Color.OrangeRed;
            else if (sector.TipoAlimentacion.Equals(TipoAlimentacion.HERBIVORO)) BackColor = Color.GreenYellow;
            if (sector.Animales.Count == 0) BackColor = Color.Gray;
            btnVer.BackColor = BackColor;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {

        }

        private void btnVer_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(lblNroSector.Text, out int nroSector)) return;
            DetalleSectorView detalleSector = new DetalleSectorView(nroSector);
            detalleSector.ShowDialog();
        }

        private void btnVer_Click_2(object sender, EventArgs e)
        {

        }
    }
}
