namespace HouseForm
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
            this.infoBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openCloseAllButton = new System.Windows.Forms.Button();
            this.closeOpenButton = new System.Windows.Forms.Button();
            this.countDoorsButton = new System.Windows.Forms.Button();
            this.countWindowsButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.addDoorButton = new System.Windows.Forms.Button();
            this.addWindowButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Двери в доме";
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(12, 466);
            this.infoBox.Multiline = true;
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(531, 109);
            this.infoBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Информация о выбранном объекте";
            // 
            // openCloseAllButton
            // 
            this.openCloseAllButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openCloseAllButton.Location = new System.Drawing.Point(796, 87);
            this.openCloseAllButton.Name = "openCloseAllButton";
            this.openCloseAllButton.Size = new System.Drawing.Size(233, 61);
            this.openCloseAllButton.TabIndex = 4;
            this.openCloseAllButton.Text = "Закрыть/Открыть двери";
            this.openCloseAllButton.UseVisualStyleBackColor = true;
            this.openCloseAllButton.Click += new System.EventHandler(this.openCloseAllButton_Click);
            // 
            // closeOpenButton
            // 
            this.closeOpenButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeOpenButton.Location = new System.Drawing.Point(796, 503);
            this.closeOpenButton.Name = "closeOpenButton";
            this.closeOpenButton.Size = new System.Drawing.Size(233, 61);
            this.closeOpenButton.TabIndex = 5;
            this.closeOpenButton.Text = "Закрыть/Открыть выбранный объект";
            this.closeOpenButton.UseVisualStyleBackColor = true;
            this.closeOpenButton.Click += new System.EventHandler(this.closeOpenButton_Click);
            // 
            // countDoorsButton
            // 
            this.countDoorsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countDoorsButton.Location = new System.Drawing.Point(796, 164);
            this.countDoorsButton.Name = "countDoorsButton";
            this.countDoorsButton.Size = new System.Drawing.Size(233, 61);
            this.countDoorsButton.TabIndex = 6;
            this.countDoorsButton.Text = "Узнать количество дверей";
            this.countDoorsButton.UseVisualStyleBackColor = true;
            this.countDoorsButton.Click += new System.EventHandler(this.countDoorsButton_Click);
            // 
            // countWindowsButton
            // 
            this.countWindowsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countWindowsButton.Location = new System.Drawing.Point(796, 244);
            this.countWindowsButton.Name = "countWindowsButton";
            this.countWindowsButton.Size = new System.Drawing.Size(233, 61);
            this.countWindowsButton.TabIndex = 7;
            this.countWindowsButton.Text = "Узнать количество окон";
            this.countWindowsButton.UseVisualStyleBackColor = true;
            this.countWindowsButton.Click += new System.EventHandler(this.countWindowsButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(392, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Окна в доме";
            // 
            // addDoorButton
            // 
            this.addDoorButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addDoorButton.Location = new System.Drawing.Point(796, 334);
            this.addDoorButton.Name = "addDoorButton";
            this.addDoorButton.Size = new System.Drawing.Size(233, 61);
            this.addDoorButton.TabIndex = 10;
            this.addDoorButton.Text = "Добавить дверь";
            this.addDoorButton.UseVisualStyleBackColor = true;
            this.addDoorButton.Click += new System.EventHandler(this.addDoorButton_Click);
            // 
            // addWindowButton
            // 
            this.addWindowButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addWindowButton.Location = new System.Drawing.Point(796, 414);
            this.addWindowButton.Name = "addWindowButton";
            this.addWindowButton.Size = new System.Drawing.Size(233, 61);
            this.addWindowButton.TabIndex = 11;
            this.addWindowButton.Text = "Добавить окно";
            this.addWindowButton.UseVisualStyleBackColor = true;
            this.addWindowButton.Click += new System.EventHandler(this.addWindowButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(331, 304);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(396, 87);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(351, 304);
            this.listBox2.TabIndex = 13;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 589);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.addWindowButton);
            this.Controls.Add(this.addDoorButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countWindowsButton);
            this.Controls.Add(this.countDoorsButton);
            this.Controls.Add(this.closeOpenButton);
            this.Controls.Add(this.openCloseAllButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private TextBox infoBox;
        private Label label2;
        private Button openCloseAllButton;
        private Button closeOpenButton;
        private Button countDoorsButton;
        private Button countWindowsButton;
        private Label label3;
        private Button addDoorButton;
        private Button addWindowButton;
        private ListBox listBox1;
        private ListBox listBox2;
    }
}