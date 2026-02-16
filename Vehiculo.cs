using System;
using System.Collections.Generic;
using System.Text;

namespace TransporteUrbano
{
    abstract class Vehiculo
    {
        private string placa;
        private int capacidadPasajeros;
        private double velocidadMaxima;
        protected double kilometrosRecorridos;

        public Vehiculo(string placa, int capacidad, double velocidad)
        {
            this.placa = placa;
            capacidadPasajeros = capacidad;
            velocidadMaxima = velocidad;
            kilometrosRecorridos = 0;
        }

        public void RecorrerKilometros(double km)
        {
            kilometrosRecorridos += km;
        }

        public abstract double CalcularCostoViaje();
        public abstract void MostrarInformacion();
    }

}
