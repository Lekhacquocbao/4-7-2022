using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoginForm.Properties
{
    public partial class Translate : Form
    {
        public Translate()
        {
            InitializeComponent();
        }

        private void Translate_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            try
            {
                string url = String.Format("http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}", textBox1.Text, comboBox1.Text + "|" + comboBox2.Text);
                string result = webClient.DownloadString(url);
                int bas = result.IndexOf("TRANSLATED_TEXT='") + "TRANSLATED_TEXT='".Length;
                int bit = result.Substring(bas).IndexOf("';var");
                result = result.Substring(bas, bit);
                textBox2.Text = result.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
