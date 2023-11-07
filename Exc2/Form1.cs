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

namespace Exc2
{
    public partial class Form1 : Form
    {
        string caminho = @"C:\Users\hp\Documents\Joelson Botelho\Exc2\Exc2.txt";
        string[] Unidade = new string[10] { " ", "I", "II", "III", "IV", "V", "VI", "VII", "VIII","IX" };
        string[] Dezena = new string[10] { " ", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] Centena = new string[100] { " ", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM", " ", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM", " ", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM", " ", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM", " ", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM", " ", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM", " ", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM", " ", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM", " ", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM", " ", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"};
        string[] Milesimo = new string[10] { " ", "M", "MM", "MMM", "IV_", "V_", "VI_", "VII_", "VIII_", "IX_" };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRomana_Click(object sender, EventArgs e)
        {
            try
            {
                int Numero = int.Parse(txtNum.Text);
                int unidade = Numero % 10;
                int dezena = (Numero / 10) % 10;
                int centena = (Numero / 100);
                int milesimo = (Numero / 1000);
                if (Numero >= 10000)
                {
                    MessageBox.Show("Digite um Número no Intervalo de 1 à 9999");
                }
                else
                {
                    if (Numero >= 1000)
                    {
                        txtNumRomana.Text = Milesimo[milesimo] + Centena[centena] + Dezena[dezena] + Unidade[unidade];
                        txtNumRomana.Text = txtNumRomana.Text.Replace(" ", "");
                    }
                    else
                    {
                        if (Numero >= 100)
                        {
                            txtNumRomana.Text = Centena[centena] + Dezena[dezena] + Unidade[unidade];
                        }
                        else
                        {
                            if (Numero >= 10)
                            {
                                txtNumRomana.Text = Dezena[dezena] + Unidade[unidade];
                            }
                            else
                            {
                                if (Numero < 0)
                                {
                                    MessageBox.Show("Digite Um Número Positivo");
                                }
                                else
                                {
                                    txtNumRomana.Text = Unidade[unidade];
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um Número");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Tem A Certeza Que Deseja Sair ??","Sair",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            Application.Exit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Tudo = txtNum.Text + " = " + txtNumRomana.Text;
            List<string> doc = new List<string>();
            if (File.Exists(caminho))
            {
                StreamReader rd = new StreamReader(caminho);
                while (!rd.EndOfStream)
                {
                    doc.Add(rd.ReadLine());
                }
                rd.Close();
                foreach (string item in doc)
                {
                    if (item == Tudo)
                    {
                        MessageBox.Show("Este Dado já foi Gravado");
                        return;
                    }
                }
                StreamWriter wr = new StreamWriter(caminho, true);
                wr.WriteLine(Tudo);
                wr.Close();
            }
            else
            {
                MessageBox.Show("Crie um Ficheiro Com o Nome Exc2 e Formato .txt");
            }
        }
    }
}