using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComIT.Console.Vehiculos
{
    public class Auto : Vehiculo
    {
        public int CantidadPuerta = 2;

        private bool radioPrendida = false;

        public Auto()
        {
            CantidadDeRuedas = 4;
            TipoVehiculo = "Auto";
        }

        public void PrenderRadio()
        {
            if (!radioPrendida)
            {
                radioPrendida = true;
                System.Console.WriteLine("Radio prendida");
            }
            else
            {
                System.Console.WriteLine("La radio ya esta prendida");
            }

        }
    }
}
