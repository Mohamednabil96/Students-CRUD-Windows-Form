namespace InsertStudentsITI
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
            lblID = new Label();
            txtID = new TextBox();
            txtFName = new TextBox();
            lblFName = new Label();
            txtLName = new TextBox();
            lblLName = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            lblResult = new Label();
            btnInsert = new Button();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(94, 56);
            lblID.Name = "lblID";
            lblID.Size = new Size(35, 20);
            lblID.TabIndex = 1;
            lblID.Text = "ID : ";
            // 
            // txtID
            // 
            txtID.Location = new Point(233, 56);
            txtID.Name = "txtID";
            txtID.Size = new Size(224, 27);
            txtID.TabIndex = 2;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(233, 122);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(224, 27);
            txtFName.TabIndex = 4;
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Location = new Point(94, 122);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(91, 20);
            lblFName.TabIndex = 3;
            lblFName.Text = "First Name : ";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(233, 186);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(224, 27);
            txtLName.TabIndex = 8;
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Location = new Point(94, 186);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(90, 20);
            lblLName.TabIndex = 7;
            lblLName.Text = "Last Name : ";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(233, 247);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(224, 27);
            txtAddress.TabIndex = 6;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(94, 247);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(73, 20);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "Address : ";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(507, 343);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(66, 20);
            lblResult.TabIndex = 9;
            lblResult.Text = "lblResult";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(94, 343);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 10;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 411);
            Controls.Add(btnInsert);
            Controls.Add(lblResult);
            Controls.Add(txtLName);
            Controls.Add(lblLName);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtFName);
            Controls.Add(lblFName);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblID;
        private TextBox txtID;
        private TextBox txtFName;
        private Label lblFName;
        private TextBox txtLName;
        private Label lblLName;
        private TextBox txtAddress;
        private Label lblAddress;
        private Label lblResult;
        private Button btnInsert;
    }
}