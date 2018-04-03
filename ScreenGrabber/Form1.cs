using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ScreenGrabber
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private string pathToSave = string.Empty;
        private int captureTime = 0;
        private int counter = 0;
        private bool running = false;
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            DialogResult result = fdb.ShowDialog();
            if (result == DialogResult.OK)
            {
                savePath.Text = fdb.SelectedPath;
                pathToSave = fdb.SelectedPath;
            }
        }

        private void MainWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            alternativeScreenCap cap = new alternativeScreenCap();

            while (running)
            {
                cap.GetScreenGrab(pathToSave + "\\", counter);
                counter++;
                Thread.Sleep(captureTime);
            }
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            stopbtn.Enabled = false;
            labelDisplay.Visible = false;

        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            if (savePath.Text != "" && capture.Text != "")
            {
                startbtn.Enabled = false;
                stopbtn.Enabled = true;
                labelDisplay.Visible = true;
                this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                try
                {
                    running = true;
                    captureTime = Convert.ToInt32(capture.Text);
                    captureTime = captureTime * 1000;                 
                    MainWorker.RunWorkerAsync();
                }
                catch
                {
                    MessageBox.Show("That is not a number. Please put a NUMBER in. You know.. 1,2,3,4,5,6,7 etc....");
                }
                
            }
            else
            {
                MessageBox.Show("Ok I know its hard, but you need to enter a path to save it to, and a time to do it at. Otherwise, I dont know what stuff's going down??", "Human.. you are doing it wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            MainWorker.CancelAsync();
            running = false;
            startbtn.Enabled = true;
            stopbtn.Enabled = false;
            labelDisplay.Visible = false;
            counter = 0;
        }
    }
}
