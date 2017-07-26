using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subdomainLookup
{
    public partial class Form1 : Form
    {
        public string chars = "";
        public int set = 0;
        public int len = 0;
        public int[] charsInt = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public string currentSet = "";
        public int currentLen = 1;
        public int charset = 5;
        public int delay = 200;

        Thread t = null;

        int pagesFound = 0;

        string proxy = "";

        HttpWebRequest req = null;

        public string _URL_ = "";

        public string[] words = null;

        public string[] uas = new string[] {
            "Mozilla/5.0 (Windows NT [VER1]; Win64; x64) AppleWebKit/[VER1] (KHTML, like Gecko) Chrome/[VER3] Safari/[VER1]",
            "Mozilla/5.0 (Windows NT [VER1]; Win64; x64) AppleWebKit/[VER1] (KHTML, like Gecko) Chrome/[VER3] Safari/[VER1]",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_12_5) AppleWebKit/[VER1] (KHTML, like Gecko) Chrome/[VER3] Safari/[VER1]",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_12_5) AppleWebKit/[VER2] (KHTML, like Gecko) Version/[VER2] Safari/[VER2]",
            "Mozilla/5.0 (Windows NT [VER1]; WOW64; rv:[VER1]) Gecko/20100101 Firefox/[VER1]",
            "Mozilla/5.0 (Windows NT [VER1]; Win64; x64) AppleWebKit/[VER1] (KHTML, like Gecko) Chrome/[VER3] Safari/[VER1]",
            "Mozilla/5.0 (Windows NT [VER1]; WOW64; rv:[VER1]) Gecko/20100101 Firefox/[VER1]",
            "Mozilla/5.0 (Windows NT [VER1]; Win64; x64) AppleWebKit/[VER1] (KHTML, like Gecko) Chrome/[VER3] Safari/[VER1]",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_6) AppleWebKit/[VER1] (KHTML, like Gecko) Chrome/[VER3] Safari/[VER1]",
            "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/[VER1] (KHTML, like Gecko) Chrome/[VER3] Safari/[VER1]",
            "Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:[VER1]) Gecko/20100101 Firefox/[VER1]",
            "Mozilla/5.0 (Windows NT [VER1]; WOW64; Trident/[VER1]; rv:[VER1]) like Gecko",
            "Mozilla/5.0 (Windows NT [VER1]) AppleWebKit/[VER1] (KHTML, like Gecko) Chrome/[VER3] Safari/[VER1]",
            "Mozilla/5.0 (Windows NT [VER1]; Win64; x64) AppleWebKit/[VER1] (KHTML, like Gecko) Chrome/[VER3] Safari/[VER1]",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X [VER1]; rv:[VER1]) Gecko/20100101 Firefox/[VER1]",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_12_5) AppleWebKit/[VER1] (KHTML, like Gecko) Chrome/[VER3] Safari/[VER1]",
            "Mozilla/5.0 (Windows NT [VER1]; Win64; x64; rv:[VER1]) Gecko/20100101 Firefox/[VER1]",
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_12_4) AppleWebKit/[VER1] (KHTML, like Gecko) Chrome/[VER3] Safari/[VER1]",
            "Mozilla/5.0 (Windows NT [VER1]; Win64; x64) AppleWebKit/[VER1] (KHTML, like Gecko) Chrome/[VER3] Safari/[VER1]",
            "Mozilla/5.0 (Windows NT [VER1]; Win64; x64) AppleWebKit/[VER1] (KHTML, like Gecko) Chrome/[VER3] Safari/[VER1] Edge/[VER1]",
            "Mozilla/5.0 (Windows NT [VER1]; Win64; x64) AppleWebKit/[VER1] (KHTML, like Gecko) Chrome/[VER3] Safari/[VER1] Edge/[VER1]"
        };

        public bool run = false;

        public Form1()
        {
            InitializeComponent();

            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadSettings();
        }

        public void loadSettings()
        {
            tc_Tabs.SelectedIndex = Properties.Settings.Default.s_LastMode;
            tb_ListFile.Text = Properties.Settings.Default.s_ListFile;

            if (!Directory.Exists("lists")) { Directory.CreateDirectory("lists"); }

            if (!File.Exists("lists/popular_1000")) { File.WriteAllText("lists/popular_1000", Properties.Resources.popular_1000); }
            if (!File.Exists("lists/popular_10000")) { File.WriteAllText("lists/popular_10000", Properties.Resources.popular_10000); }
            if (!File.Exists("lists/popular_100000")) { File.WriteAllText("lists/popular_100000", Properties.Resources.popular_100000); }
            if (!File.Exists("lists/popular_1000000")) { File.WriteAllText("lists/popular_1000000", Properties.Resources.popular_1000000); }


            if (tb_ListFile.Text != "" && File.Exists(tb_ListFile.Text))
            {
                words = File.ReadAllLines(tb_ListFile.Text);
            }

            tb_Domain.Text = Properties.Settings.Default.s_LastUrl;
        }

        public void startList()
        {
            pagesFound = 0;

            for (int i = 0; i < words.Length; i++)
            {
                Thread.Sleep(delay);
                

                if (!run)
                {
                    break;
                }

                _URL_ = tb_Domain.Text + "/" + words[i];

                var req = getreq(_URL_);
                req.UserAgent = generateUA();

                try
                {
                    if (i == 1 || i % 5 == 0)
                    {
                        this.Invoke(new myDelegate(refreshDataList), i + "", pagesFound + "", "");
                    }

                    var resp = (HttpWebResponse)req.GetResponse();

                    pagesFound++;


                    this.Invoke(new myDelegate(fillList), i + "", words[i], _URL_);
                }
                catch { }
            }

            t = null;
        }

        public void startBrute()
        {
            pagesFound = 0;
            c_set.setupCharset(charset, out chars, out len);
            int i = 0;

            while (true)
            {
                Thread.Sleep(10);

                i++;

                if (!run)
                {
                    break;
                }
                c_set.updateSet(charsInt, currentLen, out currentLen, len, currentSet, out currentSet, chars);

                //currentSet += "a";

                _URL_ = tb_Domain.Text + "/" + currentSet;

                var req = getreq(_URL_);
                req.UserAgent = generateUA();

                try
                {
                    if (i == 1 || i % 5 == 0)
                    {
                        this.Invoke(new myDelegate(refreshDataBrute), i + "", currentSet, "");
                    }

                    var resp = (HttpWebResponse)req.GetResponse();

                    pagesFound++;
                    

                    this.Invoke(new myDelegate(fillList), i + "", currentSet, _URL_);
                }
                catch { }
            }

            t = null;
        }

        public delegate void myDelegate(string s1, string s2, string s3);
        public void refreshDataBrute(string s1, string s2, string s3)
        {
            lbl_Pages.Text = s1 + "/" + pagesFound;
            tb_At.Text = s2;
        }
        public void refreshDataList(string s1, string s2, string s3)
        {
            lbl_List_Index.Text = s1;
            lbl_List_Subs.Text = s2;

            int i1 = 0;
            int i2 = 0;
            int.TryParse(s1, out i1);
            int.TryParse(s2, out i2);
            
            lbl_Percent.Text = (((100 * 1.0f) / (i1 * 1.0f)) * i2) + "%";
        }
        public void fillBrute(string s1, string s2, string s3)
        {
            var lvi = new ListViewItem();
            lvi.Text = s1;
            lvi.SubItems.Add(s2);
            lvi.SubItems.Add(s3);

            lvi.BackColor = (lv_Brute.Items.Count % 2 == 0 ? Color.LightYellow : Color.LightGray);

            lv_Brute.Items.Add(lvi);

            lv_Brute.Refresh();

            if (!File.Exists("brute_tmp.txt")) { File.Create("brute_tmp.txt").Close(); }
            if (!File.Exists("brute_tmp2.txt")) { File.Create("brute_tmp2.txt").Close(); }

            File.AppendAllText("brute_tmp.txt", s3 + "\r\n");
            File.AppendAllText("brute_tmp2.txt", DateTime.Now.ToShortTimeString().PadRight(10) + " - " + s1.PadLeft(6, '0') + " - " + s2.PadRight(10, ' ') + "\t - \t" + s3 + "\r\n");

        }
        public void fillList(string s1, string s2, string s3)
        {
            var lvi = new ListViewItem();
            lvi.Text = s1;
            lvi.SubItems.Add(s2);
            lvi.SubItems.Add(s3);

            lvi.BackColor = (lv_Brute.Items.Count % 2 == 0 ? Color.LightYellow : Color.LightGray);
            lv_List.Items.Add(lvi);
            lv_List.Refresh();

            if (!File.Exists("list_tmp.txt")) { File.Create("list_tmp.txt").Close(); }
            if (!File.Exists("list_tmp2.txt")) { File.Create("list_tmp2.txt").Close(); }

            File.AppendAllText("list_tmp.txt", s3 + "\r\n");
            File.AppendAllText("list_tmp2.txt", DateTime.Now.ToShortTimeString().PadRight(10) + " - " + s1.PadLeft(6, '0') + " - " + s2.PadRight(10, ' ') + "\t - \t" + s3 + "\r\n");

        }

        public HttpWebRequest getreq(string url)
        {
            var req = HttpWebRequest.Create(url);
            req.Method = "GET";
            
            WebProxy myProxy = new WebProxy();
            // Obtain the Proxy Prperty of the  Default browser.  
            //myProxy = (WebProxy)req.Proxy;

            return (HttpWebRequest)req;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if(t == null)
            {
                run = true;
                start();
            }else
            {
                run = false;
            }
        }

        public string generateUA()
        {
            string ua = "";

            ua = uas[new Random().Next(0, uas.Length)];
            ua = ua.Replace("[VER1]", generateVersion(1));
            ua = ua.Replace("[VER2]", generateVersion(2));
            ua = ua.Replace("[VER3]", generateVersion(3));

            return ua;
        }

        public string generateVersion(int type)
        {
            string ver = "";

            Thread.Sleep(5);

            switch (type)
            {
                case 1:
                    ver = new Random().Next(1, 20) + "." + new Random().Next(1, 20);
                    break;

                case 2:
                    ver = new Random().Next(100, 800) + "." + new Random().Next(1, 10) + "." + new Random().Next(1, 10);
                    break;

                case 3:
                    ver = new Random().Next(10, 70) + ".0." + new Random().Next(1000, 5000) + "." + new Random().Next(10, 100);
                    break;
            }


            return ver;
        }

        private void btn_StartStop_Click(object sender, EventArgs e)
        {
            if (t == null)
            {
                run = true;
                start();
            }
            else
            {
                run = false;
            }
        }

        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            run = false;
        }

        private void lv_Brute_DoubleClick(object sender, EventArgs e)
        {
            if(lv_Brute.FocusedItem != null)
            {
                System.Diagnostics.Process.Start(lv_Brute.FocusedItem.SubItems[2].Text);
            }
        }

        private void lv_Brute_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                f_Demo fd = new f_Demo();
                fd.url = lv_Brute.FocusedItem.SubItems[2].Text;
                fd.ShowDialog();
            }
        }

        private void lv_Brute_Click(object sender, EventArgs e)
        {
            if(MouseButtons == MouseButtons.Middle)
            {
                f_Demo fd = new f_Demo();
                fd.url = lv_Brute.FocusedItem.SubItems[2].Text;
                fd.ShowDialog();
            }
        }

        private void btn_Brute_Click(object sender, EventArgs e)
        {
            tc_Tabs.SelectedIndex = 0;
        }

        private void btn_Google_Click(object sender, EventArgs e)
        {
            tc_Tabs.SelectedIndex = 1;
        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            tc_Tabs.SelectedIndex = 2;
        }

        public void start()
        {
            if (!tb_Domain.Text.ToLower().StartsWith("http://") && !tb_Domain.Text.ToLower().StartsWith("https://"))
            {
                tb_Domain.Text = "http://" + tb_Domain.Text;
            }

            if (tc_Tabs.SelectedIndex == 0)
            {
                currentSet = tb_At.Text;

                t = new Thread(new ThreadStart(startBrute));
            }
            else if (tc_Tabs.SelectedIndex == 1)
            {
               
            }
            else
            {
                t = new Thread(new ThreadStart(startList));
            }

            Properties.Settings.Default.s_LastUrl = tb_Domain.Text;
            Properties.Settings.Default.s_LastMode = tc_Tabs.SelectedIndex;
            Properties.Settings.Default.Save();

            delay = tb_Delay.Value;

            t.Start();
        }

        private void btn_ListBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files|*.lst;*.txt;*.rtf|XML Files|*.xml;*.html|All Files|*.*";
            ofd.Title = "Open List file";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                tb_ListFile.Text = ofd.FileName;

                words = File.ReadAllLines(ofd.FileName);
                pb_List_Index.Maximum = words.Length;
                pb_List_Index.Value = 0;

                Properties.Settings.Default.s_ListFile = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void tb_Delay_ValueChanged(object sender, EventArgs e)
        {
            lbl_DelayMS.Text = tb_Delay.Value + "ms";
        }
    }
}
