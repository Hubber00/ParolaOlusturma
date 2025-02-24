using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParolaOlusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Empty;
            Random rnd = new Random();
            string kucukharfHavuz = "qwertyuıoppğüasdfghjklşizxcvbnmöç";
            string buyukharfHavuz = "QWERTYUIOPĞASDFGHJKLŞİÜZXCVBNMÖÇ";
            string buyukKucuk = "QWeRTyUıOpğASdFghjKlŞizXCvbNMö";
            string sayiHavuz = "0123456789";
            string harfsayiHavuz = "qwertyuıoppğüasdfghjklşizxcvbnmöç0123456789";
            string sifre = "";
            int uzunluk = Convert.ToInt32(textBox1.Text);

            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                MessageBox.Show("1 Adet Parola Türü seçmek zorundasınız");
            }
            else
            {
                if (radioButton1.Checked == true) 
                { sifre += sayiHavuz; }
                if (radioButton2.Checked == true && radioButton6.Checked == true)
                {
                    sifre += kucukharfHavuz;
                }
                if (radioButton2.Checked == true && radioButton5.Checked == true)
                {
                    sifre += buyukharfHavuz;
                }
                if (radioButton2.Checked == true && radioButton4.Checked == true)
                {
                    sifre += buyukKucuk;
                }
                if (radioButton3.Checked == true && radioButton6.Checked == true)
                {
                    sifre += sayiHavuz + kucukharfHavuz;
                }
                if (radioButton3.Checked == true && radioButton5.Checked == true)
                {
                    sifre += sayiHavuz + buyukharfHavuz;
                }
                if (radioButton3.Checked == true && radioButton4.Checked == true)
                {
                    sifre += sayiHavuz + buyukKucuk;
                }

                for (int i = 0; i < uzunluk; i++)
                {
                    textBox2.Text += sifre[rnd.Next(sifre.Length)];
                }
            }

            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            { groupBox2.Visible = true; }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            { groupBox2.Visible = true; }
        }
    }
}
