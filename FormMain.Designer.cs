
namespace AppForMemorizing
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonAddForm = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.buttonSortAZ = new System.Windows.Forms.Button();
            this.buttonZA = new System.Windows.Forms.Button();
            this.labelSort = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddForm
            // 
            this.buttonAddForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(48)))));
            this.buttonAddForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAddForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddForm.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddForm.ForeColor = System.Drawing.Color.White;
            this.buttonAddForm.Location = new System.Drawing.Point(405, 13);
            this.buttonAddForm.Name = "buttonAddForm";
            this.buttonAddForm.Size = new System.Drawing.Size(24, 24);
            this.buttonAddForm.TabIndex = 0;
            this.buttonAddForm.Text = "+";
            this.buttonAddForm.UseVisualStyleBackColor = false;
            this.buttonAddForm.Click += new System.EventHandler(this.buttonAddForm_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(48)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(405, 41);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(24, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "-";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(48)))));
            this.buttonCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheck.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheck.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCheck.ForeColor = System.Drawing.Color.White;
            this.buttonCheck.Location = new System.Drawing.Point(405, 70);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(24, 23);
            this.buttonCheck.TabIndex = 3;
            this.buttonCheck.Text = "?";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheckForm_Click);
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.MediumPurple;
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox.ForeColor = System.Drawing.Color.White;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(387, 194);
            this.listBox.TabIndex = 4;
            // 
            // buttonSortAZ
            // 
            this.buttonSortAZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(48)))));
            this.buttonSortAZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSortAZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSortAZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortAZ.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSortAZ.ForeColor = System.Drawing.Color.White;
            this.buttonSortAZ.Location = new System.Drawing.Point(63, 209);
            this.buttonSortAZ.Name = "buttonSortAZ";
            this.buttonSortAZ.Size = new System.Drawing.Size(46, 24);
            this.buttonSortAZ.TabIndex = 5;
            this.buttonSortAZ.Text = "A-Z";
            this.buttonSortAZ.UseVisualStyleBackColor = false;
            this.buttonSortAZ.Click += new System.EventHandler(this.buttonSortAZ_Click);
            // 
            // buttonZA
            // 
            this.buttonZA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(48)))));
            this.buttonZA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonZA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZA.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonZA.ForeColor = System.Drawing.Color.White;
            this.buttonZA.Location = new System.Drawing.Point(115, 209);
            this.buttonZA.Name = "buttonZA";
            this.buttonZA.Size = new System.Drawing.Size(46, 24);
            this.buttonZA.TabIndex = 6;
            this.buttonZA.Text = "Z-A";
            this.buttonZA.UseVisualStyleBackColor = false;
            this.buttonZA.Click += new System.EventHandler(this.buttonZA_Click);
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(114)))));
            this.labelSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSort.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSort.ForeColor = System.Drawing.Color.White;
            this.labelSort.Location = new System.Drawing.Point(12, 210);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(45, 23);
            this.labelSort.TabIndex = 7;
            this.labelSort.Text = "Sort";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(48)))));
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Location = new System.Drawing.Point(167, 209);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(46, 24);
            this.buttonRefresh.TabIndex = 8;
            this.buttonRefresh.Text = "REF";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(325, 211);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 23);
            this.textBoxSearch.TabIndex = 9;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(114)))));
            this.labelSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSearch.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSearch.ForeColor = System.Drawing.Color.White;
            this.labelSearch.Location = new System.Drawing.Point(255, 209);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(64, 23);
            this.labelSearch.TabIndex = 10;
            this.labelSearch.Text = "Search";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(437, 241);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.labelSort);
            this.Controls.Add(this.buttonZA);
            this.Controls.Add(this.buttonSortAZ);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddForm);
            this.Name = "FormMain";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddForm;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button buttonSortAZ;
        private System.Windows.Forms.Button buttonZA;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
    }
}

