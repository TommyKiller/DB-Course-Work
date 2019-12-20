namespace DBApp
{
    partial class ShowStadiums
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sportStadtDBDataSet = new DBApp.Server.SportStadtDBDataSet();
            this.stadiumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stadiumsTableAdapter = new DBApp.Server.SportStadtDBDataSetTableAdapters.StadiumsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treadmillLenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treadmillNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sitsNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OKBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportStadtDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadiumsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.buildingIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.treadmillLenDataGridViewTextBoxColumn,
            this.treadmillNumDataGridViewTextBoxColumn,
            this.sitsNumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stadiumsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(648, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // sportStadtDBDataSet
            // 
            this.sportStadtDBDataSet.DataSetName = "SportStadtDBDataSet";
            this.sportStadtDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stadiumsBindingSource
            // 
            this.stadiumsBindingSource.DataMember = "Stadiums";
            this.stadiumsBindingSource.DataSource = this.sportStadtDBDataSet;
            // 
            // stadiumsTableAdapter
            // 
            this.stadiumsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buildingIDDataGridViewTextBoxColumn
            // 
            this.buildingIDDataGridViewTextBoxColumn.DataPropertyName = "Building_ID";
            this.buildingIDDataGridViewTextBoxColumn.HeaderText = "Building_ID";
            this.buildingIDDataGridViewTextBoxColumn.Name = "buildingIDDataGridViewTextBoxColumn";
            this.buildingIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // treadmillLenDataGridViewTextBoxColumn
            // 
            this.treadmillLenDataGridViewTextBoxColumn.DataPropertyName = "Treadmill_Len";
            this.treadmillLenDataGridViewTextBoxColumn.HeaderText = "Treadmill_Len";
            this.treadmillLenDataGridViewTextBoxColumn.Name = "treadmillLenDataGridViewTextBoxColumn";
            this.treadmillLenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // treadmillNumDataGridViewTextBoxColumn
            // 
            this.treadmillNumDataGridViewTextBoxColumn.DataPropertyName = "Treadmill_Num";
            this.treadmillNumDataGridViewTextBoxColumn.HeaderText = "Treadmill_Num";
            this.treadmillNumDataGridViewTextBoxColumn.Name = "treadmillNumDataGridViewTextBoxColumn";
            this.treadmillNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sitsNumDataGridViewTextBoxColumn
            // 
            this.sitsNumDataGridViewTextBoxColumn.DataPropertyName = "Sits_Num";
            this.sitsNumDataGridViewTextBoxColumn.HeaderText = "Sits_Num";
            this.sitsNumDataGridViewTextBoxColumn.Name = "sitsNumDataGridViewTextBoxColumn";
            this.sitsNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(12, 168);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 1;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // ShowStadiums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 205);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowStadiums";
            this.Text = "ShowStadiums";
            this.Load += new System.EventHandler(this.ShowStadiums_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportStadtDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stadiumsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Server.SportStadtDBDataSet sportStadtDBDataSet;
        private System.Windows.Forms.BindingSource stadiumsBindingSource;
        private Server.SportStadtDBDataSetTableAdapters.StadiumsTableAdapter stadiumsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treadmillLenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treadmillNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitsNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button OKBtn;
    }
}