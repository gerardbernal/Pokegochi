using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PokeAPI;


namespace Pokegochi
{
    public partial class Form1 : Form
    {

        Jugador j1 = new Jugador();
        public Form1()
        {
            InitializeComponent();
   

        }

        private void but_AñadirPokemon_Click(object sender, EventArgs e)
        {
            PokemonDetails pokeDetails = GetPokemonAsync("https://pokeapi.co/api/v2/pokemon/" + txt_addPokemon.Text).Result;
            Pokemon nuevoPokemon = new Pokemon();
            nuevoPokemon.Nombre = pokeDetails.Name;
            nuevoPokemon.Tipo = pokeDetails.Types;
            

            j1.AñadirPokemonALaPokedex(nuevoPokemon);
            


            //j1.Pokedex.Add(pokemon);
        }

        static async Task<PokemonDetails> GetPokemonAsync(string url)
        {
            
            string page =url;

            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(page))
            using (HttpContent content = response.Content)
            {
                string result = await content.ReadAsStringAsync();

                var p = PokemonDetails.FromJson(result);
                return p;

            }
          
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void but_Nombre_Click(object sender, EventArgs e)
        {
            j1.Nombre = txt_NombreJ.Text;
            label1.Text = j1.Nombre;
            txt_NombreJ.Clear();
        }
    }
}
