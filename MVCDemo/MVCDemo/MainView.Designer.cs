namespace MVCDemo {
    partial class MainView {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            toCustomerViewButton = new Button();
            toRealtorViewButton = new Button();
            SuspendLayout();
            // 
            // toCustomerViewButton
            // 
            toCustomerViewButton.Location = new Point(60, 217);
            toCustomerViewButton.Name = "toCustomerViewButton";
            toCustomerViewButton.Size = new Size(234, 57);
            toCustomerViewButton.TabIndex = 0;
            toCustomerViewButton.Text = "I am a Customer";
            toCustomerViewButton.UseVisualStyleBackColor = true;
            toCustomerViewButton.Click += onCustomerViewButtonClick;
            // 
            // toRealtorViewButton
            // 
            toRealtorViewButton.Location = new Point(443, 217);
            toRealtorViewButton.Name = "toRealtorViewButton";
            toRealtorViewButton.Size = new Size(234, 57);
            toRealtorViewButton.TabIndex = 1;
            toRealtorViewButton.Text = "I am a Realtor";
            toRealtorViewButton.UseVisualStyleBackColor = true;
            toRealtorViewButton.Click += onRealtorViewButtonClick;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toRealtorViewButton);
            Controls.Add(toCustomerViewButton);
            Name = "MainView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainView";
            ResumeLayout(false);
        }

        #endregion

        private Button toCustomerViewButton;
        private Button toRealtorViewButton;
    }
}