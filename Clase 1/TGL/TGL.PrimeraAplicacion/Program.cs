using System;
using TGL.PrimeraAplicacion.Clases;

namespace TGL.PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Computador ComputadorJuanPablo = new Computador();
                //ComputadorJuanPablo.Pantalla = new Pantalla();
                ComputadorJuanPablo.Pantalla.Color = "Negro";
                ComputadorJuanPablo.Pantalla.Marca = "HP";
                ComputadorJuanPablo.Pantalla.Tamaño = 15;
                ComputadorJuanPablo.Cpu = new Cpu()
                {
                    Marca = "Intel",
                    Procesador = 3.20,
                    Ram = 16,
                    TieneGpu = true
                }; 
                Console.WriteLine("Juan Pablo tiene un computador con "
                    + ComputadorJuanPablo.Cpu.Procesador + " de PROCESADOR y "
                    + ComputadorJuanPablo.Cpu.Ram + " de RAM");
                Console.WriteLine("Juan pablo tiene un toro de PC ;)");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ups! ha ocurrido un error. Error:"+ ex.Message);
            }
            Console.ReadKey(); 
        }
    }
}
