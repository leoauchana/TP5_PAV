using Pav.Ut3.Tp5.Interfaces;
using Pav.Ut3.Tp5.Modelo;
using Pav.Ut3.Tp5.Persistencia;
using Pav.Ut3.Tp5.Presentadores;
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
    public delegate void Comida();
    public delegate void IniciarSectores();
    public partial class SectoresView : Form, ISectores
    {
        private Comida _comida;
        public IniciarSectores Iniciar;
        private SectoresPresenter _sectoresPresentador;
        public SectoresView()
        {
            _sectoresPresentador = new SectoresPresenter(this);
            InitializeComponent();
            Iniciar += CargarSectores;
            _comida += CalcularComida;
            Iniciar.Invoke();
        }

        public void CalcularComida()
        {
            (double alimentoCarnivoro, double alimentoHerbivoro) = _sectoresPresentador.DevolverComida();
            lblValorCarne.Text = $"{Math.Round(alimentoCarnivoro,2)}";
            lbelValorHerbivoro.Text = $"{Math.Round(alimentoHerbivoro,2)}";
            lbelValorTotal.Text = $"{Math.Round(alimentoHerbivoro + alimentoCarnivoro,2)}";
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
            Hide();
            AgregarAnimalView agregarAnimalView = new AgregarAnimalView();
            agregarAnimalView.ShowDialog();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            _comida.Invoke();
        }

        private void pnlBotones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flpSectores_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblKgsHerbivoro_Click(object sender, EventArgs e)
        {

        }

        private void SectoresView_Load(object sender, EventArgs e)
        {

        }

        private void pnlLabel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SectoresView_Load_1(object sender, EventArgs e)
        {

        }
    }
}
