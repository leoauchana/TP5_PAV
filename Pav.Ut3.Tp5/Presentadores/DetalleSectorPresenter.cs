using Pav.Ut3.Tp5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pav.Ut3.Tp5.Modelo;
using Pav.Ut3.Tp5.Persistencia;
namespace Pav.Ut3.Tp5.Presentadores
{
    public class DetalleSectorPresenter
    {
        private IDetalleSector _detalleSector;
        public DetalleSectorPresenter(IDetalleSector view) {
        _detalleSector = view;
        }
        public List<Mamifero>? DevolverListaAnimales(int nroSector,out Empleado? empleado)
        {
            if (!Repositorio.Instance.Sectores.Any(e => e.Numero-1 == nroSector - 1) || nroSector < 0) {
                empleado = null;
                return null;
            }
            var listaAnimalesSector = Repositorio.Instance.Sectores[nroSector - 1].Animales;
            empleado = Repositorio.Instance.Sectores[nroSector - 1].Empleado;
            return listaAnimalesSector;
        }

        public Color DevolverColor(TipoAlimentacion tipoAlimentacion)
        {
            if (tipoAlimentacion == TipoAlimentacion.CARNIVORO) return Color.OrangeRed;
            if (tipoAlimentacion == TipoAlimentacion.HERBIVORO) return Color.GreenYellow;
            else return Color.Gray;
        }
    }
}
