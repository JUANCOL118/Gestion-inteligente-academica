using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_inteligente_academica
{
    public partial class fm_Inicio_Sesion : Form
    {
        public fm_Inicio_Sesion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new fm_Inicio();
            formulario.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new fm_Inicio();
            formulario.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new fm_Panel_Estudiante();
            formulario.Close();
        }

        private void fm_Inicio_Sesion_Load(object sender, EventArgs e)
        {

        }
    }
    
}
