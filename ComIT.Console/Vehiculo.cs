using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComIT.Console
{
    public class Vehiculo
    {
        public int Año = 0;
        public string Color = "";
        public int VelocidadMaxima = 0;
        private bool Encendido = false;
        private int VelocidadActual = 0;

        public void Encender()
        {
            if (!Encendido)
            {
                Encendido = true;
                System.Console.WriteLine("El auto está encendido");
            }else
            {
                System.Console.WriteLine("El auto ya está en marcha");
            }
            
        }
        public void Apagar()
        {   
            if (Encendido)
            {
                System.Console.WriteLine("El auto se apagó");
            }else
            {
                System.Console.WriteLine("El auto no esta encendido");
            }
        }
        public void Acelerar()
        {   
            if (Encendido)
            {
                VelocidadActual += 20;
                if (VelocidadActual > VelocidadMaxima)
                {
                    System.Console.WriteLine($"La nueva velocidad es {VelocidadMaxima}. No se puede acelerar mas");
                }
               
            }else
            {
                System.Console.WriteLine("Antes de acelerar, prende el vehiculo");
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
                } else
                {
                    System.Console.WriteLine("El auto esta frenado");
                }
            }
            else
            {
                System.Console.WriteLine("El auto esta apagado");
            }
            
        }
    }
}
