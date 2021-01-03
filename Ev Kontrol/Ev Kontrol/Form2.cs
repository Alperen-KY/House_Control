using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Proje_Odev_AkilliEv_deneme_3
{
    public partial class Form2 : Form
    {
        SerialPort myPort;
        public Form2(SerialPort port)
        {
            InitializeComponent();
            myPort = port;
        }

        private void button9_Click(object sender, EventArgs e)      // 9
        {
            try 
            { 
                myPort.Write("T");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void button8_Click(object sender, EventArgs e)      // 8
        {
            try 
            { 
                myPort.Write("t");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void button7_Click(object sender, EventArgs e)      // 7
        {
            try 
            { 
                myPort.Write("S");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void button6_Click(object sender, EventArgs e)      // 6
        {
            try
            { 
                myPort.Write("s");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void button5_Click(object sender, EventArgs e)      // 5
        {
            try
            { 
                myPort.Write("R");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)      // 2
        {
            try
            { 
                myPort.Write("p");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)      // 3
        {
            try
            { 
                myPort.Write("P");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)      // 4
        {
            try 
            { 
            myPort.Write("r");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)      // 1
        {
            try 
            { 
                myPort.Write("O");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void button16_Click(object sender, EventArgs e)     // ONoff
        {
            try
            { 
                myPort.Write("o");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void button10_Click(object sender, EventArgs e)     // 0
        {
            try
            { 
                myPort.Write("u");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void button11_Click(object sender, EventArgs e)     // ok
        {
            try
            { 
                myPort.Write("U");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void button12_Click(object sender, EventArgs e)     // down
        {
            try
            { 
                myPort.Write("V");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void button13_Click(object sender, EventArgs e)     // up
        {
            try
            { 
                myPort.Write("v");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void button14_Click(object sender, EventArgs e)     // right
        {
            try
            { 
                myPort.Write("y");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void button15_Click(object sender, EventArgs e)     // left
        {
            try
            { 
                myPort.Write("Y");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void button17_Click(object sender, EventArgs e)     // mute
        {
            try
            { 
                myPort.Write("z");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void button18_Click(object sender, EventArgs e)     // volDOWN
        {
            try
            { 
                myPort.Write("x");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void button19_Click(object sender, EventArgs e)     // volUP
        {
            try 
            { 
                myPort.Write("Z");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void button20_Click(object sender, EventArgs e)     // chNext
        {
            try
            { 
                myPort.Write("X");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void button21_Click(object sender, EventArgs e)     // chPrevious
        {
            try
            { 
                myPort.Write("w");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }



        private void button22_Click(object sender, EventArgs e)     // options
        {
            try

            { 
                myPort.Write("W");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }


       

        private void button23_Click(object sender, EventArgs e)     // list
        {
            try
            { 
                myPort.Write("q");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                myPort.Write("Q");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }
    }
}
