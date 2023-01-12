namespace Section_A_Lab___Blake
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
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnFillRandom = new System.Windows.Forms.Button();
            this.btnLoopArray = new System.Windows.Forms.Button();
            this.txtStrt = new System.Windows.Forms.TextBox();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 15;
            this.lstOutput.Location = new System.Drawing.Point(12, 12);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(177, 454);
            this.lstOutput.TabIndex = 0;
            // 
            // btnFillRandom
            // 
            this.btnFillRandom.Location = new System.Drawing.Point(195, 12);
            this.btnFillRandom.Name = "btnFillRandom";
            this.btnFillRandom.Size = new System.Drawing.Size(116, 23);
            this.btnFillRandom.TabIndex = 1;
            this.btnFillRandom.Text = "Fill Random 0 - 100";
            this.btnFillRandom.UseVisualStyleBackColor = true;
            this.btnFillRandom.Click += new System.EventHandler(this.btnFillRandom_Click);
            // 
            // btnLoopArray
            // 
            this.btnLoopArray.Location = new System.Drawing.Point(195, 41);
            this.btnLoopArray.Name = "btnLoopArray";
            this.btnLoopArray.Size = new System.Drawing.Size(116, 23);
            this.btnLoopArray.TabIndex = 2;
            this.btnLoopArray.Text = "Sum of all values";
            this.btnLoopArray.UseVisualStyleBackColor = true;
            this.btnLoopArray.Click += new System.EventHandler(this.btnLoopArray_Click);
            // 
            // txtStrt
            // 
            this.txtStrt.Location = new System.Drawing.Point(195, 102);
            this.txtStrt.Name = "txtStrt";
            this.txtStrt.Size = new System.Drawing.Size(116, 23);
            this.txtStrt.TabIndex = 3;
            // 
            // txtVal
            // 
            this.txtVal.Location = new System.Drawing.Point(195, 162);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(116, 23);
            this.txtVal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start Script:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Values:";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(210, 191);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 7;
            this.btnDisplay.Text = "Display Range";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 479);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.txtStrt);
            this.Controls.Add(this.btnLoopArray);
            this.Controls.Add(this.btnFillRandom);
            this.Controls.Add(this.lstOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstOutput;
        private Button btnFillRandom;
        private Button btnLoopArray;
        private TextBox txtStrt;
        private TextBox txtVal;
        private Label label1;
        private Label label2;
        private Button btnDisplay;
    }
}