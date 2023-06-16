namespace ReadFromDatabaseApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.TopRightP = new System.Windows.Forms.Panel();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.SendBtn = new System.Windows.Forms.Button();
            this.efim1DataSet = new ReadFromDatabaseApp.Efim1DataSet();
            this.userInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userInfoTableAdapter = new ReadFromDatabaseApp.Efim1DataSetTableAdapters.UserInfoTableAdapter();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAdapterManager1 = new ReadFromDatabaseApp.Efim1DataSetTableAdapters.TableAdapterManager();
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.TopRightP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.efim1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TopRightP
            // 
            this.TopRightP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TopRightP.Controls.Add(this.TimerLabel);
            this.TopRightP.Location = new System.Drawing.Point(824, 13);
            this.TopRightP.Name = "TopRightP";
            this.TopRightP.Size = new System.Drawing.Size(211, 93);
            this.TopRightP.TabIndex = 0;
            // 
            // TimerLabel
            // 
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.Location = new System.Drawing.Point(20, 32);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(181, 41);
            this.TimerLabel.TabIndex = 0;
            this.TimerLabel.Text = "00:00:000";
            this.TimerLabel.Visible = false;
            this.TimerLabel.Click += new System.EventHandler(this.TimerLabel_Click);
            // 
            // SendBtn
            // 
            this.SendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendBtn.Location = new System.Drawing.Point(649, 12);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(165, 45);
            this.SendBtn.TabIndex = 1;
            this.SendBtn.Text = "Send Data";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // efim1DataSet
            // 
            this.efim1DataSet.DataSetName = "Efim1DataSet";
            this.efim1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userInfoBindingSource
            // 
            this.userInfoBindingSource.DataMember = "UserInfo";
            this.userInfoBindingSource.DataSource = this.efim1DataSet;
            // 
            // userInfoTableAdapter
            // 
            this.userInfoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.columnName,
            this.LastName});
            this.dataGrid.Location = new System.Drawing.Point(13, 13);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(529, 425);
            this.dataGrid.TabIndex = 3;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // columnName
            // 
            this.columnName.DataPropertyName = "Name";
            this.columnName.HeaderText = "Name";
            this.columnName.Name = "columnName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = ReadFromDatabaseApp.Efim1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UserInfoTableAdapter = this.userInfoTableAdapter;
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OptionsPanel.Location = new System.Drawing.Point(691, 127);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(340, 388);
            this.OptionsPanel.TabIndex = 4;
            this.OptionsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OptionsPanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 527);
            this.Controls.Add(this.OptionsPanel);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.TopRightP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TopRightP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.efim1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopRightP;
        private System.Windows.Forms.Button SendBtn;
        private Efim1DataSet efim1DataSet;
        private System.Windows.Forms.BindingSource userInfoBindingSource;
        private Efim1DataSetTableAdapters.UserInfoTableAdapter userInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private Efim1DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Panel OptionsPanel;
        public System.Windows.Forms.DataGridView dataGrid;
        public System.Windows.Forms.Label TimerLabel;
    }
}

