using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Ut3.Tp5.Modelo;

public class Herbivoro: Mamifero
{
    public Herbivoro(): base(TipoAlimentacion.HERBIVORO)
    {
        
    }

    public static double PorcentajePeso { get; } = 2;
    public double ValorFijo { get; set; }

    public override double CalcularComida()
    {
        return ((PorcentajePeso * Peso) + ValorFijo);
    }
}
