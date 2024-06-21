using Pav.Ut3.Tp5.Interfaces;
using Pav.Ut3.Tp5.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Ut3.Tp5.Presentadores
{
    
    public class AgregarAnimalPresenter
    {
        private IAgregarAnimal _agregarAnimal;
        public AgregarAnimalPresenter(IAgregarAnimal view)
        {
            _agregarAnimal = view;
        }

        public bool AgregarAnimal(string nombre, Especie especie, int edad, Pais pais, double peso, Sector sector)
        {
            if (!(edad > 0) || !(peso > 0)) return false;
            Mamifero? animal = null;
            if(sector.TipoAlimentacion == TipoAlimentacion.CARNIVORO)
            {
                animal = new Carnivoro()
                {
                    Nombre = nombre,
                    Especie = especie,
                    Edad = edad,
                    Origen = pais,
                    Peso =peso,
                };
            }else if(sector.TipoAlimentacion == TipoAlimentacion.HERBIVORO)
            {
                animal = new Herbivoro()
                {
                    Nombre = nombre,
                    Especie = especie,
                    Edad = edad,
                    Origen = pais,
                    Peso = peso,
                };
            }
            if (animal is null) return false;
            sector.AgregarAnimal(animal);
            return true;
        }
    }
}
