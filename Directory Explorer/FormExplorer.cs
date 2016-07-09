using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Directory_Explorer
{
    public partial class FormExplorer : Form
    {
        public FormExplorer()
        {
            InitializeComponent();
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            lbLista.Items.Clear();
            string[] input = tbPath.Text.Split('\\');
            string indent = "";
            foreach (string value in input)
            {
                if(value == "")
                {
                    continue;
                }
                lbLista.Items.Add(indent + value);
                indent += "   ";
            }
            try
            {
                string[] list = Directory.GetFiles(tbPath.Text);
                indent += "   ";
                foreach (string value in list)
                {
                    lbLista.Items.Add(indent + value.Replace(tbPath.Text, ""));
                }
            }
            catch
            {
                lbLista.Items.Add("Doesn't exist or empty!");
                lbLista.ForeColor = Color.Red;
            }
        }
    }
}
