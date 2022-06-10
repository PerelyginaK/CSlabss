using NetworkModels;

namespace NetworkForm
{
    public partial class Form1 : Form
    {
        Network net;
        NetworkChild netChild;
        public Form1(Network network, NetworkChild networkChild)
        {
            InitializeComponent();
            net = network;
            netChild = networkChild;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = net.ToString();
            textBox2.Text = netChild.ToString();
        }

       
    }
}