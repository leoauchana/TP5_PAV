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
    public partial class AgregarAnimalView : Form, IAgregarAnimal
    {
        private SectoresView _sectorView = new SectoresView();
        private AgregarAnimalPresenter _presentadorAgregar;
        public AgregarAnimalView()
        {
            _presentadorAgregar = new AgregarAnimalPresenter(this);
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
            if (clbSectores.SelectedItem is null || clbSectores.SelectedItems.Count > 1 || cbPais.SelectedItem is null) return;
            if (!int.TryParse(clbSectores.SelectedItem.ToString(), out var numSector)) return;
            var sectorSeleccionado = Repositorio.Instance.Sectores[numSector - 1];
            if (!int.TryParse(txtEdad.Text, out int edad) || !double.TryParse(txtPeso.Text, out double peso) || (double.TryParse(txtNombre.Text, out _))) return;
            var nombre = txtNombre.Text;
            var especie = cbEspecie.SelectedItem as Especie;
            var pais = cbPais.SelectedItem as Pais;
            var verificacion = _presentadorAgregar.AgregarAnimal(nombre, especie!, edad, pais!, peso, sectorSeleccionado);
            if (verificacion)
            {
                _sectorView.Iniciar.Invoke();
                Hide();
                MostrarMensajes("Se guardo correctamente", verificacion);
                _sectorView.Show();
            }
            else
            {
                MostrarMensajes("Error al guardar", verificacion);
            }
        
    }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void MostrarMensajes(string mensaje, bool validacion)
        {
            if (validacion)
            {
                MessageBox.Show(mensaje, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
