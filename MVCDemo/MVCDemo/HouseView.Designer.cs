namespace MVCDemo {
    partial class HouseView {
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
            Price_Label = new Label();
            Address_label = new Label();
            Address_Text = new TextBox();
            richTextBox1 = new RichTextBox();
            NumBedrooms_Label = new Label();
            NumberBedrooms_Text = new TextBox();
            Price_Text = new TextBox();
            Year_Text = new TextBox();
            Year_Label = new Label();
            CustomerViewButton = new Button();
            PropertyType_Text = new TextBox();
            Property_Label = new Label();
            SuspendLayout();
            // 
            // Price_Label
            // 
            Price_Label.AutoSize = true;
            Price_Label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Price_Label.Location = new Point(21, 237);
            Price_Label.Name = "Price_Label";
            Price_Label.Size = new Size(54, 28);
            Price_Label.TabIndex = 0;
            Price_Label.Text = "Price";
            // 
            // Address_label
            // 
            Address_label.AutoSize = true;
            Address_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Address_label.Location = new Point(12, 24);
            Address_label.Name = "Address_label";
            Address_label.Size = new Size(98, 32);
            Address_label.TabIndex = 1;
            Address_label.Text = "Address";
            // 
            // Address_Text
            // 
            Address_Text.Location = new Point(130, 27);
            Address_Text.Name = "Address_Text";
            Address_Text.ReadOnly = true;
            Address_Text.Size = new Size(443, 31);
            Address_Text.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(594, 156);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(8, 8);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // NumBedrooms_Label
            // 
            NumBedrooms_Label.AutoSize = true;
            NumBedrooms_Label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            NumBedrooms_Label.Location = new Point(18, 146);
            NumBedrooms_Label.Name = "NumBedrooms_Label";
            NumBedrooms_Label.Size = new Size(201, 28);
            NumBedrooms_Label.TabIndex = 4;
            NumBedrooms_Label.Text = "Number of Bedrooms";
            // 
            // NumberBedrooms_Text
            // 
            NumberBedrooms_Text.Location = new Point(236, 146);
            NumberBedrooms_Text.Name = "NumberBedrooms_Text";
            NumberBedrooms_Text.ReadOnly = true;
            NumberBedrooms_Text.Size = new Size(83, 31);
            NumberBedrooms_Text.TabIndex = 5;
            // 
            // Price_Text
            // 
            Price_Text.Location = new Point(107, 234);
            Price_Text.Name = "Price_Text";
            Price_Text.ReadOnly = true;
            Price_Text.Size = new Size(83, 31);
            Price_Text.TabIndex = 6;
            // 
            // Year_Text
            // 
            Year_Text.Location = new Point(130, 186);
            Year_Text.Name = "Year_Text";
            Year_Text.ReadOnly = true;
            Year_Text.Size = new Size(83, 31);
            Year_Text.TabIndex = 8;
            // 
            // Year_Label
            // 
            Year_Label.AutoSize = true;
            Year_Label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Year_Label.Location = new Point(18, 189);
            Year_Label.Name = "Year_Label";
            Year_Label.Size = new Size(92, 28);
            Year_Label.TabIndex = 7;
            Year_Label.Text = "Year Built";
            // 
            // CustomerViewButton
            // 
            CustomerViewButton.Location = new Point(262, 390);
            CustomerViewButton.Name = "CustomerViewButton";
            CustomerViewButton.Size = new Size(294, 48);
            CustomerViewButton.TabIndex = 9;
            CustomerViewButton.Text = "Back to CustomerView";
            CustomerViewButton.UseVisualStyleBackColor = true;
            CustomerViewButton.Click += CustomerViewButton_Click;
            // 
            // PropertyType_Text
            // 
            PropertyType_Text.Location = new Point(180, 87);
            PropertyType_Text.Name = "PropertyType_Text";
            PropertyType_Text.ReadOnly = true;
            PropertyType_Text.Size = new Size(208, 31);
            PropertyType_Text.TabIndex = 11;
            // 
            // Property_Label
            // 
            Property_Label.AutoSize = true;
            Property_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Property_Label.Location = new Point(12, 87);
            Property_Label.Name = "Property_Label";
            Property_Label.Size = new Size(162, 32);
            Property_Label.TabIndex = 10;
            Property_Label.Text = "Property Type";
            // 
            // HouseView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PropertyType_Text);
            Controls.Add(Property_Label);
            Controls.Add(CustomerViewButton);
            Controls.Add(Year_Text);
            Controls.Add(Year_Label);
            Controls.Add(Price_Text);
            Controls.Add(NumberBedrooms_Text);
            Controls.Add(NumBedrooms_Label);
            Controls.Add(richTextBox1);
            Controls.Add(Address_Text);
            Controls.Add(Address_label);
            Controls.Add(Price_Label);
            Name = "HouseView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HouseView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Price_Label;
        private Label Address_label;
        private TextBox Address_Text;
        private RichTextBox richTextBox1;
        private Label NumBedrooms_Label;
        private TextBox NumberBedrooms_Text;
        private TextBox Price_Text;
        private TextBox Year_Text;
        private Label Year_Label;
        private Button CustomerViewButton;
        private TextBox PropertyType_Text;
        private Label Property_Label;
    }
}