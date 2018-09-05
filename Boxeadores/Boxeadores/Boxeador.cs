using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxeadores
{
    class Boxeador
    {
        //public string brazos { get; set; }  //Brazos {muy cortos, cortos, largos, muy largos}
        public bool[] Brazos { get; set; }  //Cuando lo manejo como matrices
        public bool Estamina { get; set; }//Estamina {poca o mucha}
        public bool Rapidez { get; set; } //Rápidez {tortuga o libre}
        public bool[] Fuerte { get; set; }  //Fuerte{Ompa lompa, williem wonka y Sanson}
        public bool Genero { get; set; }    //Genero Femenino o Masculino (Cromosoma dominante)


        public Boxeador()
        {
            Brazos = new bool[1];
            Fuerte = new bool[1];
        }

        public Boxeador Generar_individuo()
        {
            Boxeador individuo = new Boxeador();
            Random aleatorio = new Random();
            int ale = aleatorio.Next(3);
            individuo.Brazos = conversion(ale);
            return individuo;
        }

        private bool[] conversion(int dato)
        {
            bool[] dato_conver = new bool[1];

            return dato_conver;
        }
    }
}
