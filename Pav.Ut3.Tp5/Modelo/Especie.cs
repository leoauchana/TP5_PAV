using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Ut3.Tp5.Modelo;

public class Especie
{
    public int Codigo { get; set; }
    public string? Nombre { get; init; }
    public double PorcentajePesoCarne { get; init; }

    public TipoAlimentacion TipoAlimentacion { get; init; }
}
