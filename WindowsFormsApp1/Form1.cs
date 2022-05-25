using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializarColumnatabla();
        }

        private void Calculos_Click(object sender, EventArgs e)
        {
            Deducciones();
        }
        public void InicializarColumnatabla()
        {
            DGVdeducciones.Columns.Add("Sueldo Bruto", "Sueldo Bruto");
            DGVdeducciones.Columns.Add("SFS", "SFS");
            DGVdeducciones.Columns.Add("AFP", "AFP");
            DGVdeducciones.Columns.Add("ISR", "ISR");
            DGVdeducciones.Columns.Add("Sueldo Neto", "Sueldo Neto");
        }
        public void Deducciones()
        {
            double SB = Convert.ToDouble(SueldoBruto.Text);
            double SN, SFS, AFP, ISR;


            SFS = SB * (0.0304);
            AFP = SB * 0.0287;

            if (SB <= 34685)
            {
                ISR = 0;
                SN = SB - SFS - AFP - ISR;
                DGVdeducciones.Rows.Add("RD$" + SB, "RD$" + SFS, "RD$" + AFP, "RD$" + ISR, "RD$" + SN);
            }
            else
            {
                if (SB > 34685 && SB < 52027)
                {
                    ISR = (SB - 34685) * 0.15;
                    SN = SB - SFS - AFP - ISR;
                    DGVdeducciones.Rows.Add("RD$" + SB, "RD$" + SFS, "RD$" + AFP, "RD$" + ISR, "RD$" + SN);
                }
                else
                {
                    if (SB > 52027 && SB < 72260)
                    {
                        ISR = ((SB - 52027) * 0.20 + 2601);
                        SN = SB - SFS - AFP - ISR;
                        DGVdeducciones.Rows.Add("RD$" + SB, "RD$" + SFS, "RD$" + AFP, "RD$" + ISR, "RD$" + SN);
                    }
                    else
                    {
                        if (SB > 72260)
                        {
                            ISR = ((SB - 72260) * 0.25 + 6648);
                            SN = SB - SFS - AFP - ISR;
                            DGVdeducciones.Rows.Add("RD$" + SB, "RD$" + SFS, "RD$" + AFP, "RD$" + ISR, "RD$" + SN);
                        }
                    }
                }
            }

        }
    }

}