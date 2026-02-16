using System;
using System.Collections.Generic;
using System.Text;

namespace TransporteUrbano
{
    class Taxi : Vehiculo
    {
        private double tarifaBase;
        private double tarifaPorKm;

        public Taxi(string placa, int capacidad, double velocidad,
                    double baseTarifa, double tarifaKm)
            : base(placa, capacidad, velocidad)
        {
            tarifaBase = baseTarifa;
            tarifaPorKm = tarifaKm;
        }

        public override double CalcularCostoViaje()
        {
            return tarifaBase + (kilometrosRecorridos * tarifaPorKm);
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Taxi");
            Console.WriteLine("Km recorridos: " + kilometrosRecorridos);
            Console.WriteLine("Costo total: " + CalcularCostoViaje());
            Console.WriteLine();
        }
    }
}
