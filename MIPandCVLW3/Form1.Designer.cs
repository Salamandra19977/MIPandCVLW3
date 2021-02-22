namespace MIPandCVLW3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.examplePictureBox = new System.Windows.Forms.PictureBox();
            this.selectBtn = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.СannyBtn = new System.Windows.Forms.Button();
            this.LaplasianBtn = new System.Windows.Forms.Button();
            this.KirschBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxl2Gradient = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxApertureSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxThreshLinking = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxThresh = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxApertureSizeL = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxApertureSizeK = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examplePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.examplePictureBox);
            this.panel1.Location = new System.Drawing.Point(11, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 357);
            this.panel1.TabIndex = 13;
            // 
            // examplePictureBox
            // 
            this.examplePictureBox.Location = new System.Drawing.Point(3, 3);
            this.examplePictureBox.Name = "examplePictureBox";
            this.examplePictureBox.Size = new System.Drawing.Size(344, 289);
            this.examplePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.examplePictureBox.TabIndex = 9;
            this.examplePictureBox.TabStop = false;
            // 
            // selectBtn
            // 
            this.selectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectBtn.Location = new System.Drawing.Point(388, 9);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(201, 36);
            this.selectBtn.TabIndex = 12;
            this.selectBtn.Text = "Выбрать изображение";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(11, 9);
            this.pathTextBox.Multiline = true;
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(371, 35);
            this.pathTextBox.TabIndex = 11;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialogImage";
            this.openFile.Filter = "Image|*.jpg";
            // 
            // СannyBtn
            // 
            this.СannyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.СannyBtn.Location = new System.Drawing.Point(10, 123);
            this.СannyBtn.Name = "СannyBtn";
            this.СannyBtn.Size = new System.Drawing.Size(173, 33);
            this.СannyBtn.TabIndex = 14;
            this.СannyBtn.Text = "Сanny";
            this.СannyBtn.UseVisualStyleBackColor = true;
            this.СannyBtn.Click += new System.EventHandler(this.СannyBtn_Click);
            // 
            // LaplasianBtn
            // 
            this.LaplasianBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LaplasianBtn.Location = new System.Drawing.Point(10, 45);
            this.LaplasianBtn.Name = "LaplasianBtn";
            this.LaplasianBtn.Size = new System.Drawing.Size(173, 33);
            this.LaplasianBtn.TabIndex = 15;
            this.LaplasianBtn.Text = "Laplasian";
            this.LaplasianBtn.UseVisualStyleBackColor = true;
            this.LaplasianBtn.Click += new System.EventHandler(this.LaplasianBtn_Click);
            // 
            // KirschBtn
            // 
            this.KirschBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KirschBtn.Location = new System.Drawing.Point(10, 45);
            this.KirschBtn.Name = "KirschBtn";
            this.KirschBtn.Size = new System.Drawing.Size(173, 33);
            this.KirschBtn.TabIndex = 16;
            this.KirschBtn.Text = "Kirsch";
            this.KirschBtn.UseVisualStyleBackColor = true;
            this.KirschBtn.Click += new System.EventHandler(this.KirschBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxl2Gradient);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxApertureSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxThreshLinking);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxThresh);
            this.groupBox1.Controls.Add(this.СannyBtn);
            this.groupBox1.Location = new System.Drawing.Point(389, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 165);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сanny";
            // 
            // checkBoxl2Gradient
            // 
            this.checkBoxl2Gradient.AutoSize = true;
            this.checkBoxl2Gradient.Location = new System.Drawing.Point(83, 100);
            this.checkBoxl2Gradient.Name = "checkBoxl2Gradient";
            this.checkBoxl2Gradient.Size = new System.Drawing.Size(74, 17);
            this.checkBoxl2Gradient.TabIndex = 22;
            this.checkBoxl2Gradient.Text = "l2Gradient";
            this.checkBoxl2Gradient.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "ApertureSize:";
            // 
            // textBoxApertureSize
            // 
            this.textBoxApertureSize.Location = new System.Drawing.Point(83, 48);
            this.textBoxApertureSize.Name = "textBoxApertureSize";
            this.textBoxApertureSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxApertureSize.TabIndex = 19;
            this.textBoxApertureSize.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "ThreshLinking:";
            // 
            // textBoxThreshLinking
            // 
            this.textBoxThreshLinking.Location = new System.Drawing.Point(83, 74);
            this.textBoxThreshLinking.Name = "textBoxThreshLinking";
            this.textBoxThreshLinking.Size = new System.Drawing.Size(100, 20);
            this.textBoxThreshLinking.TabIndex = 17;
            this.textBoxThreshLinking.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Thresh:";
            // 
            // textBoxThresh
            // 
            this.textBoxThresh.Location = new System.Drawing.Point(83, 19);
            this.textBoxThresh.Name = "textBoxThresh";
            this.textBoxThresh.Size = new System.Drawing.Size(100, 20);
            this.textBoxThresh.TabIndex = 15;
            this.textBoxThresh.Text = "100";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxApertureSizeL);
            this.groupBox2.Controls.Add(this.LaplasianBtn);
            this.groupBox2.Location = new System.Drawing.Point(389, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 89);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Laplasian";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "ApertureSize:";
            // 
            // textBoxApertureSizeL
            // 
            this.textBoxApertureSizeL.Location = new System.Drawing.Point(83, 19);
            this.textBoxApertureSizeL.Name = "textBoxApertureSizeL";
            this.textBoxApertureSizeL.Size = new System.Drawing.Size(100, 20);
            this.textBoxApertureSizeL.TabIndex = 21;
            this.textBoxApertureSizeL.Text = "13";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxApertureSizeK);
            this.groupBox3.Controls.Add(this.KirschBtn);
            this.groupBox3.Location = new System.Drawing.Point(389, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 91);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kirsch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "ApertureSize:";
            // 
            // textBoxApertureSizeK
            // 
            this.textBoxApertureSizeK.Location = new System.Drawing.Point(83, 19);
            this.textBoxApertureSizeK.Name = "textBoxApertureSizeK";
            this.textBoxApertureSizeK.Size = new System.Drawing.Size(100, 20);
            this.textBoxApertureSizeK.TabIndex = 23;
            this.textBoxApertureSizeK.Text = "150";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 413);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.pathTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "л/р 3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examplePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox examplePictureBox;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button СannyBtn;
        private System.Windows.Forms.Button LaplasianBtn;
        private System.Windows.Forms.Button KirschBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxThresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxThreshLinking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxApertureSize;
        private System.Windows.Forms.CheckBox checkBoxl2Gradient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxApertureSizeL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxApertureSizeK;
    }
}

