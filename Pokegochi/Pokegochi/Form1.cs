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

        private void but_AddPokemon_Click(object sender, EventArgs e)
        {
            Pokemon pokemon = new Pokemon();
            GetPokemonNameAndTypeAsyncYComprobarLegendario("https://pokeapi.co/api/v2/pokemon/" + txt_addPokemon.Text, pokemon);
            GetPokemonIsLegendaryAsync("https://pokeapi.co/api/v2/pokemon-species/" + txt_addPokemon.Text, pokemon);
            j1.Pokedex.Add(pokemon);
        }



        async void GetPokemonNameAndTypeAsyncYComprobarLegendario(string url, Pokemon nuevoPokemon)
        {
            string page = url;

            using HttpClient client = new HttpClient();
            using HttpResponseMessage response = await client.GetAsync(page);
            using HttpContent content = response.Content;

            string result = await content.ReadAsStringAsync();
            if (result != "Not Found")
            {

                nuevoPokemon.PokeDetails = PokemonDetails.FromJson(result);

                nuevoPokemon.Nombre = nuevoPokemon.PokeDetails.Name;
                nuevoPokemon.Tipo = nuevoPokemon.PokeDetails.Types;


                if (nuevoPokemon.EsLegendario == false)
                {
                    count++;
                    listBoxPokedex.Items.Add(nuevoPokemon.Nombre + ", " + nuevoPokemon.Tipo[0].Type.Name);

                }
                else
                    j1.Pokedex.RemoveAt(count);

                if (nuevoPokemon.EsLegendario == true && labelTextoLegendario.Visible == true)
                {
                    count++;
                    listBoxPokedex.Items.Add(nuevoPokemon.Nombre + ", " + nuevoPokemon.Tipo[0].Type.Name);
                    labelTextoLegendario.Visible = false;
                }
            }
        }
        async void GetPokemonIsLegendaryAsync(string url, Pokemon nuevoPokemon)
        {
            string page = url;

            using HttpClient client = new HttpClient();

            using HttpResponseMessage response = await client.GetAsync(page);
            using HttpContent content = response.Content;
            string result = await content.ReadAsStringAsync();

            if (result != "Not Found")
            { 

                nuevoPokemon.PokemonSpecies = PokemonSpecies.FromJson(result);

                nuevoPokemon.EsLegendario = nuevoPokemon.PokemonSpecies.IsLegendary;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labelTextoLegendario.ForeColor = System.Drawing.Color.Red;
            labelTextoLegendario.Visible = false;
        }

        private void but_Nombre_Click(object sender, EventArgs e)
        {
            j1.Nombre = txt_NombreJ.Text;
            label1.Text = j1.Nombre;
            txt_NombreJ.Clear();
        }

        private void butTransferirPokemon_Click(object sender, EventArgs e)
        {
            if (listBoxPokedex.SelectedIndex >= 0)
            {
                
                listBoxPokedex.Items.RemoveAt(listBoxPokedex.SelectedIndex);
                count--;
                j1.TransferirPokemon(count);
                actualizarLabelCaramelos();
            }


        }

        private void butTransferirTodosPokemon_Click(object sender, EventArgs e)
        {
            j1.CaramelosRaros += listBoxPokedex.Items.Count;
            actualizarLabelCaramelos();
            listBoxPokedex.Items.Clear();
            count = 0;
        }

        private void ConsultarEstadoPokemon_Click(object sender, EventArgs e)
        {
            if(listBoxPokedex.SelectedIndex >= 0)
                labelPokemon.Text = j1.Pokedex[listBoxPokedex.SelectedIndex].ToString();
        }

        private void but_ConseguirLegendario_Click(object sender, EventArgs e)
        {
            if (j1.CaramelosRaros > 20)
            {
                labelTextoLegendario.Visible = true;

                j1.CaramelosRaros -= 20;
                actualizarLabelCaramelos();
            }
        }


        void actualizarLabelCaramelos()
        {
            labelContadorCaramelos.Text = j1.CaramelosRaros.ToString();
        }


    }
}
