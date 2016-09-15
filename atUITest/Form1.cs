using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atUITest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                Console.WriteLine(file + " --advisory explicit --overWrite");
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = Directory.GetCurrentDirectory() + "/AtomicParsley.exe";
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                psi.Arguments = "\"" + file + "\"" + " --advisory explicit --overWrite";
                Process p = new Process();
                p.StartInfo = psi;
                p.EnableRaisingEvents = true;
                p.Exited += (s, ea) =>
                {
                    Console.WriteLine(file + " explicit");
                    ProcessStartInfo psi1 = new ProcessStartInfo();
                    psi1.FileName = Directory.GetCurrentDirectory() + "/advisorytaggr.exe";
                    psi1.WindowStyle = ProcessWindowStyle.Hidden;
                    psi1.RedirectStandardOutput = true;
                    psi1.UseShellExecute = false;
                    psi1.CreateNoWindow = true;
                    psi1.Arguments = "\"" + file + "\"" + " explicit";
                    Process p1 = new Process();
                    p1.StartInfo = psi1;
                    p1.EnableRaisingEvents = true;
                    p1.Exited += (s1, ea1) =>
                    {
                        Console.WriteLine("done");
                    };
                    p1.Start();
                    while (!p1.StandardOutput.EndOfStream)
                    {
                        string line = p1.StandardOutput.ReadLine();
                        Console.WriteLine(line);
                    }
                };
                p.Start();
                while (!p.StandardOutput.EndOfStream)
                {
                    string line = p.StandardOutput.ReadLine();
                    Console.WriteLine(line);
                }

            }
        }

    }
}
