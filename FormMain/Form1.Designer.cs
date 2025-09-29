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
            simpleListBox = new ListBox();
            fibbListBox = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            maxTb = new TextBox();
            minTb = new TextBox();
            labelTextMax = new Label();
            labelTextMin = new Label();
            startSimpleBtn = new Button();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            fibMaxLb = new Label();
            fibMinLb = new Label();
            startFibbonachiBtn = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pauseSimpl = new Button();
            simpleContinue = new Button();
            simpleStop = new Button();
            simpleRestart = new Button();
            groupBox4 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            fibbPause = new Button();
            fibbContinue = new Button();
            fibbStop = new Button();
            fibbRestart = new Button();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // simpleListBox
            // 
            simpleListBox.BorderStyle = BorderStyle.FixedSingle;
            simpleListBox.Dock = DockStyle.Top;
            simpleListBox.ItemHeight = 15;
            simpleListBox.Location = new Point(3, 19);
            simpleListBox.MultiColumn = true;
            simpleListBox.Name = "simpleListBox";
            simpleListBox.SelectionMode = SelectionMode.None;
            simpleListBox.Size = new Size(379, 332);
            simpleListBox.TabIndex = 0;
            // 
            // fibbListBox
            // 
            fibbListBox.Dock = DockStyle.Top;
            fibbListBox.ItemHeight = 15;
            fibbListBox.Location = new Point(3, 19);
            fibbListBox.MultiColumn = true;
            fibbListBox.Name = "fibbListBox";
            fibbListBox.Size = new Size(366, 334);
            fibbListBox.TabIndex = 0;
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
            tableLayoutPanel1.Size = new Size(769, 124);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maxTb);
            groupBox1.Controls.Add(minTb);
            groupBox1.Controls.Add(labelTextMax);
            groupBox1.Controls.Add(labelTextMin);
            groupBox1.Controls.Add(startSimpleBtn);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 118);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // maxTb
            // 
            maxTb.Location = new Point(137, 53);
            maxTb.Name = "maxTb";
            maxTb.Size = new Size(223, 23);
            maxTb.TabIndex = 9;
            // 
            // minTb
            // 
            minTb.Location = new Point(137, 26);
            minTb.Name = "minTb";
            minTb.Size = new Size(223, 23);
            minTb.TabIndex = 10;
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
            // labelTextMin
            // 
            labelTextMin.AutoSize = true;
            labelTextMin.Location = new Point(20, 29);
            labelTextMin.Name = "labelTextMin";
            labelTextMin.Size = new Size(99, 15);
            labelTextMin.TabIndex = 3;
            labelTextMin.Text = "Нижняя граница";
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
            startSimpleBtn.Click += startSimpleBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(fibMaxLb);
            groupBox2.Controls.Add(fibMinLb);
            groupBox2.Controls.Add(startFibbonachiBtn);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(394, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(372, 118);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(139, 53);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(223, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(139, 26);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(223, 23);
            textBox4.TabIndex = 8;
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
            startFibbonachiBtn.Click += startFibbonachiBtn_Click;
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
            tableLayoutPanel2.Size = new Size(769, 401);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(flowLayoutPanel2);
            groupBox3.Controls.Add(simpleListBox);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(385, 395);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Простые числа";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(pauseSimpl);
            flowLayoutPanel2.Controls.Add(simpleContinue);
            flowLayoutPanel2.Controls.Add(simpleStop);
            flowLayoutPanel2.Controls.Add(simpleRestart);
            flowLayoutPanel2.Dock = DockStyle.Bottom;
            flowLayoutPanel2.Location = new Point(3, 353);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(379, 39);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // pauseSimpl
            // 
            pauseSimpl.BackColor = SystemColors.ButtonFace;
            pauseSimpl.FlatAppearance.BorderColor = Color.Gray;
            pauseSimpl.FlatStyle = FlatStyle.Flat;
            pauseSimpl.Location = new Point(3, 3);
            pauseSimpl.Name = "pauseSimpl";
            pauseSimpl.Size = new Size(86, 23);
            pauseSimpl.TabIndex = 0;
            pauseSimpl.Text = "Пауза";
            pauseSimpl.UseVisualStyleBackColor = false;
            pauseSimpl.Click += pauseSimpl_Click;
            // 
            // simpleContinue
            // 
            simpleContinue.BackColor = SystemColors.ButtonFace;
            simpleContinue.FlatAppearance.BorderColor = Color.Gray;
            simpleContinue.FlatStyle = FlatStyle.Flat;
            simpleContinue.Location = new Point(95, 3);
            simpleContinue.Name = "simpleContinue";
            simpleContinue.Size = new Size(97, 23);
            simpleContinue.TabIndex = 1;
            simpleContinue.Text = "Продолжить";
            simpleContinue.UseVisualStyleBackColor = false;
            // 
            // simpleStop
            // 
            simpleStop.BackColor = SystemColors.ButtonFace;
            simpleStop.FlatAppearance.BorderColor = Color.Gray;
            simpleStop.FlatStyle = FlatStyle.Flat;
            simpleStop.Location = new Point(198, 3);
            simpleStop.Name = "simpleStop";
            simpleStop.Size = new Size(77, 23);
            simpleStop.TabIndex = 2;
            simpleStop.Text = "Стоп";
            simpleStop.UseVisualStyleBackColor = false;
            simpleStop.Click += simpleStop_Click;
            // 
            // simpleRestart
            // 
            simpleRestart.BackColor = SystemColors.ButtonFace;
            simpleRestart.FlatAppearance.BorderColor = Color.Gray;
            simpleRestart.FlatStyle = FlatStyle.Flat;
            simpleRestart.Location = new Point(281, 3);
            simpleRestart.Name = "simpleRestart";
            simpleRestart.Size = new Size(95, 23);
            simpleRestart.TabIndex = 3;
            simpleRestart.Text = "Перезапуск";
            simpleRestart.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(flowLayoutPanel1);
            groupBox4.Controls.Add(fibbListBox);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(394, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(372, 395);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Числа Фиббоначи";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(fibbPause);
            flowLayoutPanel1.Controls.Add(fibbContinue);
            flowLayoutPanel1.Controls.Add(fibbStop);
            flowLayoutPanel1.Controls.Add(fibbRestart);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(3, 353);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(366, 39);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // fibbPause
            // 
            fibbPause.BackColor = SystemColors.ButtonFace;
            fibbPause.FlatAppearance.BorderColor = Color.Gray;
            fibbPause.FlatStyle = FlatStyle.Flat;
            fibbPause.Location = new Point(3, 3);
            fibbPause.Name = "fibbPause";
            fibbPause.Size = new Size(85, 23);
            fibbPause.TabIndex = 4;
            fibbPause.Text = "Пауза";
            fibbPause.UseVisualStyleBackColor = false;
            // 
            // fibbContinue
            // 
            fibbContinue.BackColor = SystemColors.ButtonFace;
            fibbContinue.FlatAppearance.BorderColor = Color.Gray;
            fibbContinue.FlatStyle = FlatStyle.Flat;
            fibbContinue.Location = new Point(94, 3);
            fibbContinue.Name = "fibbContinue";
            fibbContinue.Size = new Size(91, 23);
            fibbContinue.TabIndex = 5;
            fibbContinue.Text = "Продолжить";
            fibbContinue.UseVisualStyleBackColor = false;
            // 
            // fibbStop
            // 
            fibbStop.BackColor = SystemColors.ButtonFace;
            fibbStop.FlatAppearance.BorderColor = Color.Gray;
            fibbStop.FlatStyle = FlatStyle.Flat;
            fibbStop.Location = new Point(191, 3);
            fibbStop.Name = "fibbStop";
            fibbStop.Size = new Size(80, 23);
            fibbStop.TabIndex = 6;
            fibbStop.Text = "Стоп";
            fibbStop.UseVisualStyleBackColor = false;
            // 
            // fibbRestart
            // 
            fibbRestart.BackColor = SystemColors.ButtonFace;
            fibbRestart.FlatAppearance.BorderColor = Color.Gray;
            fibbRestart.FlatStyle = FlatStyle.Flat;
            fibbRestart.Location = new Point(277, 3);
            fibbRestart.Name = "fibbRestart";
            fibbRestart.Size = new Size(85, 23);
            fibbRestart.TabIndex = 7;
            fibbRestart.Text = "Перезапуск";
            fibbRestart.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 525);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
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
        private Button startFibbonachiBtn;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button pauseSimpl;
        private Button simpleContinue;
        private Button simpleStop;
        private Button simpleRestart;
        private ListBox simpleListBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private ListBox fibbListBox;
        private Label fibMaxLb;
        private Label fibMinLb;
        private TextBox maxTb;
        private TextBox minTb;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button fibbPause;
        private Button fibbContinue;
        private Button fibbStop;
        private Button fibbRestart;
    }
}
