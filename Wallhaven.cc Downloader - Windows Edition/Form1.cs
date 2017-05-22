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
using System.IO;
using System.Diagnostics;
using System.Threading;
using CsQuery;

namespace Wallhaven.cc_Downloader___Windows_Edition
{
    public partial class Form1 : Form
    {
        private class MyWebClient : WebClient
        {
            protected override WebRequest GetWebRequest(Uri uri)
            {
                WebRequest w = base.GetWebRequest(uri);
                w.Timeout = 20 * 60 * 1000;
                return w;
            }
        }
        string saveplace = AppDomain.CurrentDomain.BaseDirectory + "wallhaven";
        int version = 5;
        bool started = false;
        bool stop = false;
        string dir;
        int piccount;
        int errors;
        int dbsize;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            ToolTip t = new ToolTip();
            t.SetToolTip(button4, "Open destination folder");
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void textBox3_keyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void textBox6_enter(object sender, EventArgs e)
        {
            textBox6.Text = null;
            textBox6.ForeColor = Color.Black;
        }
        private void textBox7_enter(object sender, EventArgs e)
        {
            textBox7.Text = null;
            textBox7.ForeColor = Color.Black;
        }

        private void textBox8_enter(object sender, EventArgs e)
        {
            textBox8.Text = null;
            textBox8.ForeColor = Color.Black;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                checkBox1.Visible = true;
            }
            else
            {
                checkBox1.Visible = false;
            }
            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 3)
            {
                textBox1.Enabled = true;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
            }
            else
            {
                textBox1.Enabled = false;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = false;
                textBox3.Visible = false;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox3.Visible = false;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                richTextBox1.Text = richTextBox1.Text + "\nSelected random. Getting pictures amount...";
                System.Net.WebClient wc = new System.Net.WebClient();
                try
                {
                    string webData = wc.DownloadString("http://intel777.esy.es/whwdl/dbsize.html");
                    dbsize = Int32.Parse(webData);
                    richTextBox1.Text = richTextBox1.Text + "\nPicture database size is: " + dbsize + " pictures.";
                }
                catch (Exception) {
                    richTextBox1.Text = richTextBox1.Text + "\nError while connecting to server. Using local db size with 500000 elements.";
                    dbsize = 500000;
                }
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            stop = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.Description = "Destination folder...";
            FBD.SelectedPath = AppDomain.CurrentDomain.BaseDirectory;
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                saveplace = FBD.SelectedPath;
                string buffer = richTextBox1.Text;
                richTextBox1.Text = buffer + "\nDestination folder selected: " + saveplace;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.Visible = true;
            }
            else
            {
                textBox3.Visible = false;
            }
        }
        //Declarating functions
        delegate void SetTextCallback(string text);
        delegate void SetProgressbar();
        delegate void RestoreControl();
        void restorecontrol()
        {
            if (this.InvokeRequired || this.groupBox1.InvokeRequired)
            {
                RestoreControl d = new RestoreControl(restorecontrol);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.Text = "Wallhaven.cc Downloader - Windows Edition";
                this.ControlBox = true;
                groupBox1.Enabled = true;
            }
        }
        void progressbaradd()
        {
            if(this.progressBar1.InvokeRequired)
            {
                SetProgressbar d = new SetProgressbar(progressbaradd);
                this.Invoke(d, new object[] { });
            }
            else
            {
                progressBar1.PerformStep();
            }
        }

        void conpush(string text)
        {
            if (this.richTextBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(conpush);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                string conbuffer = richTextBox1.Text;
                this.richTextBox1.Text = conbuffer + text;
            }
        }

        void download(int id, int ids, int piccount)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile("https://wallpapers.wallhaven.cc/wallpapers/full/wallhaven-" + id + ".jpg", dir + id + ".jpg");
                    FileInfo file = new FileInfo(dir + id + ".jpg");
                    long size = file.Length / 1024;
                    conpush("\n[" + ids + "/" + piccount + "]Downloaded: " + id + ", " + size + "KB");
                }
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError &&
                    ex.Response != null)
                {
                    var resp = (HttpWebResponse)ex.Response;
                    if (resp.StatusCode == HttpStatusCode.NotFound)
                    {
                        conpush("\n404. Changing extention...");
                        try
                        {
                            using (WebClient client = new WebClient())
                            {
                                client.DownloadFile("https://wallpapers.wallhaven.cc/wallpapers/full/wallhaven-" + id + ".png", dir + id + ".png");
                                FileInfo file = new FileInfo(dir + id + ".png");
                                long size = file.Length / 1024;
                                conpush("\n[" + ids + "/" + piccount + "]Downloaded: " + id + ", " + size + "KB");
                            }
                        }
                        catch (WebException exp)
                        {
                            if (exp.Status == WebExceptionStatus.ProtocolError &&
                                exp.Response != null)
                            {
                                conpush("\n[id" + id + "]Error!");
                                errors++;
                            }
                            else { }
                        }
                    }
                    else { }
                }
                else { }
            }
        }
        void update() {
            conpush("\nChecking for updates...");
            System.Net.WebClient wc = new System.Net.WebClient();
            string webData = wc.DownloadString("http://intel777.esy.es/whwdl/version.html");
            int curvers = Int32.Parse(webData);
            conpush("\nYou version: " + version + "\nAvaliabe version: " + curvers);
            if (version < curvers)
            {

                conpush("\nUpdate found. Downloading to upd_wld.zip...");
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile("http://intel777.esy.es/whwdl/" + curvers + ".zip", "upd_wld.zip");
                    var bytes = Convert.ToInt64(client.ResponseHeaders["Content-Length"]);
                    conpush("\nUpdate Downloaded. File size: " + bytes + "bytes.\nClose program and unzip it to update.");
                }
            }
            else
            {
                conpush("\nYou are using latest version!");
            }
        }
        bool exists(int id)
        {
            if (File.Exists(dir + id + ".jpg"))
            {
                conpush("\n[" + id + "]Already exists");
                return true;
            }
            else if (File.Exists(dir + id + ".png"))
            {
                conpush("\n[" + id + "]Already exists");
                return true;
            }
            else
            {
                return false;
            }
        }
        //Main function
        private void button1_Click(object sender, EventArgs e)
        {
            if (started)
            {
                new System.Threading.Thread(delegate ()
                {
                    MessageBox.Show("Download already in progress!", "Error");
                }).Start();
            }
            else {
                stop = false;
                DateTime StartTime;
                StartTime = DateTime.Now;
                string picountraw = textBox1.Text;
                int piccount = Int32.Parse(picountraw);
                int selection = comboBox1.SelectedIndex;
                dir = saveplace + "/";
                errors = 0;
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                if (picountraw == "")
                {
                    conpush("\nPossible error: no amount of pictures entered");
                }
                started = true;
                string title = this.Text;
                this.Text = title + " ###WORKING###";
                this.ControlBox = false;
                groupBox1.Enabled = false;

                if (comboBox1.SelectedIndex != 1 && comboBox1.SelectedIndex != 2)
                {

                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = piccount;
                    progressBar1.Step = 1;
                    progressBar1.Value = 1;
                }
                else
                {
                    piccount = 0;
                }
                    if (checkBox1.Checked)
                    {
                        conpush("\nOffset selected: " + textBox3.Text);
                    }
                    {
                        if (selection == 0)
                        {
                            new Thread(delegate ()
                            {
                                for (int i = 1; i < piccount + 1; i++)
                                {
                                    if (!stop)
                                    {
                                        if (!exists(i))
                                        {
                                            if (checkBox1.Checked)
                                            {
                                                int dloffset = Int32.Parse(textBox3.Text);
                                                download((dloffset + i), i, piccount);
                                            }
                                            else
                                            {
                                                download(i, i, piccount);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        started = false;
                                        DateTime EndTime = DateTime.Now;
                                        restorecontrol();
                                        conpush("\n==Download canceled by user==" + "\nFiles Downloaded: " + (i - errors) + "\nTime Elapsed: " + (EndTime - StartTime) + "\nErrors: " + errors + "\n==================================");
                                        errors = 0;
                                        break;
                                    }
                                    progressbaradd();
                                }
                                if (!stop)
                                {
                                    started = false;
                                    DateTime EndTime = DateTime.Now;
                                    restorecontrol();
                                    conpush("\n========\nDownload Finished!" + "\nFiles Downloaded: " + (piccount - errors) + "\nTime Elapsed: " + (EndTime - StartTime) + "\nErrors: " + errors + "\n========");
                                    errors = 0;
                                }
                            }).Start();
                        }
                        if (selection == 1)
                        {
                            string username = textBox6.Text;
                            conpush("\nUsername changed to: " + username);
                            int pagescount = Int32.Parse(textBox7.Text);
                            conpush("\nAmount of pages changed to: " + pagescount);
                            new Thread(delegate ()
                            {
                                int i = 0;
                                int ii = 0;
                                for (; i < pagescount + 1; i++)
                                {
                                    string html = "https://alpha.wallhaven.cc/user/" + username + "/uploads?page=" + i;
                                    CQ cq = CQ.CreateFromUrl(html);
                                    foreach (IDomObject obj in cq.Find("figure"))
                                    {
                                        string downloadid = obj.GetAttribute("data-wallpaper-id");
                                        int did = Int32.Parse(downloadid);
                                        if (!stop)
                                        {
                                            if (!exists(did))
                                            {
                                                download(did, ii, piccount);
                                            }
                                        }
                                        else
                                        {
                                            started = false;
                                            DateTime EndTime = DateTime.Now;
                                            restorecontrol();
                                            conpush("\n == Download canceled by user == " + "\nFiles Downloaded: " + (ii - errors) + "\nTime Elapsed: " + (EndTime - StartTime) + "\nErrors: " + errors + "\n ================================== ");
                                            errors = 0;
                                            break;
                                        }
                                    }
                                    conpush("\n" + i + " of " + pagescount + " pages downloaded.");
                                }
                                if (!stop)
                                {
                                    started = false;
                                    DateTime EndTime = DateTime.Now;
                                    restorecontrol();
                                    conpush("\n========\nDownload Finished!\nDownloaded from: " + username + " uploads\nProcessed Pages: " + i + "\nFiles Downloaded: " + (ii - errors) + "\nTime Elapsed: " + (EndTime - StartTime) + "\nErrors: " + errors + "\n========");
                                    errors = 0;
                                }
                            }).Start();
                            }
                        if(selection == 2)
                        {
                            string username = textBox6.Text;
                            conpush("\nUsername changed to: " + username);
                            piccount = Int32.Parse(textBox7.Text);
                            conpush("\nAmount of pictures changed to: " + piccount);
                            string collectionid = textBox8.Text;
                            conpush("\nCollection ID changed to: " + collectionid);
                            new Thread(delegate ()
                            {
                                int page = 1;
                                for (int i = 0; i < piccount + 1;)
                                {
                                    string html = "https://alpha.wallhaven.cc/user/" + username + "/favorites/" + collectionid + "?purity=110&page=" + page;
                                    CQ cq = CQ.CreateFromUrl(html);
                                    foreach (IDomObject obj in cq.Find("figure"))
                                    {
                                        string downloadid = obj.GetAttribute("data-wallpaper-id");
                                        int did = Int32.Parse(downloadid);
                                        if (!stop)
                                        {
                                            if (!exists(did))
                                            {
                                                download(did, i, piccount);
                                                i++;
                                            }

                                        }
                                        else
                                        {
                                            started = false;
                                            DateTime EndTime = DateTime.Now;
                                            restorecontrol();
                                            conpush("\n == Download canceled by user == " + "\nFiles Downloaded: " + (i - errors) + "\nTime Elapsed: " + (EndTime - StartTime) + "\nErrors: " + errors + "\n ================================== ");
                                            errors = 0;
                                            break;
                                        }
                                    }
                                    if (!stop)
                                    {
                                        conpush("\nPage processed: " + page);
                                        page++;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                if (!stop)
                                {
                                    started = false;
                                    DateTime EndTime = DateTime.Now;
                                    restorecontrol();
                                    conpush("\n========\nDownload Finished!\nDownloaded from: " + username + "'s collection\nCollection ID: " + collectionid + "\nProcessed Pages: " + page + "\nFiles Downloaded: " + (piccount- errors) + "\nTime Elapsed: " + (EndTime - StartTime) + "\nErrors: " + errors + "\n========");
                                    errors = 0;
                                }
                            }).Start();
                        }
                        if (selection == 3)
                        {
                            new Thread(delegate ()
                                {
                                    for (int i = 0; i < piccount; i++)
                                    {
                                        if (!stop)
                                        {
                                            Random rand = new Random();
                                            int randompic = rand.Next(dbsize);
                                            if (!exists(randompic))
                                            {
                                                download(randompic, i, piccount);
                                            }                  
                                        }
                                        else
                                        {
                                            started = false;
                                            DateTime EndTime = DateTime.Now;
                                            restorecontrol();
                                            conpush("\n==Download canceled by user==" + "\nFiles Downloaded: " + (i - errors) + "\nTime Elapsed: " + (EndTime - StartTime) + "\nErrors: " + errors + "\n==================================");
                                            break;
                                        }
                                        progressbaradd();
                                    }
                                    if (!stop)
                                    {
                                        started = false;
                                        DateTime EndTime = DateTime.Now;
                                        restorecontrol();
                                        conpush("\n========\nDownload Finished!" + "\nFiles Downloaded: " + (piccount - errors) + "\nTime Elapsed: " + (EndTime - StartTime) + "\nErrors: " + errors + "\n========");
                                        errors = 0;
                                    }
                                }).Start();
                        }
                    }
                }
            }
        private void button4_Click(object sender, EventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "explorer";
            proc.StartInfo.Arguments = saveplace;
            proc.Start();
            proc.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            update();
        }
    }
}