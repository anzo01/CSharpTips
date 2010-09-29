using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;

namespace SmoTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void c_DoItButton_Click(object sender, EventArgs e)
        {
            var server = new Server();
            c_ListBox.Items.Clear();
            foreach (Database database in server.Databases) {
                c_ListBox.Items.Add(database.Name);
            }
        }

        private void c_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var server = new Server();
            foreach (Database database in server.Databases)
            {
                if (database.Name == (string) c_ListBox.SelectedItem) {
                    textBox1.Lines = database.Script().Cast<string>().ToArray();
                    c_Tables.Items.Clear();
                    foreach (Table table in database.Tables) {
                        c_Tables.Items.Add(table.Name);
                    }
                    return;
                }
            }
        }

        private void c_Tables_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
