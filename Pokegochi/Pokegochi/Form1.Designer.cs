
namespace Pokegochi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.but_AñadirPokemon = new System.Windows.Forms.Button();
            this.txt_addPokemon = new System.Windows.Forms.TextBox();
            this.txt_NombreJ = new System.Windows.Forms.TextBox();
            this.but_Nombre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PokemonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PokemonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // but_AñadirPokemon
            // 
            this.but_AñadirPokemon.Location = new System.Drawing.Point(271, 64);
            this.but_AñadirPokemon.Name = "but_AñadirPokemon";
            this.but_AñadirPokemon.Size = new System.Drawing.Size(122, 28);
            this.but_AñadirPokemon.TabIndex = 0;
            this.but_AñadirPokemon.Text = "Añadir Pokemon";
            this.but_AñadirPokemon.UseVisualStyleBackColor = true;
            this.but_AñadirPokemon.Click += new System.EventHandler(this.but_AñadirPokemon_Click);
            // 
            // txt_addPokemon
            // 
            this.txt_addPokemon.Location = new System.Drawing.Point(242, 35);
            this.txt_addPokemon.Name = "txt_addPokemon";
            this.txt_addPokemon.Size = new System.Drawing.Size(150, 23);
            this.txt_addPokemon.TabIndex = 1;
            // 
            // txt_NombreJ
            // 
            this.txt_NombreJ.Location = new System.Drawing.Point(12, 37);
            this.txt_NombreJ.Name = "txt_NombreJ";
            this.txt_NombreJ.Size = new System.Drawing.Size(150, 23);
            this.txt_NombreJ.TabIndex = 2;
            // 
            // but_Nombre
            // 
            this.but_Nombre.Location = new System.Drawing.Point(41, 66);
            this.but_Nombre.Name = "but_Nombre";
            this.but_Nombre.Size = new System.Drawing.Size(121, 26);
            this.but_Nombre.TabIndex = 3;
            this.but_Nombre.Text = "Entrar Nombre";
            this.but_Nombre.UseVisualStyleBackColor = true;
            this.but_Nombre.Click += new System.EventHandler(this.but_Nombre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre del Jugador";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_Nombre);
            this.Controls.Add(this.txt_NombreJ);
            this.Controls.Add(this.txt_addPokemon);
            this.Controls.Add(this.but_AñadirPokemon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PokemonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_AñadirPokemon;
        private System.Windows.Forms.TextBox txt_addPokemon;
        private System.Windows.Forms.TextBox txt_NombreJ;
        private System.Windows.Forms.Button but_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource PokemonBindingSource;
    }
}

