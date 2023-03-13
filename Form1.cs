using System.Collections.Generic;
using System;
using Microsoft.VisualBasic.Devices;

namespace ejerciciopractico
{
    public partial class Form1 : Form
    {
        public Empleado[] obj = new Empleado[12];
        public int x = 0;
        public Form1()
        {
            for (int i = 0; i < 12; i++)
            {
                obj[i] = new Empleado();
            }
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addempleado(object sender, EventArgs e)
        {
            anuncio.Text = "Empleados agregados: " + (x+1); 
            anuncio.Refresh();
            string nomx = entrynom.Text;
            string ccx = entrycc.Text;
            
           
            if (string.IsNullOrEmpty(nomx) || string.IsNullOrEmpty(ccx)) {
                MessageBox.Show("ERROR. Alguno de los campos está vacio");
                return;
            }
            if (x < 11) {
                obj[x].nombre = nomx;
                obj[x].Id = ccx; 
                
            } else {
                obj[x].nombre = nomx;
                obj[x].Id = ccx;
                string strMensaje = null; 
                for (int i = 0; i<12 ;i++)
                {
                     strMensaje = strMensaje + "Empleado: " + obj[i].nombre + "\n\r" + "Cedula: " +  obj[i].Id + "\n\r";
                }  
                MessageBox.Show(strMensaje);
                return;
            }
            x++;

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}