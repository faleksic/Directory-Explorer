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
                if (list.Length == 0)
                {
                    lbLista.Items.Add(indent + "Directory doesn't contain files!");
                    lbLista.ForeColor = Color.Red;
                }
                else
                {
                    lbLista.ForeColor = Color.Olive;
                    foreach (string value in list)
                    {
                        string val = value.Replace(tbPath.Text, "");
                        val = val.Replace("\\", "");
                        lbLista.Items.Add(indent + val);
                    }
                }
            }
            catch
            {
                indent += "   ";
                lbLista.Items.Add(indent + "Doesn't exist!");
                lbLista.ForeColor = Color.Red;
            }
        }

        private void btFavorite_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Public\WriteLines.txt";
            StreamWriter sw = File.CreateText(path);
            sw.WriteLine(tbPath.Text);
            foreach(var i in lbLista.SelectedItems)
            { 
                sw.WriteLine(i.ToString());
            }
            sw.Close();

        }
    }
}
