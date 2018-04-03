namespace ScreenGrabber
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.savePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.capture = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startbtn = new System.Windows.Forms.Button();
            this.MainWorker = new System.ComponentModel.BackgroundWorker();
            this.stopbtn = new System.Windows.Forms.Button();
            this.labelDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // savePath
            // 
            this.savePath.Location = new System.Drawing.Point(89, 12);
            this.savePath.Name = "savePath";
            this.savePath.ReadOnly = true;
            this.savePath.Size = new System.Drawing.Size(254, 20);
            this.savePath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Save Path";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // capture
            // 
            this.capture.Location = new System.Drawing.Point(147, 38);
            this.capture.Name = "capture";
            this.capture.Size = new System.Drawing.Size(196, 20);
            this.capture.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Caputre time (seconds)";
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(12, 130);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(90, 23);
            this.startbtn.TabIndex = 5;
            this.startbtn.Text = "START";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // MainWorker
            // 
            this.MainWorker.WorkerSupportsCancellation = true;
            this.MainWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.MainWorker_DoWork);
            // 
            // stopbtn
            // 
            this.stopbtn.Location = new System.Drawing.Point(12, 101);
            this.stopbtn.Name = "stopbtn";
            this.stopbtn.Size = new System.Drawing.Size(90, 23);
            this.stopbtn.TabIndex = 6;
            this.stopbtn.Text = "STOP";
            this.stopbtn.UseVisualStyleBackColor = true;
            this.stopbtn.Click += new System.EventHandler(this.stopbtn_Click);
            // 
            // labelDisplay
            // 
            this.labelDisplay.AutoSize = true;
            this.labelDisplay.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplay.Location = new System.Drawing.Point(123, 119);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Size = new System.Drawing.Size(240, 37);
            this.labelDisplay.TabIndex = 7;
            this.labelDisplay.Text = "SYSTEM RUNNING";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 165);
            this.Controls.Add(this.labelDisplay);
            this.Controls.Add(this.stopbtn);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.capture);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.savePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen Grabber v.1.0";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox savePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox capture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startbtn;
        private System.ComponentModel.BackgroundWorker MainWorker;
        private System.Windows.Forms.Button stopbtn;
        private System.Windows.Forms.Label labelDisplay;
    }
}

