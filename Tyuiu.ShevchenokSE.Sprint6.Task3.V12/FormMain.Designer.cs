namespace Tyuiu.ShevchenokSE.Sprint6.Task3.V12
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxResult_SSE = new GroupBox();
            buttonResult_SSE = new Button();
            dataGridViewResult_SSE = new DataGridView();
            dataGridViewSorted_SSE = new DataGridView();
            textBox_SSE = new TextBox();
            groupBoxResult_SSE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SSE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSorted_SSE).BeginInit();
            SuspendLayout();
            // 
            // groupBoxResult_SSE
            // 
            groupBoxResult_SSE.Controls.Add(textBox_SSE);
            groupBoxResult_SSE.Location = new Point(22, 26);
            groupBoxResult_SSE.Margin = new Padding(6, 6, 6, 6);
            groupBoxResult_SSE.Name = "groupBoxResult_SSE";
            groupBoxResult_SSE.Padding = new Padding(6, 6, 6, 6);
            groupBoxResult_SSE.Size = new Size(630, 642);
            groupBoxResult_SSE.TabIndex = 0;
            groupBoxResult_SSE.TabStop = false;
            groupBoxResult_SSE.Text = "Условие";
            // 
            // buttonResult_SSE
            // 
            buttonResult_SSE.Location = new Point(22, 681);
            buttonResult_SSE.Margin = new Padding(6, 6, 6, 6);
            buttonResult_SSE.Name = "buttonResult_SSE";
            buttonResult_SSE.Size = new Size(630, 141);
            buttonResult_SSE.TabIndex = 1;
            buttonResult_SSE.Text = "Выполнить";
            buttonResult_SSE.UseVisualStyleBackColor = true;
            buttonResult_SSE.Click += buttonResult_SSE_Click;
            // 
            // dataGridViewResult_SSE
            // 
            dataGridViewResult_SSE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_SSE.Location = new Point(676, 94);
            dataGridViewResult_SSE.Margin = new Padding(6, 6, 6, 6);
            dataGridViewResult_SSE.Name = "dataGridViewResult_SSE";
            dataGridViewResult_SSE.RowHeadersWidth = 82;
            dataGridViewResult_SSE.Size = new Size(446, 320);
            dataGridViewResult_SSE.TabIndex = 2;
            dataGridViewResult_SSE.CellContentClick += dataGridViewResult_KFA_CellContentClick;
            // 
            // dataGridViewSorted_SSE
            // 
            dataGridViewSorted_SSE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSorted_SSE.Location = new Point(676, 463);
            dataGridViewSorted_SSE.Margin = new Padding(6, 6, 6, 6);
            dataGridViewSorted_SSE.Name = "dataGridViewSorted_SSE";
            dataGridViewSorted_SSE.RowHeadersWidth = 82;
            dataGridViewSorted_SSE.Size = new Size(446, 320);
            dataGridViewSorted_SSE.TabIndex = 3;
            // 
            // textBox_SSE
            // 
            textBox_SSE.Location = new Point(9, 41);
            textBox_SSE.Multiline = true;
            textBox_SSE.Name = "textBox_SSE";
            textBox_SSE.Size = new Size(612, 578);
            textBox_SSE.TabIndex = 0;
            textBox_SSE.Text = resources.GetString("textBox_SSE.Text");
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 835);
            Controls.Add(dataGridViewSorted_SSE);
            Controls.Add(dataGridViewResult_SSE);
            Controls.Add(buttonResult_SSE);
            Controls.Add(groupBoxResult_SSE);
            Margin = new Padding(6, 6, 6, 6);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 12| Шевченок С.Е.";
            Load += FormMain_Load;
            groupBoxResult_SSE.ResumeLayout(false);
            groupBoxResult_SSE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SSE).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSorted_SSE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxResult_SSE;
        private Button buttonResult_SSE;
        private DataGridView dataGridViewResult_SSE;
        private DataGridView dataGridViewSorted_SSE;
        private TextBox textBox_SSE;
    }
}
