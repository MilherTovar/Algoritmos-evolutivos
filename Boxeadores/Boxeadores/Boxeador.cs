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
            individuo.Genero = false;
            individuo.Estamina = aleatorios();
            individuo.Rapidez = aleatorios();
           return individuo;
        }

        private bool[] conversion(int dato)
        {
            bool[] dato_conver = new bool[1];
            #region Código de convertir decimales a binarios con ciclos
            /*int contador = 0;
            for (int i = 0; i < 1; i++)
            {
                dato_conver[i] = false;
            }
            while (((dato / 2) >= 1))
            {
                int dato_dividido = dato / 2;
                int modulo = dato % 2;
                dato = dato_dividido;
                if (modulo == 0)
                {
                    dato_conver[contador] = true;
                }
                else
                {
                    dato_conver[contador] = false;
                }
                contador++;
            }*/
            #endregion
            #region Código conversión números pequeños
            switch (dato)
            {
                case 0:
                    dato_conver[0] = false;
                    dato_conver[1] = false;
                    break;
                case 1:
                    dato_conver[0] = true;
                    dato_conver[1] = false;
                    break;
                case 2:
                    dato_conver[0] = false;
                    dato_conver[1] = true;
                    break;
                case 3:
                    dato_conver[0] = true;
                    dato_conver[1] = true;
                    break;
            }
            #endregion
            return dato_conver;
        }
        
        private bool aleatorios()
        {
            Random aleatorio = new Random();
            int ale = aleatorio.Next(1);
            if (ale == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
