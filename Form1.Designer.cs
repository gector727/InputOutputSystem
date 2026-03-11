namespace TPModul3
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
            txtInput = new TextBox();
            btnSubmit = new Button();
            lblOutput = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 65);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(202, 23);
            txtInput.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(73, 111);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblOutput
            // 
            lblOutput.Location = new Point(23, 2);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(180, 49);
            lblOutput.TabIndex = 3;
            lblOutput.Text = "OUTPUT";
            lblOutput.TextAlign = ContentAlignment.MiddleCenter;
            lblOutput.Click += lblOutput_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblOutput);
            Controls.Add(btnSubmit);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnSubmit;
        private Label lblOutput;
    }
}
