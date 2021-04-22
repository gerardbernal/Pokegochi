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



namespace Pokegochi
{
    public partial class Form1 : Form
    {

        Jugador j1 = new Jugador();
        int count = 0;

        public Form1()
        {
            InitializeComponent();
   

        }

        private void but_AñadirPokemon_Click(object sender, EventArgs e)
        {
            Pokemon pokemon = new Pokemon();
            GetPokemonNameAndTypeAsync("https://pokeapi.co/api/v2/pokemon/" + txt_addPokemon.Text, pokemon);
            GetPokemonIsLegendaryAsync("https://pokeapi.co/api/v2/pokemon-species/" + txt_addPokemon.Text, pokemon);

            j1.Pokedex.Add(pokemon);
            //ComprobarLegendario(pokemon);


        }

        async void GetPokemonNameAndTypeAsync(string url, Pokemon nuevoPokemon)
        {   
           
            
            string page = url;
            
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(page))
            using (HttpContent content = response.Content)
            {
                string result = await content.ReadAsStringAsync();
               
                nuevoPokemon.PokeDetails = PokemonDetails.FromJson(result);
                

            }
            nuevoPokemon.Nombre = nuevoPokemon.PokeDetails.Name;
            nuevoPokemon.Tipo = nuevoPokemon.PokeDetails.Types;

            if (j1.Pokedex[count].EsLegendario == false)
            {
                count++;
                listBoxPokedex.Items.Add(nuevoPokemon.Nombre + ", " + nuevoPokemon.Tipo[0].Type.Name);
                j1.CaramelosRaros++;
            }
            else
                j1.Pokedex.RemoveAt(count);



        }
        async void GetPokemonIsLegendaryAsync(string url, Pokemon nuevoPokemon)
        {
         
            string page = url;

            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(page))
            using (HttpContent content = response.Content)
            {
                string result = await content.ReadAsStringAsync();

                nuevoPokemon.PokeSpecies = PokemonSpecies.FromJson(result);
            }
            nuevoPokemon.EsLegendario = nuevoPokemon.PokeSpecies.IsLegendary;

            


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

        private void button1_Click(object sender, EventArgs e)
        {
            labelPokemon.Text = j1.Pokedex[listBoxPokedex.SelectedIndex].ToString();
        }
    }
}
