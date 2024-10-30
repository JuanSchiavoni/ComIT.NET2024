using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComIT.Console.Vehiculos
{
    public class Vehiculo
    {
        public int Año = 0;
        public string Color = "";
        public int VelocidadMaxima = 0;
        public int CantidadDeRuedas = 0;
        private bool Encendido = false;
        private int VelocidadActual = 0;
        protected string TipoVehiculo = "";

        public Vehiculo()
        {

        }

        public void Encender()
        {
            if (!Encendido)
            {
                Encendido = true;
                System.Console.WriteLine($"{TipoVehiculo} está en marcha");
            }
            else
            {
                System.Console.WriteLine($"{TipoVehiculo} ya está en marcha");
            }

        }
        public void Apagar()
        {
            if (Encendido)
            {
                System.Console.WriteLine($"{TipoVehiculo} se apagó");
            }
            else
            {
                System.Console.WriteLine($"{TipoVehiculo} no esta en marcha");
            }
        }

        //public void Acelerar() 
        //{
        //    Acelerar(20);
        //}

        //dos formas distintas de hacerlo

        public void Acelerar(int aceleracion = 20)
        {
            if (Encendido)
            {
                VelocidadActual += aceleracion;
                if (VelocidadActual > VelocidadMaxima)
                {
                    System.Console.WriteLine($"La velocidad maxima es {VelocidadMaxima}. No se puede acelerar mas");
                }
                else
                {
                    System.Console.WriteLine($"La nueva velocidad es {VelocidadActual}");
                }

            }
            else
            {
                System.Console.WriteLine($"Antes de acelerar, prender {TipoVehiculo}");
            }
        }
        public void Frenar()
        {
            if (Encendido)
            {
                VelocidadActual -= 20;
                if (VelocidadActual > 0)
                {
                    System.Console.WriteLine($"La velocidad actual es {VelocidadActual}");
                }
                else
                {
                    System.Console.WriteLine($"{TipoVehiculo} ya esta detenido");
                }
            }
            else
            {
                System.Console.WriteLine($"{TipoVehiculo} esta apagado");
            }

        }
    }
}
