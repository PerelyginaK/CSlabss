using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetworkModels;
namespace NetworkForm
{
    public partial class EnterDataForm : Form
    {
        public EnterDataForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Network network = new Network(
                NameParentBox.Text,
                int.Parse(CountParentBox.Text),
                double.Parse(DistanceParentBox.Text));

            NetworkChild networkChild = new NetworkChild(
                NameChildBox.Text,
                int.Parse(CountChildBox.Text),
                double.Parse(DistanceChildBox.Text),
                double.Parse(SpeedChildBox.Text));

            Form1 form = new Form1(network, networkChild);
            form.ShowDialog();
            Close();
        }
    }   
}
