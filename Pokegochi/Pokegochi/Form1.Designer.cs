
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
            this.but_AddPokemon = new System.Windows.Forms.Button();
            this.txt_addPokemon = new System.Windows.Forms.TextBox();
            this.txt_NombreJ = new System.Windows.Forms.TextBox();
            this.but_Nombre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPokedex = new System.Windows.Forms.ListBox();
            this.butConsultarEstadoPokemon = new System.Windows.Forms.Button();
            this.labelPokemon = new System.Windows.Forms.Label();
            this.butTransferirPokemon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelContadorCaramelos = new System.Windows.Forms.Label();
            this.but_ConseguirLegendario = new System.Windows.Forms.Button();
            this.butTransferirTodosPokemon = new System.Windows.Forms.Button();
            this.labelTextoLegendario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_AddPokemon
            // 
            this.but_AddPokemon.Location = new System.Drawing.Point(242, 64);
            this.but_AddPokemon.Name = "but_AddPokemon";
            this.but_AddPokemon.Size = new System.Drawing.Size(151, 28);
            this.but_AddPokemon.TabIndex = 0;
            this.but_AddPokemon.Text = "Añadir Pokemon";
            this.but_AddPokemon.UseVisualStyleBackColor = true;
            this.but_AddPokemon.Click += new System.EventHandler(this.but_AddPokemon_Click);
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
            this.txt_NombreJ.Location = new System.Drawing.Point(41, 37);
            this.txt_NombreJ.Name = "txt_NombreJ";
            this.txt_NombreJ.Size = new System.Drawing.Size(121, 23);
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
            // listBoxPokedex
            // 
            this.listBoxPokedex.FormattingEnabled = true;
            this.listBoxPokedex.ItemHeight = 15;
            this.listBoxPokedex.Location = new System.Drawing.Point(468, 37);
            this.listBoxPokedex.Name = "listBoxPokedex";
            this.listBoxPokedex.Size = new System.Drawing.Size(231, 244);
            this.listBoxPokedex.TabIndex = 5;
            // 
            // butConsultarEstadoPokemon
            // 
            this.butConsultarEstadoPokemon.Location = new System.Drawing.Point(48, 324);
            this.butConsultarEstadoPokemon.Name = "butConsultarEstadoPokemon";
            this.butConsultarEstadoPokemon.Size = new System.Drawing.Size(366, 30);
            this.butConsultarEstadoPokemon.TabIndex = 6;
            this.butConsultarEstadoPokemon.Text = "Como esta el pokemon?";
            this.butConsultarEstadoPokemon.UseVisualStyleBackColor = true;
            this.butConsultarEstadoPokemon.Click += new System.EventHandler(this.ConsultarEstadoPokemon_Click);
            // 
            // labelPokemon
            // 
            this.labelPokemon.AutoSize = true;
            this.labelPokemon.Location = new System.Drawing.Point(41, 201);
            this.labelPokemon.Name = "labelPokemon";
            this.labelPokemon.Size = new System.Drawing.Size(0, 15);
            this.labelPokemon.TabIndex = 7;
            // 
            // butTransferirPokemon
            // 
            this.butTransferirPokemon.Location = new System.Drawing.Point(468, 288);
            this.butTransferirPokemon.Name = "butTransferirPokemon";
            this.butTransferirPokemon.Size = new System.Drawing.Size(231, 30);
            this.butTransferirPokemon.TabIndex = 8;
            this.butTransferirPokemon.Text = "Transferir pokemon por 1 caramelo raro";
            this.butTransferirPokemon.UseVisualStyleBackColor = true;
            this.butTransferirPokemon.Click += new System.EventHandler(this.butTransferirPokemon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Caramelos Raros:";
            // 
            // labelContadorCaramelos
            // 
            this.labelContadorCaramelos.AutoSize = true;
            this.labelContadorCaramelos.Location = new System.Drawing.Point(145, 153);
            this.labelContadorCaramelos.Name = "labelContadorCaramelos";
            this.labelContadorCaramelos.Size = new System.Drawing.Size(0, 15);
            this.labelContadorCaramelos.TabIndex = 10;
            // 
            // but_ConseguirLegendario
            // 
            this.but_ConseguirLegendario.Location = new System.Drawing.Point(441, 360);
            this.but_ConseguirLegendario.Name = "but_ConseguirLegendario";
            this.but_ConseguirLegendario.Size = new System.Drawing.Size(292, 31);
            this.but_ConseguirLegendario.TabIndex = 11;
            this.but_ConseguirLegendario.Text = "Cambiar 20 caramelos por un Pokemon Legendario";
            this.but_ConseguirLegendario.UseVisualStyleBackColor = true;
            this.but_ConseguirLegendario.Click += new System.EventHandler(this.but_ConseguirLegendario_Click);
            // 
            // butTransferirTodosPokemon
            // 
            this.butTransferirTodosPokemon.Location = new System.Drawing.Point(468, 324);
            this.butTransferirTodosPokemon.Name = "butTransferirTodosPokemon";
            this.butTransferirTodosPokemon.Size = new System.Drawing.Size(231, 30);
            this.butTransferirTodosPokemon.TabIndex = 12;
            this.butTransferirTodosPokemon.Text = "Transferir todos los pokemon";
            this.butTransferirTodosPokemon.UseVisualStyleBackColor = true;
            this.butTransferirTodosPokemon.Click += new System.EventHandler(this.butTransferirTodosPokemon_Click);
            // 
            // labelTextoLegendario
            // 
            this.labelTextoLegendario.AutoSize = true;
            this.labelTextoLegendario.Location = new System.Drawing.Point(204, 95);
            this.labelTextoLegendario.Name = "labelTextoLegendario";
            this.labelTextoLegendario.Size = new System.Drawing.Size(240, 15);
            this.labelTextoLegendario.TabIndex = 14;
            this.labelTextoLegendario.Text = "Ahora puedes pedir un pokemon legendario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 452);
            this.Controls.Add(this.labelTextoLegendario);
            this.Controls.Add(this.butTransferirTodosPokemon);
            this.Controls.Add(this.but_ConseguirLegendario);
            this.Controls.Add(this.labelContadorCaramelos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butTransferirPokemon);
            this.Controls.Add(this.labelPokemon);
            this.Controls.Add(this.butConsultarEstadoPokemon);
            this.Controls.Add(this.listBoxPokedex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_Nombre);
            this.Controls.Add(this.txt_NombreJ);
            this.Controls.Add(this.txt_addPokemon);
            this.Controls.Add(this.but_AddPokemon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_AddPokemon;
        private System.Windows.Forms.TextBox txt_addPokemon;
        private System.Windows.Forms.TextBox txt_NombreJ;
        private System.Windows.Forms.Button but_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPokedex;
        private System.Windows.Forms.Button butConsultarEstadoPokemon;
        private System.Windows.Forms.Label labelPokemon;
        private System.Windows.Forms.Button butTransferirPokemon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelContadorCaramelos;
        private System.Windows.Forms.Button but_ConseguirLegendario;
        private System.Windows.Forms.Button butTransferirTodosPokemon;
        private System.Windows.Forms.Label labelTextoLegendario;
    }
}

