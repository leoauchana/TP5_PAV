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
    public partial class AgregarAnimalView : Form
    {
        private SectoresView _sectorView = new SectoresView();
        public AgregarAnimalView()
        {
            InitializeComponent();
            especieBindingSource.DataSource = Repositorio.Instance.Especies.ToArray();
            paisBindingSource.DataSource = Repositorio.Instance.Paises.ToArray();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEspecie.SelectedItem is null) return;
            var especie = cbEspecie.SelectedItem as Especie;
            clbSectores.Items.Clear();
            clbSectores.Items.AddRange(Repositorio.Instance.Sectores.Where(
                s => s.TipoAlimentacion == especie!.TipoAlimentacion).Select(e => e.Numero.ToString()).ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
            _sectorView.Show();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (clbSectores.SelectedItem is null || clbSectores.SelectedItems.Count > 1) return;
            if (!int.TryParse(clbSectores.SelectedItem.ToString(), out var numSector)) return;
            var sectorSeleccionado = Repositorio.Instance.Sectores[numSector - 1];
            Mamifero? animal;
            if (!int.TryParse(txtEdad.Text, out _) || !double.TryParse(txtPeso.Text, out _)) return;
            if (sectorSeleccionado!.TipoAlimentacion.Equals(TipoAlimentacion.CARNIVORO))
            {
                animal = new Carnivoro()
                {
                    Nombre = txtNombre.Text,
                    Especie = cbEspecie.SelectedItem as Especie,
                    Edad = int.Parse(txtEdad.Text),
                    Origen = cbPais.SelectedItem as Pais,
                    Peso = double.Parse(txtPeso.Text),
                };
            }
            else animal = new Herbivoro()
            {
                Nombre = txtNombre.Text,
                Especie = cbEspecie.SelectedItem as Especie,
                Edad = int.Parse(txtEdad.Text),
                Origen = cbPais.SelectedItem as Pais,
                Peso = double.Parse(txtPeso.Text),
            };
            if (animal is null) return;
            sectorSeleccionado.AgregarAnimal(animal);
            Dispose();
            _sectorView.Show();
            _sectorView.CargarSectores();
        }
    }
}
