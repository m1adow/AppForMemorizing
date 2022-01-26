
namespace AppForMemorizing
{
    partial class FormAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            this.textBoxForeign = new System.Windows.Forms.TextBox();
            this.textBoxNative = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelForeign = new System.Windows.Forms.Label();
            this.labelNative = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxForeign
            // 
            this.textBoxForeign.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxForeign.Location = new System.Drawing.Point(12, 32);
            this.textBoxForeign.Name = "textBoxForeign";
            this.textBoxForeign.Size = new System.Drawing.Size(109, 24);
            this.textBoxForeign.TabIndex = 0;
            // 
            // textBoxNative
            // 
            this.textBoxNative.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxNative.Location = new System.Drawing.Point(217, 32);
            this.textBoxNative.Name = "textBoxNative";
            this.textBoxNative.Size = new System.Drawing.Size(109, 24);
            this.textBoxNative.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(48)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(128, 54);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(83, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelForeign
            // 
            this.labelForeign.AutoSize = true;
            this.labelForeign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(114)))));
            this.labelForeign.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelForeign.ForeColor = System.Drawing.Color.White;
            this.labelForeign.Location = new System.Drawing.Point(12, 6);
            this.labelForeign.Name = "labelForeign";
            this.labelForeign.Size = new System.Drawing.Size(109, 23);
            this.labelForeign.TabIndex = 3;
            this.labelForeign.Text = "Foreign word";
            // 
            // labelNative
            // 
            this.labelNative.AutoSize = true;
            this.labelNative.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(114)))));
            this.labelNative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNative.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNative.ForeColor = System.Drawing.Color.White;
            this.labelNative.Location = new System.Drawing.Point(217, 6);
            this.labelNative.Name = "labelNative";
            this.labelNative.Size = new System.Drawing.Size(104, 23);
            this.labelNative.TabIndex = 4;
            this.labelNative.Text = "Native word";
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(338, 84);
            this.Controls.Add(this.labelNative);
            this.Controls.Add(this.labelForeign);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxNative);
            this.Controls.Add(this.textBoxForeign);
            this.Name = "FormAdd";
            this.Text = "Add a word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxForeign;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxNative;
        private System.Windows.Forms.Label labelForeign;
        private System.Windows.Forms.Label labelNative;
    }
}