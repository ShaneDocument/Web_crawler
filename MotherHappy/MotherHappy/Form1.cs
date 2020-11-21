using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Diagnostics;
using System.IO;
namespace MotherHappy
{
    public partial class Form1 : Form
    {
        string series;
        int DrivesNum = 0;
        string[] Link = new string[100];
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
            LinkList.DrawItem += new DrawItemEventHandler(LinkList_DrawItem);
            
        }
        Form2 f = new Form2();
        private void LinkList_DrawItem(object sender,DrawItemEventArgs e)
        {
            string line;
            e.DrawBackground();
            Brush mybsh = Brushes.Black;
            try
            {
                StreamReader file = new StreamReader(@"C:\MotherHappy\series\" + SeriesName.Text + "\\" + seriesList.SelectedItem.ToString() + "his.Data");
                while ((line = file.ReadLine()) != null)
                {
                    
                    if (LinkList.Items[e.Index].ToString().IndexOf(line) != -1)
                    {
                        mybsh = Brushes.Blue;
                    }
                   
                }
                file.Close();
                
            }
            catch
            {

            }
            e.DrawFocusRectangle();
            e.Graphics.DrawString(LinkList.Items[e.Index].ToString(), e.Font, mybsh, e.Bounds, StringFormat.GenericDefault);

        }

        void LoadSeries(string name)
        {

            seriesList.Items.Clear();

            string path = @"C:\MotherHappy\series\" + name;
            try
            {
                foreach (string fname in Directory.GetFileSystemEntries(path, "*.txt"))
                {
                    seriesList.Items.Add(Path.GetFileNameWithoutExtension(fname));
                }
            }
            catch
            {

            }




        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (!(seriestb.Text == ""))
            {
                series = seriestb.Text;
                SeriesName.Text = series;
                File.WriteAllText("c:/MotherHappy/temp.txt", series);
                try
                {
                    Process.Start("C:/MotherHappy/search.exe");
                }
                catch
                {
                    MessageBox.Show("程式安裝不完整，請重新安裝。", "媽媽樂-Error");
                }
                Process[] myProcess = Process.GetProcessesByName("search");


                try
                {

                    while (true)
                    {
                        if (myProcess[0].Responding)
                        {
                            HintLB.Text = "搜尋中.....";
                        }
                        else
                        {
                            HintLB.Text = "搜尋完畢!";
                            HistoryList.Items.Clear();
                            string path = @"C:\MotherHappy\series";
                            string[] dirs = Directory.GetDirectories(path);
                            try
                            {
                                List<string> dirlist = new List<string>();

                                foreach (string item in dirs)
                                {
                                    dirlist.Add(Path.GetFileNameWithoutExtension(item));
                                }

                                foreach (var item in dirlist)
                                {
                                    HistoryList.Items.Add(item.ToString());
                                }
                            }
                            catch
                            {

                            }
                            break;
                        }
                    }
                    LoadSeries(series);

                }
                catch
                {

                }

            }
            else
            {
                seriestb.Text = "";
                MessageBox.Show("不能搜尋空白影集", "媽媽樂-Error");

            }





        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            this.ShowInTaskbar = true;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            notifyIcon1.Text = "LetYouHappy";


            if (Process.GetProcessesByName("MotherHappy").Length > 1)
            {
                this.Close();
                Environment.Exit(Environment.ExitCode);
            }

            string fileName = "search.exe";
            string fileName2 = "Watch.exe";
            string fileName3 = "chromedriver.exe";
            string fileName4 = "config.exe";
            string fileName5 = "MotherHappy.exe";
            try
            {
                string targetPath = @"C:\MotherHappy";
                string seriesPath = @"C:\MotherHappy\series";
                string systemPath = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\StartUp";
                string sourceFile = System.IO.Path.Combine(fileName);
                string sourceFile2 = System.IO.Path.Combine(fileName2);
                string sourceFile3 = System.IO.Path.Combine(fileName3);
                string sourceFile4 = System.IO.Path.Combine(fileName4);
                string sourceFile5 = System.IO.Path.Combine(fileName5);


                string destFile = System.IO.Path.Combine(targetPath, fileName);
                string destFile2 = System.IO.Path.Combine(targetPath, fileName2);
                string destFile3 = System.IO.Path.Combine(targetPath, fileName3);
                string destFile4 = System.IO.Path.Combine(targetPath, fileName4);
                string destFile5 = System.IO.Path.Combine(systemPath, fileName5);

                if (!System.IO.Directory.Exists(targetPath))
                {
                    System.IO.Directory.CreateDirectory(seriesPath);
                }
                if (!System.IO.Directory.Exists(seriesPath))
                {
                    System.IO.Directory.CreateDirectory(seriesPath);
                }


                System.IO.File.Copy(sourceFile, destFile, true);
                System.IO.File.Copy(sourceFile2, destFile2, true);
                System.IO.File.Copy(sourceFile3, destFile3, true);
                System.IO.File.Copy(sourceFile4, destFile4, true);
                System.IO.File.Copy(sourceFile5, destFile5, true);

            }
            catch
            {

            }
            string path = @"C:\MotherHappy\series";
            string[] dirs = Directory.GetDirectories(path);
            try
            {
                List<string> dirlist = new List<string>();

                foreach (string item in dirs)
                {
                    dirlist.Add(Path.GetFileNameWithoutExtension(item));
                }

                foreach (var item in dirlist)
                {
                    HistoryList.Items.Add(item.ToString());
                }
            }
            catch
            {

            }
        }




        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            LinkList.Items.Clear();
            string line;
            int i = 1, x = 0;
            try
            {
                StreamReader file = new StreamReader(@"c:\\MotherHappy\\series\\" + SeriesName.Text + "\\" + seriesList.SelectedItem.ToString() + ".txt");//, System.Text.Encoding.Default);
                while ((line = file.ReadLine()) != null)
                {
                    if (i % 2 == 0)
                    {
                        LinkList.Items.Add(line);
                    }
                    else
                    {
                        Link[x] = line;

                        x++;
                    }
                    i++;
                }




            }
            catch { }
            try
            {
                StreamReader img = new StreamReader(@"c:\\MotherHappy\\series\\" + SeriesName.Text + "\\" + seriesList.SelectedItem.ToString() + "img.Data");//, System.Text.Encoding.Default);
                while ((line = img.ReadLine()) != null)
                {
                    MovieImg.ImageLocation = line;
                }
            }

            catch { }
            try
            {
                StreamReader img = new StreamReader(@"c:\\MotherHappy\\series\\" + SeriesName.Text + "\\" + seriesList.SelectedItem.ToString() + "intro.Data");//, System.Text.Encoding.Default);
                while ((line = img.ReadLine()) != null)
                {
                    intro.Text = line;
                }
            }

            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (LinkList.SelectedItems.Count > 0)
            {
                Watch.Visible = true;
            }
            else
            {
                Watch.Visible = false;
            }
            if (SystemList.SelectedItems.Count > 0)
            {
                MoveButton.Visible = true;
            }
            else
            {
                MoveButton.Visible = false;
            }
            DriveInfo[] drives = DriveInfo.GetDrives();
            if (DrivesNum != drives.Length)
            {
                DrivesNum = drives.Length;
                SystemList.Items.Clear();
                foreach (DriveInfo drive in drives)
                {
                    SystemList.Items.Add(drive.Name);

                }

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void LinkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText("c:/MotherHappy/Link.txt", Link[LinkList.SelectedIndices[0]]);
            }
            catch { }
        }

