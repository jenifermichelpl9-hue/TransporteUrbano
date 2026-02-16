using System;
using TransporteUrbano;
//Primer commit ejercicio transporte urbano

class Program
{
    static void Main()
    {
        Console.WriteLine("Nombre: Jenifer Michel Padilla Lara");
        Console.WriteLine("Cuenta: 20241900042");
        Console.WriteLine();

        Bus bus = new Bus("BUS123", 40, 80, 2);
        Taxi taxi = new Taxi("TAX456", 4, 120, 20, 3);
        BicicletaElectrica bici = new BicicletaElectrica("BICI789", 1, 25, 1);

        // Viaje 1
        bus.RecorrerKilometros(10);
        taxi.RecorrerKilometros(10);
        bici.RecorrerKilometros(10);

        // Viaje 2
        bus.RecorrerKilometros(30);
        taxi.RecorrerKilometros(30);
        bici.RecorrerKilometros(30);

        bus.MostrarInformacion();
        taxi.MostrarInformacion();
        bici.MostrarInformacion();

        Console.ReadLine();
    }
}
