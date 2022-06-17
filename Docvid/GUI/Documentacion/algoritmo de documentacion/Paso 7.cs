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
    public partial class Paso_7 : Form
    {
        public Paso_7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //paso9 n = new paso9();
            //n.ShowDialog();
            panelprincipalpasos a = new panelprincipalpasos();
            a.agregarpaso("Es no volatil los datos que se requieren del dispositivo");
            a.setpasosiguiente(9);
            a.panel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //paso10 a = new paso10();
            //a.ShowDialog();
            panelprincipalpasos a = new panelprincipalpasos();
            a.agregarpaso("Es volatil los datos que se requieren del dispositivo");

            a.setpasosiguiente(10);
            a.panel.Visible = false;
        }

        private void agregarcarpeta()
        {



        }
        private void btnagregarcarpeta_Click(object sender, EventArgs e)
        {
            panelprincipalpasos a = new panelprincipalpasos();
            a.agregarpaso("Se agregaron datos volatiles");
            String auxiliarruta;
            var resultado = fbd.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                //extraemos la direccion del archivo
                txtcarpeta.Text = fbd.SelectedPath;
                String auxiliar1 = fbd.SelectedPath;

                //conversion de \ a /
                auxiliar1 = auxiliar1.Replace(@"\", "/");

                // algoritmo de reemplazo de \ a /
                String auxiliar = txtcarpeta.Text.Replace(@"\", "/");

                txtcarpeta.Text = auxiliar1;
                auxiliarruta = auxiliar1;
                txtcarpeta.Text = auxiliar;

                // txtruta.Text = fbd.SelectedPath;
            }
        }
    }
}
