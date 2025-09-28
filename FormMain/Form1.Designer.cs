namespace FormMain
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            minTb = new TextBox();
            maxTb = new TextBox();
            startSimpleBtn = new Button();
            startFibbonachiBtn = new Button();
            labelTextMin = new Label();
            labelTextMax = new Label();
            fibMaxLb = new Label();
            fibMinLb = new Label();
            minFibTb = new TextBox();
            maxFibTb = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.9727631F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.0272369F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(771, 124);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.9727631F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.0272369F));
            tableLayoutPanel2.Controls.Add(groupBox3, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox4, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 124);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(771, 401);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelTextMax);
            groupBox1.Controls.Add(labelTextMin);
            groupBox1.Controls.Add(minTb);
            groupBox1.Controls.Add(startSimpleBtn);
            groupBox1.Controls.Add(maxTb);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 118);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(fibMaxLb);
            groupBox2.Controls.Add(fibMinLb);
            groupBox2.Controls.Add(minFibTb);
            groupBox2.Controls.Add(maxFibTb);
            groupBox2.Controls.Add(startFibbonachiBtn);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(396, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(372, 118);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(flowLayoutPanel2);
            groupBox3.Controls.Add(listBox2);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(387, 395);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Простые числа";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(flowLayoutPanel1);
            groupBox4.Controls.Add(listBox1);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(396, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(372, 395);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Числа Фиббоначи";
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Top;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 19);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(366, 334);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.Dock = DockStyle.Top;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(3, 19);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(381, 334);
            listBox2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(3, 353);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(366, 39);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(button5);
            flowLayoutPanel2.Controls.Add(button6);
            flowLayoutPanel2.Controls.Add(button7);
            flowLayoutPanel2.Controls.Add(button8);
            flowLayoutPanel2.Dock = DockStyle.Bottom;
            flowLayoutPanel2.Location = new Point(3, 353);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(381, 39);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.FlatAppearance.BorderColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(85, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.FlatAppearance.BorderColor = Color.Gray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(94, 3);
            button2.Name = "button2";
            button2.Size = new Size(85, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.FlatAppearance.BorderColor = Color.Gray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(185, 3);
            button3.Name = "button3";
            button3.Size = new Size(85, 23);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.FlatAppearance.BorderColor = Color.Gray;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(276, 3);
            button4.Name = "button4";
            button4.Size = new Size(85, 23);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonFace;
            button5.FlatAppearance.BorderColor = Color.Gray;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(3, 3);
            button5.Name = "button5";
            button5.Size = new Size(87, 23);
            button5.TabIndex = 0;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonFace;
            button6.FlatAppearance.BorderColor = Color.Gray;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(96, 3);
            button6.Name = "button6";
            button6.Size = new Size(87, 23);
            button6.TabIndex = 1;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonFace;
            button7.FlatAppearance.BorderColor = Color.Gray;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(189, 3);
            button7.Name = "button7";
            button7.Size = new Size(87, 23);
            button7.TabIndex = 2;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ButtonFace;
            button8.FlatAppearance.BorderColor = Color.Gray;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(282, 3);
            button8.Name = "button8";
            button8.Size = new Size(96, 23);
            button8.TabIndex = 3;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = false;
            // 
            // minTb
            // 
            minTb.Location = new Point(140, 26);
            minTb.Name = "minTb";
            minTb.Size = new Size(220, 23);
            minTb.TabIndex = 0;
            // 
            // maxTb
            // 
            maxTb.Location = new Point(140, 53);
            maxTb.Name = "maxTb";
            maxTb.Size = new Size(220, 23);
            maxTb.TabIndex = 1;
            // 
            // startSimpleBtn
            // 
            startSimpleBtn.BackColor = SystemColors.ButtonFace;
            startSimpleBtn.FlatAppearance.BorderColor = Color.Gray;
            startSimpleBtn.FlatStyle = FlatStyle.Flat;
            startSimpleBtn.Location = new Point(20, 82);
            startSimpleBtn.Name = "startSimpleBtn";
            startSimpleBtn.Size = new Size(340, 23);
            startSimpleBtn.TabIndex = 2;
            startSimpleBtn.Text = "Запустить простые числа";
            startSimpleBtn.UseVisualStyleBackColor = false;
            // 
            // startFibbonachiBtn
            // 
            startFibbonachiBtn.BackColor = SystemColors.ButtonFace;
            startFibbonachiBtn.FlatAppearance.BorderColor = Color.Gray;
            startFibbonachiBtn.FlatStyle = FlatStyle.Flat;
            startFibbonachiBtn.Location = new Point(22, 82);
            startFibbonachiBtn.Name = "startFibbonachiBtn";
            startFibbonachiBtn.Size = new Size(340, 23);
            startFibbonachiBtn.TabIndex = 1;
            startFibbonachiBtn.Text = "Запустить Фиббоначи";
            startFibbonachiBtn.UseVisualStyleBackColor = false;
            // 
            // labelTextMin
            // 
            labelTextMin.AutoSize = true;
            labelTextMin.Location = new Point(20, 29);
            labelTextMin.Name = "labelTextMin";
            labelTextMin.Size = new Size(99, 15);
            labelTextMin.TabIndex = 3;
            labelTextMin.Text = "Нижняя граница";
            // 
            // labelTextMax
            // 
            labelTextMax.AutoSize = true;
            labelTextMax.Location = new Point(20, 56);
            labelTextMax.Name = "labelTextMax";
            labelTextMax.Size = new Size(100, 15);
            labelTextMax.TabIndex = 4;
            labelTextMax.Text = "Верхняя граница";
            // 
            // fibMaxLb
            // 
            fibMaxLb.AutoSize = true;
            fibMaxLb.Location = new Point(22, 56);
            fibMaxLb.Name = "fibMaxLb";
            fibMaxLb.Size = new Size(100, 15);
            fibMaxLb.TabIndex = 8;
            fibMaxLb.Text = "Верхняя граница";
            // 
            // fibMinLb
            // 
            fibMinLb.AutoSize = true;
            fibMinLb.Location = new Point(22, 29);
            fibMinLb.Name = "fibMinLb";
            fibMinLb.Size = new Size(99, 15);
            fibMinLb.TabIndex = 7;
            fibMinLb.Text = "Нижняя граница";
            // 
            // minFibTb
            // 
            minFibTb.Location = new Point(142, 26);
            minFibTb.Name = "minFibTb";
            minFibTb.Size = new Size(220, 23);
            minFibTb.TabIndex = 5;
            // 
            // maxFibTb
            // 
            maxFibTb.Location = new Point(142, 53);
            maxFibTb.Name = "maxFibTb";
            maxFibTb.Size = new Size(220, 23);
            maxFibTb.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 525);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label labelTextMax;
        private Label labelTextMin;
        private Button startSimpleBtn;
        private TextBox maxTb;
        private Button startFibbonachiBtn;
        private TextBox minTb;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private ListBox listBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListBox listBox1;
        private Label fibMaxLb;
        private Label fibMinLb;
        private TextBox minFibTb;
        private TextBox maxFibTb;
    }
}
