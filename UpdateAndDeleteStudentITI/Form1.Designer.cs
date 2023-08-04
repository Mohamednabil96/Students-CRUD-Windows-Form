namespace UpdateAndDeleteStudentITI
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
            comboStudents = new ComboBox();
            lblID = new Label();
            txtID = new TextBox();
            txtFName = new TextBox();
            lblFName = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtLName = new TextBox();
            lblLName = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // comboStudents
            // 
            comboStudents.FormattingEnabled = true;
            comboStudents.Location = new Point(73, 41);
            comboStudents.Name = "comboStudents";
            comboStudents.Size = new Size(231, 28);
            comboStudents.TabIndex = 0;
            comboStudents.SelectedIndexChanged += comboStudents_SelectedIndexChanged_1;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(98, 105);
            lblID.Name = "lblID";
            lblID.Size = new Size(35, 20);
            lblID.TabIndex = 1;
            lblID.Text = "ID : ";
            // 
            // txtID
            // 
            txtID.Location = new Point(196, 105);
            txtID.Name = "txtID";
            txtID.Size = new Size(213, 27);
            txtID.TabIndex = 2;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(196, 156);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(213, 27);
            txtFName.TabIndex = 4;
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Location = new Point(98, 156);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(91, 20);
            lblFName.TabIndex = 3;
            lblFName.Text = "First Name : ";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(196, 267);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(213, 27);
            txtAddress.TabIndex = 8;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(98, 267);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(73, 20);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "Address : ";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(196, 216);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(213, 27);
            txtLName.TabIndex = 6;
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Location = new Point(98, 216);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(90, 20);
            lblLName.TabIndex = 5;
            lblLName.Text = "Last Name : ";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaption;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(98, 381);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(315, 381);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(556, 385);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(49, 20);
            lblResult.TabIndex = 11;
            lblResult.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtLName);
            Controls.Add(lblLName);
            Controls.Add(txtFName);
            Controls.Add(lblFName);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Controls.Add(comboStudents);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboStudents;
        private Label lblID;
        private TextBox txtID;
        private TextBox txtFName;
        private Label lblFName;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtLName;
        private Label lblLName;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lblResult;
    }
}