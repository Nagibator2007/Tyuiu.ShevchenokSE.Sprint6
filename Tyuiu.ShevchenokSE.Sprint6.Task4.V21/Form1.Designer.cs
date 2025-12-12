namespace Tyuiu.ShevchenokSE.Sprint6.Task4.V21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBoxUSL_SSE = new GroupBox();
            pictureBox_SSE = new PictureBox();
            groupBoxIn_SSE = new GroupBox();
            groupBoxOUT_SSE = new GroupBox();
            groupBox3 = new GroupBox();
            textBoxout_SSE = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labelst_SSE = new Label();
            labelEND_SSE = new Label();
            groupBoxUSL_SSE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_SSE).BeginInit();
            groupBoxIn_SSE.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUSL_SSE
            // 
            groupBoxUSL_SSE.Controls.Add(pictureBox_SSE);
            groupBoxUSL_SSE.Location = new Point(23, 26);
            groupBoxUSL_SSE.Name = "groupBoxUSL_SSE";
            groupBoxUSL_SSE.Size = new Size(688, 293);
            groupBoxUSL_SSE.TabIndex = 0;
            groupBoxUSL_SSE.TabStop = false;
            groupBoxUSL_SSE.Text = "Условие";
            // 
            // pictureBox_SSE
            // 
            pictureBox_SSE.BackgroundImage = (Image)resources.GetObject("pictureBox_SSE.BackgroundImage");
            pictureBox_SSE.Location = new Point(14, 43);
            pictureBox_SSE.Name = "pictureBox_SSE";
            pictureBox_SSE.Size = new Size(660, 229);
            pictureBox_SSE.TabIndex = 0;
            pictureBox_SSE.TabStop = false;
            // 
            // groupBoxIn_SSE
            // 
            groupBoxIn_SSE.Controls.Add(labelEND_SSE);
            groupBoxIn_SSE.Controls.Add(labelst_SSE);
            groupBoxIn_SSE.Controls.Add(textBox2);
            groupBoxIn_SSE.Controls.Add(textBox1);
            groupBoxIn_SSE.Location = new Point(746, 47);
            groupBoxIn_SSE.Name = "groupBoxIn_SSE";
            groupBoxIn_SSE.Size = new Size(431, 272);
            groupBoxIn_SSE.TabIndex = 1;
            groupBoxIn_SSE.TabStop = false;
            groupBoxIn_SSE.Text = "Ввод данных";
            // 
            // groupBoxOUT_SSE
            // 
            groupBoxOUT_SSE.Location = new Point(1223, 47);
            groupBoxOUT_SSE.Name = "groupBoxOUT_SSE";
            groupBoxOUT_SSE.Size = new Size(400, 272);
            groupBoxOUT_SSE.TabIndex = 2;
            groupBoxOUT_SSE.TabStop = false;
            groupBoxOUT_SSE.Text = "Управление";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxout_SSE);
            groupBox3.Location = new Point(23, 356);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1582, 200);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // textBoxout_SSE
            // 
            textBoxout_SSE.Location = new Point(14, 38);
            textBoxout_SSE.Multiline = true;
            textBoxout_SSE.Name = "textBoxout_SSE";
            textBoxout_SSE.Size = new Size(1562, 144);
            textBoxout_SSE.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(404, 39);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 212);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(404, 39);
            textBox2.TabIndex = 1;
            // 
            // labelst_SSE
            // 
            labelst_SSE.AutoSize = true;
            labelst_SSE.Location = new Point(21, 54);
            labelst_SSE.Name = "labelst_SSE";
            labelst_SSE.Size = new Size(134, 32);
            labelst_SSE.TabIndex = 2;
            labelst_SSE.Text = "Старт шага";
            // 
            // labelEND_SSE
            // 
            labelEND_SSE.AutoSize = true;
            labelEND_SSE.Location = new Point(21, 162);
            labelEND_SSE.Name = "labelEND_SSE";
            labelEND_SSE.Size = new Size(142, 32);
            labelEND_SSE.TabIndex = 3;
            labelEND_SSE.Text = "Конец шага";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1647, 595);
            Controls.Add(groupBox3);
            Controls.Add(groupBoxOUT_SSE);
            Controls.Add(groupBoxIn_SSE);
            Controls.Add(groupBoxUSL_SSE);
            Name = "Form1";
            Text = "Form1";
            groupBoxUSL_SSE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_SSE).EndInit();
            groupBoxIn_SSE.ResumeLayout(false);
            groupBoxIn_SSE.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUSL_SSE;
        private PictureBox pictureBox_SSE;
        private GroupBox groupBoxIn_SSE;
        private GroupBox groupBoxOUT_SSE;
        private GroupBox groupBox3;
        private Label labelEND_SSE;
        private Label labelst_SSE;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBoxout_SSE;
    }
}
