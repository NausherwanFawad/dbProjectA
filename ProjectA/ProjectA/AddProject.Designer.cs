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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblprojecttitle = new System.Windows.Forms.Label();
            this.ProjectDescription = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.txtDerscription = new System.Windows.Forms.TextBox();
            this.txtprojecttitle = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblprojecttitle
            // 
            this.lblprojecttitle.AutoSize = true;
            this.lblprojecttitle.Location = new System.Drawing.Point(27, 101);
            this.lblprojecttitle.Name = "lblprojecttitle";
            this.lblprojecttitle.Size = new System.Drawing.Size(63, 13);
            this.lblprojecttitle.TabIndex = 0;
            this.lblprojecttitle.Text = "Project Title";
            // 
            // ProjectDescription
            // 
            this.ProjectDescription.AutoSize = true;
            this.ProjectDescription.Location = new System.Drawing.Point(27, 167);
            this.ProjectDescription.Name = "ProjectDescription";
            this.ProjectDescription.Size = new System.Drawing.Size(96, 13);
            this.ProjectDescription.TabIndex = 1;
            this.ProjectDescription.Text = "Project Description";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(229, 248);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDerscription
            // 
            this.txtDerscription.Location = new System.Drawing.Point(165, 164);
            this.txtDerscription.Name = "txtDerscription";
            this.txtDerscription.Size = new System.Drawing.Size(139, 20);
            this.txtDerscription.TabIndex = 5;
            // 
            // txtprojecttitle
            // 
            this.txtprojecttitle.Location = new System.Drawing.Point(165, 98);
            this.txtprojecttitle.Name = "txtprojecttitle";
            this.txtprojecttitle.Size = new System.Drawing.Size(139, 20);
            this.txtprojecttitle.TabIndex = 6;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(36, 35);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Home";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(366, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 201);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Delete
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "DELETE";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 389);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtprojecttitle);
            this.Controls.Add(this.txtDerscription);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.ProjectDescription);
            this.Controls.Add(this.lblprojecttitle);
            this.Name = "AddProject";
            this.Text = "AddProject";
            this.Load += new System.EventHandler(this.AddProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblprojecttitle;
        private System.Windows.Forms.Label ProjectDescription;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox txtDerscription;
        private System.Windows.Forms.TextBox txtprojecttitle;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}