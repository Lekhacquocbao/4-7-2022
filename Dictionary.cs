using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LoginForm.Properties
{
    public partial class Dictionary : Form
    {
        public static Dictionary<string, string> myDictionary = new Dictionary<string, string>();
        public Dictionary()
        {
            InitializeComponent();
        }

        private void Dictionary_Load(object sender, EventArgs e)
        {

        }
        private void btnLookUp_Click(object sender, EventArgs e)
        {
            if (tbLookUp.Text == "")
                MessageBox.Show("Please input a word");
            else if (tbLookUp.Text != "")
            {
                //string result;
                //myDictionary.TryGetValue(tbLookUp.Text, out result);
                //tbShow.Text = result;
                String[] a = File.ReadAllLines("C:\\Users\\Baole\\OneDrive - The University of Technology\\Desktop\\Word.txt");
                foreach (String s in a)
                {
                    string[] ss = s.Split('/');
                    if (tbLookUp.Text.Equals(ss[0]))
                    {
                        tbShow.Text = ss[1] + ", " + ss[2];
                    }
                }
            }
            else
                tbShow.Text = "Unknow!";

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbLookUp.Text = String.Empty;
            tbShow.Text = String.Empty;
        }
    }
}
