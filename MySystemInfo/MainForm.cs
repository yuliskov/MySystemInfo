using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySystemInfo.Properties;

namespace MySystemInfo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            textBox1.Text = Resources.MainForm_Loading;
            textBox1.Text = InfoUtil.GetOsInformation();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Resources.MainForm_Loading;
            textBox1.Text = InfoUtil.GetOsInformation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Resources.MainForm_Loading;
            textBox1.Text = InfoUtil.GetCpuInformation();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = Resources.MainForm_Loading;
            textBox1.Text = InfoUtil.GetGpuInformation();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = Resources.MainForm_Loading;
            textBox1.Text = InfoUtil.GetDiskInformation();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = Resources.MainForm_Loading;
            textBox1.Text = InfoUtil.GetRamInformation();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = Resources.MainForm_Loading;
            textBox1.Text = "App created by Yuriy Lyskov\n\n" +
            "Email:  mailto:yu.liskov@gmail.com \n\nDownload Source Code:\n" +
            "https://github.com/yuliskov/MySystemInfo";
        }

        private void textBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}