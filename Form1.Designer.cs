namespace Attributes
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
            this.btnGetMemberFullName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetMemberFullName
            // 
            this.btnGetMemberFullName.Location = new System.Drawing.Point(141, 56);
            this.btnGetMemberFullName.Name = "btnGetMemberFullName";
            this.btnGetMemberFullName.Size = new System.Drawing.Size(177, 39);
            this.btnGetMemberFullName.TabIndex = 0;
            this.btnGetMemberFullName.Text = "Get Member Attribute FullName";
            this.btnGetMemberFullName.UseVisualStyleBackColor = true;
            this.btnGetMemberFullName.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.btnGetMemberFullName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetMemberFullName;
    }
}

