namespace MVCDemo {
    partial class RealtorView {
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
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(230, 54);
            button1.Name = "button1";
            button1.Size = new Size(294, 48);
            button1.TabIndex = 3;
            button1.Text = "Back to MainView";
            button1.UseVisualStyleBackColor = true;
            button1.Click += onMainViewButtonClic;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 9);
            label1.Name = "label1";
            label1.Size = new Size(214, 25);
            label1.TabIndex = 2;
            label1.Text = "Welcome to RealtorView! ";
            // 
            // RealtorView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "RealtorView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RealtorView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
    }
}