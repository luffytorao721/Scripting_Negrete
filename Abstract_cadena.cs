using System;

// Clase abstracta base
abstract class AbstractSample
{
    private string message;

    public abstract void PrintMessage(string input);

    public virtual void InvertMessage(string input)
    {
        message = input;
        char[] chars = message.ToCharArray();
        Array.Reverse(chars);
        message = new string(chars);
        Console.WriteLine("Mensaje invertido: " + message);
    }

    protected string GetMessage()
    {
        return message;
    }

    protected void SetMessage(string value)
    {
        message = value;
    }
}

// Subclase que imprime el mensaje tal cual
class ClaseNormal : AbstractSample
{
    public override void PrintMessage(string input)
    {
        SetMessage(input);
        Console.WriteLine("Mensaje: " + GetMessage());
    }
}

// Subclase que imprime el mensaje con mayúsculas/minúsculas invertidas
class ClaseInvertida : AbstractSample
{
    public override void PrintMessage(string input)
    {
        SetMessage(input);
        string cambiado = CambiarMayusMinus(GetMessage());
        Console.WriteLine("Mensaje con mayúsculas/minúsculas invertidas: " + cambiado);
    }

    public override void InvertMessage(string input)
    {
        SetMessage(input);
        char[] chars = GetMessage().ToCharArray();
        Array.Reverse(chars);
        string invertido = new string(chars);
        string cambiado = CambiarMayusMinus(invertido);
        SetMessage(cambiado);
        Console.WriteLine("Mensaje invertido y con mayúsculas/minúsculas cambiadas: " + GetMessage());
    }

    private string CambiarMayusMinus(string texto)
    {
        string resultado = "";
        foreach (char c in texto)
        {
            if (char.IsUpper(c))
                resultado += char.ToLower(c);
            else if (char.IsLower(c))
                resultado += char.ToUpper(c);
            else
                resultado += c;
        }
        return resultado;
    }
}

// Clase que gestiona el uso de ambas subclases
class MessageManager
{
    public void Ejecutar(string mensaje)
    {
        AbstractSample obj1 = new ClaseNormal();
        AbstractSample obj2 = new ClaseInvertida();

        Console.WriteLine("\n[ClaseNormal]");
        obj1.PrintMessage(mensaje);
        obj1.InvertMessage(mensaje);

        Console.WriteLine("\n[ClaseInvertida]");
        obj2.PrintMessage(mensaje);
        obj2.InvertMessage(mensaje);
    }
}

// Programa principal
class Program
{
    static void Main()
    {
        Console.Write("Ingresa un mensaje: ");
        string mensajeUsuario = Console.ReadLine();

        MessageManager manager = new MessageManager();
        manager.Ejecutar(mensajeUsuario);
    }
}
