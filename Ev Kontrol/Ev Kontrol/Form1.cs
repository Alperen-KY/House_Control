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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        int[] btn_drm = new int[20];
        int saat, dakika, saniye = 0;
                

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Maximum = 390;
            trackBar1.Minimum = 1;

            comboBox1.ResetText();

            string[] ports = SerialPort.GetPortNames();
            
            foreach(string port in ports)
            {
                comboBox1.Items.Add(port);
            }
        }


        private void label12_Click(object sender, EventArgs e)
        {

        }


        private void button12_Click(object sender, EventArgs e)     // Klima ON OFF
        {
            try
            {
                if (btn_drm[12] == 0)
                {
                    btn_drm[12] = 1;
                    serialPort1.Write("n");
                    textBox1.Text = "ON";
                }

                else if (btn_drm[12] == 1)
                {
                    btn_drm[12] = 0;
                    serialPort1.Write("n");
                    textBox1.Text = "OFF";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)          // SALON 
        {
            try { 
            if(btn_drm[1] == 0)
            {
                btn_drm[1] = 1;
                button1.ImageIndex = 6;

                serialPort1.Write("a");
               

            }

            else if(btn_drm[1] == 1)
            {
                btn_drm[1] = 0;
                button1.ImageIndex = 5;

                serialPort1.Write("a");
             
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
                button1.ImageIndex = 5;
            }
        }

        private void button8_Click(object sender, EventArgs e)      // Tuvalet
        {
            try
            {
                if (btn_drm[8] == 0)
                {
                    btn_drm[8] = 1;
                    button8.ImageIndex = 6;

                    serialPort1.Write("b");

                }

                else if (btn_drm[8] == 1)
                {
                    btn_drm[8] = 0;
                    button8.ImageIndex = 5;

                    serialPort1.Write("b");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
                button8.ImageIndex = 5;
            }
        }

        private void button2_Click(object sender, EventArgs e)      // Yatak Odası
        {
            try
            {
                if (btn_drm[2] == 0)
                {
                    btn_drm[2] = 1;
                    button2.ImageIndex = 6;

                    serialPort1.Write("c");

                }

                else if (btn_drm[2] == 1)
                {
                    btn_drm[2] = 0;
                    button2.ImageIndex = 5;

                    serialPort1.Write("c");
                }            
            }
            catch(Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
                button2.ImageIndex = 5;
            }
        }

        private void button9_Click(object sender, EventArgs e)      // Banyo
        {
            try
            {
                if (btn_drm[9] == 0)
                {
                    btn_drm[9] = 1;
                    button9.ImageIndex = 6;

                    serialPort1.Write("d");

                }

                else if (btn_drm[9] == 1)
                {
                    btn_drm[9] = 0;
                    button9.ImageIndex = 5;

                    serialPort1.Write("d");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
                button9.ImageIndex = 5;
            }
        }

        private void button3_Click(object sender, EventArgs e)      // Çocuk Odası
        {
            try { 
            if (btn_drm[3] == 0)
            {
                btn_drm[3] = 1;
                button3.ImageIndex = 6;

                serialPort1.Write("e");

            }

            else if (btn_drm[3] == 1)
            {
                btn_drm[3] = 0;
                button3.ImageIndex = 5;

                serialPort1.Write("e");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
                button3.ImageIndex = 5;
            }
        }

        private void button10_Click(object sender, EventArgs e)     // Antre
        {
            try
            {
                if (btn_drm[10] == 0)
                {
                    btn_drm[10] = 1;
                    button10.ImageIndex = 6;

                    serialPort1.Write("f");

                }

                else if (btn_drm[10] == 1)
                {
                    btn_drm[10] = 0;
                    button10.ImageIndex = 5;

                    serialPort1.Write("f");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
                button10.ImageIndex = 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)      // Balkon
        {
            try { 
            if (btn_drm[6] == 0)
            {
                btn_drm[6] = 1;
                button6.ImageIndex = 6;

                serialPort1.Write("g");

            }

            else if (btn_drm[6] == 1)
            {
                btn_drm[6] = 0;
                button6.ImageIndex = 5;

                serialPort1.Write("g");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
                button6.ImageIndex = 5;
            }
        }

        private void button14_Click(object sender, EventArgs e)     // Kiler
        {
            try { 
            if (btn_drm[14] == 0)
            {
                btn_drm[14] = 1;
                button14.ImageIndex = 6;

                serialPort1.Write("h");

            }

            else if (btn_drm[14] == 1)
            {
                btn_drm[14] = 0;
                button14.ImageIndex = 5;

                serialPort1.Write("h");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
                button14.ImageIndex = 5;
            }
        }

        private void button5_Click(object sender, EventArgs e)      // Teras
        {
            try { 
            if (btn_drm[5] == 0)
            {
                btn_drm[5] = 1;
                button5.ImageIndex = 6;

                serialPort1.Write("i");

            }

            else if (btn_drm[5] == 1)
            {
                btn_drm[5] = 0;
                button5.ImageIndex = 5;

                serialPort1.Write("i");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
                button5.ImageIndex = 5;
            }
        }

        private void button7_Click(object sender, EventArgs e)      // Mutfak
        {
            try
            {
                if (btn_drm[7] == 0)
                {
                    btn_drm[7] = 1;
                    button7.ImageIndex = 6;

                    serialPort1.Write("j");

                }

                else if (btn_drm[7] == 1)
                {
                    btn_drm[7] = 0;
                    button7.ImageIndex = 5;

                    serialPort1.Write("j");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
                button7.ImageIndex = 5;
            }
        }

        
        private void timer1_Tick(object sender, EventArgs e)         // Timer 1
        {
            saniye--;
            if(saniye == 0 && dakika != 0)
            {
                dakika--;
                saniye = 59;
            }

            if(dakika == 0 && saat != 0)
            {
                saat--;
                dakika = 59;
            }

            textBox2.Text = saat.ToString();
            textBox3.Text = dakika.ToString();
            textBox4.Text = saniye.ToString();

            if(saniye == 0 && dakika == 0 && saat == 0)
            {
                
                serialPort1.Write("k");
                button13.ImageIndex = 8;
                trackBar1.Enabled = true;

                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                timer1.Stop();

            }
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)     // Combo Box 1
        {
            
            serialPort1.PortName = comboBox1.SelectedItem.ToString();
            serialPort1.Open();
        }

        private void groupBox1_Enter(object sender, EventArgs e)                // Group Box 1
        {

        }

        private void button11_Click(object sender, EventArgs e)     // Kapı Otomatiği           
        {
            try 
            {             
                serialPort1.Write("l");            
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }
        //*************************************************************

        

        private void button20_Click(object sender, EventArgs e)     // TV
        {
            
            Form2 frm2 = new Form2(this.serialPort1);
                      
            frm2.Show();
        }

        private void button4_Click(object sender, EventArgs e)      // Zil
        {
            try 
            { 
                serialPort1.Write("m");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void button19_Click(object sender, EventArgs e)     // Klima Derce +       
        {
            try
            {
                serialPort1.Write("A");
                textBox1.Text = "+1°C";
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void portÖğrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İlk olarak (Bilgisayarım veya Bu Bilgisayar) yazan dosyaya sağ tıklayınız daha sonra çıkan listeden yönete tıklayıp, açılan pencerede sol taraftan Sistem Araçları 'na tıklayıp Aygıt yöneticisine giriniz. Aygıt Yöneticisiyle gelen ekrandan (Bağlantı noktaları (COM ve LPT)) yazan yere tıklayıp, cihaınızın hangi porta bağlı olduğunu öğrenebilirsiniz.");
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void button18_Click(object sender, EventArgs e)     // Klima Derece -
        {
            try
            {
                serialPort1.Write("B");
                textBox1.Text = "-1°C";
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void button15_Click(object sender, EventArgs e)     // Klima Cool
        {
            try
            {
                serialPort1.Write("C");
                textBox1.Text = "COOL";
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void button16_Click(object sender, EventArgs e)     // Klima Heat
        {
            try
            {
                serialPort1.Write("F");
                textBox1.Text = "HEAT";
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("N");
                textBox1.Text = "^FAN";
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button13_Click(object sender, EventArgs e)     // Fırın
        {
            try { 
            if (btn_drm[13] == 0)
            {
                btn_drm[13] = 1;
                button13.ImageIndex = 7;

                saniye = 59;
                dakika = trackBar1.Value % 60 - 1;
                textBox2.Text = saat.ToString();
                textBox3.Text = dakika.ToString();
                textBox4.Text = saniye.ToString();

                timer1.Interval = 1000;
                timer1.Start();

                trackBar1.Enabled = false;

                //zamanlayici = true;

                serialPort1.Write("k");

            }

            else if (btn_drm[13] == 1)
            {
                btn_drm[13] = 0;
                button13.ImageIndex = 8;

                timer1.Stop();

                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                trackBar1.Enabled = true;
                trackBar1.Value = 1;

               

                serialPort1.Write("k");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA\nMuhtemelen COM port seçilmemiştir\nPort ismini nasıl öğrenileceğini bilmiyorsanız görmek için yukarıdaki menüden port öğrene tıklayınız\nHATA AÇIKLAMASI:\n" + ex);
                button13.ImageIndex = 8;
                trackBar1.Enabled = true;

                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                timer1.Stop();
            }
        }

        

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(trackBar1.Value < 60)
            {
                saat = 0;
                textBox2.Text = saat.ToString(); 
            }

            else if (trackBar1.Value >= 60 && trackBar1.Value < 120)
            {
                saat = 1;
                textBox2.Text = saat.ToString();
            }

            else if(trackBar1.Value >= 120 && trackBar1.Value < 180)
            {
                saat = 2;
                textBox2.Text = saat.ToString();
            }

            else if (trackBar1.Value >= 180 && trackBar1.Value < 240)
            {
                saat = 3;
                textBox2.Text = saat.ToString();
            }

            else if (trackBar1.Value >= 300 && trackBar1.Value < 360)
            {
                saat = 4;
                textBox2.Text = saat.ToString();
            }
            else 
            {
                saat = 5;
                textBox2.Text = saat.ToString();
            }

            textBox3.Text = Convert.ToString(trackBar1.Value % 60);

            textBox4.Text = "0";
        }
    }
}
