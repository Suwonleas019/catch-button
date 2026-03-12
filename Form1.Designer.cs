namespace WinFormsApp_3
{
    partial class 버튼잡기게임
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
            target = new Button();
            btnRestart = new Button();
            SuspendLayout();
            // 
            // target
            // 
            target.BackColor = Color.FromArgb(255, 128, 128);
            target.Font = new Font("맑은 고딕", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            target.ForeColor = SystemColors.ActiveCaptionText;
            target.Location = new Point(234, 66);
            target.Name = "target";
            target.Size = new Size(300, 200);
            target.TabIndex = 0;
            target.Text = "나를 잡아봐";
            target.UseVisualStyleBackColor = false;
            target.Click += target_Click;
            target.MouseEnter += target_MouseEnter;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(260, 192);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(247, 70);
            btnRestart.TabIndex = 1;
            btnRestart.Text = "다시시작";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Visible = false;
            btnRestart.Click += btnRestart_Click_1;
            // 
            // 버튼잡기게임
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRestart);
            Controls.Add(target);
            Name = "버튼잡기게임";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button target;
        private Button btnRestart;
    }
}
