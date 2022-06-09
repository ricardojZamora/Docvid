using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docvid.GUI.Documentacion.algoritmo_de_documentacion
{
    public partial class paso6 : Form
    {
        public paso6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //paso8 a = new paso8();
            //a.ShowDialog();
            panelprincipalpasos a = new panelprincipalpasos();
            a.setpasosiguiente(8);
            a.panel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Paso_7 a = new Paso_7();
            //a.ShowDialog();
            panelprincipalpasos a = new panelprincipalpasos();
            a.setpasosiguiente(7);
            a.panel.Visible = false;
        }

        private void btnsi_Click(object sender, EventArgs e)
        {
            //Paso_7 a = new Paso_7();
            //a.ShowDialog();
            panelprincipalpasos a = new panelprincipalpasos();
            a.setpasosiguiente(7);
            a.panel.Visible = false;
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            //paso8 a = new paso8();
            //a.ShowDialog();
            panelprincipalpasos a = new panelprincipalpasos();
            a.setpasosiguiente(8);
            a.panel.Visible = false;
        }
    }
}
