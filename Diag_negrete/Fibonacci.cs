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
                Console.WriteLine(primero);
            }
            int siguiente = primero + segundo;
            primero = segundo;
            segundo = siguiente;
            cuenta = cuenta + 1;
        } while (cuenta < limite);
    }

    bool EsPrimo(int numero)
    {
        if (numero < 2) return false;
        for (int i = 2; i < numero; i++)
        {
            if (numero % i == 0)
                return false;
        }
        return true;
    }

    static void Main()
    {
        MiPrograma miCodigo = new MiPrograma(); // ahora si debería de ejecutar con el static main
        miCodigo.MostrarPrimosFibonacci(10);
    }
}
