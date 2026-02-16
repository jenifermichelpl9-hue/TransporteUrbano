using System;
using System.Collections.Generic;
using System.Text;

namespace TransporteUrbano
{
    class BicicletaElectrica : Vehiculo
    {
        private double costoEnergiaPorKm;

        public BicicletaElectrica(string placa, int capacidad,
                                  double velocidad, double costoEnergia)
            : base(placa, capacidad, velocidad)
        {
            costoEnergiaPorKm = costoEnergia;
        }

        public override double CalcularCostoViaje()
        {
            return kilometrosRecorridos * costoEnergiaPorKm;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Bicicleta Eléctrica");
            Console.WriteLine("Km recorridos: " + kilometrosRecorridos);
            Console.WriteLine("Costo total: " + CalcularCostoViaje());
            Console.WriteLine();
        }
    }
}
