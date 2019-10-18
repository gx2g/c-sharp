using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace ComboMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // This is out close button.
        private void closeBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        // This is our first import button.
        private void imprtBTN1_Click(object sender, EventArgs e)
        {
            var import = new OpenFileDialog();

            if (import.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] allLines = System.IO.File.ReadAllLines(import.FileName);

                listBox1.Items.AddRange(allLines);
            }
        }

        // This is our second import button.
        private void imprtBTN2_Click(object sender, EventArgs e)
        {
            var import = new OpenFileDialog();

            if (import.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] allLines = System.IO.File.ReadAllLines(import.FileName);

                listBox2.Items.AddRange(allLines);
            }
        }

        // This is our save list button
        private void saveBTN_Click(object sender, EventArgs e)
        {
            var save = new SaveFileDialog();

            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamWriter sWriter;
                sWriter = new System.IO.StreamWriter(save.FileName);

                for (var i = 0; i <= listBox3.Items.Count; i++)

                    sWriter.WriteLine(listBox3.Items.IndexOf(i));

                sWriter.Close();
            }
        }

        // This is our create list button.
        private void createBTN_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
                MessageBox.Show("No usernames.");
            else if (listBox2.Items.Count == 0)
                MessageBox.Show("No passwords.");
            else
                makeList();
        }

        public void makeList()
        {
            for (var i = 0; i <= listBox1.Items.Count; i++)
            {
                for (var o = 0; o <= listBox2.Items.Count; o++)

                    listBox3.Items.Add(listBox1.Items.IndexOf(i) + ":" + listBox2.Items.IndexOf(o));

                label2.Text = listBox3.Items.ToString();
            }
        }
    }
}
