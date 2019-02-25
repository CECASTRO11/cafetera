using Practia.Cafe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practia.Cafe.Fapp
{
    public partial class Cafetera : Form
    {
        Cliente user = new Cliente();
        Cafetera1 cafetera = new Cafetera1();
        double coin = 0;
        double cambio = 0;
        

        public Cafetera()
        {
            InitializeComponent();
        }
        

        private void Cafetera_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label1.Visible = false;
            label2.Visible = false;

        }

        private void Coin_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label2.Visible = false;
            coin++;
            pictureBox1.Visible = true;
            label1.Text = coin.ToString();
            label1.Visible = true;
            
        }

        private void ECEspresso_Click(object sender, EventArgs e)
        {
            if (coin > 2) {
                cambio = coin - 2;
                label2.Text = cambio.ToString();
                pictureBox6.Visible = true;
                label2.Visible = true;
            }
            if (coin >= 2)
            {  
                pictureBox4.Visible = true;
                label1.Visible = false;
                pictureBox1.Visible = false;
                
                cambio = 0;
                coin = 0;
            
            }
            else
            {
                MessageBox.Show("Ingrese mas monedas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ECEspressosa_Click(object sender, EventArgs e)
        {
            if (coin > 2)
            {
                cambio = coin - 2;
                label2.Text = cambio.ToString();
                pictureBox6.Visible = true;
                label2.Visible = true;
            }
            if (coin >= 2)
            {
                pictureBox4.Visible = true;
                label1.Visible = false;
                pictureBox1.Visible = false;
                coin = 0;

            }
            else
            {
                MessageBox.Show("Ingrese mas monedas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ELatte_Click(object sender, EventArgs e)
        {
            if (coin > 2)
            {
                cambio = coin - 2;
                label2.Text = cambio.ToString();
                pictureBox6.Visible = true;
                label2.Visible = true;
            }
            if (coin >= 2)
            {
                    pictureBox5.Visible = true;
                label1.Visible = false;
                pictureBox1.Visible = false;
                coin = 0;

                }
                else
                {
                    MessageBox.Show("Ingrese mas monedas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void ELattesa_Click(object sender, EventArgs e)
        {
            if (coin > 2)
            {
                cambio = coin - 2;
                label2.Text = cambio.ToString();
                pictureBox6.Visible = true;
                label2.Visible = true;
            }
            if (coin >= 2)
            {
                pictureBox5.Visible = true;
                label1.Visible = false;
                pictureBox1.Visible = false;
                coin = 0;

            }
            else
            {
                MessageBox.Show("Ingrese mas monedas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (coin == 0)
            {
                MessageBox.Show("Ingrese monedas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else {
                cambio = coin;
                label1.Visible = false;
                pictureBox1.Visible = false;
                label2.Text = cambio.ToString();
                pictureBox6.Visible = true;
                label2.Visible = true;
                coin = 0;
                cambio = 0;
                     }
        }
    }
}
