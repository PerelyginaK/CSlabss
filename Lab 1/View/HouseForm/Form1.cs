using HouseModel;
namespace HouseForm
{
    public partial class Form1 : Form
    {
        House House = new House() {
            Windows = new List<Window>()
            {
                new Window(),
                new Window(),
                new Window() {IsLocked = true, Name = "Окно, стеклянное"}
            },
            Doors = new List<Door>()
            {
                new Door(),
                new Door(),
                new Door() {IsLocked = true, Name = "Дверь, бронированная"}
            }
        };


        public Form1()
        {
            InitializeComponent();
            Update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                infoBox.Text = House.Doors[listBox1.SelectedIndex].ToString();
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                infoBox.Text = House.Windows[listBox2.SelectedIndex].ToString();
            }
        }

        private void openCloseAllButton_Click(object sender, EventArgs e)
        {
            if (House.Doors.Count != 0)
            {
                if (House.Doors[0].IsLocked)
                {
                    foreach (var item in House.Doors)
                    {
                        item.IsLocked = false;
                    }
                }
                else
                {
                    foreach (var item in House.Doors)
                    {
                        item.IsLocked = true;
                    }
                }
                Update();
            }
        }

        private void Update()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            foreach (var item in House.Doors)
            {
                listBox1.Items.Add(item.ToString());
            }

            foreach (var item in House.Windows)
            {
                listBox2.Items.Add(item.ToString());
            }
        }

        private void addDoorButton_Click(object sender, EventArgs e)
        {
            House.Doors.Add(new Door());
            Update();
        }

        private void addWindowButton_Click(object sender, EventArgs e)
        {
            House.Windows.Add(new Window());
            Update();
        }

        private void countDoorsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Количество дверей: " + House.Doors.Count);
        }

        private void countWindowsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Количество окон: " + House.Windows.Count);
        }

        private void closeOpenButton_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                House.Windows[listBox2.SelectedIndex].IsLocked = !House.Windows[listBox2.SelectedIndex].IsLocked;
            }
            else if (listBox1.SelectedIndex != -1)
            {
                House.Doors[listBox1.SelectedIndex].IsLocked = !House.Doors[listBox1.SelectedIndex].IsLocked;
            }
            Update();
        }
    }
}