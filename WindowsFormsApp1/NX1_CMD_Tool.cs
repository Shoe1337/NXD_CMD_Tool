using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using XRPCLib;


namespace WindowsFormsApp1
{
    public partial class NX1_CMD_Tool : DevExpress.XtraEditors.XtraForm
    {
        XRPC Jtag = new XRPC();

        private void cbuf(string cmd)
        {
            Jtag.Call(0x822C8C20, 0, cmd);
        }

        public NX1_CMD_Tool()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Jtag.Connect();
            if (Jtag.activeConnection == true)
            {
               
                label2.ForeColor = System.Drawing.Color.Green;
                label2.Text = "Connected";
            }
            else
            {
                label2.ForeColor = System.Drawing.Color.Red;
                label2.Text = "Error Connecting";

            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            cbuf("god");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            cbuf("noclip");
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            cbuf("give all");
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            cbuf("" + textBox1.Text);
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            cbuf("setPlayerData kills " + textBox2.Text); //kills
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            cbuf("setPlayerData deaths " + textBox3.Text);
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            cbuf("setPlayerData score " + textBox4.Text);
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            cbuf("setPlayerData experience " + textBox5.Text);
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            cbuf("setPlayerData wins " + textBox6.Text);
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            cbuf("setPlayerData losees " + textBox7.Text);
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            cbuf("setPlayerData ties " + textBox8.Text);
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            cbuf("setPlayerData headshots " + textBox9.Text);
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            cbuf("setPlayerData assists " + textBox10.Text);
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            textBox5.Text = "2516000";
            textBox2.Text = "2147483647";
            textBox3.Text = "2147483647";
            textBox4.Text = "2147483647";
            textBox6.Text = "2147483647";
            textBox7.Text = "2147483647";
            textBox8.Text = "2147483647";
            textBox9.Text = "2147483647";
            textBox10.Text = "2147483647";
           
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            textBox5.Text = "2516000";
            textBox2.Text = "93421";
            textBox3.Text = "57293";
            textBox4.Text = "1587283";
            textBox6.Text = "2938";
            textBox7.Text = "1293";
            textBox8.Text = "596";
            textBox9.Text = "29374";
            textBox10.Text = "84712";
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            cbuf("setPlayerData kills " + textBox2.Text);
            cbuf("setPlayerData deaths " + textBox3.Text);
            cbuf("setPlayerData score " + textBox4.Text);
            cbuf("setPlayerData experience " + textBox5.Text);
            cbuf("setPlayerData wins " + textBox6.Text);
            cbuf("setPlayerData losses " + textBox7.Text);
            cbuf("setPlayerData ties " + textBox8.Text);
            cbuf("setPlayerData headshots " + textBox9.Text);
            cbuf("setPlayerData assists " + textBox10.Text);
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            cbuf("give ammo");
        }

       
    }
}