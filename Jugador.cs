using System;
using System.Collections.Generic;

class Jugador
{
    public string Nombre { get; }
    public List<Carta> Mano { get; }

    public Jugador(string nombre)
    {
        Nombre = nombre;
        Mano = new List<Carta>();
    }

    public Carta? Robar(Mazo mazo)
    {
        if (mazo.cartas.Count > 0)
        {
            Carta cartaRobada = mazo.DarCartaMasAlta();
            Mano.Add(cartaRobada);
            return cartaRobada;
        }

        return null; // Devolver null si no hay cartas en el mazo
    }

    public Carta? Descartar(int indice)
    {
        if (indice >= 0 && indice < Mano.Count)
        {
            Carta cartaDescartada = Mano[indice];
            Mano.RemoveAt(indice);
            return cartaDescartada;
        }
        return null;
    }
}
