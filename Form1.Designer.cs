namespace CountdownTimer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.onesSecondCounter = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tensSecondCounter = new System.Windows.Forms.NumericUpDown();
            this.onesMinuteCounter = new System.Windows.Forms.NumericUpDown();
            this.tensMinuteCounter = new System.Windows.Forms.NumericUpDown();
            this.controlButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.onesSecondCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tensSecondCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onesMinuteCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tensMinuteCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Countdown Timer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minute";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Second";
            // 
            // onesSecondCounter
            // 
            this.onesSecondCounter.Font = new System.Drawing.Font("Open Sans Extrabold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onesSecondCounter.Location = new System.Drawing.Point(220, 98);
            this.onesSecondCounter.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.onesSecondCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.onesSecondCounter.Name = "onesSecondCounter";
            this.onesSecondCounter.Size = new System.Drawing.Size(47, 51);
            this.onesSecondCounter.TabIndex = 3;
            this.onesSecondCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lithograph", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 39);
            this.label4.TabIndex = 4;
            this.label4.Text = ":";
            // 
            // tensSecondCounter
            // 
            this.tensSecondCounter.Font = new System.Drawing.Font("Open Sans Extrabold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tensSecondCounter.Location = new System.Drawing.Point(162, 98);
            this.tensSecondCounter.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.tensSecondCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.tensSecondCounter.Name = "tensSecondCounter";
            this.tensSecondCounter.Size = new System.Drawing.Size(47, 51);
            this.tensSecondCounter.TabIndex = 5;
            this.tensSecondCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // onesMinuteCounter
            // 
            this.onesMinuteCounter.Font = new System.Drawing.Font("Open Sans Extrabold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onesMinuteCounter.Location = new System.Drawing.Point(76, 98);
            this.onesMinuteCounter.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.onesMinuteCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.onesMinuteCounter.Name = "onesMinuteCounter";
            this.onesMinuteCounter.Size = new System.Drawing.Size(47, 51);
            this.onesMinuteCounter.TabIndex = 6;
            this.onesMinuteCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tensMinuteCounter
            // 
            this.tensMinuteCounter.Font = new System.Drawing.Font("Open Sans Extrabold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tensMinuteCounter.Location = new System.Drawing.Point(23, 98);
            this.tensMinuteCounter.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.tensMinuteCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.tensMinuteCounter.Name = "tensMinuteCounter";
            this.tensMinuteCounter.Size = new System.Drawing.Size(47, 51);
            this.tensMinuteCounter.TabIndex = 7;
            this.tensMinuteCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // controlButton
            // 
            this.controlButton.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlButton.Location = new System.Drawing.Point(76, 183);
            this.controlButton.Name = "controlButton";
            this.controlButton.Size = new System.Drawing.Size(121, 50);
            this.controlButton.TabIndex = 8;
            this.controlButton.Text = "Start";
            this.controlButton.UseVisualStyleBackColor = true;
            this.controlButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 280);
            this.Controls.Add(this.controlButton);
            this.Controls.Add(this.tensMinuteCounter);
            this.Controls.Add(this.onesMinuteCounter);
            this.Controls.Add(this.tensSecondCounter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.onesSecondCounter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(323, 319);
            this.MinimumSize = new System.Drawing.Size(323, 319);
            this.Name = "Form1";
            this.Text = "Countdown Timer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.onesSecondCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tensSecondCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onesMinuteCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tensMinuteCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown onesSecondCounter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown tensSecondCounter;
        private System.Windows.Forms.NumericUpDown onesMinuteCounter;
        private System.Windows.Forms.NumericUpDown tensMinuteCounter;
        private System.Windows.Forms.Button controlButton;
    }
}

