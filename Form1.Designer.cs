namespace Capstone_Project_1
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
            txtStudentAnswer = new TextBox();
            btnParseAnswer = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtStudentAnswer
            // 
            txtStudentAnswer.Location = new Point(27, 96);
            txtStudentAnswer.Multiline = true;
            txtStudentAnswer.Name = "txtStudentAnswer";
            txtStudentAnswer.Size = new Size(699, 216);
            txtStudentAnswer.TabIndex = 0;
            // 
            // btnParseAnswer
            // 
            btnParseAnswer.Location = new Point(27, 28);
            btnParseAnswer.Name = "btnParseAnswer";
            btnParseAnswer.Size = new Size(130, 50);
            btnParseAnswer.TabIndex = 1;
            btnParseAnswer.Text = "Parse Answer";
            btnParseAnswer.UseVisualStyleBackColor = true;
            btnParseAnswer.Click += btnParseAnswer_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(27, 332);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(66, 20);
            lblResult.TabIndex = 2;
            lblResult.Text = "lblResult";
            lblResult.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnParseAnswer);
            Controls.Add(txtStudentAnswer);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentAnswer;
        private Button btnParseAnswer;
        private Label lblResult;
    }
}
