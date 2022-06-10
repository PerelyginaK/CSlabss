namespace AutoForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.classBox = new System.Windows.Forms.ComboBox();
            this.methodBox = new System.Windows.Forms.ComboBox();
            this.propertyBox = new System.Windows.Forms.ListBox();
            this.paramBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.enterParamButton = new System.Windows.Forms.Button();
            this.doMethodButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Класс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(407, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выбор метода";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Свойства объекта класса";
            // 
            // classBox
            // 
            this.classBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.classBox.FormattingEnabled = true;
            this.classBox.Location = new System.Drawing.Point(36, 59);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(344, 33);
            this.classBox.TabIndex = 3;
            this.classBox.SelectedIndexChanged += new System.EventHandler(this.classBox_SelectedIndexChanged);
            // 
            // methodBox
            // 
            this.methodBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.methodBox.FormattingEnabled = true;
            this.methodBox.Location = new System.Drawing.Point(407, 59);
            this.methodBox.Name = "methodBox";
            this.methodBox.Size = new System.Drawing.Size(336, 33);
            this.methodBox.TabIndex = 4;
            this.methodBox.SelectedIndexChanged += new System.EventHandler(this.methodBox_SelectedIndexChanged);
            // 
            // propertyBox
            // 
            this.propertyBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.propertyBox.FormattingEnabled = true;
            this.propertyBox.ItemHeight = 21;
            this.propertyBox.Location = new System.Drawing.Point(36, 149);
            this.propertyBox.Name = "propertyBox";
            this.propertyBox.Size = new System.Drawing.Size(344, 151);
            this.propertyBox.TabIndex = 5;
            // 
            // paramBox
            // 
            this.paramBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paramBox.FormattingEnabled = true;
            this.paramBox.ItemHeight = 21;
            this.paramBox.Location = new System.Drawing.Point(407, 149);
            this.paramBox.Name = "paramBox";
            this.paramBox.Size = new System.Drawing.Size(336, 151);
            this.paramBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(407, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Параметры метода";
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createButton.Location = new System.Drawing.Point(38, 321);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(222, 99);
            this.createButton.TabIndex = 8;
            this.createButton.Text = "Создать объект класса";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // enterParamButton
            // 
            this.enterParamButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterParamButton.Location = new System.Drawing.Point(283, 321);
            this.enterParamButton.Name = "enterParamButton";
            this.enterParamButton.Size = new System.Drawing.Size(222, 99);
            this.enterParamButton.TabIndex = 9;
            this.enterParamButton.Text = "Ввести параметры метода";
            this.enterParamButton.UseVisualStyleBackColor = true;
            this.enterParamButton.Click += new System.EventHandler(this.enterParamButton_Click);
            // 
            // doMethodButton
            // 
            this.doMethodButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.doMethodButton.Location = new System.Drawing.Point(521, 321);
            this.doMethodButton.Name = "doMethodButton";
            this.doMethodButton.Size = new System.Drawing.Size(222, 99);
            this.doMethodButton.TabIndex = 10;
            this.doMethodButton.Text = "Выполнить метод";
            this.doMethodButton.UseVisualStyleBackColor = true;
            this.doMethodButton.Click += new System.EventHandler(this.doMethodButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doMethodButton);
            this.Controls.Add(this.enterParamButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.paramBox);
            this.Controls.Add(this.propertyBox);
            this.Controls.Add(this.methodBox);
            this.Controls.Add(this.classBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox classBox;
        private ComboBox methodBox;
        private ListBox propertyBox;
        private ListBox paramBox;
        private Label label4;
        private Button createButton;
        private Button enterParamButton;
        private Button doMethodButton;
    }
}