using Pav.Ut3.Tp5.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Ut3.Tp5.Persistencia;

public class Repositorio
{
    private static Repositorio? _instance = null;
    private static readonly object _lock = new();

    private Repositorio()
    {
        Inicializar();
    }

    public static Repositorio Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance = new Repositorio();
                }
            }
            return _instance;
        }
    }

    public List<Sector> Sectores { get; } = new List<Sector>();
    public List<Pais> Paises { get; } = new List<Pais>();
    public List<Especie> Especies { get; } = new List<Especie>();

    private void Inicializar()
    {
        InicializarPaises();
        InicializarEspecies();
        InicializarSectores();
    }

    private void InicializarPaises()
    {
        Paises.AddRange(new[]
        {
            new Pais
            {
                Cod = 1,
                Nombre = "Sudáfrica"
            },
            new Pais
            {
                Cod = 2,
                Nombre = "Australia"
            },
            new Pais
            {
                Cod= 3,
                Nombre = "Singapur"
            },
            new Pais 
            {
                Cod= 4,
                Nombre = "Canadá"
            }
        });
    }

    private void InicializarEspecies()
    {
        Especies.AddRange(new[]
        {
            new Especie
            {
                Codigo =1,
                Nombre = "León",
                TipoAlimentacion = TipoAlimentacion.CARNIVORO,
                PorcentajePesoCarne = 0.7
            },
            new Especie
            {
                Codigo = 2,
                Nombre = "Jirafa",
                TipoAlimentacion = TipoAlimentacion.HERBIVORO
            },
            new Especie
            {
                Codigo=3,
                Nombre = "Tigre",
                TipoAlimentacion = TipoAlimentacion.CARNIVORO,
                PorcentajePesoCarne = 0.5
            },
            new Especie
            {
                Codigo=4,
                Nombre = "Rinoceronte",
                TipoAlimentacion = TipoAlimentacion.HERBIVORO
            }
        });
    }

    private void InicializarSectores()
    {
        var empleado1 = new Empleado
        {
            Nombre = "Luis",
            Documento = "12345678",
            Domicilio = "Tucumán"
        };
        var empleado2 = new Empleado
        {
            Nombre = "María",
            Documento = "87654321",
            Domicilio = "Tucumán"
        };
        Sectores.AddRange(new[]
        {
            new Sector
            {
                Numero = 1,
                Latitud =-26.250724,
                Longitud = -65.522827,
                Limite = 10,
                TipoAlimentacion = TipoAlimentacion.HERBIVORO,
                Empleado = empleado1
            },
            new Sector
            {
                Numero = 2,
                Latitud =-26.252359,
                Longitud = -65.521511,
                Limite = 10,
                TipoAlimentacion = TipoAlimentacion.CARNIVORO,
                Empleado = empleado1
            },
            new Sector
            {
                Numero = 3,
                Latitud =-26.254661,
                Longitud = -65.522726,
                Limite = 10,
                TipoAlimentacion = TipoAlimentacion.HERBIVORO,
                Empleado = empleado2
            },
            new Sector
            {
                Numero = 4,
                Latitud =-26.257250,
                Longitud = -65.523514,
                Limite = 10,
                TipoAlimentacion = TipoAlimentacion.CARNIVORO,
                Empleado = empleado2
            },
            new Sector
            {
                Numero = 5,
                Latitud = -25.89876,
                Longitud = -66.56437,
                Limite = 10,
                TipoAlimentacion = TipoAlimentacion.HERBIVORO,
                Empleado = empleado2
            }
        });
    }

}
