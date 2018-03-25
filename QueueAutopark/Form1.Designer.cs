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
            this.label5 = new System.Windows.Forms.Label();
            this.lblNormalTotalWaitingPeriod = new System.Windows.Forms.Label();
            this.txtCarlist = new System.Windows.Forms.TextBox();
            this.txtPriorityQueue = new System.Windows.Forms.TextBox();
            this.lblTotalCar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNormalAverageWaitingPeriod = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPrioritizedAverageWaitingPeriod = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPrioritizedTotalWaitingPeriod = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnterCarNoEnter
            // 
            this.btnEnterCarNoEnter.Location = new System.Drawing.Point(563, 290);
            this.btnEnterCarNoEnter.Name = "btnEnterCarNoEnter";
            this.btnEnterCarNoEnter.Size = new System.Drawing.Size(75, 28);
            this.btnEnterCarNoEnter.TabIndex = 0;
            this.btnEnterCarNoEnter.Text = "Start";
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
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Normal Queue :";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Waiting Period :";
            // 
            // lblNormalTotalWaitingPeriod
            // 
            this.lblNormalTotalWaitingPeriod.AutoSize = true;
            this.lblNormalTotalWaitingPeriod.Location = new System.Drawing.Point(691, 170);
            this.lblNormalTotalWaitingPeriod.Name = "lblNormalTotalWaitingPeriod";
            this.lblNormalTotalWaitingPeriod.Size = new System.Drawing.Size(19, 13);
            this.lblNormalTotalWaitingPeriod.TabIndex = 12;
            this.lblNormalTotalWaitingPeriod.Text = "00";
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
            // lblTotalCar
            // 
            this.lblTotalCar.AutoSize = true;
            this.lblTotalCar.Location = new System.Drawing.Point(630, 125);
            this.lblTotalCar.Name = "lblTotalCar";
            this.lblTotalCar.Size = new System.Drawing.Size(19, 13);
            this.lblTotalCar.TabIndex = 21;
            this.lblTotalCar.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(561, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Total Cars :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "NORMAL QUEUE";
            // 
            // lblNormalAverageWaitingPeriod
            // 
            this.lblNormalAverageWaitingPeriod.AutoSize = true;
            this.lblNormalAverageWaitingPeriod.Location = new System.Drawing.Point(691, 187);
            this.lblNormalAverageWaitingPeriod.Name = "lblNormalAverageWaitingPeriod";
            this.lblNormalAverageWaitingPeriod.Size = new System.Drawing.Size(19, 13);
            this.lblNormalAverageWaitingPeriod.TabIndex = 26;
            this.lblNormalAverageWaitingPeriod.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(561, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Average Waiting Period :";
            // 
            // lblPrioritizedAverageWaitingPeriod
            // 
            this.lblPrioritizedAverageWaitingPeriod.AutoSize = true;
            this.lblPrioritizedAverageWaitingPeriod.Location = new System.Drawing.Point(691, 256);
            this.lblPrioritizedAverageWaitingPeriod.Name = "lblPrioritizedAverageWaitingPeriod";
            this.lblPrioritizedAverageWaitingPeriod.Size = new System.Drawing.Size(19, 13);
            this.lblPrioritizedAverageWaitingPeriod.TabIndex = 31;
            this.lblPrioritizedAverageWaitingPeriod.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(561, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Average Waiting Period :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(561, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "PRIORITIZED QUEUE";
            // 
            // lblPrioritizedTotalWaitingPeriod
            // 
            this.lblPrioritizedTotalWaitingPeriod.AutoSize = true;
            this.lblPrioritizedTotalWaitingPeriod.Location = new System.Drawing.Point(691, 239);
            this.lblPrioritizedTotalWaitingPeriod.Name = "lblPrioritizedTotalWaitingPeriod";
            this.lblPrioritizedTotalWaitingPeriod.Size = new System.Drawing.Size(19, 13);
            this.lblPrioritizedTotalWaitingPeriod.TabIndex = 28;
            this.lblPrioritizedTotalWaitingPeriod.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(561, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Total Waiting Period :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(754, 509);
            this.Controls.Add(this.lblPrioritizedAverageWaitingPeriod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblPrioritizedTotalWaitingPeriod);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblNormalAverageWaitingPeriod);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotalCar);
            this.Controls.Add(this.txtPriorityQueue);
            this.Controls.Add(this.txtCarlist);
            this.Controls.Add(this.lblNormalTotalWaitingPeriod);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNormalTotalWaitingPeriod;
        private System.Windows.Forms.TextBox txtCarlist;
        private System.Windows.Forms.TextBox txtPriorityQueue;
        private System.Windows.Forms.Label lblTotalCar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNormalAverageWaitingPeriod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPrioritizedAverageWaitingPeriod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPrioritizedTotalWaitingPeriod;
        private System.Windows.Forms.Label label11;
    }
}

