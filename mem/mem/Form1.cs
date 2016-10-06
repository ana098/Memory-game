using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mem
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int s;
        int a = 0;
        PictureBox prva;
        PictureBox druga;
        List<Point> lokacija = new List<Point>();
        
        public Form1()
        {
            InitializeComponent();
            
        }
   
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (PictureBox picture in this.Controls.OfType<PictureBox>() )
            {
                picture.Enabled = false;
                picture.Image = Properties.Resources.upitnik;
                picture.Cursor = Cursors.Hand;
                lokacija.Add(picture.Location);
            }
            foreach (PictureBox picture in this.Controls.OfType<PictureBox>())
            {
                int next = random.Next(lokacija.Count);
                Point p = lokacija[next];
                picture.Location = p;
                lokacija.Remove(p);
            }
            
        }
        private void kraj() 
        {
                if (a==10)
                {
                    timer1.Stop();
                    label4.Text = Convert.ToString(Convert.ToInt64(label4.Text + 1));
                    button1.Click -= this.button1_Click;
                    button1.Click += this.button1n_Click;
                }
        }
        private void button1n_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            s = 60;
            timer1.Start();
            foreach (PictureBox picture in this.Controls.OfType<PictureBox>())
            {
                picture.Enabled = true;
            }
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s= s-1;
            lbl_sec.Text = s.ToString();
            if (s == 0) 
            {
                timer1.Stop();
                foreach (PictureBox pic in this.Controls.OfType<PictureBox>())
                {
                    pic.Enabled = false;
                }
                MessageBox.Show("Vrijeme je isteklo, probajte ponovno !!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.zmaj;
            if (prva==null)
            {
                prva = pictureBox1;
            }
            else if(prva!=null && druga==null)
            {
                druga = pictureBox1;
            }
            if(prva!=null && druga!=null)
            {
                if (prva.Tag == druga.Tag)
                {
                    prva = null;
                    druga = null;
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 10);
                    a++;
                    kraj();
                }
                else 
                {
                    timer2.Start();
                }
                
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            prva.Image = Properties.Resources.upitnik;
            druga.Image = Properties.Resources.upitnik;
            prva = null;
            druga = null;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.zmaj;
            if (prva == null)
            {
                prva = pictureBox2;
            }
            else if (prva != null && druga == null)
            {
                druga = pictureBox2;
            }
            if (prva != null && druga != null)
            {
                if (prva.Tag == druga.Tag)
                {
                    prva = null;
                    druga = null;
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 10);
                    a++;
                    kraj();
                }
                else
                {
                    timer2.Start();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.zirafa;
            if (prva == null)
            {
                prva = pictureBox3;
            }
            else if (prva != null && druga == null)
            {
                druga = pictureBox3;
            }
            if (prva != null && druga != null)
            {
                if (prva.Tag == druga.Tag)
                {
                    prva = null;
                    druga = null;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 10);
                    a++;
                    kraj();
                }
                else
                {
                    timer2.Start();
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.zirafa;
            if (prva == null)
            {
                prva = pictureBox4;
            }
            else if (prva != null && druga == null)
            {
                druga = pictureBox4;
            }
            if (prva != null && druga != null)
            {
                if (prva.Tag == druga.Tag)
                {
                    prva = null;
                    druga = null;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 10);
                    a++;
                    kraj();
                }
                else
                {
                    timer2.Start();
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.zec;
            if (prva == null)
            {
                prva = pictureBox5;
            }
            else if (prva != null && druga == null)
            {
                druga = pictureBox5;
            }
            if (prva != null && druga != null)
            {
                if (prva.Tag == druga.Tag)
                {
                    prva = null;
                    druga = null;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 10);
                    a++;
                    kraj();
                }
                else
                {
                    timer2.Start();
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.zec;
            if (prva == null)
            {
                prva = pictureBox6;
            }
            else if (prva != null && druga == null)
            {
                druga = pictureBox6;
            }
            if (prva != null && druga != null)
            {
                if (prva.Tag == druga.Tag)
                {
                    prva = null;
                    druga = null;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 10);
                    a++;
                    kraj();
                }
                else
                {
                    timer2.Start();
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.sova;
            if (prva == null)
            {
                prva = pictureBox7;
            }
            else if (prva != null && druga == null)
            {
                druga = pictureBox7;
            }
            if (prva != null && druga != null)
            {
                if (prva.Tag == druga.Tag)
                {
                    prva = null;
                    druga = null;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;
                    label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 10);
                    a++;
                    kraj();
                }
                else
                {
                    timer2.Start();
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.sova;
            if (prva == null)
            {
                prva = pictureBox8;
            }
            else if (prva != null && druga == null)
            {
                druga = pictureBox8;
            }
            if (prva != null && druga != null)
            {
                if (prva.Tag == druga.Tag)
                {
                    prva = null;
                    druga = null;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;
                    label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 10);
                    a++;
                    kraj();
                }
                else
                {
                    timer2.Start();
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.rak;
            if (prva == null)
            {
                prva = pictureBox9;
            }
            else if (prva != null && druga == null)
            {
                druga = pictureBox9;
            }
            if (prva != null && druga != null)
            {
                if (prva.Tag == druga.Tag)
                {
                    prva = null;
                    druga = null;
                    pictureBox9.Enabled = false;
                    pictureBox10.Enabled = false;
                    label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 10);
                    a++;
                    kraj();
                }
                else
                {
                    timer2.Start();
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.rak;
            if (prva == null)
            {
                prva = pictureBox10;
            }
            else if (prva != null && druga == null)
            {
                druga = pictureBox10;
            }
            if (prva != null && druga != null)
            {
                if (prva.Tag == druga.Tag)
                {
                    prva = null;
                    druga = null;
                    pictureBox9.Enabled = false;
                    pictureBox10.Enabled = false;
                    label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 10);
                    a++;
                    kraj();
                }
                else
                {
                    timer2.Start();
                }
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = Properties.Resources.ptica;
            if (prva == null)
            {
                prva = pictureBox11;
            }
            else if (prva != null && druga == null)
            {
                druga = pictureBox11;
            }
            if (prva != null && druga != null)
            {
                if (prva.Tag == druga.Tag)
                {
                    prva = null;
                    druga = null;
                    pictureBox11.Enabled = false;
                    pictureBox12.Enabled = false;
                    label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 10);
                    a++;
                    kraj();
                }
                else
                {
                    timer2.Start();
                }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Image = Properties.Resources.ptica;
            if (prva == null)
            {
                prva = pictureBox12;
            }
            else if (prva != null && druga == null)
            {
                druga = pictureBox12;
            }
            if (prva != null && druga != null)
            {
                if (prva.Tag == druga.Tag)
                {
                    prva = null;
                    druga = null;
                    pictureBox11.Enabled = false;
                    pictureBox12.Enabled = false;
                    label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 10);
                    a++;
                    kraj();
                }
                else
                {
                    timer2.Start();
                }
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.Image = Properties.Resources.pauk;
            if (prva == null)
            {
                prva = pictureBox13;
            }
            else if (prva != null && druga == null)
            {
                druga = pictureBox13;
            }
            if (prva != null && druga != null)
            {
                if (prva.Tag == druga.Tag)
                {
                    prva = null;
                    druga = null;
                    pictureBox13.Enabled = false;
                    pictureBox14.Enabled = false;
                    label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 10);
                    a++;
                    kraj();
                }
                else
                {
                    timer2.Start();
                }
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Properties.Resources.pauk;
            if (prva == null)
            {
                prva = pictureBox14;
            }
            else if (prva != null && druga == null)
            {
                druga = pictureBox14;
            }
            if (prva != null && druga != null)
            {
                if (prva.Tag == druga.Tag)
                {
                    prva = null;
                    druga = null;
                    pictureBox13.Enabled = false;
                    pictureBox14.Enabled = false;
                    label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 10);
                    a++;
                    kraj();
                }
                else
                {
                    timer2.Start();
                }
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.Image = Properties.Resources.nikola;
            if (prva == null)
            {
                prva = pictureBox15;
            }
            else if (prva != null && druga == null)
            {
                druga = pictureBox15;
            }
            if (prva != null && druga != null)
            {
                if (prva.Tag == druga.Tag)
                {
                    prva = null;
                    druga = null;
                    pictureBox15.Enabled = false;
                    pictureBox16.Enabled = false;
                    label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 10);
                    a++;
                    kraj();
                }
                else
                {
                    timer2.Start();
                }
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.Image = Properties.Resources.nikola;
            if (prva == null)
            {
                prva = pictureBox16;
            }
            else if (prva != null && druga == null)
            {
                druga = pictureBox16;
            }
            if (prva != null && druga != null)
            {
                if (prva.Tag == druga.Tag)
                {
                    prva = null;
                    druga = null;
                    pictureBox15.Enabled = false;
                    pictureBox16.Enabled = false;
                    label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 10);
                    a++;
                    kraj();
                }
                else
                {
                    timer2.Start();
                }
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox17.Image = Properties.Resources.mis;
            if (prva == null)
            {
                prva = pictureBox17;
            }
            else if (prva != null && druga == null)
            {
                druga = pictureBox17;
            }
            if (prva != null && druga != null)
            {
                if (prva.Tag == druga.Tag)
                {
                    prva = null;
                    druga = null;
                    pictureBox17.Enabled = false;
                    pictureBox18.Enabled = false;
                    label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 10);
                    a++;
                    kraj();
                }
                else
                {
                    timer2.Start();
                }
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox18.Image = Properties.Resources.mis;
            if (prva == null)
            {
                prva = pictureBox18;
            }
            else if (prva != null && druga == null)
            {
                druga = pictureBox18;
            }
            if (prva != null && druga != null)
            {
                if (prva.Tag == druga.Tag)
                {
                    prva = null;
                    druga = null;
                    pictureBox17.Enabled = false;
                    pictureBox18.Enabled = false;
                    label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 10);
                    a++;
                    kraj();
                }
                else
                {
                    timer2.Start();
                }
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pictureBox19.Image = Properties.Resources.leptir;
            if (prva == null)
            {
                prva = pictureBox19;
            }
            else if (prva != null && druga == null)
            {
                druga = pictureBox19;
            }
            if (prva != null && druga != null)
            {
                if (prva.Tag == druga.Tag)
                {
                    prva = null;
                    druga = null;
                    pictureBox19.Enabled = false;
                    pictureBox20.Enabled = false;
                    label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 10);
                    a++;
                    kraj();
                }
                else
                {
                    timer2.Start();
                }
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pictureBox20.Image = Properties.Resources.leptir;
            if (prva == null)
            {
                prva = pictureBox20;
            }
            else if (prva != null && druga == null)
            {
                druga = pictureBox20;
            }
            if (prva != null && druga != null)
            {
                if (prva.Tag == druga.Tag)
                {
                    prva = null;
                    druga = null;
                    pictureBox19.Enabled = false;
                    pictureBox20.Enabled = false;
                    label3.Text =Convert.ToString(Convert.ToInt32(label3.Text) + 10);
                    a++;
                    kraj();
                }
                else
                {
                    timer2.Start();
                }
            }
        }
        

    }
}
