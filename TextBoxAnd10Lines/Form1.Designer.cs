namespace TextBoxAnd10Lines
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.InsertionTbx = new System.Windows.Forms.TextBox();
            this.Output10LinesLimitedTbx = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InsertBtn);
            this.groupBox1.Controls.Add(this.InsertionTbx);
            this.groupBox1.Location = new System.Drawing.Point(10, 276);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.MaximumSize = new System.Drawing.Size(679, 53);
            this.groupBox1.MinimumSize = new System.Drawing.Size(679, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(679, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertion";
            // 
            // InsertBtn
            // 
            this.InsertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertBtn.Enabled = false;
            this.InsertBtn.Location = new System.Drawing.Point(592, 20);
            this.InsertBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(82, 22);
            this.InsertBtn.TabIndex = 1;
            this.InsertBtn.Text = "INSERT";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InsertTextInto10LinesTbx);
            // 
            // InsertionTbx
            // 
            this.InsertionTbx.Location = new System.Drawing.Point(5, 22);
            this.InsertionTbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertionTbx.Multiline = true;
            this.InsertionTbx.Name = "InsertionTbx";
            this.InsertionTbx.Size = new System.Drawing.Size(582, 27);
            this.InsertionTbx.TabIndex = 0;
            this.InsertionTbx.TextChanged += new System.EventHandler(this.ChangeInsertBtnState);
            this.InsertionTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnEnterHit);
            // 
            // Output10LinesLimitedTbx
            // 
            this.Output10LinesLimitedTbx.CausesValidation = false;
            this.Output10LinesLimitedTbx.Location = new System.Drawing.Point(16, 9);
            this.Output10LinesLimitedTbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Output10LinesLimitedTbx.MaximumSize = new System.Drawing.Size(669, 264);
            this.Output10LinesLimitedTbx.MinimumSize = new System.Drawing.Size(669, 264);
            this.Output10LinesLimitedTbx.Multiline = true;
            this.Output10LinesLimitedTbx.Name = "Output10LinesLimitedTbx";
            this.Output10LinesLimitedTbx.ReadOnly = true;
            this.Output10LinesLimitedTbx.Size = new System.Drawing.Size(669, 264);
            this.Output10LinesLimitedTbx.TabIndex = 1;
            this.Output10LinesLimitedTbx.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 336);
            this.Controls.Add(this.Output10LinesLimitedTbx);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(718, 375);
            this.MinimumSize = new System.Drawing.Size(718, 375);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button InsertBtn;
        private TextBox InsertionTbx;
        private TextBox Output10LinesLimitedTbx;
    }
}