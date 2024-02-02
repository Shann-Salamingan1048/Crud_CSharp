namespace Crud_CSharp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Label_FN = new System.Windows.Forms.Label();
            this.FN_TextBox = new System.Windows.Forms.TextBox();
            this.MN_TextBox = new System.Windows.Forms.TextBox();
            this.MN_Label = new System.Windows.Forms.Label();
            this.LN_TextBox = new System.Windows.Forms.TextBox();
            this.LN_Label = new System.Windows.Forms.Label();
            this.Age_TextBox = new System.Windows.Forms.TextBox();
            this.Age_Label = new System.Windows.Forms.Label();
            this.Address_TextBox = new System.Windows.Forms.TextBox();
            this.Address_Label = new System.Windows.Forms.Label();
            this.Email_Ad_TextBox = new System.Windows.Forms.TextBox();
            this.Email_Address_Label = new System.Windows.Forms.Label();
            this.EmployeeID_TextBox = new System.Windows.Forms.TextBox();
            this.EmployeeID_Label = new System.Windows.Forms.Label();
            this.Create_btn = new System.Windows.Forms.Button();
            this.Read_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(550, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(836, 547);
            this.dataGridView1.TabIndex = 0;
            // 
            // Label_FN
            // 
            this.Label_FN.AutoSize = true;
            this.Label_FN.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FN.Location = new System.Drawing.Point(3, 59);
            this.Label_FN.Name = "Label_FN";
            this.Label_FN.Size = new System.Drawing.Size(188, 36);
            this.Label_FN.TabIndex = 1;
            this.Label_FN.Text = "First Name: ";
            // 
            // FN_TextBox
            // 
            this.FN_TextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FN_TextBox.Location = new System.Drawing.Point(197, 59);
            this.FN_TextBox.Name = "FN_TextBox";
            this.FN_TextBox.Size = new System.Drawing.Size(318, 44);
            this.FN_TextBox.TabIndex = 2;
            // 
            // MN_TextBox
            // 
            this.MN_TextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MN_TextBox.Location = new System.Drawing.Point(197, 134);
            this.MN_TextBox.Name = "MN_TextBox";
            this.MN_TextBox.Size = new System.Drawing.Size(318, 44);
            this.MN_TextBox.TabIndex = 4;
            // 
            // MN_Label
            // 
            this.MN_Label.AutoSize = true;
            this.MN_Label.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MN_Label.Location = new System.Drawing.Point(-9, 137);
            this.MN_Label.Name = "MN_Label";
            this.MN_Label.Size = new System.Drawing.Size(221, 36);
            this.MN_Label.TabIndex = 3;
            this.MN_Label.Text = "Middle Name: ";
            // 
            // LN_TextBox
            // 
            this.LN_TextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LN_TextBox.Location = new System.Drawing.Point(197, 197);
            this.LN_TextBox.Name = "LN_TextBox";
            this.LN_TextBox.Size = new System.Drawing.Size(318, 44);
            this.LN_TextBox.TabIndex = 6;
            // 
            // LN_Label
            // 
            this.LN_Label.AutoSize = true;
            this.LN_Label.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LN_Label.Location = new System.Drawing.Point(3, 197);
            this.LN_Label.Name = "LN_Label";
            this.LN_Label.Size = new System.Drawing.Size(182, 36);
            this.LN_Label.TabIndex = 5;
            this.LN_Label.Text = "Last Name: ";
            // 
            // Age_TextBox
            // 
            this.Age_TextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age_TextBox.Location = new System.Drawing.Point(197, 266);
            this.Age_TextBox.Name = "Age_TextBox";
            this.Age_TextBox.Size = new System.Drawing.Size(318, 44);
            this.Age_TextBox.TabIndex = 8;
            this.Age_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // Age_Label
            // 
            this.Age_Label.AutoSize = true;
            this.Age_Label.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age_Label.Location = new System.Drawing.Point(89, 266);
            this.Age_Label.Name = "Age_Label";
            this.Age_Label.Size = new System.Drawing.Size(87, 36);
            this.Age_Label.TabIndex = 7;
            this.Age_Label.Text = "Age: ";
            // 
            // Address_TextBox
            // 
            this.Address_TextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_TextBox.Location = new System.Drawing.Point(197, 334);
            this.Address_TextBox.Name = "Address_TextBox";
            this.Address_TextBox.Size = new System.Drawing.Size(318, 44);
            this.Address_TextBox.TabIndex = 10;
            // 
            // Address_Label
            // 
            this.Address_Label.AutoSize = true;
            this.Address_Label.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_Label.Location = new System.Drawing.Point(47, 334);
            this.Address_Label.Name = "Address_Label";
            this.Address_Label.Size = new System.Drawing.Size(144, 36);
            this.Address_Label.TabIndex = 9;
            this.Address_Label.Text = "Address: ";
            // 
            // Email_Ad_TextBox
            // 
            this.Email_Ad_TextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_Ad_TextBox.Location = new System.Drawing.Point(197, 397);
            this.Email_Ad_TextBox.Name = "Email_Ad_TextBox";
            this.Email_Ad_TextBox.Size = new System.Drawing.Size(318, 44);
            this.Email_Ad_TextBox.TabIndex = 12;
            // 
            // Email_Address_Label
            // 
            this.Email_Address_Label.AutoSize = true;
            this.Email_Address_Label.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_Address_Label.Location = new System.Drawing.Point(-9, 403);
            this.Email_Address_Label.Name = "Email_Address_Label";
            this.Email_Address_Label.Size = new System.Drawing.Size(203, 32);
            this.Email_Address_Label.TabIndex = 11;
            this.Email_Address_Label.Text = "Email Address: ";
            // 
            // EmployeeID_TextBox
            // 
            this.EmployeeID_TextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeID_TextBox.Location = new System.Drawing.Point(197, 464);
            this.EmployeeID_TextBox.Name = "EmployeeID_TextBox";
            this.EmployeeID_TextBox.Size = new System.Drawing.Size(318, 44);
            this.EmployeeID_TextBox.TabIndex = 14;
            // 
            // EmployeeID_Label
            // 
            this.EmployeeID_Label.AutoSize = true;
            this.EmployeeID_Label.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeID_Label.Location = new System.Drawing.Point(-8, 467);
            this.EmployeeID_Label.Name = "EmployeeID_Label";
            this.EmployeeID_Label.Size = new System.Drawing.Size(202, 36);
            this.EmployeeID_Label.TabIndex = 13;
            this.EmployeeID_Label.Text = "Employee ID:";
            // 
            // Create_btn
            // 
            this.Create_btn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_btn.Location = new System.Drawing.Point(12, 628);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(230, 104);
            this.Create_btn.TabIndex = 15;
            this.Create_btn.Text = "Create";
            this.Create_btn.UseVisualStyleBackColor = true;
            this.Create_btn.Click += new System.EventHandler(this.Create_btn_Click);
            // 
            // Read_btn
            // 
            this.Read_btn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Read_btn.Location = new System.Drawing.Point(285, 628);
            this.Read_btn.Name = "Read_btn";
            this.Read_btn.Size = new System.Drawing.Size(230, 104);
            this.Read_btn.TabIndex = 16;
            this.Read_btn.Text = "Read";
            this.Read_btn.UseVisualStyleBackColor = true;
            this.Read_btn.Click += new System.EventHandler(this.Read_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.Location = new System.Drawing.Point(550, 628);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(230, 104);
            this.Update_btn.TabIndex = 17;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.Location = new System.Drawing.Point(807, 628);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(230, 104);
            this.Delete_btn.TabIndex = 18;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 813);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.Read_btn);
            this.Controls.Add(this.Create_btn);
            this.Controls.Add(this.EmployeeID_TextBox);
            this.Controls.Add(this.EmployeeID_Label);
            this.Controls.Add(this.Email_Ad_TextBox);
            this.Controls.Add(this.Email_Address_Label);
            this.Controls.Add(this.Address_TextBox);
            this.Controls.Add(this.Address_Label);
            this.Controls.Add(this.Age_TextBox);
            this.Controls.Add(this.Age_Label);
            this.Controls.Add(this.LN_TextBox);
            this.Controls.Add(this.LN_Label);
            this.Controls.Add(this.MN_TextBox);
            this.Controls.Add(this.MN_Label);
            this.Controls.Add(this.FN_TextBox);
            this.Controls.Add(this.Label_FN);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Label_FN;
        private System.Windows.Forms.TextBox FN_TextBox;
        private System.Windows.Forms.TextBox MN_TextBox;
        private System.Windows.Forms.Label MN_Label;
        private System.Windows.Forms.TextBox LN_TextBox;
        private System.Windows.Forms.Label LN_Label;
        private System.Windows.Forms.TextBox Age_TextBox;
        private System.Windows.Forms.Label Age_Label;
        private System.Windows.Forms.TextBox Address_TextBox;
        private System.Windows.Forms.Label Address_Label;
        private System.Windows.Forms.TextBox Email_Ad_TextBox;
        private System.Windows.Forms.Label Email_Address_Label;
        private System.Windows.Forms.TextBox EmployeeID_TextBox;
        private System.Windows.Forms.Label EmployeeID_Label;
        private System.Windows.Forms.Button Create_btn;
        private System.Windows.Forms.Button Read_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Delete_btn;
    }
}

