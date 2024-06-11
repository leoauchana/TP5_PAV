using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Ut3.Tp5.Modelo;

public abstract class Mamifero
{
    protected Mamifero(TipoAlimentacion tipoAlimentacion)
    {
        TipoAlimentacion = tipoAlimentacion;
    }

    public string? Nombre { get; set; }
    public int Edad { get; set; }
    public double Peso { get; set; }
    public TipoAlimentacion TipoAlimentacion { get; }

    public Especie? Especie { get; set; }
    public Sector? Sector { get; set; }
    public Pais? Origen { get; set; }

    public abstract double CalcularComida();
}
