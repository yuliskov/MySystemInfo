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
            textBox1.Text = InfoUtil.SystemInformation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Resources.MainForm_Loading;
            textBox1.Text = InfoUtil.DeviceInformation("Win32_Processor");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = Resources.MainForm_Loading;
            textBox1.Text = InfoUtil.DeviceInformation("Win32_VideoController");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = Resources.MainForm_Loading;
            textBox1.Text = InfoUtil.DeviceInformation("Win32_LogicalDisk");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = Resources.MainForm_Loading;
            textBox1.Text = InfoUtil.DeviceInformation("Win32_MemoryDevice");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = Resources.MainForm_Loading;
            textBox1.Text = "Dedicated to opens source community by:\n Yuriy Lyskov\n\n\n\n" +
            "Email:  yu.liskov@gmail.com \n\n\n\n Downlaod Source Code:\n" +
            "https://github.com/yuliskov/MySystemInfo";
        }
    }
}