
namespace AppForMemorizing
{
    partial class FormCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheck));
            this.labelForeignWord = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.textBoxTranslate = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelNativeWord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelForeignWord
            // 
            this.labelForeignWord.AutoSize = true;
            this.labelForeignWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(114)))));
            this.labelForeignWord.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelForeignWord.ForeColor = System.Drawing.Color.White;
            this.labelForeignWord.Location = new System.Drawing.Point(156, 9);
            this.labelForeignWord.Name = "labelForeignWord";
            this.labelForeignWord.Size = new System.Drawing.Size(86, 23);
            this.labelForeignWord.TabIndex = 0;
            this.labelForeignWord.Text = "EXAMPLE";
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(48)))));
            this.buttonCheck.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheck.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCheck.ForeColor = System.Drawing.Color.White;
            this.buttonCheck.Location = new System.Drawing.Point(24, 50);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 1;
            this.buttonCheck.Text = "CHECK";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // textBoxTranslate
            // 
            this.textBoxTranslate.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTranslate.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxTranslate.Location = new System.Drawing.Point(12, 12);
            this.textBoxTranslate.Name = "textBoxTranslate";
            this.textBoxTranslate.Size = new System.Drawing.Size(100, 24);
            this.textBoxTranslate.TabIndex = 2;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(48)))));
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(167, 50);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelNativeWord
            // 
            this.labelNativeWord.AutoSize = true;
            this.labelNativeWord.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNativeWord.Location = new System.Drawing.Point(80, 35);
            this.labelNativeWord.Name = "labelNativeWord";
            this.labelNativeWord.Size = new System.Drawing.Size(102, 30);
            this.labelNativeWord.TabIndex = 4;
            this.labelNativeWord.Text = "EXAMPLE";
            this.labelNativeWord.Visible = false;
            // 
            // FormCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(272, 83);
            this.Controls.Add(this.labelNativeWord);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxTranslate);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.labelForeignWord);
            this.Name = "FormCheck";
            this.Text = "Check your knowledge";
            this.Load += new System.EventHandler(this.FormCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelForeignWord;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.TextBox textBoxTranslate;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelNativeWord;
    }
}