        private void HistoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SeriesName.Text = HistoryList.SelectedItem.ToString();
            }
            catch
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SeriesName_TextChanged(object sender, EventArgs e)
        {
            LoadSeries(SeriesName.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            string path = @"C:\\MotherHappy\\series\\";
            if (HistoryList.SelectedItems.Count > 0)
            {
                Directory.Delete(path + HistoryList.SelectedItem.ToString(), true);
                HistoryList.Items.Remove(HistoryList.SelectedItem.ToString());
                seriesList.Items.Clear();
            }

        }

        private void Watch_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("C:/MotherHappy/Watch.exe");
            }
            catch
            {
                MessageBox.Show("程式安裝不完整，請重新安裝。", "媽媽樂-Error");
            }


            try
            {
                StreamWriter file = File.AppendText(@"C:\MotherHappy\series\" + SeriesName.Text + "\\" + seriesList.SelectedItem.ToString() + "his.Data");
                file.WriteLine(LinkList.SelectedItem.ToString());
                file.Flush();
                file.Close();
            }
            catch
            {

            }
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void SystemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText("c:/MotherHappy/disk.txt", SystemList.SelectedItem.ToString());
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("C:/MotherHappy/config.exe");
            }
            catch
            {
                MessageBox.Show("程式安裝不完整，請重新安裝。", "媽媽樂-Error");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com.tw/");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EP02 = 第二集\nE02 = 第二集\nS1E02代表第一季第二集", "MotherHappy");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(Environment.ExitCode);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.ShowInTaskbar = false;
            notifyIcon1.Visible = true;
        }
        
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {           
            e.Cancel = true;
            this.Hide();
            this.ShowInTaskbar = false;
            notifyIcon1.Visible = true;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            
        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.books.com.tw/");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(Environment.ExitCode);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(Environment.ExitCode);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            if (f.Visible == false)
            f.Visible = true;

        }
    }
}
