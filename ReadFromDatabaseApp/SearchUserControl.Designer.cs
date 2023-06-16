namespace ReadFromDatabaseApp
{
    partial class SearchUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FNameLabel = new System.Windows.Forms.Label();
            this.LNameLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.FTextBox = new System.Windows.Forms.TextBox();
            this.LTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.efim1DataSet1 = new ReadFromDatabaseApp.Efim1DataSet();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.efim1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // FNameLabel
            // 
            this.FNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameLabel.Location = new System.Drawing.Point(3, 0);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(141, 29);
            this.FNameLabel.TabIndex = 0;
            this.FNameLabel.Text = "First Name";
            // 
            // LNameLabel
            // 
            this.LNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameLabel.Location = new System.Drawing.Point(3, 108);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(137, 29);
            this.LNameLabel.TabIndex = 1;
            this.LNameLabel.Text = "Last Name";
            // 
            // IdLabel
            // 
            this.IdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(3, 206);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(35, 29);
            this.IdLabel.TabIndex = 2;
            this.IdLabel.Text = "Id";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(8, 295);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(99, 55);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // FTextBox
            // 
            this.FTextBox.Location = new System.Drawing.Point(8, 53);
            this.FTextBox.Name = "FTextBox";
            this.FTextBox.Size = new System.Drawing.Size(151, 20);
            this.FTextBox.TabIndex = 4;
            // 
            // LTextBox
            // 
            this.LTextBox.Location = new System.Drawing.Point(8, 160);
            this.LTextBox.Name = "LTextBox";
            this.LTextBox.Size = new System.Drawing.Size(151, 20);
            this.LTextBox.TabIndex = 5;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(8, 252);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(151, 20);
            this.IDTextBox.TabIndex = 6;
            // 
            // efim1DataSet1
            // 
            this.efim1DataSet1.DataSetName = "Efim1DataSet";
            this.efim1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(127, 295);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(99, 55);
            this.Add.TabIndex = 7;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // SearchUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Add);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.LTextBox);
            this.Controls.Add(this.FTextBox);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.LNameLabel);
            this.Controls.Add(this.FNameLabel);
            this.Name = "SearchUserControl";
            this.Size = new System.Drawing.Size(644, 413);
            this.Load += new System.EventHandler(this.SearchUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.efim1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FNameLabel;
        private System.Windows.Forms.Label LNameLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox FTextBox;
        private System.Windows.Forms.TextBox LTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private Efim1DataSet efim1DataSet1;
        private System.Windows.Forms.Button Add;
    }
}
