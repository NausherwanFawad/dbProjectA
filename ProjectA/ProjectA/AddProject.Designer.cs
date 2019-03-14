namespace ProjectA
{
    partial class AddProject
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
            this.lblprojecttitle = new System.Windows.Forms.Label();
            this.ProjectDescription = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.txtDerscription = new System.Windows.Forms.TextBox();
            this.txtprojecttitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblprojecttitle
            // 
            this.lblprojecttitle.AutoSize = true;
            this.lblprojecttitle.Location = new System.Drawing.Point(95, 98);
            this.lblprojecttitle.Name = "lblprojecttitle";
            this.lblprojecttitle.Size = new System.Drawing.Size(63, 13);
            this.lblprojecttitle.TabIndex = 0;
            this.lblprojecttitle.Text = "Project Title";
            // 
            // ProjectDescription
            // 
            this.ProjectDescription.AutoSize = true;
            this.ProjectDescription.Location = new System.Drawing.Point(95, 164);
            this.ProjectDescription.Name = "ProjectDescription";
            this.ProjectDescription.Size = new System.Drawing.Size(96, 13);
            this.ProjectDescription.TabIndex = 1;
            this.ProjectDescription.Text = "Project Description";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(297, 245);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDerscription
            // 
            this.txtDerscription.Location = new System.Drawing.Point(233, 161);
            this.txtDerscription.Name = "txtDerscription";
            this.txtDerscription.Size = new System.Drawing.Size(139, 20);
            this.txtDerscription.TabIndex = 5;
            // 
            // txtprojecttitle
            // 
            this.txtprojecttitle.Location = new System.Drawing.Point(233, 95);
            this.txtprojecttitle.Name = "txtprojecttitle";
            this.txtprojecttitle.Size = new System.Drawing.Size(139, 20);
            this.txtprojecttitle.TabIndex = 6;
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 336);
            this.Controls.Add(this.txtprojecttitle);
            this.Controls.Add(this.txtDerscription);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.ProjectDescription);
            this.Controls.Add(this.lblprojecttitle);
            this.Name = "AddProject";
            this.Text = "AddProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblprojecttitle;
        private System.Windows.Forms.Label ProjectDescription;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox txtDerscription;
        private System.Windows.Forms.TextBox txtprojecttitle;
    }
}