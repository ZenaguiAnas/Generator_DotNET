namespace Generateur_d_interface
{
    partial class DataBaseConnectionForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.HostDB = new System.Windows.Forms.TextBox();
            this.UsernameDB = new System.Windows.Forms.TextBox();
            this.PasswordDB = new System.Windows.Forms.TextBox();
            this.DatabaseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConnectDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HostDB
            // 
            this.HostDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.HostDB.Location = new System.Drawing.Point(189, 104);
            this.HostDB.Margin = new System.Windows.Forms.Padding(4);
            this.HostDB.Multiline = true;
            this.HostDB.Name = "HostDB";
            this.HostDB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.HostDB.Size = new System.Drawing.Size(343, 36);
            this.HostDB.TabIndex = 0;
            this.HostDB.TextChanged += new System.EventHandler(this.HostDB_TextChanged);
            // 
            // UsernameDB
            // 
            this.UsernameDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.UsernameDB.Location = new System.Drawing.Point(189, 190);
            this.UsernameDB.Margin = new System.Windows.Forms.Padding(4);
            this.UsernameDB.Multiline = true;
            this.UsernameDB.Name = "UsernameDB";
            this.UsernameDB.Size = new System.Drawing.Size(343, 36);
            this.UsernameDB.TabIndex = 1;
            // 
            // PasswordDB
            // 
            this.PasswordDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.PasswordDB.Location = new System.Drawing.Point(189, 299);
            this.PasswordDB.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordDB.Multiline = true;
            this.PasswordDB.Name = "PasswordDB";
            this.PasswordDB.Size = new System.Drawing.Size(343, 36);
            this.PasswordDB.TabIndex = 2;
            this.PasswordDB.UseSystemPasswordChar = true;
            // 
            // DatabaseName
            // 
            this.DatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.DatabaseName.Location = new System.Drawing.Point(188, 397);
            this.DatabaseName.Margin = new System.Windows.Forms.Padding(4);
            this.DatabaseName.Multiline = true;
            this.DatabaseName.Name = "DatabaseName";
            this.DatabaseName.Size = new System.Drawing.Size(343, 36);
            this.DatabaseName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.label1.Location = new System.Drawing.Point(293, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Host:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.label2.Location = new System.Drawing.Point(265, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.label3.Location = new System.Drawing.Point(279, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.label4.Location = new System.Drawing.Point(279, 354);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Database:";
            // 
            // ConnectDB
            // 
            this.ConnectDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnectDB.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.ConnectDB.Location = new System.Drawing.Point(272, 468);
            this.ConnectDB.Margin = new System.Windows.Forms.Padding(4);
            this.ConnectDB.Name = "ConnectDB";
            this.ConnectDB.Size = new System.Drawing.Size(164, 55);
            this.ConnectDB.TabIndex = 8;
            this.ConnectDB.Text = "Connect";
            this.ConnectDB.UseVisualStyleBackColor = true;
            this.ConnectDB.Click += new System.EventHandler(this.ConnectDB_Click);
            // 
            // DataBaseConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(699, 544);
            this.Controls.Add(this.ConnectDB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatabaseName);
            this.Controls.Add(this.PasswordDB);
            this.Controls.Add(this.UsernameDB);
            this.Controls.Add(this.HostDB);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(717, 591);
            this.MinimumSize = new System.Drawing.Size(717, 591);
            this.Name = "DataBaseConnectionForm";
            this.Text = "UIGen - Database Connection";
            this.Load += new System.EventHandler(this.DataBaseConnectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HostDB;
        private System.Windows.Forms.TextBox UsernameDB;
        private System.Windows.Forms.TextBox PasswordDB;
        private System.Windows.Forms.TextBox DatabaseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ConnectDB;
    }
}
