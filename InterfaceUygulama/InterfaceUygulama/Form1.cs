using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sirali("Tomer", "Yokdil");
            Fernandao f = new Fernandao();
           MessageBox.Show(SutCek(f,20.15f,30));
            Alex a = new Alex();
            Gostermek(SutCek(a, 90.2f, 90), OyunKur(a));

            MessageBox.Show(SutCek(a, 90.2f, 90)+" "+ OyunKur(a));
       
            MessageBox.Show(CalimAt(a, 18));
            

        }
        public void Sirali(string D1, string D2)
        {

            MessageBox.Show(D1);
            MessageBox.Show(D2);


        }
        public void Gostermek(string D1,string D2)
        {
            string D3 = D1 +" "+ D2;
            MessageBox.Show(D3);
        }

        private string OyunKur(IOyunKurabilable kur)
        {
            return kur.OyunKur();
        }

        private string SutCek(ISutCekebilable sut,float hiz,float mesafe)
        {
            return sut.SutCek(hiz, mesafe);
        }
       
        private string CalimAt(IOyunKurabilable cal,float hiz)
        {
            return cal.CalimAt(hiz);
        }
    }
}
