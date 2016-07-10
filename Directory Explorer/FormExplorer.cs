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
            addFavorite();
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            listPath();
        }

        private void listPath()
        {
            lbLista.Items.Clear();
            btFavorite.Enabled = true;
            string[] input = tbPath.Text.Split('\\');
            string indent = "";
            foreach (string value in input)
            {
                if (value == "")
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
                    btFavorite.Enabled = false;
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
                btFavorite.Enabled = false;
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

        private void addFavorite()
        {
            string line = "";
            try
            {
                StreamReader file = new StreamReader(@"C:\Users\Public\WriteLines.txt");
                line = file.ReadLine();
                if (line != null)
                {
                    tbPath.Text = line;
                    listPath();
                    int[] selectThis;
                    while ((line = file.ReadLine()) != null)
                    {
                        for (int i = 0; i < lbLista.Items.Count; i++)
                        {
                            if (line == lbLista.Items[i].ToString())
                            {
                                lbLista.SelectedIndex = i;
                            }
                        }
                    }
                }
                file.Close();
            }
            catch
            {
                MessageBox.Show("You don't have any favorite records so I am giving you a clean Start :).");
            }
        }
    }
}
