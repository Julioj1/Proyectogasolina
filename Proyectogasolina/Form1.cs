using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectogasolina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            int i;
            double precio = 293.6;
            double pmcarretera = 10.5;
            double pmciudad = 12.5;
            double galon = 3.78541;
            double paso = 1;
            double litro;
            double costoxkm;
            double kmxgalon;

            for (i = 0; i < 22; i++)
            {
                int n = gasolina.Rows.Add();
                gasolina.Rows[n].Cells[0].Value = 1;
                for (pmciudad = 12.5; pmciudad > pmcarretera; pmciudad = pmciudad - paso)
                {
                    gasolina.Rows[n].Cells[1].Value = pmciudad - paso;
                }
                kmxgalon = litro = 10 / galon;
                costoxkm = precio / kmxgalon;
                gasolina.Rows[n].Cells[2].Value = kmxgalon;
                gasolina.Rows[n].Cells[3].Value = costoxkm;
            }

        }
    }
}
