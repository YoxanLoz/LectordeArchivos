using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OSFS_LectordeArchivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLeer_Click(object sender, EventArgs e)
        {

            string Ubicacion = "tamanos3.csv";
            StreamReader A = new StreamReader(Ubicacion);

            string linea;
            double total = 0;
            char Caracter = ',';
            int N;
            string output = "";
          
            A.ReadLine();
            while ((linea = A.ReadLine()) != null)
            {
                string[] fila = linea.Split(Caracter);
                string pro =  Convert.ToString(fila[0]);
                int bas = Convert.ToInt16(fila[1]);
                int mod = Convert.ToInt16(fila[2]);
                int bor = Convert.ToInt16(fila[3]);
                int and = Convert.ToInt16(fila[4]);
                int reu = Convert.ToInt16(fila[5]);

                N = and + mod;
                total = bas - bor + and + reu;
                string comentario = "OKAY";

                if (bor >= bas)
                {
                    N = 0;
                    total = 0;
                    comentario = "Datos incorrectos";

                }
                output += pro + " : " + N + " total " + total + " Comentarios : " + comentario + "\n";
                      
                    }
            imprimir.Text = output;

        }
    }
}
