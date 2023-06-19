namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.NewParty = new System.Windows.Forms.GroupBox();
            this.Create = new System.Windows.Forms.Button();
            this.FeePerPerson1 = new System.Windows.Forms.Label();
            this.CostPerPerson1 = new System.Windows.Forms.Label();
            this.MaxNumOfGuests1 = new System.Windows.Forms.Label();
            this.FeePerPerson11 = new System.Windows.Forms.TextBox();
            this.CostPerPerson11 = new System.Windows.Forms.TextBox();
            this.MaxNumOfGuests11 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumOfGuests11 = new System.Windows.Forms.Label();
            this.Deficit11 = new System.Windows.Forms.Label();
            this.TotalFee11 = new System.Windows.Forms.Label();
            this.TotalCost11 = new System.Windows.Forms.Label();
            this.TotalCost1 = new System.Windows.Forms.Label();
            this.Deficit1 = new System.Windows.Forms.Label();
            this.TotalFee1 = new System.Windows.Forms.Label();
            this.NumOfGuests1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Add = new System.Windows.Forms.Button();
            this.LastName1 = new System.Windows.Forms.Label();
            this.FirstName1 = new System.Windows.Forms.Label();
            this.LastName11 = new System.Windows.Forms.TextBox();
            this.FirstName11 = new System.Windows.Forms.TextBox();
            this.LBoxShowGuestList = new System.Windows.Forms.ListView();
            this.Delete = new System.Windows.Forms.Button();
            this.NewParty.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewParty
            // 
            this.NewParty.BackColor = System.Drawing.Color.Gray;
            this.NewParty.Controls.Add(this.Create);
            this.NewParty.Controls.Add(this.FeePerPerson1);
            this.NewParty.Controls.Add(this.CostPerPerson1);
            this.NewParty.Controls.Add(this.MaxNumOfGuests1);
            this.NewParty.Controls.Add(this.FeePerPerson11);
            this.NewParty.Controls.Add(this.CostPerPerson11);
            this.NewParty.Controls.Add(this.MaxNumOfGuests11);
            this.NewParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewParty.ForeColor = System.Drawing.Color.Black;
            this.NewParty.Location = new System.Drawing.Point(12, 22);
            this.NewParty.Name = "NewParty";
            this.NewParty.Size = new System.Drawing.Size(395, 293);
            this.NewParty.TabIndex = 0;
            this.NewParty.TabStop = false;
            this.NewParty.Text = "New Party";
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.White;
            this.Create.ForeColor = System.Drawing.Color.Black;
            this.Create.Location = new System.Drawing.Point(255, 223);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(120, 45);
            this.Create.TabIndex = 6;
            this.Create.Text = "Create List";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // FeePerPerson1
            // 
            this.FeePerPerson1.AutoSize = true;
            this.FeePerPerson1.ForeColor = System.Drawing.Color.Black;
            this.FeePerPerson1.Location = new System.Drawing.Point(6, 184);
            this.FeePerPerson1.Name = "FeePerPerson1";
            this.FeePerPerson1.Size = new System.Drawing.Size(131, 20);
            this.FeePerPerson1.TabIndex = 5;
            this.FeePerPerson1.Text = "Fee per person";
            // 
            // CostPerPerson1
            // 
            this.CostPerPerson1.AutoSize = true;
            this.CostPerPerson1.ForeColor = System.Drawing.Color.Black;
            this.CostPerPerson1.Location = new System.Drawing.Point(6, 116);
            this.CostPerPerson1.Name = "CostPerPerson1";
            this.CostPerPerson1.Size = new System.Drawing.Size(137, 20);
            this.CostPerPerson1.TabIndex = 4;
            this.CostPerPerson1.Text = "Cost per person";
            // 
            // MaxNumOfGuests1
            // 
            this.MaxNumOfGuests1.AutoSize = true;
            this.MaxNumOfGuests1.ForeColor = System.Drawing.Color.Black;
            this.MaxNumOfGuests1.Location = new System.Drawing.Point(6, 49);
            this.MaxNumOfGuests1.Name = "MaxNumOfGuests1";
            this.MaxNumOfGuests1.Size = new System.Drawing.Size(186, 20);
            this.MaxNumOfGuests1.TabIndex = 3;
            this.MaxNumOfGuests1.Text = "Max number of guests";
            this.MaxNumOfGuests1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FeePerPerson11
            // 
            this.FeePerPerson11.BackColor = System.Drawing.Color.White;
            this.FeePerPerson11.Location = new System.Drawing.Point(225, 178);
            this.FeePerPerson11.Name = "FeePerPerson11";
            this.FeePerPerson11.Size = new System.Drawing.Size(150, 26);
            this.FeePerPerson11.TabIndex = 2;
            // 
            // CostPerPerson11
            // 
            this.CostPerPerson11.BackColor = System.Drawing.Color.White;
            this.CostPerPerson11.Location = new System.Drawing.Point(225, 110);
            this.CostPerPerson11.Name = "CostPerPerson11";
            this.CostPerPerson11.Size = new System.Drawing.Size(150, 26);
            this.CostPerPerson11.TabIndex = 1;
            // 
            // MaxNumOfGuests11
            // 
            this.MaxNumOfGuests11.BackColor = System.Drawing.Color.White;
            this.MaxNumOfGuests11.Location = new System.Drawing.Point(225, 43);
            this.MaxNumOfGuests11.Name = "MaxNumOfGuests11";
            this.MaxNumOfGuests11.Size = new System.Drawing.Size(150, 26);
            this.MaxNumOfGuests11.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.NumOfGuests11);
            this.groupBox2.Controls.Add(this.Deficit11);
            this.groupBox2.Controls.Add(this.TotalFee11);
            this.groupBox2.Controls.Add(this.TotalCost11);
            this.groupBox2.Controls.Add(this.TotalCost1);
            this.groupBox2.Controls.Add(this.Deficit1);
            this.groupBox2.Controls.Add(this.TotalFee1);
            this.groupBox2.Controls.Add(this.NumOfGuests1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Summary";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // NumOfGuests11
            // 
            this.NumOfGuests11.BackColor = System.Drawing.Color.Black;
            this.NumOfGuests11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NumOfGuests11.Location = new System.Drawing.Point(323, 22);
            this.NumOfGuests11.Name = "NumOfGuests11";
            this.NumOfGuests11.Size = new System.Drawing.Size(172, 34);
            this.NumOfGuests11.TabIndex = 7;
            this.NumOfGuests11.Text = "label13";
            // 
            // Deficit11
            // 
            this.Deficit11.BackColor = System.Drawing.Color.Black;
            this.Deficit11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Deficit11.Location = new System.Drawing.Point(323, 182);
            this.Deficit11.Name = "Deficit11";
            this.Deficit11.Size = new System.Drawing.Size(172, 32);
            this.Deficit11.TabIndex = 6;
            this.Deficit11.Text = "label12";
            // 
            // TotalFee11
            // 
            this.TotalFee11.BackColor = System.Drawing.Color.Black;
            this.TotalFee11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalFee11.Location = new System.Drawing.Point(323, 132);
            this.TotalFee11.Name = "TotalFee11";
            this.TotalFee11.Size = new System.Drawing.Size(172, 30);
            this.TotalFee11.TabIndex = 5;
            this.TotalFee11.Text = "label11";
            // 
            // TotalCost11
            // 
            this.TotalCost11.BackColor = System.Drawing.Color.Black;
            this.TotalCost11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalCost11.Location = new System.Drawing.Point(323, 81);
            this.TotalCost11.Name = "TotalCost11";
            this.TotalCost11.Size = new System.Drawing.Size(172, 29);
            this.TotalCost11.TabIndex = 4;
            this.TotalCost11.Text = "label10";
            // 
            // TotalCost1
            // 
            this.TotalCost1.ForeColor = System.Drawing.Color.White;
            this.TotalCost1.Location = new System.Drawing.Point(16, 82);
            this.TotalCost1.Name = "TotalCost1";
            this.TotalCost1.Size = new System.Drawing.Size(121, 29);
            this.TotalCost1.TabIndex = 3;
            this.TotalCost1.Text = "Total Cost";
            // 
            // Deficit1
            // 
            this.Deficit1.ForeColor = System.Drawing.Color.White;
            this.Deficit1.Location = new System.Drawing.Point(18, 182);
            this.Deficit1.Name = "Deficit1";
            this.Deficit1.Size = new System.Drawing.Size(100, 32);
            this.Deficit1.TabIndex = 2;
            this.Deficit1.Text = "Deficit";
            // 
            // TotalFee1
            // 
            this.TotalFee1.ForeColor = System.Drawing.Color.White;
            this.TotalFee1.Location = new System.Drawing.Point(18, 132);
            this.TotalFee1.Name = "TotalFee1";
            this.TotalFee1.Size = new System.Drawing.Size(119, 38);
            this.TotalFee1.TabIndex = 1;
            this.TotalFee1.Text = "Total Fee";
            // 
            // NumOfGuests1
            // 
            this.NumOfGuests1.ForeColor = System.Drawing.Color.White;
            this.NumOfGuests1.Location = new System.Drawing.Point(16, 32);
            this.NumOfGuests1.Name = "NumOfGuests1";
            this.NumOfGuests1.Size = new System.Drawing.Size(176, 34);
            this.NumOfGuests1.TabIndex = 0;
            this.NumOfGuests1.Text = "Number of guests";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gray;
            this.groupBox3.Controls.Add(this.Add);
            this.groupBox3.Controls.Add(this.LastName1);
            this.groupBox3.Controls.Add(this.FirstName1);
            this.groupBox3.Controls.Add(this.LastName11);
            this.groupBox3.Controls.Add(this.FirstName11);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(424, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 293);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Invite Guest";
            // 
            // Add
            // 
            this.Add.ForeColor = System.Drawing.Color.Black;
            this.Add.Location = new System.Drawing.Point(209, 223);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(120, 45);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // LastName1
            // 
            this.LastName1.AutoSize = true;
            this.LastName1.BackColor = System.Drawing.Color.Gray;
            this.LastName1.ForeColor = System.Drawing.Color.Black;
            this.LastName1.Location = new System.Drawing.Point(26, 136);
            this.LastName1.Name = "LastName1";
            this.LastName1.Size = new System.Drawing.Size(95, 20);
            this.LastName1.TabIndex = 3;
            this.LastName1.Text = "Last Name";
            this.LastName1.Click += new System.EventHandler(this.LastName1_Click);
            // 
            // FirstName1
            // 
            this.FirstName1.AutoSize = true;
            this.FirstName1.BackColor = System.Drawing.Color.Gray;
            this.FirstName1.ForeColor = System.Drawing.Color.Black;
            this.FirstName1.Location = new System.Drawing.Point(26, 55);
            this.FirstName1.Name = "FirstName1";
            this.FirstName1.Size = new System.Drawing.Size(96, 20);
            this.FirstName1.TabIndex = 2;
            this.FirstName1.Text = "First Name";
            // 
            // LastName11
            // 
            this.LastName11.BackColor = System.Drawing.Color.White;
            this.LastName11.ForeColor = System.Drawing.SystemColors.InfoText;
            this.LastName11.Location = new System.Drawing.Point(169, 130);
            this.LastName11.Name = "LastName11";
            this.LastName11.Size = new System.Drawing.Size(160, 26);
            this.LastName11.TabIndex = 1;
            // 
            // FirstName11
            // 
            this.FirstName11.BackColor = System.Drawing.Color.White;
            this.FirstName11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FirstName11.Location = new System.Drawing.Point(169, 49);
            this.FirstName11.Name = "FirstName11";
            this.FirstName11.Size = new System.Drawing.Size(160, 26);
            this.FirstName11.TabIndex = 0;
            this.FirstName11.TextChanged += new System.EventHandler(this.FirstName11_TextChanged);
            // 
            // LBoxShowGuestList
            // 
            this.LBoxShowGuestList.AllowDrop = true;
            this.LBoxShowGuestList.FullRowSelect = true;
            this.LBoxShowGuestList.HideSelection = false;
            this.LBoxShowGuestList.HoverSelection = true;
            this.LBoxShowGuestList.Location = new System.Drawing.Point(851, 22);
            this.LBoxShowGuestList.Name = "LBoxShowGuestList";
            this.LBoxShowGuestList.Size = new System.Drawing.Size(355, 478);
            this.LBoxShowGuestList.TabIndex = 7;
            this.LBoxShowGuestList.UseCompatibleStateImageBehavior = false;
            this.LBoxShowGuestList.View = System.Windows.Forms.View.List;
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.Red;
            this.Delete.Location = new System.Drawing.Point(983, 520);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(120, 45);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1228, 574);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.LBoxShowGuestList);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.NewParty);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "MainForm";
            this.Text = "Party Planner by";
            this.NewParty.ResumeLayout(false);
            this.NewParty.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NewParty;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label MaxNumOfGuests1;
        private System.Windows.Forms.TextBox FeePerPerson11;
        private System.Windows.Forms.TextBox CostPerPerson11;
        private System.Windows.Forms.TextBox MaxNumOfGuests11;
        private System.Windows.Forms.TextBox LastName11;
        private System.Windows.Forms.TextBox FirstName11;
        private System.Windows.Forms.Label FeePerPerson1;
        private System.Windows.Forms.Label CostPerPerson1;
        private System.Windows.Forms.Label NumOfGuests1;
        private System.Windows.Forms.Label LastName1;
        private System.Windows.Forms.Label FirstName1;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label NumOfGuests11;
        private System.Windows.Forms.Label Deficit11;
        private System.Windows.Forms.Label TotalFee11;
        private System.Windows.Forms.Label TotalCost11;
        private System.Windows.Forms.Label TotalCost1;
        private System.Windows.Forms.Label Deficit1;
        private System.Windows.Forms.Label TotalFee1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ListView LBoxShowGuestList;
        private System.Windows.Forms.Button Delete;
    }
}

