namespace CatchButton
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
            Run = new Button();
            SuspendLayout();
            // 
            // Run
            // 
            Run.BackColor = SystemColors.Desktop;
            Run.Font = new Font("안동엄마까투리", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Run.Location = new Point(510, 243);
            Run.Name = "Run";
            Run.Size = new Size(150, 60);
            Run.TabIndex = 0;
            Run.Text = "나를 잡아봐";
            Run.UseVisualStyleBackColor = false;
            Run.MouseEnter += Run_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Run);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Run;
    }
}
