namespace WinFormProject
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
            this.Title = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.forName = new System.Windows.Forms.TextBox();
            this.forSurname = new System.Windows.Forms.TextBox();
            this.Division = new System.Windows.Forms.Label();
            this.forDivision = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.forAge = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.Label();
            this.forGender = new System.Windows.Forms.ComboBox();
            this.Insert = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.DataField = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Label();
            this.forSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataField)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(255, 9);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(163, 32);
            this.Title.TabIndex = 0;
            this.Title.Text = "EMPLOYEE";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(133, 49);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(43, 20);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            // 
            // forName
            // 
            this.forName.Location = new System.Drawing.Point(208, 44);
            this.forName.Name = "forName";
            this.forName.Size = new System.Drawing.Size(256, 25);
            this.forName.TabIndex = 0;
            // 
            // forSurname
            // 
            this.forSurname.Location = new System.Drawing.Point(208, 83);
            this.forSurname.Name = "forSurname";
            this.forSurname.Size = new System.Drawing.Size(256, 25);
            this.forSurname.TabIndex = 1;
            // 
            // Division
            // 
            this.Division.AutoSize = true;
            this.Division.Location = new System.Drawing.Point(133, 219);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(60, 20);
            this.Division.TabIndex = 3;
            this.Division.Text = "Division";
            // 
            // forDivision
            // 
            this.forDivision.Location = new System.Drawing.Point(208, 214);
            this.forDivision.Name = "forDivision";
            this.forDivision.Size = new System.Drawing.Size(256, 25);
            this.forDivision.TabIndex = 4;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(133, 171);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(54, 20);
            this.Gender.TabIndex = 5;
            this.Gender.Text = "Gender";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(133, 124);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(33, 20);
            this.Age.TabIndex = 7;
            this.Age.Text = "Age";
            // 
            // forAge
            // 
            this.forAge.Location = new System.Drawing.Point(208, 119);
            this.forAge.Name = "forAge";
            this.forAge.Size = new System.Drawing.Size(256, 25);
            this.forAge.TabIndex = 2;
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(133, 88);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(63, 20);
            this.Surname.TabIndex = 9;
            this.Surname.Text = "Surname";
            // 
            // forGender
            // 
            this.forGender.FormattingEnabled = true;
            this.forGender.Items.AddRange(new object[] {
            "Male",
            "Famale"});
            this.forGender.Location = new System.Drawing.Point(208, 163);
            this.forGender.Name = "forGender";
            this.forGender.Size = new System.Drawing.Size(256, 28);
            this.forGender.TabIndex = 3;
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(137, 311);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(71, 33);
            this.Insert.TabIndex = 5;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(225, 311);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(64, 33);
            this.Update.TabIndex = 6;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(312, 311);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(64, 33);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(400, 311);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(66, 33);
            this.Reset.TabIndex = 8;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // DataField
            // 
            this.DataField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataField.Location = new System.Drawing.Point(137, 378);
            this.DataField.Name = "DataField";
            this.DataField.Size = new System.Drawing.Size(329, 216);
            this.DataField.TabIndex = 9;
            this.DataField.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataField_MouseDoubleClick);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(133, 261);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(51, 20);
            this.Search.TabIndex = 10;
            this.Search.Text = "Search";
            // 
            // forSearch
            // 
            this.forSearch.Location = new System.Drawing.Point(208, 261);
            this.forSearch.Name = "forSearch";
            this.forSearch.Size = new System.Drawing.Size(256, 25);
            this.forSearch.TabIndex = 11;
            this.forSearch.TextChanged += new System.EventHandler(this.forSearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 615);
            this.Controls.Add(this.forSearch);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.DataField);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.forGender);
            this.Controls.Add(this.forAge);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.forDivision);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.forSurname);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.forName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox forName;
        private System.Windows.Forms.TextBox forSurname;
        private System.Windows.Forms.Label Division;
        private System.Windows.Forms.TextBox forDivision;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.TextBox forAge;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.ComboBox forGender;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.DataGridView DataField;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox forSearch;
    }
}

