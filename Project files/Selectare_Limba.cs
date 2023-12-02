using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DerDeutschenNichtigkeiten
{
    public partial class Selectare_Limba : Form
    {
        public Selectare_Limba()
        {
            InitializeComponent();
        }
        int limba = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (limba == 1)
            {
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Hide();
            }
            else if (limba == 2)
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            limba = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            limba = 2;
        }

        private void Selectare_Limba_Load(object sender, EventArgs e)
        {

        }
    }
}
