using System;
using System.Collections.Generic;
using System.Text;

namespace TransporteUrbano
{
    class Bus : Vehiculo
    {
        private double tarifaPorKm;

        public Bus(string placa, int capacidad, double velocidad, double tarifa)
            : base(placa, capacidad, velocidad)
        {
            tarifaPorKm = tarifa;
        }

        public override double CalcularCostoViaje()
        {
            return kilometrosRecorridos * tarifaPorKm;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Bus Urbano");
            Console.WriteLine("Km recorridos: " + kilometrosRecorridos);
            Console.WriteLine("Costo total: " + CalcularCostoViaje());
            Console.WriteLine();
        }
    }
}
