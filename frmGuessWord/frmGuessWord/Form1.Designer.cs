namespace frmGuessWord
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
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblWordToGuess = new System.Windows.Forms.Label();
            this.lstWrongGuesses = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGuess
            // 
            this.txtGuess.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGuess.Location = new System.Drawing.Point(24, 170);
            this.txtGuess.Multiline = true;
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(359, 45);
            this.txtGuess.TabIndex = 0;
            this.txtGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(137, 232);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(127, 40);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "GUESS";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblWordToGuess
            // 
            this.lblWordToGuess.AutoSize = true;
            this.lblWordToGuess.BackColor = System.Drawing.Color.Transparent;
            this.lblWordToGuess.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWordToGuess.ForeColor = System.Drawing.Color.Black;
            this.lblWordToGuess.Location = new System.Drawing.Point(154, 75);
            this.lblWordToGuess.Name = "lblWordToGuess";
            this.lblWordToGuess.Size = new System.Drawing.Size(90, 45);
            this.lblWordToGuess.TabIndex = 3;
            this.lblWordToGuess.Text = "?????";
            this.lblWordToGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstWrongGuesses
            // 
            this.lstWrongGuesses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstWrongGuesses.FormattingEnabled = true;
            this.lstWrongGuesses.ItemHeight = 21;
            this.lstWrongGuesses.Location = new System.Drawing.Point(445, 54);
            this.lstWrongGuesses.Name = "lstWrongGuesses";
            this.lstWrongGuesses.Size = new System.Drawing.Size(231, 298);
            this.lstWrongGuesses.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(491, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "WRONG GUESS";
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLives.Location = new System.Drawing.Point(45, 26);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(65, 21);
            this.lblLives.TabIndex = 6;
            this.lblLives.Text = "Lives: 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 379);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstWrongGuesses);
            this.Controls.Add(this.lblWordToGuess);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtGuess);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUESS GAME";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtGuess;
        private Button btnCheck;
        private Label lblWordToGuess;
        private ListBox lstWrongGuesses;
        private Label label1;
        private Label lblLives;
    }
}