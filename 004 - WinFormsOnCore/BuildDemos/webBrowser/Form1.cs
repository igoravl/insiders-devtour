using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            try
            {
                this.Text += $" ({RuntimeInformation.FrameworkDescription.Substring(0, RuntimeInformation.FrameworkDescription.LastIndexOf(' '))})";
                InitializeComponent();
            }
            catch (NotSupportedException nse)
            {
                MessageBox.Show(nse.Message);
                this.ResumeLayout(false);
            }
        }

        private void UpdateUrl()
        {
            var text = this.navTextBox.Text;

            Uri url = null;

            if (!Uri.TryCreate(text, UriKind.Absolute, out url))
            {
                if (!Uri.TryCreate("http://" + text, UriKind.Absolute, out url))
                {
                    return;
                }
            }

            this.webBrowser1.Url = url;
            this.webView1.Navigate(url);

        }

        private void goButton_Click(object sender, EventArgs e)
        {
            UpdateUrl();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }
    }
}
