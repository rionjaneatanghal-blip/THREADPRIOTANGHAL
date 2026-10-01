namespace THREADPRIOTANGHAL
{
    partial class frmTrackThread
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
            lblStatus = new Label();
            btnRun = new Button();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(133, 33);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(89, 15);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "-Thread Starts -";
            // 
            // btnRun
            // 
            btnRun.Location = new Point(133, 63);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(122, 55);
            btnRun.TabIndex = 1;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // frmTrackThread
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 171);
            Controls.Add(btnRun);
            Controls.Add(lblStatus);
            Name = "frmTrackThread";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private Button btnRun;
    }
}
