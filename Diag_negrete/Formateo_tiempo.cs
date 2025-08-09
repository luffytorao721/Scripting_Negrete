using System;

class MiPrograma
{
    string FormatearTiempo(int segundos)
    {
        int horas = segundos / 3600;
        int resto = segundos % 3600;
        int minutos = resto / 60;
        int segs = resto % 60;
        return horas.ToString("D2") + ":" + minutos.ToString("D2") + ":" + segs.ToString("D2");
    }

    static void Main()
    {
        MiPrograma miCodigo = new MiPrograma();
        Console.WriteLine("Ingresa los segundos: ");
        string input = Console.ReadLine();
        int segundos = int.Parse(input); // Hace que sea parametrizable
        Console.WriteLine(miCodigo.FormatearTiempo(segundos));
    }
}
