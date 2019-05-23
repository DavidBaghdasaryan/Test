using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsoxoTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Հարցեր_SelectedIndexChanged(object sender, EventArgs e)
        {
            sender = "adasd";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Sum = 0;
            if (checkBox1.Checked) ; else Sum = Sum + 2;
            if (checkBox2.Checked)  Sum = Sum + 2;
            if (checkBox3.Checked)  Sum = Sum + 2;
            if (checkBox4.Checked) Sum = Sum + 2;
            if (checkBox5.Checked)  Sum = Sum + 2;
            if (checkBox6.Checked) ; else Sum = Sum + 2;
            if (checkBox7.Checked) ; else Sum = Sum + 2;
            if (checkBox8.Checked)  Sum = Sum + 2;
            if (checkBox9.Checked) ; else Sum = Sum + 2;
            if (checkBox10.Checked) Sum = Sum + 2;

            label13.Text = Sum.ToString();

            if (Sum >= 0 && Sum <= 6)  label12.Text= "Դժվար է ձեզ հետ անկեղծ լինել: " +
                    "Դուք դրան պարզապես չեք տրամադրում: Թոթափեք ներքին լարվածությունը," +
                    " դադարեք բոլորի մեջ թշնամի տեսնել, և կյանքը կհեշտանա ձեզ համար:";

            if (Sum >= 8 && Sum <= 12) label12.Text = "Մտերիմ մարդիկ հաճախ են ձեզ մոտ անկեղծանում," +
                    " բայց միշտ չէ, որ դուք կարող եք համարժեք կերպով ընկալել լսածը: Երբեմն պարզապես չեք " +
                    "լսում ձեր զրուցակցին, իսկ երբեմն էլ ասես խլանում եք, որովհետև լսում եք միայն ձեզ:";

            if (Sum >= 14 && Sum <= 20) label12.Text = "Ձեզ հետ, անկասկած, կարելի է խոսել բացարձակապես" +
                    " ամեն ինչի մասին և հնարավորինս անկեղծ: Դուք կարողանում եք դիմացինին լսել, հասկանալ" +
                    " և մխիթարել:";
        }
    }
}
