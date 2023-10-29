using System;
using System.Collections.Generic;
using System.Linq;

class Mazo
{
    public List<Carta> cartas;

    public Mazo()
    {
        cartas = new List<Carta>();
        InicializarMazo();
    }

    public Carta DarCartaMasAlta()
    {
        Carta cartaMasAlta = cartas.OrderByDescending(carta => carta.Val).First();
        cartas.Remove(cartaMasAlta);
        return cartaMasAlta;
    }

    public void ReiniciarMazo()
    {
        InicializarMazo();
    }

    public void Barajar()
    {
        Random random = new Random();
        cartas = cartas.OrderBy(carta => random.Next()).ToList();
    }

    public void ImprimirMazo()
    {
        foreach (var carta in cartas)
        {
            carta.ImprimeCarta();
        }
    }

    private void InicializarMazo()
    {
        cartas = new List<Carta>();
        string[] pintas = { "Tréboles", "Picas", "Corazones", "Diamantes" };
        for (int i = 0; i < 4; i++)
        {
            for (int j = 1; j <= 13; j++)
            {
                string nombre = AsignarNombre(j);
                Carta nuevaCarta = new Carta(nombre, pintas[i], j);
                cartas.Add(nuevaCarta);
            }
        }
    }

    private string AsignarNombre(int valor)
    {
        switch (valor)
        {
            case 1:
                return "As";
            case 11:
                return "J";
            case 12:
                return "Reina";
            case 13:
                return "Rey";
            default:
                return valor.ToString();
        }
    }
}
