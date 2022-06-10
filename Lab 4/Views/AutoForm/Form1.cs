using System.Reflection;
using AutoModel;

namespace AutoForm
{
    public partial class Form1 : Form
    {
        Assembly assembly;
        IEnumerable<Type> types;

        Type currentType;
        object currentObject;

        MethodInfo currentMethod;
        object[]? methodParameters;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            assembly = Assembly.Load("AutoModel");

            types = assembly.GetTypes()
                .Where(t => !t.IsAbstract && t.GetInterface("IAuto") != null);

            methodBox.Enabled = false;
            createButton.Enabled = false;
            enterParamButton.Enabled = false;
            doMethodButton.Enabled = false;

            classBox.Items.AddRange(types.Select(t => t.Name).ToArray());
        }

        private void classBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentType = types.First(t => t.Name == classBox.SelectedItem.ToString());

            methodBox.Enabled = true;
            createButton.Enabled = true;
            IEnumerable<string> objectMethods = (new object()).GetType().GetMethods().Select(method => method.Name);

            methodBox.Items.Clear();

            methodBox.Items.AddRange(currentType.GetMethods().Where(m => !objectMethods.Contains(m.Name)
                && m.Name.Substring(0, 4) != "get_"
                && m.Name.Substring(0, 4) != "set_")
                .Select(t => t.Name).ToArray());
        }

        private void methodBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerable<string> objectMethods = (new object()).GetType().GetMethods().Select(method => method.Name);

            currentMethod = currentType.GetMethods()
                .First( m => !objectMethods.Contains(m.Name)
                && m.Name.Substring(0, 4) != "get_"
                && m.Name.Substring(0, 4) != "set_"
                && m.Name == methodBox.SelectedItem.ToString());

            if (currentMethod.GetParameters().Length == 0)
            {
                methodParameters = null;
                enterParamButton.Enabled = false;
            }
            else
            {
                enterParamButton.Enabled = true;
            }

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            doMethodButton.Enabled = true;
            enterParamButton.Enabled = true;

            MessageBox.Show($"¬ведите объект класса" +
                $" {currentType.Name}");

            object newObject = Activator.CreateInstance(currentType);

            foreach (var it in newObject.GetType().GetProperties())
            {
                var form = CreateInputForm(it.Name);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    var a = form.Controls[1].Text;
                    if (it.PropertyType.Name == "Int32")
                    {
                        it.SetValue(newObject, Int32.Parse(a));
                    }
                    else if (it.PropertyType.Name == "Double")
                    {
                        it.SetValue(newObject, double.Parse(a));
                    }
                    else
                    {
                        it.SetValue(newObject, a);
                    }
                }
            }

            currentObject = newObject;
            UpdateClassInfo();
        }

        private void UpdateClassInfo()
        {
            propertyBox.Items.Clear();
            foreach (var item in currentType.GetProperties())
            {
                propertyBox.Items.Add(item.Name + ": " + item.GetValue(currentObject));
            }
        }
        private Form CreateInputForm(string name)
        {
            var form = new Form();
            form.ClientSize = new Size(150, 80);

            var label = new Label { Top = 0, Left = 0, Width = form.ClientSize.Width / 2, Height = 16 };
            label.Text = name;

            var textBox = new TextBox { Top = 0, Left = label.Width, Width = label.Width, Height = 16 };
            textBox.Text = "0";

            form.Controls.Add(label);
            form.Controls.Add(textBox);

            form.Controls.Add(new Button() { Top = 40, Left = 40, Width = 90, Height = 40, Text = "ќк" });
            form.Controls[form.Controls.Count - 1].Click
                += new EventHandler((object sender, EventArgs e) =>
                {
                    form.DialogResult = DialogResult.OK;
                    form.Hide();
                });

            return form;
        }

        private void enterParamButton_Click(object sender, EventArgs e)
        {
            if (methodBox.SelectedIndex != -1)
            {
                paramBox.Items.Clear();
                if (currentMethod.GetParameters().Length != 0)
                {
                    var listParam = new List<object>();
                    
                    foreach (var it in currentMethod.GetParameters())
                    {
                        var form = CreateInputForm(it.Name);

                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            var a = form.Controls[1].Text;
                            listParam.Add(int.Parse(a));
                            paramBox.Items.Add(form.Controls[0].Text + ": " + a);

                        }
                    }
                    methodParameters = listParam.Select(x => x).ToArray();
                    doMethodButton.Enabled = true;

                }
                else
                {
                    methodParameters = null;
                }
            }
        }

        private void doMethodButton_Click(object sender, EventArgs e)
        {
            if (methodBox.SelectedIndex != -1)
            {
                if (currentMethod.GetParameters().Length != 0 && methodParameters == null)
                {
                    MessageBox.Show("¬ведите параметры метода!");
                }
                else
                {
                    if (currentMethod.ReturnType == typeof(void))
                    {
                        currentMethod.Invoke(currentObject, methodParameters);
                    }
                    else
                    {
                        MessageBox.Show(currentMethod.Invoke(currentObject, methodParameters).ToString());
                    }

                    UpdateClassInfo();
                }
            }
            else
            {
                MessageBox.Show("—начала создайте объект и выберите метод");
            }
        }
    }
}