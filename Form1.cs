using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
namespace WindowsFormsApp3
{
public partial class Form1 : Form
    {
        static Regex rgx = new Regex(@"(^|\.)0+(?!\.|$)", RegexOptions.Compiled);
        public Form1()
        {
            InitializeComponent();
        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            String ipString = AdresIP.Text;
            ipString = rgx.Replace(ipString, ".");
            IPAddress ipAddress = IPAddress.Parse(ipString);
            IPAddress maskAddress = IPAddress.Parse(Maska.Text);
            byte[] ip = ipAddress.GetAddressBytes();
            byte[] mask = maskAddress.GetAddressBytes();
            IPNetwork network = IPNetwork.Parse(ipAddress.ToString(), maskAddress.ToString());

            AdresSieci.Text = network.Network.ToString();
            AdresR.Text = network.Broadcast.ToString();
            Adres1.Text = network.FirstUsable.ToString();
            Adres2.Text = network.LastUsable.ToString();

        }
        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
