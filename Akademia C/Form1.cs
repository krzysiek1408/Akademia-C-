using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AGaugeApp
{

    public partial class Form1 : Form
    {
        int zmienna = 1;
        bool karamba = false;
        bool karamba2 = false;
        bool karamba3 = false;
        bool karamba4 = false;

        float przebieg_p;
        float przebieg;

        Timer t = new Timer();


        public Form1()
        {
            InitializeComponent();
        }



        private void aGauge2_ValueInRangeChanged(object sender, AGauge.ValueInRangeChangedEventArgs e)
        {
           /* if (e.valueInRange == 1)
            {
                label1.Text = "lol";
            }
            else if (e.valueInRange == 2)
            {
                label1.Text = "HEHEHKEKEKEKEKETHEN SOMTHING IS WRONG ;-)";
            }
            else
            {
                label1.Text = "lodzik";
            }*/
        }
        float xy;
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            aGauge1.Value = trackBar1.Value * 4 / 3;
            aGauge2.Value = trackBar1.Value;
            //aGauge9.Value = 100;
            paliwo = Math.Abs(Math.Log(Math.Abs(trackBar1.Value))) - 5;
            label4.Text = "Zuzycie paliwa " + Math.Round((aGauge2.Value * 20 / 300), 2) + " l/100km";

            label6.Text = "temp silnika" + (xy + aGauge2.Value / 5);

            

           // textBox1.Text = aGauge1.Value.ToString();

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // aGauge3.Value+=0.5f;
            //aGauge4.Value += 10;

            /*  if (aGauge3.Value >= 50)
              {
                  aGauge3.Value = 0;
              }*/
            /*
            if (aGauge4.Value >= 300)
            {
                aGauge4.Value = -300;
            }*/

            // aGauge5.Value = aGauge3.Value;
            //aGauge6.Value = (Single)(((Int32)aGauge6.Value + 49) % 50);
            //aGauge7.Value = (Single)(((Int32)aGauge7.Value + 49) % 50);
            //aGauge8.Value = (Single)(((Int32)aGauge8.Value + 51) % 50);
            //aGauge11.Value = (Single)(((Int32)aGauge11.Value + 9) % 10);

            if (zmienna == 1)
            {
                aGauge9.Value = 100;
                zmienna = 0;
                //przebieg1 = 0;
            }
            aGauge9.Value = aGauge9.Value - aGauge2.Value / 3000; //(Single)(((Int32)aGauge9.Value ) );
            //aGauge10.Value = (Single)(((Int32)aGauge10.Value + 99) % 100);
            //aGauge12.Value = (Single)(((Int32)aGauge12.Value + 99) % 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (aGauge1.NeedleType == 0)
            {
                aGauge1.NeedleType = 1;
            }
            else
            {
                aGauge1.NeedleType = 0;
            }

            if (aGauge2.NeedleType == 0)
            {
                aGauge2.NeedleType = 1;
            }
            else
            {
                aGauge2.NeedleType = 0;
            }

            /*if (aGauge3.NeedleType == 0)
            {
                aGauge3.NeedleType = 1;
            }
            else
            {
                aGauge3.NeedleType = 0;
            }*/

            /*if (aGauge4.NeedleType == 0)
            {
                aGauge4.NeedleType = 1;
            }
            else
            {
                aGauge4.NeedleType = 0;
            }*/

            /*  if (aGauge5.NeedleType == 0)
              {
                  aGauge5.NeedleType = 1;
              }
              else
              {
                  aGauge5.NeedleType = 0;
              }*/

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aGauge9_ValueInRangeChanged(object sender, AGauge.ValueInRangeChangedEventArgs e)
        {

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            xy = trackBar3.Value;
            label5.Text = "Temperatura otoczenia: " + xy;
            label6.Text = "temp silnika" + (xy + aGauge2.Value / 5);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (karamba == true)
            {
                pictureBox2.BackColor = Color.Lime;
                karamba = false;
            }
            else
            {
                pictureBox2.BackColor = Color.Red;
                karamba = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (karamba3 == true)
            {
                pictureBox4.BackColor = Color.Lime;
                karamba3 = false;
            }
            else
            {
                pictureBox4.BackColor = Color.Red;
                karamba3 = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (karamba4 == true)
            {
                pictureBox5.BackColor = Color.Lime;
                karamba4 = false;
            }
            else
            {
                pictureBox5.BackColor = Color.Red;
                karamba4 = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (karamba2 == true)
            {
                pictureBox3.BackColor = Color.Lime;
                karamba2 = false;
            }
            else
            {
                pictureBox3.BackColor = Color.Red;
                karamba2 = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void timer2_Tick(object sender, EventArgs e)
        {

        }
        private void Form1_Load1(object sender, EventArgs e)
        {
            //timer interval
            t.Interval = 1000;  //in milliseconds

            t.Tick += new EventHandler(this.t_Tick);

            //start timer when form loads
            t.Start();  //this will use t_Tick() method
        }

        //timer eventhandler
        private void t_Tick(object sender, EventArgs e)
        {
            //get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            //time
            string time = "";

            //padding leading zero
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            //update label
            //label8.Text = time;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        



       

        private void StartTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }

       

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            
            label10.Text = DateTime.Now.ToString();
            przebieg = trackBar1.Value;
            label1.Text = "przebieg auta: " + Math.Round(((przebieg_p + przebieg)/30000),1) + "km";
            przebieg_p = przebieg_p + przebieg;
        }



        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    } 

}



