using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Ut3.Tp5.Excepciones;

public class DominioException: Exception
{
    public DominioException(string mensaje) : base(mensaje)
    {
        
    }
}
