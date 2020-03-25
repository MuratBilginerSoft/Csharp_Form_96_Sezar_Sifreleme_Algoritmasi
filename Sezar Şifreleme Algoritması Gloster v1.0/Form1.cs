using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sezar_Şifreleme_Algoritması_Gloster_v1._0
{
    public partial class Form1 : Form
    {
        #region Değişkenler

        private int Anahtar;

        private int Anahtar2 = 0;

        private string Cümle;

        private string ŞifreliCümle="";

        #endregion

        #region Tanımlamalar

        private string Alfabe = "ABCÇDEFGHIİJKLMNOÖPRSŞTUÜVYZ ".ToLower();

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void PicŞifrele_Click(object sender, EventArgs e)
        {
            Cümle = richTextBox1.Text.ToLower();
            Anahtar = int.Parse(TextAnahtar.Text);
            ŞifreliCümle = "";

            foreach (char Harf in Cümle)
            {
                Anahtar2 = 0;

                foreach (char Harf2 in Alfabe)
                {
                    if (Harf==Harf2)
                    {
                        break;
                    }

                    Anahtar2++;
                }

                Anahtar = Anahtar + Anahtar2;

                Anahtar = Anahtar % 29;

                ŞifreliCümle += Alfabe[Anahtar];
            }

            richTextBox2.Text = ŞifreliCümle;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
