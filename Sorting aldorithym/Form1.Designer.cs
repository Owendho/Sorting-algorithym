namespace Sorting_aldorithym
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
            this.lstBox = new System.Windows.Forms.ListBox();
            this.lstBox2 = new System.Windows.Forms.ListBox();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.btnOne = new System.Windows.Forms.Button();
            this.NumberGenerator = new System.Windows.Forms.Button();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 16;
            this.lstBox.Location = new System.Drawing.Point(12, 25);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(242, 388);
            this.lstBox.TabIndex = 0;
            // 
            // lstBox2
            // 
            this.lstBox2.FormattingEnabled = true;
            this.lstBox2.ItemHeight = 16;
            this.lstBox2.Location = new System.Drawing.Point(545, 25);
            this.lstBox2.Name = "lstBox2";
            this.lstBox2.Size = new System.Drawing.Size(242, 388);
            this.lstBox2.TabIndex = 1;
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(107, 443);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(147, 22);
            this.txtBox1.TabIndex = 2;
            this.txtBox1.TextChanged += new System.EventHandler(this.txtBox1_TextChanged);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(327, 25);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(161, 81);
            this.btnOne.TabIndex = 3;
            this.btnOne.Text = "bubbleSort";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // NumberGenerator
            // 
            this.NumberGenerator.Location = new System.Drawing.Point(327, 125);
            this.NumberGenerator.Name = "NumberGenerator";
            this.NumberGenerator.Size = new System.Drawing.Size(161, 70);
            this.NumberGenerator.TabIndex = 4;
            this.NumberGenerator.Text = "Generate";
            this.NumberGenerator.UseVisualStyleBackColor = true;
            this.NumberGenerator.Click += new System.EventHandler(this.NumberGenerator_Click);
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(599, 443);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(147, 22);
            this.txtBox2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 548);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.NumberGenerator);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.lstBox2);
            this.Controls.Add(this.lstBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.ListBox lstBox2;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button NumberGenerator;
        private System.Windows.Forms.TextBox txtBox2;
    }
}

