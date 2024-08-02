using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace kill_roblox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//csharp
        {
            Process[] processes = Process.GetProcessesByName("RobloxPlayerBeta");
            foreach (Process process in processes)
            {
                process.Kill();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//always on top
        {
            if (checkBox1.Checked == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)//kill roblox with a .bat code
        {
            string normal_path = AppDomain.CurrentDomain.BaseDirectory;
            string yol = Path.Combine(normal_path, "batch_kill.bat");
            ProcessStartInfo processInfo = new ProcessStartInfo
            {
                FileName = yol,
                UseShellExecute = true,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(processInfo))
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)//it brings you to my github page
        {
            string url = "https://github.com/Bxtumation";//you can change the url
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void button3_Click(object sender, EventArgs e)//kill roblox with c++
        {
            string normal_path = AppDomain.CurrentDomain.BaseDirectory;
            string yol = Path.Combine(normal_path, "cplusplus_dosyalari\\killroblox.exe");
            ProcessStartInfo processInfo = new ProcessStartInfo
            {
                FileName = yol,
                UseShellExecute = true,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(processInfo))
            {
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)//change background colors
        {
            if (checkBox2.Checked == true)
            {
                this.BackColor = Color.Black;
                checkBox1.ForeColor = Color.White;
                checkBox2.ForeColor = Color.White;
            } else
            {
                this.BackColor = Color.Snow;
                checkBox1.ForeColor = SystemColors.ControlText;
                checkBox2.ForeColor = SystemColors.ControlText;
            }
        }
    }
}
