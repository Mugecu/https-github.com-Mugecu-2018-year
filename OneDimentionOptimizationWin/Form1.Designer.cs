namespace OneDimentionOptimizationWin
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MonteCarloRadioBtn = new System.Windows.Forms.RadioButton();
            this.GoldenRadioBtn = new System.Windows.Forms.RadioButton();
            this.FunctionTxtBx = new System.Windows.Forms.TextBox();
            this.DichotomyMethodRadioBtn = new System.Windows.Forms.RadioButton();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.D_TxtBx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.E_TextBx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.B_TextBx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.A_TextBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OutputDataList = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.IterationTxtBx = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1127, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IterationTxtBx);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.MonteCarloRadioBtn);
            this.groupBox1.Controls.Add(this.GoldenRadioBtn);
            this.groupBox1.Controls.Add(this.FunctionTxtBx);
            this.groupBox1.Controls.Add(this.DichotomyMethodRadioBtn);
            this.groupBox1.Controls.Add(this.CalculateBtn);
            this.groupBox1.Controls.Add(this.D_TxtBx);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.E_TextBx);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.B_TextBx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.A_TextBx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1127, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных.";
            // 
            // MonteCarloRadioBtn
            // 
            this.MonteCarloRadioBtn.AutoSize = true;
            this.MonteCarloRadioBtn.Location = new System.Drawing.Point(587, 75);
            this.MonteCarloRadioBtn.Name = "MonteCarloRadioBtn";
            this.MonteCarloRadioBtn.Size = new System.Drawing.Size(163, 21);
            this.MonteCarloRadioBtn.TabIndex = 17;
            this.MonteCarloRadioBtn.TabStop = true;
            this.MonteCarloRadioBtn.Text = "Метод Монте-Карло";
            this.MonteCarloRadioBtn.UseVisualStyleBackColor = true;
            this.MonteCarloRadioBtn.CheckedChanged += new System.EventHandler(this.MonteCarloRadioBtn_CheckedChanged);
            // 
            // GoldenRadioBtn
            // 
            this.GoldenRadioBtn.AutoSize = true;
            this.GoldenRadioBtn.Location = new System.Drawing.Point(587, 48);
            this.GoldenRadioBtn.Name = "GoldenRadioBtn";
            this.GoldenRadioBtn.Size = new System.Drawing.Size(195, 21);
            this.GoldenRadioBtn.TabIndex = 16;
            this.GoldenRadioBtn.TabStop = true;
            this.GoldenRadioBtn.Text = "Метод Золотого сечения\r\n";
            this.GoldenRadioBtn.UseVisualStyleBackColor = true;
            this.GoldenRadioBtn.CheckedChanged += new System.EventHandler(this.GoldenRadioBtn_CheckedChanged);
            // 
            // FunctionTxtBx
            // 
            this.FunctionTxtBx.Location = new System.Drawing.Point(82, 24);
            this.FunctionTxtBx.Name = "FunctionTxtBx";
            this.FunctionTxtBx.Size = new System.Drawing.Size(228, 22);
            this.FunctionTxtBx.TabIndex = 15;
            // 
            // DichotomyMethodRadioBtn
            // 
            this.DichotomyMethodRadioBtn.AutoSize = true;
            this.DichotomyMethodRadioBtn.Location = new System.Drawing.Point(587, 21);
            this.DichotomyMethodRadioBtn.Name = "DichotomyMethodRadioBtn";
            this.DichotomyMethodRadioBtn.Size = new System.Drawing.Size(148, 21);
            this.DichotomyMethodRadioBtn.TabIndex = 12;
            this.DichotomyMethodRadioBtn.TabStop = true;
            this.DichotomyMethodRadioBtn.Text = "Метод Дихотомии";
            this.DichotomyMethodRadioBtn.UseVisualStyleBackColor = true;
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(973, 21);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(133, 82);
            this.CalculateBtn.TabIndex = 11;
            this.CalculateBtn.Text = "Подсчитать";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // D_TxtBx
            // 
            this.D_TxtBx.Location = new System.Drawing.Point(264, 84);
            this.D_TxtBx.Name = "D_TxtBx";
            this.D_TxtBx.Size = new System.Drawing.Size(69, 22);
            this.D_TxtBx.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Шаг(d):";
            // 
            // E_TextBx
            // 
            this.E_TextBx.Location = new System.Drawing.Point(129, 84);
            this.E_TextBx.Margin = new System.Windows.Forms.Padding(4);
            this.E_TextBx.Name = "E_TextBx";
            this.E_TextBx.Size = new System.Drawing.Size(68, 22);
            this.E_TextBx.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Погрешность(e):";
            // 
            // B_TextBx
            // 
            this.B_TextBx.Location = new System.Drawing.Point(255, 53);
            this.B_TextBx.Margin = new System.Windows.Forms.Padding(4);
            this.B_TextBx.Name = "B_TextBx";
            this.B_TextBx.Size = new System.Drawing.Size(55, 22);
            this.B_TextBx.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "a:";
            // 
            // A_TextBx
            // 
            this.A_TextBx.Location = new System.Drawing.Point(172, 53);
            this.A_TextBx.Margin = new System.Windows.Forms.Padding(4);
            this.A_TextBx.Name = "A_TextBx";
            this.A_TextBx.Size = new System.Drawing.Size(47, 22);
            this.A_TextBx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Отрезок неопред.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Функция:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OutputDataList);
            this.groupBox2.Location = new System.Drawing.Point(0, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 304);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выходные данные.";
            // 
            // OutputDataList
            // 
            this.OutputDataList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.OutputDataList.Location = new System.Drawing.Point(7, 22);
            this.OutputDataList.Name = "OutputDataList";
            this.OutputDataList.Size = new System.Drawing.Size(342, 276);
            this.OutputDataList.TabIndex = 0;
            this.OutputDataList.UseCompatibleStateImageBehavior = false;
            this.OutputDataList.View = System.Windows.Forms.View.List;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "К-во итераций:";
            // 
            // IterationTxtBx
            // 
            this.IterationTxtBx.Location = new System.Drawing.Point(430, 24);
            this.IterationTxtBx.Name = "IterationTxtBx";
            this.IterationTxtBx.Size = new System.Drawing.Size(53, 22);
            this.IterationTxtBx.TabIndex = 19;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Координаты точки";
            this.columnHeader1.Width = 240;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 466);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "OneDimentionOptimization";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox E_TextBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox B_TextBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox A_TextBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox D_TxtBx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.RadioButton DichotomyMethodRadioBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView OutputDataList;
        private System.Windows.Forms.TextBox FunctionTxtBx;
        private System.Windows.Forms.RadioButton GoldenRadioBtn;
        private System.Windows.Forms.RadioButton MonteCarloRadioBtn;
        private System.Windows.Forms.TextBox IterationTxtBx;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

