namespace LoginForm.Properties
{
    partial class Dictionary
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbLookUp = new System.Windows.Forms.TextBox();
            this.tbShow = new System.Windows.Forms.TextBox();
            this.btnLookUp = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dictionary Alpha";
            // 
            // tbLookUp
            // 
            this.tbLookUp.Location = new System.Drawing.Point(18, 46);
            this.tbLookUp.Multiline = true;
            this.tbLookUp.Name = "tbLookUp";
            this.tbLookUp.Size = new System.Drawing.Size(186, 77);
            this.tbLookUp.TabIndex = 1;
            // 
            // tbShow
            // 
            this.tbShow.Location = new System.Drawing.Point(222, 46);
            this.tbShow.Multiline = true;
            this.tbShow.Name = "tbShow";
            this.tbShow.Size = new System.Drawing.Size(186, 77);
            this.tbShow.TabIndex = 2;
            // 
            // btnLookUp
            // 
            this.btnLookUp.Location = new System.Drawing.Point(222, 143);
            this.btnLookUp.Name = "btnLookUp";
            this.btnLookUp.Size = new System.Drawing.Size(89, 23);
            this.btnLookUp.TabIndex = 3;
            this.btnLookUp.Text = "Look Up";
            this.btnLookUp.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(317, 143);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 183);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLookUp);
            this.Controls.Add(this.tbShow);
            this.Controls.Add(this.tbLookUp);
            this.Controls.Add(this.label1);
            this.Name = "Dictionary";
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.Dictionary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLookUp;
        private System.Windows.Forms.TextBox tbShow;
        private System.Windows.Forms.Button btnLookUp;
        private System.Windows.Forms.Button btnClear;
    }
}