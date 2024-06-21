using Pav.Ut3.Tp5.Interfaces;
using Pav.Ut3.Tp5.Modelo;
using Pav.Ut3.Tp5.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Ut3.Tp5.Presentadores
{
    public class SectoresPresenter
    {
        private ISectores _sectores;
        public SectoresPresenter(ISectores view) {
            _sectores = view;
        }
        public (double, double) DevolverComida()
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
            return(comidaCarnivoro, comidaHerbivoro);
        }
    }
}
