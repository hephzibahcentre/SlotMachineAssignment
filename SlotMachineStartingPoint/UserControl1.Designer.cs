namespace SlotMachineStartingPoint
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
            this.multi5cents = new System.Windows.Forms.Button();
            this.multi10cents = new System.Windows.Forms.Button();
            this.multi25cents = new System.Windows.Forms.Button();
            this.multi1dollar = new System.Windows.Forms.Button();
            this.spinBox1 = new System.Windows.Forms.PictureBox();
            this.spinButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.outputWin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.outputLoss = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.outputNet = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.spinBox2 = new System.Windows.Forms.PictureBox();
            this.spinBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.spinBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // multi5cents
            // 
            this.multi5cents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multi5cents.Location = new System.Drawing.Point(127, 399);
            this.multi5cents.Name = "multi5cents";
            this.multi5cents.Size = new System.Drawing.Size(109, 55);
            this.multi5cents.TabIndex = 0;
            this.multi5cents.Text = "$0.05";
            this.multi5cents.UseVisualStyleBackColor = true;
            this.multi5cents.Click += new System.EventHandler(this.multi5cents_Click);
            // 
            // multi10cents
            // 
            this.multi10cents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multi10cents.Location = new System.Drawing.Point(242, 399);
            this.multi10cents.Name = "multi10cents";
            this.multi10cents.Size = new System.Drawing.Size(109, 55);
            this.multi10cents.TabIndex = 1;
            this.multi10cents.Text = "$0.10";
            this.multi10cents.UseVisualStyleBackColor = true;
            this.multi10cents.Click += new System.EventHandler(this.multi10cents_Click);
            // 
            // multi25cents
            // 
            this.multi25cents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multi25cents.Location = new System.Drawing.Point(357, 399);
            this.multi25cents.Name = "multi25cents";
            this.multi25cents.Size = new System.Drawing.Size(109, 55);
            this.multi25cents.TabIndex = 2;
            this.multi25cents.Text = "$0.25";
            this.multi25cents.UseVisualStyleBackColor = true;
            this.multi25cents.Click += new System.EventHandler(this.multi25cents_Click);
            // 
            // multi1dollar
            // 
            this.multi1dollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multi1dollar.Location = new System.Drawing.Point(472, 399);
            this.multi1dollar.Name = "multi1dollar";
            this.multi1dollar.Size = new System.Drawing.Size(109, 55);
            this.multi1dollar.TabIndex = 3;
            this.multi1dollar.Text = "$1.00";
            this.multi1dollar.UseVisualStyleBackColor = true;
            this.multi1dollar.Click += new System.EventHandler(this.multi1dollar_Click);
            // 
            // spinBox1
            // 
            this.spinBox1.BackColor = System.Drawing.SystemColors.Control;
            this.spinBox1.Image = global::SlotMachineStartingPoint.Properties.Resources.bell;
            this.spinBox1.Location = new System.Drawing.Point(157, 158);
            this.spinBox1.Name = "spinBox1";
            this.spinBox1.Size = new System.Drawing.Size(117, 148);
            this.spinBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.spinBox1.TabIndex = 5;
            this.spinBox1.TabStop = false;
            // 
            // spinButton
            // 
            this.spinButton.BackgroundImage = global::SlotMachineStartingPoint.Properties.Resources.handle;
            this.spinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spinButton.Location = new System.Drawing.Point(587, 18);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(107, 361);
            this.spinButton.TabIndex = 8;
            this.spinButton.UseVisualStyleBackColor = false;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.outputWin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(127, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 66);
            this.panel1.TabIndex = 10;
            // 
            // outputWin
            // 
            this.outputWin.AutoSize = true;
            this.outputWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputWin.Location = new System.Drawing.Point(36, 34);
            this.outputWin.Name = "outputWin";
            this.outputWin.Size = new System.Drawing.Size(54, 20);
            this.outputWin.TabIndex = 1;
            this.outputWin.Text = "$0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Win:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.outputLoss);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(285, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 66);
            this.panel2.TabIndex = 11;
            // 
            // outputLoss
            // 
            this.outputLoss.AutoSize = true;
            this.outputLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLoss.Location = new System.Drawing.Point(40, 34);
            this.outputLoss.Name = "outputLoss";
            this.outputLoss.Size = new System.Drawing.Size(54, 20);
            this.outputLoss.TabIndex = 2;
            this.outputLoss.Text = "$0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loss:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.outputNet);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(443, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(138, 66);
            this.panel3.TabIndex = 11;
            // 
            // outputNet
            // 
            this.outputNet.AutoSize = true;
            this.outputNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputNet.Location = new System.Drawing.Point(35, 34);
            this.outputNet.Name = "outputNet";
            this.outputNet.Size = new System.Drawing.Size(66, 20);
            this.outputNet.TabIndex = 3;
            this.outputNet.Text = "($0.00)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Net:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SlotMachineStartingPoint.Properties.Resources.slot_machine_interface;
            this.pictureBox1.Location = new System.Drawing.Point(127, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // spinBox2
            // 
            this.spinBox2.BackColor = System.Drawing.SystemColors.Control;
            this.spinBox2.Image = global::SlotMachineStartingPoint.Properties.Resources.bell;
            this.spinBox2.Location = new System.Drawing.Point(293, 158);
            this.spinBox2.Name = "spinBox2";
            this.spinBox2.Size = new System.Drawing.Size(117, 148);
            this.spinBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.spinBox2.TabIndex = 13;
            this.spinBox2.TabStop = false;
            // 
            // spinBox3
            // 
            this.spinBox3.BackColor = System.Drawing.SystemColors.Control;
            this.spinBox3.Image = global::SlotMachineStartingPoint.Properties.Resources.bell;
            this.spinBox3.Location = new System.Drawing.Point(432, 158);
            this.spinBox3.Name = "spinBox3";
            this.spinBox3.Size = new System.Drawing.Size(117, 148);
            this.spinBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.spinBox3.TabIndex = 14;
            this.spinBox3.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spinBox3);
            this.Controls.Add(this.spinBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.spinBox1);
            this.Controls.Add(this.multi1dollar);
            this.Controls.Add(this.multi25cents);
            this.Controls.Add(this.multi10cents);
            this.Controls.Add(this.multi5cents);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 505);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spinBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button multi5cents;
        private System.Windows.Forms.Button multi10cents;
        private System.Windows.Forms.Button multi25cents;
        private System.Windows.Forms.Button multi1dollar;
        private System.Windows.Forms.PictureBox spinBox1;
        private System.Windows.Forms.Button spinButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label outputWin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label outputLoss;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label outputNet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox spinBox2;
        private System.Windows.Forms.PictureBox spinBox3;
    }
}
