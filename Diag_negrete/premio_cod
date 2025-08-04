using System;

class MiPrograma
{
    int CalcularPremio(int miNumero, int numeroGanador)
    {
        int premio = 0; // empiezo sin premio
        if (miNumero == numeroGanador) // si acierto
        {
            premio = 500; // gano 500
        }
        else if (miNumero == numeroGanador + 1 || miNumero == numeroGanador - 1) // cerca por 1
        {
            premio = 300; // gano 300
        }
        else if (miNumero >= numeroGanador - 2 && miNumero <= numeroGanador + 2) // cerca por 2
        {
            premio = 200; // gano 200
        }
        else if (miNumero >= numeroGanador - 5 && miNumero <= numeroGanador + 5) // cerca por 5
        {
            premio = 50; // gano 50
        }
        else
        {
            premio = 0; // no gano nada
        }
        return premio; // devuelvo el premio
    }

    void Empezar()
    {
        MiPrograma miJuego = new MiPrograma();
        int miApuesta = 6; // mi número
        int numGanador = 5; // número ganador
        int miGanancia = miJuego.CalcularPremio(miApuesta, numGanador);
        Console.WriteLine("Mi premio es: " + miGanancia); // muestro el resultado
    }
}