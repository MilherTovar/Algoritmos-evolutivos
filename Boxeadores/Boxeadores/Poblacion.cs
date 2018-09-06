using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxeadores
{
    class Poblacion
    {
        public List<Boxeador>Pobla { get; set; }

       public Poblacion(int cantidad)
        {
            Pobla = new List<Boxeador>(cantidad);
        }

        public Poblacion generar_poblacion_inicial (int cantidad_individuos)
        {
            Poblacion poblacion_generada = new Poblacion(cantidad_individuos);
            for (int i = 0; i < cantidad_individuos; i++)
            {
                Boxeador individuo = new Boxeador();
                individuo = individuo.Generar_individuo();
                poblacion_generada.Pobla.Add(individuo);
            }
            return poblacion_generada;
        }
    }
}
