using System;

class MiPrograma
{
    string FormatearTiempo(int segundos)
    {
        int horas = segundos / 3600; // saco las horas
        int resto = segundos % 3600; // saco el resto
        int minutos = resto / 60; // saco los minutos
        int segs = resto % 60; // saco los segundos
        return horas + ":" + minutos + ":" + segs; // junto todo
    }

    void Empezar()
    {
        MiPrograma miCodigo = new MiPrograma();
        Console.WriteLine(miCodigo.FormatearTiempo(3661)); // muestro el tiempo
    }
}