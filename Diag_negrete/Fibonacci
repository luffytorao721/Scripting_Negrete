using System;

class MiPrograma
{
    void MostrarPrimosFibonacci(int limite)
    {
        int primero = 0;
        int segundo = 1;
        int cuenta = 0;

        do
        {
            if (EsPrimo(primero))
            {
                Console.WriteLine(primero); // muestro si es primo
            }
            int siguiente = primero + segundo; // calculo el siguiente
            primero = segundo;
            segundo = siguiente;
            cuenta = cuenta + 1; // aumento la cuenta
        } while (cuenta < limite);
    }

    bool EsPrimo(int numero)
    {
        if (numero < 2) return false; // no es primo si es menor a 2
        for (int i = 2; i < numero; i++)
        {
            if (numero % i == 0) // si divide sin resto, no es primo
                return false;
        }
        return true;
    }

    void Empezar()
    {
        MiPrograma miCodigo = new MiPrograma();
        miCodigo.MostrarPrimosFibonacci(10); // hasta 10 términos
    }
}