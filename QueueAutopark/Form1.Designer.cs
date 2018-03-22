namespace QueueAutopark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEnterCarNoEnter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalProcess = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalPriorityQueue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCarlist = new System.Windows.Forms.TextBox();
            this.txtPriorityQueue = new System.Windows.Forms.TextBox();
            this.txtReversePriQueue = new System.Windows.Forms.TextBox();
            this.txtGain = new System.Windows.Forms.TextBox();
            this.lblTotalCarNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnterCarNoEnter
            // 
            this.btnEnterCarNoEnter.Location = new System.Drawing.Point(491, 464);
            this.btnEnterCarNoEnter.Name = "btnEnterCarNoEnter";
            this.btnEnterCarNoEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnterCarNoEnter.TabIndex = 0;
            this.btnEnterCarNoEnter.Text = "Enter";
            this.btnEnterCarNoEnter.UseVisualStyleBackColor = true;
            this.btnEnterCarNoEnter.Click += new System.EventHandler(this.btnEnterCarNoEnter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cars List :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Priority Queue :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(841, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gain :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Process :";
            // 
            // lblTotalProcess
            // 
            this.lblTotalProcess.AutoSize = true;
            this.lblTotalProcess.Location = new System.Drawing.Point(461, 48);
            this.lblTotalProcess.Name = "lblTotalProcess";
            this.lblTotalProcess.Size = new System.Drawing.Size(19, 13);
            this.lblTotalProcess.TabIndex = 12;
            this.lblTotalProcess.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Priority Queue :";
            // 
            // lblTotalPriorityQueue
            // 
            this.lblTotalPriorityQueue.AutoSize = true;
            this.lblTotalPriorityQueue.Location = new System.Drawing.Point(488, 81);
            this.lblTotalPriorityQueue.Name = "lblTotalPriorityQueue";
            this.lblTotalPriorityQueue.Size = new System.Drawing.Size(19, 13);
            this.lblTotalPriorityQueue.TabIndex = 14;
            this.lblTotalPriorityQueue.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(565, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Reverse Priority Queue  :";
            // 
            // txtCarlist
            // 
            this.txtCarlist.Location = new System.Drawing.Point(15, 123);
            this.txtCarlist.Multiline = true;
            this.txtCarlist.Name = "txtCarlist";
            this.txtCarlist.Size = new System.Drawing.Size(251, 323);
            this.txtCarlist.TabIndex = 17;
            // 
            // txtPriorityQueue
            // 
            this.txtPriorityQueue.Location = new System.Drawing.Point(294, 123);
            this.txtPriorityQueue.Multiline = true;
            this.txtPriorityQueue.Name = "txtPriorityQueue";
            this.txtPriorityQueue.Size = new System.Drawing.Size(251, 323);
            this.txtPriorityQueue.TabIndex = 18;
            // 
            // txtReversePriQueue
            // 
            this.txtReversePriQueue.Location = new System.Drawing.Point(564, 123);
            this.txtReversePriQueue.Multiline = true;
            this.txtReversePriQueue.Name = "txtReversePriQueue";
            this.txtReversePriQueue.Size = new System.Drawing.Size(251, 323);
            this.txtReversePriQueue.TabIndex = 19;
            // 
            // txtGain
            // 
            this.txtGain.Location = new System.Drawing.Point(835, 123);
            this.txtGain.Multiline = true;
            this.txtGain.Name = "txtGain";
            this.txtGain.Size = new System.Drawing.Size(251, 323);
            this.txtGain.TabIndex = 20;
            // 
            // lblTotalCarNumber
            // 
            this.lblTotalCarNumber.AutoSize = true;
            this.lblTotalCarNumber.Location = new System.Drawing.Point(12, 464);
            this.lblTotalCarNumber.Name = "lblTotalCarNumber";
            this.lblTotalCarNumber.Size = new System.Drawing.Size(19, 13);
            this.lblTotalCarNumber.TabIndex = 21;
            this.lblTotalCarNumber.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1117, 509);
            this.Controls.Add(this.lblTotalCarNumber);
            this.Controls.Add(this.txtGain);
            this.Controls.Add(this.txtReversePriQueue);
            this.Controls.Add(this.txtPriorityQueue);
            this.Controls.Add(this.txtCarlist);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotalPriorityQueue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotalProcess);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEnterCarNoEnter);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterCarNoEnter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalProcess;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalPriorityQueue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCarlist;
        private System.Windows.Forms.TextBox txtPriorityQueue;
        private System.Windows.Forms.TextBox txtReversePriQueue;
        private System.Windows.Forms.TextBox txtGain;
        private System.Windows.Forms.Label lblTotalCarNumber;
    }
}

