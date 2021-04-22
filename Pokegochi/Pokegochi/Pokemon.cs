using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokegochi
{
    class Pokemon
    {
        public enum EstadosDeSalud
        {
            Optimo,
            Mejorable,
            Neutral,
            Mal,
            Pesimo
        }

        PokemonDetails pokeDetails;
        PokemonSpecies pokeSpecies;

        string nombre;
        TypeElement[] tipo;
        bool esLegendario;
        EstadosDeSalud saludDelPokemon;

        public string Nombre { get => nombre; set => nombre = value; }
        
        public bool EsLegendario { get => esLegendario; set => esLegendario = value; }
        private EstadosDeSalud SaludDelPokemon { get => saludDelPokemon; set => saludDelPokemon = value; }
        public TypeElement[] Tipo { get => tipo; set => tipo = value; }
        public PokemonDetails PokeDetails { get => pokeDetails; set => pokeDetails = value; }
        public PokemonSpecies PokeSpecies { get => pokeSpecies; set => pokeSpecies = value; }

        public Pokemon()
        {
            Nombre = "";
            Tipo = null;
            esLegendario = false;
            SaludDelPokemon = EstadosDeSalud.Optimo;
        }
        public Pokemon(string _nombre, TypeElement[] _tipo, bool _esLegendario)
        {
            Nombre = _nombre;
            Tipo = _tipo;
            EsLegendario = _esLegendario;
            SaludDelPokemon = EstadosDeSalud.Optimo;
        }
        public override string ToString()
        {
            
            return Nombre + " es de tipo " + (Tipo.Count() > 1 ? Tipo[0].Type.Name + " y " + Tipo[1].Type.Name : Tipo[0].Type.Name) + 
                " y su estado de salud es " + SaludDelPokemon;
        }
    }
}
