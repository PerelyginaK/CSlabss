using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoModel;
namespace AutoForm
{
    public partial class ListForm : Form
    {
        public List<IAuto> autoList = new List<IAuto>();

        public ListForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int selectedIndex = listBox1.SelectedIndex;
                Form1 editForm = new Form1(autoList[selectedIndex]);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.RemoveAt(selectedIndex);
                    listBox1.Items.Insert(selectedIndex, autoList[selectedIndex]);
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            IAuto newStudent = new Tram();
            Form1 editForm = new Form1(newStudent);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                autoList.Add(newStudent);
                listBox1.Items.Add(newStudent);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int selectedStudent = listBox1.SelectedIndex;
                autoList.RemoveAt(selectedStudent);
                listBox1.Items.RemoveAt(selectedStudent);
            }
        }
    }
}
