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

        string nombre;
        TypeElement[] tipo;
        bool esLegendario;
        EstadosDeSalud saludDelPokemon;

        public string Nombre { get => nombre; set => nombre = value; }
        
        public bool EsLegendario { get => esLegendario; set => esLegendario = value; }
        private EstadosDeSalud SaludDelPokemon { get => saludDelPokemon; set => saludDelPokemon = value; }
        public TypeElement[] Tipo { get => tipo; set => tipo = value; }

        public Pokemon()
        {
            Nombre = "";
            Tipo = null;
            esLegendario = false;
            SaludDelPokemon = EstadosDeSalud.Optimo;
        }
        public Pokemon(string _nombre, TypeElement[] _tipo, bool _Legendario, EstadosDeSalud _salud)
        {
            Nombre = _nombre;
            Tipo = _tipo;
            EsLegendario = _Legendario;
            saludDelPokemon = _salud;
        }
        public override string ToString()
        {
            return Nombre + " es de tipo " + (Tipo.Count() >1 ? Tipo[0] + " y " + Tipo[1] : Tipo[0]) + 
                " y su estado de salud es " + SaludDelPokemon;
        }
    }
}
