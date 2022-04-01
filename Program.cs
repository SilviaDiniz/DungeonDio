using System;
using static System.Console;
using DungeonDio.src.Entities;

namespace DungeonDio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Knight arus = new Knight("Arus", 42, "Knight", 469, 749, 72, 72, "Espada", "Escudo");
            Ninja wedge = new Ninja("Wedge", 42, "Ninja", 292, 574, 89, 89, "Katana", "Nuvem de fumaça"); 
                    
            // nome, nível, tipo de herói, hp atual hp, mp atual, mp, arma de ataque, defesa, força da magia
            Wizard jenica = new Wizard("Jenica", 42, "White Wizard", 325, 601, 474, 482, "Feitiço", "Poção mágica", 7); 
            Wizard topapa = new Wizard("Topapa", 42, "Black Wizard", 106, 385, 611, 641, "Magia Negra", "Magia do Espelho", 9);

            WriteLine(arus);
            WriteLine(arus.myAttack());
            WriteLine(arus.myDefense());
            WriteLine("\n--------------------------- \n");

            WriteLine(wedge);
            WriteLine(wedge.myAttack());
            WriteLine(wedge.myDefense());
            WriteLine("\n--------------------------- \n");

            WriteLine(jenica);
            WriteLine(jenica.myAttack());
            WriteLine(jenica.myDefense());
            WriteLine("\n--------------------------- \n");

            WriteLine(topapa);
            WriteLine(topapa.myAttack());
            WriteLine(topapa.myDefense());
        }
    }
}
