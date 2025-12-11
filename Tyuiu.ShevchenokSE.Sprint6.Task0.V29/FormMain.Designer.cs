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
            fileSystemWatcher_SSE = new FileSystemWatcher();
            groupBox_SSE = new GroupBox();
            textBox_SSE = new TextBox();
            groupBox_2_SSE = new GroupBox();
            textBox_2_SSE = new TextBox();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher_SSE).BeginInit();
            groupBox_SSE.SuspendLayout();
            SuspendLayout();
            // 
            // fileSystemWatcher_SSE
            // 
            fileSystemWatcher_SSE.EnableRaisingEvents = true;
            fileSystemWatcher_SSE.SynchronizingObject = this;
            // 
            // groupBox_SSE
            // 
            groupBox_SSE.Controls.Add(textBox_SSE);
            groupBox_SSE.Location = new Point(22, 26);
            groupBox_SSE.Margin = new Padding(6, 6, 6, 6);
            groupBox_SSE.Name = "groupBox_SSE";
            groupBox_SSE.Padding = new Padding(6, 6, 6, 6);
            groupBox_SSE.Size = new Size(1441, 320);
            groupBox_SSE.TabIndex = 0;
            groupBox_SSE.TabStop = false;
            groupBox_SSE.Text = "Условие";
            groupBox_SSE.Enter += groupBox1_Enter;
            // 
            // textBox_SSE
            // 
            textBox_SSE.Enabled = false;
            textBox_SSE.Font = new System.Drawing.Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_SSE.Location = new Point(0, 44);
            textBox_SSE.Margin = new Padding(6, 6, 6, 6);
            textBox_SSE.Multiline = true;
            textBox_SSE.Name = "textBox_SSE";
            textBox_SSE.ReadOnly = true;
            textBox_SSE.Size = new Size(991, 279);
            textBox_SSE.TabIndex = 1;
            textBox_SSE.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Округлить до трёх знаков после запятой. Графический интерфейс оформить по шаблону из лекции.";
            textBox_SSE.TextChanged += textBox1_TextChanged;
            // 
            // groupBox_2_SSE
            // 
            groupBox_2_SSE.Location = new Point(15, 310);
            groupBox_2_SSE.Margin = new Padding(6, 6, 6, 6);
            groupBox_2_SSE.Name = "groupBox_2_SSE";
            groupBox_2_SSE.Padding = new Padding(6, 6, 6, 6);
            groupBox_2_SSE.Size = new Size(1430, 72);
            groupBox_2_SSE.TabIndex = 1;
            groupBox_2_SSE.TabStop = false;
            groupBox_2_SSE.Text = "Результат";
            groupBox_2_SSE.Enter += groupBox2_Enter;
            // 
            // textBox_2_SSE
            // 
            textBox_2_SSE.Font = new System.Drawing.Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_2_SSE.Location = new Point(22, 394);
            textBox_2_SSE.Margin = new Padding(6, 6, 6, 6);
            textBox_2_SSE.Name = "textBox_2_SSE";
            textBox_2_SSE.ReadOnly = true;
            textBox_2_SSE.Size = new Size(1404, 58);
            textBox_2_SSE.TabIndex = 0;
            textBox_2_SSE.TextAlign = HorizontalAlignment.Center;
            // 
            // Form_SSE
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(textBox_2_SSE);
            Controls.Add(groupBox_2_SSE);
            Controls.Add(groupBox_SSE);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form_SSE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 29 | Шевченок С.Е.";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher_SSE).EndInit();
            groupBox_SSE.ResumeLayout(false);
            groupBox_SSE.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher_SSE;
        private GroupBox groupBox_SSE;
        private GroupBox groupBox_2_SSE;
        private TextBox textBox_SSE;
        private TextBox textBox_2_SSE;
    }
}