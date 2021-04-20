using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokegochi
{
    class Jugador
    {
        string nombre;
        List<Pokemon> pokedex;
        int caramelosRaros;

        public string Nombre { get => nombre; set => nombre = value; }
        public int CaramelosRaros { get => caramelosRaros; set => caramelosRaros = value; }
        internal List<Pokemon> Pokedex { get => pokedex; set => pokedex = value; }

        public Jugador()
        {
            nombre = "";
            Pokedex = new List<Pokemon>();
            caramelosRaros = 0;
        }
        public void AñadirPokemonALaPokedex(Pokemon pokemon)
        {
            Pokedex.Add(pokemon);
        }
        public string ConsutlarEstadoDelPokemon(Pokemon pokemon)
        {
            return pokemon.ToString();
        }
        public void TransferirPokemon(Pokemon pokemon)
        {
            Pokedex.Remove(pokemon);
            caramelosRaros++;
        }
    }
}
