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
    public partial class Panel_Docente : Form
    {
        public Panel_Docente()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Inicio();
            formulario.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Panel_Estudiante();
            formulario.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Planes_Mejora();
            formulario.Show();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Panel_Estudiante();
            formulario.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Inicio_Sesion();
            formulario.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Inicio_Sesion();
            formulario.Show();
        }
    }
}
