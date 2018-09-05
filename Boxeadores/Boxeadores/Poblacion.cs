using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxeadores
{
    class Poblacion
    {
        List<Boxeador> Pobla = new List<Boxeador>();

        public Poblacion generar_poblacion_inicial (int cantidad_individuos)
        {
            Poblacion poblacion_generada = new Poblacion();
            for (int i = 0; i < cantidad_individuos; i++)
            {
                Boxeador individuo = new Boxeador();
            }
            return poblacion_generada;
        }
    }
}
