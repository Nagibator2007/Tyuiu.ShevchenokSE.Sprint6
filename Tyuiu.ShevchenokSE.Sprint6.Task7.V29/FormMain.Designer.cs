
namespace Tyuiu.ShevchenokSE.Sprint6.Task7.V29
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTopSide_SSE = new Panel();
            buttonHelp_SSE = new Button();
            buttonSave_SSE = new Button();
            buttonDone_SSE = new Button();
            buttonOpen_SSE = new Button();
            panelFill_SAH = new Panel();
            groupBoxOutPut_SSE = new GroupBox();
            dataGridOutPut_SSE = new DataGridView();
            groupBoxInput_SSE = new GroupBox();
            dataGridInput_SSE = new DataGridView();
            groupBoxUslovie_SSE = new GroupBox();
            textBoxUslovie_SSE = new TextBox();
            openFileDialogTask_SAH = new OpenFileDialog();
            toolTipInfo_SAH = new ToolTip(components);
            saveFileDialogMatrix_SAH = new SaveFileDialog();
            panelTopSide_SSE.SuspendLayout();
            panelFill_SAH.SuspendLayout();
            groupBoxOutPut_SSE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOutPut_SSE).BeginInit();
            groupBoxInput_SSE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridInput_SSE).BeginInit();
            groupBoxUslovie_SSE.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopSide_SSE
            // 
            panelTopSide_SSE.Controls.Add(buttonHelp_SSE);
            panelTopSide_SSE.Controls.Add(buttonSave_SSE);
            panelTopSide_SSE.Controls.Add(buttonDone_SSE);
            panelTopSide_SSE.Controls.Add(buttonOpen_SSE);
            panelTopSide_SSE.Dock = DockStyle.Top;
            panelTopSide_SSE.Location = new Point(0, 0);
            panelTopSide_SSE.Margin = new Padding(6, 7, 6, 7);
            panelTopSide_SSE.Name = "panelTopSide_SSE";
            panelTopSide_SSE.Size = new Size(2256, 155);
            panelTopSide_SSE.TabIndex = 0;
            // 
            // buttonHelp_SSE
            // 
            buttonHelp_SSE.Image = (Image)resources.GetObject("buttonHelp_SSE.Image");
            buttonHelp_SSE.Location = new Point(2095, 7);
            buttonHelp_SSE.Margin = new Padding(6, 7, 6, 7);
            buttonHelp_SSE.Name = "buttonHelp_SSE";
            buttonHelp_SSE.Size = new Size(154, 140);
            buttonHelp_SSE.TabIndex = 0;
            toolTipInfo_SAH.SetToolTip(buttonHelp_SSE, "О программе\r\n");
            buttonHelp_SSE.UseVisualStyleBackColor = true;
            buttonHelp_SSE.Click += buttonHelp_SAH_Click;
            // 
            // buttonSave_SSE
            // 
            buttonSave_SSE.Image = (Image)resources.GetObject("buttonSave_SSE.Image");
            buttonSave_SSE.Location = new Point(377, 7);
            buttonSave_SSE.Margin = new Padding(6, 7, 6, 7);
            buttonSave_SSE.Name = "buttonSave_SSE";
            buttonSave_SSE.Size = new Size(154, 140);
            buttonSave_SSE.TabIndex = 0;
            toolTipInfo_SAH.SetToolTip(buttonSave_SSE, "Сохранения результата\r\n");
            buttonSave_SSE.UseVisualStyleBackColor = true;
            buttonSave_SSE.Click += buttonSave_SAH_Click;
            // 
            // buttonDone_SSE
            // 
            buttonDone_SSE.Image = (Image)resources.GetObject("buttonDone_SSE.Image");
            buttonDone_SSE.Location = new Point(202, 7);
            buttonDone_SSE.Margin = new Padding(6, 7, 6, 7);
            buttonDone_SSE.Name = "buttonDone_SSE";
            buttonDone_SSE.Size = new Size(162, 140);
            buttonDone_SSE.TabIndex = 0;
            toolTipInfo_SAH.SetToolTip(buttonDone_SSE, "Выполнить изменения\r\n");
            buttonDone_SSE.UseVisualStyleBackColor = true;
            buttonDone_SSE.Click += buttonDone_SAH_Click;
            // 
            // buttonOpen_SSE
            // 
            buttonOpen_SSE.Image = (Image)resources.GetObject("buttonOpen_SSE.Image");
            buttonOpen_SSE.Location = new Point(26, 7);
            buttonOpen_SSE.Margin = new Padding(6, 7, 6, 7);
            buttonOpen_SSE.Name = "buttonOpen_SSE";
            buttonOpen_SSE.Size = new Size(162, 140);
            buttonOpen_SSE.TabIndex = 0;
            toolTipInfo_SAH.SetToolTip(buttonOpen_SSE, "Выбор файла.\r\n");
            buttonOpen_SSE.UseVisualStyleBackColor = true;
            buttonOpen_SSE.Click += buttonOpen_SAH_Click;
            // 
            // panelFill_SAH
            // 
            panelFill_SAH.Controls.Add(groupBoxOutPut_SSE);
            panelFill_SAH.Controls.Add(groupBoxInput_SSE);
            panelFill_SAH.Controls.Add(groupBoxUslovie_SSE);
            panelFill_SAH.Dock = DockStyle.Fill;
            panelFill_SAH.Location = new Point(0, 155);
            panelFill_SAH.Margin = new Padding(6, 7, 6, 7);
            panelFill_SAH.Name = "panelFill_SAH";
            panelFill_SAH.Size = new Size(2256, 1263);
            panelFill_SAH.TabIndex = 1;
            // 
            // groupBoxOutPut_SSE
            // 
            groupBoxOutPut_SSE.Controls.Add(dataGridOutPut_SSE);
            groupBoxOutPut_SSE.Dock = DockStyle.Right;
            groupBoxOutPut_SSE.Location = new Point(1071, 177);
            groupBoxOutPut_SSE.Margin = new Padding(6, 7, 6, 7);
            groupBoxOutPut_SSE.Name = "groupBoxOutPut_SSE";
            groupBoxOutPut_SSE.Padding = new Padding(6, 7, 6, 7);
            groupBoxOutPut_SSE.Size = new Size(1185, 1086);
            groupBoxOutPut_SSE.TabIndex = 2;
            groupBoxOutPut_SSE.TabStop = false;
            groupBoxOutPut_SSE.Text = "Вывод";
            // 
            // dataGridOutPut_SSE
            // 
            dataGridOutPut_SSE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOutPut_SSE.Dock = DockStyle.Fill;
            dataGridOutPut_SSE.Location = new Point(6, 39);
            dataGridOutPut_SSE.Margin = new Padding(6, 7, 6, 7);
            dataGridOutPut_SSE.Name = "dataGridOutPut_SSE";
            dataGridOutPut_SSE.RowHeadersWidth = 82;
            dataGridOutPut_SSE.Size = new Size(1173, 1040);
            dataGridOutPut_SSE.TabIndex = 0;
            // 
            // groupBoxInput_SSE
            // 
            groupBoxInput_SSE.Controls.Add(dataGridInput_SSE);
            groupBoxInput_SSE.Dock = DockStyle.Left;
            groupBoxInput_SSE.Location = new Point(0, 177);
            groupBoxInput_SSE.Margin = new Padding(6, 7, 6, 7);
            groupBoxInput_SSE.Name = "groupBoxInput_SSE";
            groupBoxInput_SSE.Padding = new Padding(6, 7, 6, 7);
            groupBoxInput_SSE.Size = new Size(1057, 1086);
            groupBoxInput_SSE.TabIndex = 1;
            groupBoxInput_SSE.TabStop = false;
            groupBoxInput_SSE.Text = "Ввод";
            // 
            // dataGridInput_SSE
            // 
            dataGridInput_SSE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridInput_SSE.Dock = DockStyle.Fill;
            dataGridInput_SSE.Location = new Point(6, 39);
            dataGridInput_SSE.Margin = new Padding(6, 7, 6, 7);
            dataGridInput_SSE.Name = "dataGridInput_SSE";
            dataGridInput_SSE.RowHeadersWidth = 82;
            dataGridInput_SSE.Size = new Size(1045, 1040);
            dataGridInput_SSE.TabIndex = 0;
            // 
            // groupBoxUslovie_SSE
            // 
            groupBoxUslovie_SSE.Controls.Add(textBoxUslovie_SSE);
            groupBoxUslovie_SSE.Dock = DockStyle.Top;
            groupBoxUslovie_SSE.Location = new Point(0, 0);
            groupBoxUslovie_SSE.Margin = new Padding(6, 7, 6, 7);
            groupBoxUslovie_SSE.Name = "groupBoxUslovie_SSE";
            groupBoxUslovie_SSE.Padding = new Padding(6, 7, 6, 7);
            groupBoxUslovie_SSE.Size = new Size(2256, 177);
            groupBoxUslovie_SSE.TabIndex = 0;
            groupBoxUslovie_SSE.TabStop = false;
            groupBoxUslovie_SSE.Text = "Условие";
            groupBoxUslovie_SSE.Enter += groupBoxUslovie_SSE_Enter;
            // 
            // textBoxUslovie_SSE
            // 
            textBoxUslovie_SSE.Dock = DockStyle.Fill;
            textBoxUslovie_SSE.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxUslovie_SSE.Location = new Point(6, 39);
            textBoxUslovie_SSE.Margin = new Padding(6, 7, 6, 7);
            textBoxUslovie_SSE.Multiline = true;
            textBoxUslovie_SSE.Name = "textBoxUslovie_SSE";
            textBoxUslovie_SSE.ReadOnly = true;
            textBoxUslovie_SSE.Size = new Size(2244, 131);
            textBoxUslovie_SSE.TabIndex = 0;
            textBoxUslovie_SSE.Text = resources.GetString("textBoxUslovie_SSE.Text");
            // 
            // openFileDialogTask_SAH
            // 
            openFileDialogTask_SAH.FileName = "openFileDialogTask_SAH";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2256, 1418);
            Controls.Add(panelFill_SAH);
            Controls.Add(panelTopSide_SSE);
            Margin = new Padding(6, 7, 6, 7);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 29 | Шевченок С.Е.";
            Load += FormMain_Load;
            panelTopSide_SSE.ResumeLayout(false);
            panelFill_SAH.ResumeLayout(false);
            groupBoxOutPut_SSE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridOutPut_SSE).EndInit();
            groupBoxInput_SSE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridInput_SSE).EndInit();
            groupBoxUslovie_SSE.ResumeLayout(false);
            groupBoxUslovie_SSE.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopSide_SSE;
        private System.Windows.Forms.Panel panelFill_SAH;
        private System.Windows.Forms.GroupBox groupBoxUslovie_SSE;
        private System.Windows.Forms.TextBox textBoxUslovie_SSE;
        private System.Windows.Forms.Button buttonHelp_SSE;
        private System.Windows.Forms.Button buttonSave_SSE;
        private System.Windows.Forms.Button buttonDone_SSE;
        private System.Windows.Forms.Button buttonOpen_SSE;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SSE;
        private System.Windows.Forms.GroupBox groupBoxInput_SSE;
        private System.Windows.Forms.DataGridView dataGridInput_SSE;
        private System.Windows.Forms.DataGridView dataGridOutPut_SSE;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SAH;
        private System.Windows.Forms.ToolTip toolTipInfo_SAH;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_SAH;
    }
}

