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

            //ordenarlos alfabeticamente
            //paises = paises.OrderBy(c => c).ToArray();
            //paises = paises.OrderByDescending(c => c).ToArray();

            //Mostrar el arreglo
            foreach (var item in paises)
            {
                listBox_Paises.Items.Add(item);
            }

        }

        private void btn_Ordenar_Click(object sender, EventArgs e)
        {
            //Ordenar el Arreglo
            int[] valores = { 3, 5, 1, 6, 9, 10, 15, 2 };

            //este metodo ordena los valores internamente
            //ordenar de menor a mayor
            //Array.Sort(valores);

            //ordenar de mayor a menor
            //Array.Reverse(valores);

            valores = valores.OrderByDescending(c => c).ToArray();

            foreach (var item in valores)
            {
                listBox_Ordenar.Items.Add(item);
            }



        }

        private void btn_MaxMin_Click(object sender, EventArgs e)
        {
            int[] valores = { 8,3, 5, 1, 6, 9, 4, 7, 2 };

            int maximo = valores[0];
            int minimo = valores[0];

            //primero lo ordenara y luego lo imprimirá
            Array.Sort(valores);

            foreach (var item in valores)
            {
                listBox_MaxMin.Items.Add(item);
            }

            //verificará cual es el valor menor y el mayor
            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] > maximo)
                {
                    maximo = valores[i];
                }
                if (valores[i] < minimo)
                {
                    minimo = valores[i];
                }
            }

            //otro forma de saber los valores minimos y maximos
            
            //Array.Sort(valores);
            //int maximo = valores[valores.Length - 1];
            //int minimo = valores[0];

            MessageBox.Show("valor Máximo: " + maximo + " / Valor Minimo: " + minimo);
        }

        
    }
}
