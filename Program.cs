using System;

class Program
{
    static void Main()
    {
        Carta carta = new Carta("As", "Picas", 1);
        carta.ImprimeCarta();

        Mazo mazo = new Mazo();

        Console.WriteLine("\nBaraja inicial:");
        mazo.ImprimirMazo();

        Jugador jugador = new Jugador("Nombre del Jugador");

        // Robar tres cartas
        jugador.Robar(mazo);
        jugador.Robar(mazo);
        jugador.Robar(mazo);

        Console.WriteLine("\nMano del jugador:");
        foreach (Carta cartaJugador in jugador.Mano)
        {
            cartaJugador.ImprimeCarta();
        }

        // Descartar una carta en el índice 1
        Carta cartaDescartada = jugador.Descartar(1);
        if (cartaDescartada != null)
        {
            Console.WriteLine("\nCarta descartada:");
            cartaDescartada.ImprimeCarta();
        }
        else
        {
            Console.WriteLine("\nÍndice no válido para descartar.");
        }

        // Imprimir la mano del jugador después de descartar
        Console.WriteLine("\nMano del jugador después de descartar:");
        foreach (Carta cartaJugador in jugador.Mano)
        {
            cartaJugador.ImprimeCarta();
        }
    }
}
