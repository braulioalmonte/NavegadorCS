using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador_DCU
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.do");
            direccion_text.Text = "www.google.com.do";
            WindowState = FormWindowState.Maximized;
            toolStripStatusLabel1.Text = (direccion_text.Text);
            webBrowser1.DocumentCompleted += WebBrowser_DocumentCompleted;

        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = webBrowser1.DocumentTitle;
        }

        public void progressbar_reset()
        {
            toolStripProgressBar1.Value = 0;
        }

        public void navegador_go()
        {
           webBrowser1.Navigate(direccion_text.Text);
           direccion_text.Text = direccion_text.Text;
           progressbar_reset();
           this.timer1.Start();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = (direccion_text.Text);
            navegador_go();
            progressbar_reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
            toolStripStatusLabel1.Text = (direccion_text.Text);
            progressbar_reset();
            this.timer1.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = (direccion_text.Text);
            webBrowser1.GoForward();
            progressbar_reset();
            this.timer1.Start();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.do");
            direccion_text.Text = "www.google.com.do";
            progressbar_reset();
            this.timer1.Start();

        }

        private void button4_Click(object sender, EventArgs e)
        {
           toolStripStatusLabel1.Text = (direccion_text.Text);
           webBrowser1.Refresh();
            progressbar_reset();
            this.timer1.Start();

        }

        private void direccion_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                navegador_go();
                toolStripStatusLabel1.Text = (direccion_text.Text);
                progressbar_reset();

            }
        }

        private void agregarPestañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "New Tab";
            tabControl1.Controls.Add(tab);
            tabControl1.SelectTab(tabControl1.TabCount - 1);
            webBrowser1 = new WebBrowser() { ScriptErrorsSuppressed = true };
            webBrowser1.Parent = tab;
            webBrowser1.Dock = DockStyle.Fill;
            webBrowser1.Navigate("www.google.com.do");
            webBrowser1.DocumentCompleted += WebBrowser_DocumentCompleted;

        }

        private void quitarPestañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount == 1)
            {
                MessageBox.Show("No puedes borrar la unica pestaña que tienes");
            }

            else
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.toolStripProgressBar1.Increment(5);
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
        }

        /*private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                toolStripProgressBar1.Value = Convert.ToInt32(e.CurrentProgress);
                toolStripProgressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);

            }
            catch { }
        }*/
    }
}
