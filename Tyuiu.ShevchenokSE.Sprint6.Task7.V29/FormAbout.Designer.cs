
namespace Tyuiu.ShevchenokSE.Sprint6.Task7.V29
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            button_SSE = new Button();
            labelInfo_SAH = new Label();
            pictureBox_SSE = new PictureBox();
            label_SSE = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_SSE).BeginInit();
            SuspendLayout();
            // 
            // button_SSE
            // 
            button_SSE.Location = new Point(1152, 570);
            button_SSE.Margin = new Padding(6, 7, 6, 7);
            button_SSE.Name = "button_SSE";
            button_SSE.Size = new Size(162, 57);
            button_SSE.TabIndex = 5;
            button_SSE.Text = "OK";
            button_SSE.UseVisualStyleBackColor = true;
            button_SSE.Click += buttonOK_SAH_Click;
            // 
            // labelInfo_SAH
            // 
            labelInfo_SAH.AutoSize = true;
            labelInfo_SAH.Location = new Point(403, 22);
            labelInfo_SAH.Margin = new Padding(6, 0, 6, 0);
            labelInfo_SAH.Name = "labelInfo_SAH";
            labelInfo_SAH.Size = new Size(0, 32);
            labelInfo_SAH.TabIndex = 4;
            // 
            // pictureBox_SSE
            // 
            pictureBox_SSE.BackgroundImage = (Image)resources.GetObject("pictureBox_SSE.BackgroundImage");
            pictureBox_SSE.ErrorImage = (Image)resources.GetObject("pictureBox_SSE.ErrorImage");
            pictureBox_SSE.Image = (Image)resources.GetObject("pictureBox_SSE.Image");
            pictureBox_SSE.InitialImage = (Image)resources.GetObject("pictureBox_SSE.InitialImage");
            pictureBox_SSE.Location = new Point(20, 30);
            pictureBox_SSE.Margin = new Padding(6, 7, 6, 7);
            pictureBox_SSE.Name = "pictureBox_SSE";
            pictureBox_SSE.Size = new Size(668, 597);
            pictureBox_SSE.TabIndex = 3;
            pictureBox_SSE.TabStop = false;
            pictureBox_SSE.Click += pictureBox_SSE_Click;
            // 
            // label_SSE
            // 
            label_SSE.AutoSize = true;
            label_SSE.Location = new Point(708, 30);
            label_SSE.Name = "label_SSE";
            label_SSE.Size = new Size(609, 320);
            label_SSE.TabIndex = 6;
            label_SSE.Text = resources.GetString("label_SSE.Text");
            label_SSE.Click += label1_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1330, 639);
            Controls.Add(label_SSE);
            Controls.Add(button_SSE);
            Controls.Add(labelInfo_SAH);
            Controls.Add(pictureBox_SSE);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(6, 7, 6, 7);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox_SSE).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_SSE;
        private System.Windows.Forms.Label labelInfo_SAH;
        private System.Windows.Forms.PictureBox pictureBox_SSE;
        private Label label_SSE;
    }
}