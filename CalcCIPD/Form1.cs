using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcCIPD
{
    public partial class Form1 : Form
    {
        #region Campuri
        double sumaTotala;
        double sumaProgram;
        double sumaMembership;
        double procent;
        double sumaDiscount;

        #endregion
        public Form1()
        {
            InitializeComponent();
        }
        private void btSumaTotalFaraTVA_Click(object sender, EventArgs e)
        {
            bool total = double.TryParse(tbProgramEuroFaraTVA.Text, out sumaProgram);
            bool membership = double.TryParse(tbMembershipEuroFaraTVA.Text, out sumaMembership);
            sumaTotala = sumaProgram + sumaMembership;
            lbCostTotal.Text = sumaTotala.ToString() + " Euro + TVA";
        }
        private void btSumaCuDiscount_Click(object sender, EventArgs e)
        {
            bool discount = double.TryParse(tbProcentDiscount.Text, out procent);
            sumaDiscount = sumaProgram - (procent / 100.0) * sumaProgram;
            lbCostTotalCuDiscount.Text = sumaDiscount.ToString() + " Euro + TVA";
        }
        private static string SistemRate(double nrRate, double sumProg, double sumMemb, double avans)
        {
            var total = sumProg + sumMemb;
            var sumAvans = total * (avans / 100);
            var restSum = total - sumAvans;
            var sumRata = restSum / nrRate;
           string label = "Avans inițial de " + avans + " %, în valoare de: " + sumAvans + " Euro + TVA." +
                Environment.NewLine + nrRate + " rate a câte " + +sumRata + "Euro + TVA/fiecare.";
            return label;
        }

        private void btCalculRate_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Dorești să incluzi discount-ul?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (message == DialogResult.Yes)//calcul rate cu discount adaugat
            {
                lbCalculRate.Text = "Cu discount:" + Environment.NewLine;
                if (cb4Rate.Checked == true)
                {
                     lbCalculRate.Text += SistemRate(4, sumaDiscount, sumaMembership, 25);

                }
                if (cb5Rate.Checked == true)
                {
                    lbCalculRate.Text += SistemRate(5, sumaDiscount, sumaMembership, 25);
                }
                if (cb6Rate.Checked == true)
                {
                    lbCalculRate.Text += SistemRate(6, sumaDiscount, sumaMembership, 25);
                }
                if (cb7Rate.Checked == true)
                {
                    lbCalculRate.Text += SistemRate(7, sumaDiscount, sumaMembership, 25);
                }
            }
            if(message == DialogResult.No)//calcul rate fara discount adaugat
            {
                lbCalculRate.Text = "Fără discount:" + Environment.NewLine;
                if (cb4Rate.Checked == true)
                {
                    lbCalculRate.Text += SistemRate(4, sumaProgram, sumaMembership, 25);
                }
                if (cb5Rate.Checked == true)
                {
                    lbCalculRate.Text += SistemRate(5, sumaProgram, sumaMembership, 25);
                }
                if (cb6Rate.Checked == true)
                {
                    lbCalculRate.Text += SistemRate(6, sumaProgram, sumaMembership, 25);
                }
                if (cb7Rate.Checked == true)
                {
                    lbCalculRate.Text += SistemRate(7, sumaProgram, sumaMembership, 25);
                }
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tbMembershipEuroFaraTVA.Text = "0";
            tbProcentDiscount.Text = "0";
            tbProgramEuroFaraTVA.Text = "0";
            lbCostTotal.Text = "În așteptare...";
            lbCostTotalCuDiscount.Text = "În așteptare...";
            lbCalculRate.Text = "În așteptare...";
            cb4Rate.Checked = false;
            cb5Rate.Checked = false;
            cb6Rate.Checked = false;
            cb7Rate.Checked = false;
        }
    }
}
