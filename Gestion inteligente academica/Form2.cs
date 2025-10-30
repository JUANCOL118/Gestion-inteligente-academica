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
    public partial class fm_Panel_Estudiante : Form
    {
        public fm_Panel_Estudiante()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new fm_Inicio();
            formulario.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new fm_Inicio();
            formulario.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new fm_Panel_Docente();
            formulario.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new fm_Planes_Mejora();
            formulario.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new fm_Inicio_Sesion();
            formulario.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
