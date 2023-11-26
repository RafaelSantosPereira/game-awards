using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Windows.Forms;
using projeto_final_M9_classes.Properties;

namespace projeto_final_M9_classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(795, 445);
        }

        List<info> lista = new List<info>();
        private void label1_Click(object sender, EventArgs e)
        {

        }
        int index = 0;
        int index2 = 0;
        int index3 = 0;

        

        private void btavancar_Click(object sender, EventArgs e)
        {
            index++;
            alterar();
        }

        private void btrecuar_Click(object sender, EventArgs e)
        {
            index--;
            alterar();
        }

        private void btvotar_Click(object sender, EventArgs e)
        {
            info dados = new info();
            bool validar = int.TryParse(txtidade.Text, out int n);
            if (txtnome.Text != "" && txtidade.Text != "" && txtnota.Text != "")
            {
                if (validar == true)
                {
                    if (n < 120)
                    {
                        dados.Nome = txtnome.Text;
                        dados.Idade = n;
                        dados.Nota = txtnota.Text;
                        lista.Add(dados);
                        dados.Bestgame = dados.calcular(index);
                        dados.Consola = dados.calcular2(index2);
                        dgv.Rows.Add(dados.Nome, dados.Idade, dados.Bestgame, dados.Nota, dados.Consola);
                    }
                    else
                        MessageBox.Show("idade invalida", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("insira apenas numeros inteiros na idade", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("preencha todos os campos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void alterar()
        {
            
            
            if (index == 1) pictureBox1.Image = Properties.Resources.god_of_war;
            else if (index == 2) pictureBox1.Image = Properties.Resources.red_dead;
            else if (index == 3) pictureBox1.Image = Properties.Resources.Horizon_Forbidden_West;
            else if (index == 4) pictureBox1.Image = Properties.Resources.call_of_duty;
            else if (index == 5) pictureBox1.Image = Properties.Resources.forza;
            else if (index == 6) pictureBox1.Image = Properties.Resources.halo_infinite_box_art;
            else if (index == 7) pictureBox1.Image = Properties.Resources.super_mario_odyssey_collage_i50045;
            else if (index == 8) pictureBox1.Image = Properties.Resources.Legend_of_Zelda_Breath_of_the_Wild_capa;
            else if (index == 9) pictureBox1.Image = Properties.Resources.mario_kart_8_deluxe_i50037;
            else if (index > 10) index = 0;
            if (index == 0) pictureBox1.Image = Properties.Resources.elden_ring_;
            else if (index < 0) index = 10;
            if (index == 10) pictureBox1.Image = Properties.Resources.CSGO;

            info data = new info();
            lbjogo.Text = data.calcular(index);
        }

        

        private void btvisualizar_Click_1(object sender, EventArgs e)
        {
           
            index3++;

            if (index3 % 2 != 0) this.Size = new Size(795, 635);
            else
                this.Size = new Size(795, 445);

        }
        private void alterar2()
        {
            
            if (index2 == 1) pictureBox2.Image = Properties.Resources.ps5_photo;
            else if (index2 > 2) index2 = 0;
            if (index2 == 0) pictureBox2.Image = Properties.Resources.xbox;
            else if (index2 < 0) index2 = 2;
            if (index2 == 2) pictureBox2.Image = Properties.Resources.NINTENDO_OLED;

            info data = new info();
            lbconsola.Text = data.calcular2(index2);

        }
        private void btavancar2_Click(object sender, EventArgs e)
        {
            index2++;
            alterar2();
        }

        private void btrecuar2_Click(object sender, EventArgs e)
        {
            index2--;
            alterar2();
        }

        
    }

}
