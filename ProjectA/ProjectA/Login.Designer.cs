namespace ProjectA
{
    partial class Login
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
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnAdvisor = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnEvaluation = new System.Windows.Forms.Button();
            this.CreateGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(65, 109);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Project";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnAdvisor
            // 
            this.btnAdvisor.Location = new System.Drawing.Point(65, 247);
            this.btnAdvisor.Name = "btnAdvisor";
            this.btnAdvisor.Size = new System.Drawing.Size(75, 23);
            this.btnAdvisor.TabIndex = 5;
            this.btnAdvisor.Text = "Advisor";
            this.btnAdvisor.UseVisualStyleBackColor = true;
            this.btnAdvisor.Click += new System.EventHandler(this.btnAdvisor_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(149, 178);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(75, 23);
            this.btnStudent.TabIndex = 6;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnEvaluation
            // 
            this.btnEvaluation.Location = new System.Drawing.Point(241, 241);
            this.btnEvaluation.Name = "btnEvaluation";
            this.btnEvaluation.Size = new System.Drawing.Size(75, 29);
            this.btnEvaluation.TabIndex = 7;
            this.btnEvaluation.Text = "Evaluation";
            this.btnEvaluation.UseVisualStyleBackColor = true;
            this.btnEvaluation.Click += new System.EventHandler(this.btnEvaluation_Click);
            // 
            // CreateGroup
            // 
            this.CreateGroup.Location = new System.Drawing.Point(241, 109);
            this.CreateGroup.Name = "CreateGroup";
            this.CreateGroup.Size = new System.Drawing.Size(75, 23);
            this.CreateGroup.TabIndex = 8;
            this.CreateGroup.Text = "Create Group";
            this.CreateGroup.UseVisualStyleBackColor = true;
            this.CreateGroup.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 353);
            this.Controls.Add(this.CreateGroup);
            this.Controls.Add(this.btnEvaluation);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnAdvisor);
            this.Controls.Add(this.btnlogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnAdvisor;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnEvaluation;
        private System.Windows.Forms.Button CreateGroup;
    }
}