using AutoModel;

namespace AutoForm
{
    public partial class Form1 : Form
    {
        Tram tram = new Tram();
        public Form1(IAuto auto)
        {
            InitializeComponent();
            if (auto is Tram)
            {
                tram = auto as Tram;
                UpdateData();
            }
        }

        private void UpdateData()
        {
            nameBox.Text = tram.Name;
            quallityBox.Text = tram.Quallity().ToString();
            speedBox.Text = tram.MaxSpeed.ToString();
            kmBox.Text = tram.Mileage.ToString();
            colorBox.Text = tram.Color;
            condBox.Text = tram.Condition.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void upgradeButton_Click(object sender, EventArgs e)
        {
            tram.Update();
            UpdateData();
        }

        private void degradeButton_Click(object sender, EventArgs e)
        {
            tram.Degrade();
            UpdateData();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            tram.Go();
            UpdateData();
        }

        private void repairButton_Click(object sender, EventArgs e)
        {
            tram.Repair();
            UpdateData();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            tram.Color = colorBox.Text;
            tram.Condition = double.Parse(condBox.Text);
            tram.MaxSpeed = int.Parse(speedBox.Text);
            tram.Name = nameBox.Text;
            tram.Mileage = double.Parse(kmBox.Text);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}