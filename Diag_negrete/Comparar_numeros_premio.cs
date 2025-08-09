using System;

class MiPrograma
{
    void ComprobarNumero(int miNumero, int numeroSorteo)
    {
        if (miNumero == numeroSorteo)
        {
            Console.WriteLine("¡Ganó! El número " + miNumero + " coincide con el sorteo");
            Console.WriteLine("Premio: $1000");
        }
        else
        {
            Console.WriteLine("Perdió El número " + miNumero + " no coincide con " + numeroSorteo + ".");
            Console.WriteLine("No hay premio.");
        }
    }

    static void Main()
    {
        MiPrograma miJuego = new MiPrograma();
        int miApuesta = 1234; // Número de 4 dígitos que eligió Genérico
        Console.WriteLine("por favor ingresa el número ganador de 4 dígitos del sorteo de hoy viernes: ");
        string input = Console.ReadLine();
        int numeroGanador = int.Parse(input); //qe ingrese el resultado
        miJuego.ComprobarNumero(miApuesta, numeroGanador);
    }
}
