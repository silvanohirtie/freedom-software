using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freedom_software
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.proxy-list.download/api/v1/get?type=http&anon=elite&country=FR");
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.proxy-list.download/api/v1/get?type=http&anon=elite&country=US");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.proxy-list.download/api/v1/get?type=http&anon=elite&country=BR");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.proxy-list.download/api/v1/get?type=http&anon=elite&country=RU");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.proxy-list.download/api/v1/get?type=http&anon=elite&country=DE");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.proxy-list.download/api/v1/get?type=http&anon=elite&country=IT");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.proxy-list.download/api/v1/get?type=http&anon=elite&country=IN");
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }
    }
}
