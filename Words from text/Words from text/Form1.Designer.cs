namespace Words_from_text
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
            this.textBoxreView = new System.Windows.Forms.TextBox();
            this.buttonrVeiew = new System.Windows.Forms.Button();
            this.Next2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxreView
            // 
            this.textBoxreView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxreView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxreView.Location = new System.Drawing.Point(31, 62);
            this.textBoxreView.Multiline = true;
            this.textBoxreView.Name = "textBoxreView";
            this.textBoxreView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxreView.Size = new System.Drawing.Size(439, 45);
            this.textBoxreView.TabIndex = 0;
            this.textBoxreView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxreView_MouseClick);
            this.textBoxreView.TextChanged += new System.EventHandler(this.textBoxreView_TextChanged);
            // 
            // buttonrVeiew
            // 
            this.buttonrVeiew.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonrVeiew.Location = new System.Drawing.Point(174, 113);
            this.buttonrVeiew.Name = "buttonrVeiew";
            this.buttonrVeiew.Size = new System.Drawing.Size(147, 56);
            this.buttonrVeiew.TabIndex = 1;
            this.buttonrVeiew.Text = "Обзор";
            this.buttonrVeiew.UseVisualStyleBackColor = true;
            this.buttonrVeiew.Click += new System.EventHandler(this.buttonrVeiew_Click);
            // 
            // Next2
            // 
            this.Next2.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next2.Location = new System.Drawing.Point(182, 456);
            this.Next2.Name = "Next2";
            this.Next2.Size = new System.Drawing.Size(179, 73);
            this.Next2.TabIndex = 2;
            this.Next2.Text = "Начать";
            this.Next2.UseVisualStyleBackColor = true;
            this.Next2.Click += new System.EventHandler(this.Next2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Words_from_text";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.BackColor = System.Drawing.SystemColors.Window;
            this.labelPath.Font = new System.Drawing.Font("OCR A Extended", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPath.Location = new System.Drawing.Point(214, 70);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(68, 30);
            this.labelPath.TabIndex = 4;
            this.labelPath.Text = "Путь";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.labelPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonrVeiew);
            this.groupBox1.Controls.Add(this.textBoxreView);
            this.groupBox1.Location = new System.Drawing.Point(20, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 180);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(488, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Х";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(545, 541);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Next2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обзор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxreView;
        private System.Windows.Forms.Button buttonrVeiew;
        private System.Windows.Forms.Button Next2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}

