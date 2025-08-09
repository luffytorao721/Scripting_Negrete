using System;

class ProgramaSorteo
{
    static void Main()
    {
        int numeroApostado = 1234; // Genérico apostó a este número
        int montoApostado = 1000;  // Genérico apostó $1000

        Console.Write("Ingresa el número ganador del sorteo (4 dígitos): ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int numeroGanador) || input.Length != 4) // para que no sean más de 4
        {
            Console.WriteLine("Número inválido. Debe tener exactamente 4 dígitos.");
            return;
        }

        int premio = CalcularPremio(numeroApostado, numeroGanador, montoApostado);

        if (premio > 0)
        {
            Console.WriteLine("¡Felicidades! Ganaste $" + premio);
        }
        else
        {
            Console.WriteLine("Lo siento, no ganaste ningún premio.");
        }
    }

    static int CalcularPremio(int numeroApostado, int numeroGanador, int montoApostado)
    {
        string apostado = numeroApostado.ToString("D4"); // Siempre 4 cifras
        string ganador = numeroGanador.ToString("D4");

        if (apostado == ganador)
        {
            return 4500 * montoApostado;
        }
        else if (TienenMismasCifras(apostado, ganador))
        {
            return 200 * montoApostado;
        }
        else if (apostado.Substring(1) == ganador.Substring(1))
        {
            return 400 * montoApostado;
        }
        else if (apostado.Substring(2) == ganador.Substring(2))
        {
            return 50 * montoApostado;
        }
        else if (apostado.Substring(3) == ganador.Substring(3))
        {
            return 5 * montoApostado;
        }
        else
        {
            return 0;
        }
    }

    static bool TienenMismasCifras(string a, string b)
    {
        char[] arrA = a.ToCharArray();
        char[] arrB = b.ToCharArray();
        Array.Sort(arrA);
        Array.Sort(arrB);
        return new string(arrA) == new string(arrB);
    }
}
