namespace CSharpSerialConnection
{
    partial class Form1
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
            this.btnOpenCOM = new System.Windows.Forms.Button();
            this.btnLeftMotorSpeed = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.nudLeftMotorSpeed = new System.Windows.Forms.NumericUpDown();
            this.nudRightMotorSpeed = new System.Windows.Forms.NumericUpDown();
            this.btnRightMotorSpeed = new System.Windows.Forms.Button();
            this.gpMotorSpeed = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStopMotor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCloseCOM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeftMotorSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRightMotorSpeed)).BeginInit();
            this.gpMotorSpeed.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenCOM
            // 
            this.btnOpenCOM.Location = new System.Drawing.Point(44, 13);
            this.btnOpenCOM.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenCOM.Name = "btnOpenCOM";
            this.btnOpenCOM.Size = new System.Drawing.Size(109, 28);
            this.btnOpenCOM.TabIndex = 0;
            this.btnOpenCOM.Text = "Open COM";
            this.btnOpenCOM.UseVisualStyleBackColor = true;
            this.btnOpenCOM.Click += new System.EventHandler(this.btnOpenCOM_Click);
            // 
            // btnLeftMotorSpeed
            // 
            this.btnLeftMotorSpeed.Location = new System.Drawing.Point(149, 22);
            this.btnLeftMotorSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeftMotorSpeed.Name = "btnLeftMotorSpeed";
            this.btnLeftMotorSpeed.Size = new System.Drawing.Size(194, 28);
            this.btnLeftMotorSpeed.TabIndex = 2;
            this.btnLeftMotorSpeed.Text = "Left Motor Speed";
            this.btnLeftMotorSpeed.UseVisualStyleBackColor = true;
            this.btnLeftMotorSpeed.Click += new System.EventHandler(this.btnLeftMotorSpeed_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(13, 192);
            this.rtbOutput.Margin = new System.Windows.Forms.Padding(4);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(657, 348);
            this.rtbOutput.TabIndex = 3;
            this.rtbOutput.Text = "";
            // 
            // nudLeftMotorSpeed
            // 
            this.nudLeftMotorSpeed.Location = new System.Drawing.Point(44, 26);
            this.nudLeftMotorSpeed.Name = "nudLeftMotorSpeed";
            this.nudLeftMotorSpeed.Size = new System.Drawing.Size(98, 22);
            this.nudLeftMotorSpeed.TabIndex = 4;
            // 
            // nudRightMotorSpeed
            // 
            this.nudRightMotorSpeed.Location = new System.Drawing.Point(44, 62);
            this.nudRightMotorSpeed.Name = "nudRightMotorSpeed";
            this.nudRightMotorSpeed.Size = new System.Drawing.Size(98, 22);
            this.nudRightMotorSpeed.TabIndex = 6;
            // 
            // btnRightMotorSpeed
            // 
            this.btnRightMotorSpeed.Location = new System.Drawing.Point(149, 58);
            this.btnRightMotorSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.btnRightMotorSpeed.Name = "btnRightMotorSpeed";
            this.btnRightMotorSpeed.Size = new System.Drawing.Size(194, 28);
            this.btnRightMotorSpeed.TabIndex = 5;
            this.btnRightMotorSpeed.Text = "Right Motor Speed";
            this.btnRightMotorSpeed.UseVisualStyleBackColor = true;
            this.btnRightMotorSpeed.Click += new System.EventHandler(this.btnRightMotorSpeed_Click);
            // 
            // gpMotorSpeed
            // 
            this.gpMotorSpeed.Controls.Add(this.btnStopMotor);
            this.gpMotorSpeed.Controls.Add(this.nudRightMotorSpeed);
            this.gpMotorSpeed.Controls.Add(this.btnLeftMotorSpeed);
            this.gpMotorSpeed.Controls.Add(this.btnRightMotorSpeed);
            this.gpMotorSpeed.Controls.Add(this.nudLeftMotorSpeed);
            this.gpMotorSpeed.Location = new System.Drawing.Point(248, 15);
            this.gpMotorSpeed.Name = "gpMotorSpeed";
            this.gpMotorSpeed.Size = new System.Drawing.Size(373, 130);
            this.gpMotorSpeed.TabIndex = 7;
            this.gpMotorSpeed.TabStop = false;
            this.gpMotorSpeed.Text = "Motor Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Output";
            // 
            // btnStopMotor
            // 
            this.btnStopMotor.Location = new System.Drawing.Point(149, 94);
            this.btnStopMotor.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopMotor.Name = "btnStopMotor";
            this.btnStopMotor.Size = new System.Drawing.Size(194, 28);
            this.btnStopMotor.TabIndex = 7;
            this.btnStopMotor.Text = "Stop Motor";
            this.btnStopMotor.UseVisualStyleBackColor = true;
            this.btnStopMotor.Click += new System.EventHandler(this.btnStopMotor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(627, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 130);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infoboard";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 35);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Get Battery Level";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 71);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Get Maximum Speed";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCloseCOM
            // 
            this.btnCloseCOM.Location = new System.Drawing.Point(44, 50);
            this.btnCloseCOM.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseCOM.Name = "btnCloseCOM";
            this.btnCloseCOM.Size = new System.Drawing.Size(109, 28);
            this.btnCloseCOM.TabIndex = 9;
            this.btnCloseCOM.Text = "Close COM";
            this.btnCloseCOM.UseVisualStyleBackColor = true;
            this.btnCloseCOM.Click += new System.EventHandler(this.btnCloseCOM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 553);
            this.Controls.Add(this.btnCloseCOM);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnOpenCOM);
            this.Controls.Add(this.gpMotorSpeed);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudLeftMotorSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRightMotorSpeed)).EndInit();
            this.gpMotorSpeed.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenCOM;
        private System.Windows.Forms.Button btnLeftMotorSpeed;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.NumericUpDown nudLeftMotorSpeed;
        private System.Windows.Forms.NumericUpDown nudRightMotorSpeed;
        private System.Windows.Forms.Button btnRightMotorSpeed;
        private System.Windows.Forms.GroupBox gpMotorSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStopMotor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCloseCOM;
    }
}

