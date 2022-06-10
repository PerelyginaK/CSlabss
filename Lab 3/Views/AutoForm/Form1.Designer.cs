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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.speedBox = new System.Windows.Forms.TextBox();
            this.kmBox = new System.Windows.Forms.TextBox();
            this.condBox = new System.Windows.Forms.TextBox();
            this.colorBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.quallityBox = new System.Windows.Forms.TextBox();
            this.upgradeButton = new System.Windows.Forms.Button();
            this.degradeButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.repairButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Марка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Максимальная скорость";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Киллометраж";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Состояние";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Цвет";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(261, 24);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(166, 33);
            this.nameBox.TabIndex = 5;
            // 
            // speedBox
            // 
            this.speedBox.Location = new System.Drawing.Point(261, 80);
            this.speedBox.Multiline = true;
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(166, 33);
            this.speedBox.TabIndex = 6;
            // 
            // kmBox
            // 
            this.kmBox.Location = new System.Drawing.Point(261, 137);
            this.kmBox.Multiline = true;
            this.kmBox.Name = "kmBox";
            this.kmBox.Size = new System.Drawing.Size(166, 33);
            this.kmBox.TabIndex = 7;
            // 
            // condBox
            // 
            this.condBox.Location = new System.Drawing.Point(261, 197);
            this.condBox.Multiline = true;
            this.condBox.Name = "condBox";
            this.condBox.Size = new System.Drawing.Size(166, 33);
            this.condBox.TabIndex = 8;
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(261, 254);
            this.colorBox.Multiline = true;
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(166, 33);
            this.colorBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(22, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Качество";
            // 
            // quallityBox
            // 
            this.quallityBox.Location = new System.Drawing.Point(261, 311);
            this.quallityBox.Multiline = true;
            this.quallityBox.Name = "quallityBox";
            this.quallityBox.Size = new System.Drawing.Size(166, 33);
            this.quallityBox.TabIndex = 11;
            this.quallityBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // upgradeButton
            // 
            this.upgradeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.upgradeButton.Location = new System.Drawing.Point(520, 19);
            this.upgradeButton.Name = "upgradeButton";
            this.upgradeButton.Size = new System.Drawing.Size(169, 43);
            this.upgradeButton.TabIndex = 12;
            this.upgradeButton.Text = "Улучшить двигатель";
            this.upgradeButton.UseVisualStyleBackColor = true;
            this.upgradeButton.Click += new System.EventHandler(this.upgradeButton_Click);
            // 
            // degradeButton
            // 
            this.degradeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.degradeButton.Location = new System.Drawing.Point(520, 90);
            this.degradeButton.Name = "degradeButton";
            this.degradeButton.Size = new System.Drawing.Size(169, 43);
            this.degradeButton.TabIndex = 13;
            this.degradeButton.Text = "Ухудшить двигатель";
            this.degradeButton.UseVisualStyleBackColor = true;
            this.degradeButton.Click += new System.EventHandler(this.degradeButton_Click);
            // 
            // goButton
            // 
            this.goButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goButton.Location = new System.Drawing.Point(520, 165);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(169, 43);
            this.goButton.TabIndex = 14;
            this.goButton.Text = "Ехать";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // repairButton
            // 
            this.repairButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.repairButton.Location = new System.Drawing.Point(520, 241);
            this.repairButton.Name = "repairButton";
            this.repairButton.Size = new System.Drawing.Size(169, 43);
            this.repairButton.TabIndex = 15;
            this.repairButton.Text = "Починить";
            this.repairButton.UseVisualStyleBackColor = true;
            this.repairButton.Click += new System.EventHandler(this.repairButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(520, 311);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(169, 43);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 385);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.repairButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.degradeButton);
            this.Controls.Add(this.upgradeButton);
            this.Controls.Add(this.quallityBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.condBox);
            this.Controls.Add(this.kmBox);
            this.Controls.Add(this.speedBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox nameBox;
        private TextBox speedBox;
        private TextBox kmBox;
        private TextBox condBox;
        private TextBox colorBox;
        private Label label6;
        private TextBox quallityBox;
        private Button upgradeButton;
        private Button degradeButton;
        private Button goButton;
        private Button repairButton;
        private Button saveButton;
    }
}