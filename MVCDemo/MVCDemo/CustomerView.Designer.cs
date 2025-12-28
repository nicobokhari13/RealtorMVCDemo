namespace MVCDemo {
    public partial class CustomerView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            button1 = new Button();
            SearchResults = new ListView();
            Address = new ColumnHeader();
            City = new ColumnHeader();
            Zip = new ColumnHeader();
            ID = new ColumnHeader();
            label1 = new Label();
            SearchBox = new TextBox();
            SearchButton = new Button();
            InstructionsSeeHouseDetails = new Label();
            ResetSearch = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(751, 12);
            button1.Name = "button1";
            button1.Size = new Size(294, 48);
            button1.TabIndex = 1;
            button1.Text = "Back to MainView";
            button1.UseVisualStyleBackColor = true;
            button1.Click += onMainViewButtonClick;
            // 
            // SearchResults
            // 
            SearchResults.Columns.AddRange(new ColumnHeader[] { Address, City, Zip, ID });
            SearchResults.FullRowSelect = true;
            SearchResults.GridLines = true;
            SearchResults.Location = new Point(23, 121);
            SearchResults.Name = "SearchResults";
            SearchResults.Size = new Size(660, 519);
            SearchResults.TabIndex = 2;
            SearchResults.UseCompatibleStateImageBehavior = false;
            SearchResults.View = View.Details;
            SearchResults.MouseDoubleClick += SearchResults_MouseDoubleClick;
            // 
            // Address
            // 
            Address.Text = "Address";
            Address.Width = 200;
            // 
            // City
            // 
            City.Text = "City";
            City.Width = 150;
            // 
            // Zip
            // 
            Zip.Text = "Zip";
            Zip.Width = 150;
            // 
            // ID
            // 
            ID.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 12);
            label1.Name = "label1";
            label1.Size = new Size(211, 32);
            label1.TabIndex = 4;
            label1.Text = "Search For Houses";
            // 
            // SearchBox
            // 
            SearchBox.AcceptsReturn = true;
            SearchBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SearchBox.Location = new Point(23, 62);
            SearchBox.Name = "SearchBox";
            SearchBox.PlaceholderText = "Enter";
            SearchBox.Size = new Size(497, 39);
            SearchBox.TabIndex = 3;
            SearchBox.KeyDown += SearchBox_KeyDown;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(571, 65);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(112, 34);
            SearchButton.TabIndex = 5;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // InstructionsSeeHouseDetails
            // 
            InstructionsSeeHouseDetails.AutoSize = true;
            InstructionsSeeHouseDetails.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            InstructionsSeeHouseDetails.Location = new Point(704, 121);
            InstructionsSeeHouseDetails.Name = "InstructionsSeeHouseDetails";
            InstructionsSeeHouseDetails.Size = new Size(320, 28);
            InstructionsSeeHouseDetails.TabIndex = 6;
            InstructionsSeeHouseDetails.Text = "Double Click a House to learn more";
            // 
            // ResetSearch
            // 
            ResetSearch.Location = new Point(571, 26);
            ResetSearch.Name = "ResetSearch";
            ResetSearch.Size = new Size(112, 34);
            ResetSearch.TabIndex = 7;
            ResetSearch.Text = "Reset";
            ResetSearch.UseVisualStyleBackColor = true;
            ResetSearch.Click += ResetSearchButton_Click;
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 704);
            Controls.Add(ResetSearch);
            Controls.Add(InstructionsSeeHouseDetails);
            Controls.Add(SearchButton);
            Controls.Add(label1);
            Controls.Add(SearchBox);
            Controls.Add(SearchResults);
            Controls.Add(button1);
            Name = "CustomerView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private ListView SearchResults;
        private Label label1;
        private TextBox SearchBox;
        private Button SearchButton;
        private ColumnHeader Address;
        private ColumnHeader City;
        private ColumnHeader Zip;
        private ColumnHeader ID;
        private Label InstructionsSeeHouseDetails;
        private Button ResetSearch;
    }
}