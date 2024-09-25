namespace WindowsFormsControlLibrary1
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.bntConnect = new System.Windows.Forms.Button();
            this.bntExit = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbspeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // bntConnect
            // 
            this.bntConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntConnect.Location = new System.Drawing.Point(69, 321);
            this.bntConnect.Name = "bntConnect";
            this.bntConnect.Size = new System.Drawing.Size(272, 69);
            this.bntConnect.TabIndex = 0;
            this.bntConnect.Text = "CONNECT";
            this.bntConnect.UseVisualStyleBackColor = true;
            this.bntConnect.Click += new System.EventHandler(this.bntConnect_Click);
            // 
            // bntExit
            // 
            this.bntExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExit.Location = new System.Drawing.Point(444, 321);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(273, 69);
            this.bntExit.TabIndex = 1;
            this.bntExit.Text = "EXIT";
            this.bntExit.UseVisualStyleBackColor = true;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(178, 201);
            this.trackBar.Maximum = 999;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(428, 56);
            this.trackBar.TabIndex = 2;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "STM - UART";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "PWM";
            // 
            // lbspeed
            // 
            this.lbspeed.AutoSize = true;
            this.lbspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbspeed.Location = new System.Drawing.Point(612, 201);
            this.lbspeed.Name = "lbspeed";
            this.lbspeed.Size = new System.Drawing.Size(104, 29);
            this.lbspeed.TabIndex = 5;
            this.lbspeed.Text = "SPEED";
            // 
            // UserControl1
            // 
            this.Controls.Add(this.lbspeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.bntConnect);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(789, 431);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.IO.Ports.SerialPort serialPort1;
        public System.Windows.Forms.Button bntConnect;
        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbspeed;
    }
}
