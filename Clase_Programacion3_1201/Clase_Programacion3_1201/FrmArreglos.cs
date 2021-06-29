using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_Programacion3_1201
{
    public partial class FrmArreglos : Form
    {
        public FrmArreglos()
        {
            InitializeComponent();
        }

        private void btn_Ejecutar_Click(object sender, EventArgs e)
        {
            //Formas de decalrar arreglos tipo INT
            //int[] edades;
            int[] edades = new int[5];

            //Formas de llenar un arreglo
            edades[0] = 10;
            edades[1] = 20;
            edades[2] = 30;
            edades[3] = 40;
            edades[4] = 50;

            //Mostrar el arreglo
            for (int i = 0; i < edades.Length; i++)
            {
                listBox_Arreglo.Items.Add(edades[i]);
            }

            //Formas de decalrar arreglos tipo STRING
            string[] paises = new string[5] { "Honduras", "Nicaragua", "Costa Rica", "Guatemala", "El Salvador" };

            //for (int i = 0; i < paises.Length; i++)
            //{
            //    listBox_Paises.Items.Add((i+1)+")." + " " + paises[i]);
            //}

            foreach (var item in paises)
            {
                listBox_Paises.Items.Add(item);
            }

        }
    }
}
