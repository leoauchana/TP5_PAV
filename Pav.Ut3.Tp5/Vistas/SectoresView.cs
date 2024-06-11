using Pav.Ut3.Tp5.Modelo;
using Pav.Ut3.Tp5.Persistencia;
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
    public partial class SectoresView : Form
    {
        public SectoresView()
        {
            InitializeComponent();
            CargarSectores();
        }



        public void CargarSectores()
        {
            flpSectores.Controls.Clear();
            foreach (Sector sector in Repositorio.Instance.Sectores)
            {
                flpSectores.Controls.Add(new pnlSector(sector));
            }
        }




        private void btnAnimal_Click(object sender, EventArgs e)
        {
            AgregarAnimalView agregarAnimalView = new AgregarAnimalView();
            agregarAnimalView.Show();

            this.Hide();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var comidaCarnivoro = 0.00;
            var comidaHerbivoro = 0.00;
            foreach (var sector in Repositorio.Instance.Sectores)
            {
                foreach (var animal in sector.Animales)
                {
                    if (sector.TipoAlimentacion.Equals(TipoAlimentacion.CARNIVORO)) comidaCarnivoro += animal.CalcularComida();
                    if (sector.TipoAlimentacion.Equals(TipoAlimentacion.HERBIVORO)) comidaHerbivoro += animal.CalcularComida();
                }
            }

            lbelValorCarnivoro.Text = $"{comidaCarnivoro}";
            lbelValorHerbivoro.Text = $"{comidaHerbivoro}";
            lbelValorTotal.Text = $"{comidaCarnivoro + comidaHerbivoro}";
        }

        private void pnlBotones_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
