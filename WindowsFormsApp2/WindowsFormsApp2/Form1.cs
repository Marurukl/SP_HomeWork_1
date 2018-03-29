using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView.Columns.Add("Id");
            listView.Columns.Add("Name");
            listView.View = View.Details;
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            foreach (Process proc in Process.GetProcesses())
            {
                string[] s = new string[] { proc.Id.ToString(), proc.ProcessName };
                ListViewItem lvi = new ListViewItem(s);
                listView.Items.Add(lvi);
            }
        }
    }
}
