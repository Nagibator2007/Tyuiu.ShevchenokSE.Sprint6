using System.IO;
using System.Resources;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.ShevchenokSE.Sprint6.Task0.V29
{
    partial class Form_SSE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SSE));
            fileSystemWatcher_SSE = new FileSystemWatcher();
            groupBox_SSE = new GroupBox();
            pictureBoxTask_SSE = new PictureBox();
            groupBoxinput_SSE = new GroupBox();
            groupBoxoUTPUT_SSE = new GroupBox();
            labelST_SSE = new Label();
            labelEND_SSE = new Label();
            textBoxoutput_SSE = new TextBox();
            textBoxSTVl_SSE = new TextBox();
            textBoxENVL_SSE = new TextBox();
            groupBoxUPR_SSE = new GroupBox();
            buttonSP_SSE = new Button();
            buttonST_SSE = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher_SSE).BeginInit();
            groupBox_SSE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_SSE).BeginInit();
            groupBoxinput_SSE.SuspendLayout();
            groupBoxoUTPUT_SSE.SuspendLayout();
            groupBoxUPR_SSE.SuspendLayout();
            SuspendLayout();
            // 
            // fileSystemWatcher_SSE
            // 
            fileSystemWatcher_SSE.EnableRaisingEvents = true;
            fileSystemWatcher_SSE.SynchronizingObject = this;
            // 
            // groupBox_SSE
            // 
            groupBox_SSE.Controls.Add(pictureBoxTask_SSE);
            groupBox_SSE.Location = new Point(22, 26);
            groupBox_SSE.Margin = new Padding(6);
            groupBox_SSE.Name = "groupBox_SSE";
            groupBox_SSE.Padding = new Padding(6);
            groupBox_SSE.Size = new Size(673, 397);
            groupBox_SSE.TabIndex = 0;
            groupBox_SSE.TabStop = false;
            groupBox_SSE.Text = "Условие";
            groupBox_SSE.Enter += groupBox1_Enter;
            // 
            // pictureBoxTask_SSE
            // 
            pictureBoxTask_SSE.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBoxTask_SSE.BackgroundImage");
            pictureBoxTask_SSE.Location = new Point(9, 41);
            pictureBoxTask_SSE.Name = "pictureBoxTask_SSE";
            pictureBoxTask_SSE.Size = new Size(638, 347);
            pictureBoxTask_SSE.TabIndex = 0;
            pictureBoxTask_SSE.TabStop = false;
            // 
            // groupBoxinput_SSE
            // 
            groupBoxinput_SSE.Controls.Add(textBoxENVL_SSE);
            groupBoxinput_SSE.Controls.Add(textBoxSTVl_SSE);
            groupBoxinput_SSE.Controls.Add(labelEND_SSE);
            groupBoxinput_SSE.Controls.Add(labelST_SSE);
            groupBoxinput_SSE.Location = new Point(31, 443);
            groupBoxinput_SSE.Name = "groupBoxinput_SSE";
            groupBoxinput_SSE.Size = new Size(400, 174);
            groupBoxinput_SSE.TabIndex = 1;
            groupBoxinput_SSE.TabStop = false;
            groupBoxinput_SSE.Text = "Ввод данных";
            // 
            // groupBoxoUTPUT_SSE
            // 
            groupBoxoUTPUT_SSE.Controls.Add(textBoxoutput_SSE);
            groupBoxoUTPUT_SSE.Location = new Point(744, 44);
            groupBoxoUTPUT_SSE.Name = "groupBoxoUTPUT_SSE";
            groupBoxoUTPUT_SSE.Size = new Size(674, 599);
            groupBoxoUTPUT_SSE.TabIndex = 1;
            groupBoxoUTPUT_SSE.TabStop = false;
            groupBoxoUTPUT_SSE.Text = "Вывод данных";
            // 
            // labelST_SSE
            // 
            labelST_SSE.AutoSize = true;
            labelST_SSE.Location = new Point(16, 45);
            labelST_SSE.Name = "labelST_SSE";
            labelST_SSE.Size = new Size(138, 32);
            labelST_SSE.TabIndex = 0;
            labelST_SSE.Text = "Старт Шага";
            labelST_SSE.Click += label1_Click;
            // 
            // labelEND_SSE
            // 
            labelEND_SSE.AutoSize = true;
            labelEND_SSE.Location = new Point(209, 45);
            labelEND_SSE.Name = "labelEND_SSE";
            labelEND_SSE.Size = new Size(142, 32);
            labelEND_SSE.TabIndex = 1;
            labelEND_SSE.Text = "Конец шага";
            // 
            // textBoxoutput_SSE
            // 
            textBoxoutput_SSE.Location = new Point(19, 47);
            textBoxoutput_SSE.Multiline = true;
            textBoxoutput_SSE.Name = "textBoxoutput_SSE";
            textBoxoutput_SSE.Size = new Size(632, 526);
            textBoxoutput_SSE.TabIndex = 0;
            textBoxoutput_SSE.TextChanged += textBoxoutput_SSE_TextChanged;
            // 
            // textBoxSTVl_SSE
            // 
            textBoxSTVl_SSE.Location = new Point(16, 99);
            textBoxSTVl_SSE.Name = "textBoxSTVl_SSE";
            textBoxSTVl_SSE.Size = new Size(138, 39);
            textBoxSTVl_SSE.TabIndex = 2;
            // 
            // textBoxENVL_SSE
            // 
            textBoxENVL_SSE.Location = new Point(209, 99);
            textBoxENVL_SSE.Name = "textBoxENVL_SSE";
            textBoxENVL_SSE.Size = new Size(149, 39);
            textBoxENVL_SSE.TabIndex = 3;
            // 
            // groupBoxUPR_SSE
            // 
            groupBoxUPR_SSE.Controls.Add(buttonST_SSE);
            groupBoxUPR_SSE.Controls.Add(buttonSP_SSE);
            groupBoxUPR_SSE.Location = new Point(447, 443);
            groupBoxUPR_SSE.Name = "groupBoxUPR_SSE";
            groupBoxUPR_SSE.Size = new Size(270, 174);
            groupBoxUPR_SSE.TabIndex = 2;
            groupBoxUPR_SSE.TabStop = false;
            groupBoxUPR_SSE.Text = "Управление";
            // 
            // buttonSP_SSE
            // 
            buttonSP_SSE.Location = new Point(150, 68);
            buttonSP_SSE.Name = "buttonSP_SSE";
            buttonSP_SSE.Size = new Size(98, 88);
            buttonSP_SSE.TabIndex = 0;
            buttonSP_SSE.Text = "Справка";
            buttonSP_SSE.UseVisualStyleBackColor = true;
            // 
            // buttonST_SSE
            // 
            buttonST_SSE.Location = new Point(25, 68);
            buttonST_SSE.Name = "buttonST_SSE";
            buttonST_SSE.Size = new Size(87, 88);
            buttonST_SSE.TabIndex = 1;
            buttonST_SSE.Text = "Выполнить";
            buttonST_SSE.UseVisualStyleBackColor = true;
            // 
            // Form_SSE
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 672);
            Controls.Add(groupBoxUPR_SSE);
            Controls.Add(groupBoxinput_SSE);
            Controls.Add(groupBoxoUTPUT_SSE);
            Controls.Add(groupBox_SSE);
            Margin = new Padding(6);
            Name = "Form_SSE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 21 | Шевченок С.Е.";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher_SSE).EndInit();
            groupBox_SSE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_SSE).EndInit();
            groupBoxinput_SSE.ResumeLayout(false);
            groupBoxinput_SSE.PerformLayout();
            groupBoxoUTPUT_SSE.ResumeLayout(false);
            groupBoxoUTPUT_SSE.PerformLayout();
            groupBoxUPR_SSE.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher_SSE;
        private GroupBox groupBox_SSE;
        private PictureBox pictureBoxTask_SSE;
        private GroupBox groupBoxinput_SSE;
        private GroupBox groupBoxoUTPUT_SSE;
        private Label labelEND_SSE;
        private Label labelST_SSE;
        private TextBox textBoxENVL_SSE;
        private TextBox textBoxSTVl_SSE;
        private TextBox textBoxoutput_SSE;
        private GroupBox groupBoxUPR_SSE;
        private Button buttonST_SSE;
        private Button buttonSP_SSE;
    }
}