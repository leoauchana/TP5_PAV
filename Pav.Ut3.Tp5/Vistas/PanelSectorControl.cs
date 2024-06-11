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
            lblEspecies.Text = EspeciesText(sector);
            if (sector.TipoAlimentacion.Equals(TipoAlimentacion.CARNIVORO)) BackColor = Color.IndianRed;
            else if (sector.TipoAlimentacion.Equals(TipoAlimentacion.HERBIVORO)) BackColor = Color.DarkOliveGreen;
            if (sector.Animales.Count == 0) BackColor = Color.Gray;
            btnVer.BackColor = BackColor;
        }
        private string EspeciesText(Sector sector)
        {
            return string.Join(" ,", sector.Animales.Select(e => e.Especie?.Nombre));
        }

        private void btnVer_Click(object sender, EventArgs e)
        {

        }

        private void btnVer_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(lblNroSector.Text, out int nroSector)) return;
            DetalleSectorView detalleSector = new DetalleSectorView(nroSector);
            detalleSector.Show();
            _sector?.Hide();
        }
    }
}
