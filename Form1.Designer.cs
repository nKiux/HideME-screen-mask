namespace HideME
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            TimeShow = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(-1, 0);
            button1.Name = "button1";
            button1.Size = new Size(154, 109);
            button1.TabIndex = 1;
            button1.Text = "快速啟動";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TimeShow
            // 
            TimeShow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TimeShow.AutoSize = true;
            TimeShow.Cursor = Cursors.Cross;
            TimeShow.Font = new Font("Microsoft JhengHei UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 136);
            TimeShow.ForeColor = SystemColors.Window;
            TimeShow.Location = new Point(500, 200);
            TimeShow.Name = "TimeShow";
            TimeShow.Size = new Size(332, 122);
            TimeShow.TabIndex = 2;
            TimeShow.Text = "label1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // button2
            // 
            button2.Location = new Point(-1, 86);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "結束";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = SystemColors.ControlLightLight;
            checkBox1.Location = new Point(-1, 90);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(74, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "遮罩啟動";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(155, 107);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(TimeShow);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "HideME";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label TimeShow;
        private System.Windows.Forms.Timer timer1;
        private Button button2;
        private CheckBox checkBox1;
    }
}
