using System;

class Carta
{
    public string Nombre { get; }
    public string Pinta { get; }
    public int Val { get; }

    public Carta(string nombre, string pinta, int val)
    {
        Nombre = nombre;
        Pinta = pinta;
        Val = val;
    }

    public void ImprimeCarta()
    {
        Console.WriteLine($"Nombre: {Nombre}, Pinta: {Pinta}, Valor: {Val}");
    }
}
