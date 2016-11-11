namespace _5171580_김상원
{
    partial class DocMngMembers
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cUSTOMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new _5171580_김상원.DataSet1();
            this.cUSTOMERSTableAdapter = new _5171580_김상원.DataSet1TableAdapters.CUSTOMERSTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLKLISTDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLACKLISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bLACKLISTTableAdapter = new _5171580_김상원.DataSet1TableAdapters.BLACKLISTTableAdapter();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cADDRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBIRTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPWDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oracleCommand1 = new System.Data.OracleClient.OracleCommand();
            this.oracleConnection1 = new System.Data.OracleClient.OracleConnection();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLACKLISTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDDataGridViewTextBoxColumn,
            this.C_NAME,
            this.cTELDataGridViewTextBoxColumn,
            this.cADDRDataGridViewTextBoxColumn,
            this.cBIRTHDataGridViewTextBoxColumn,
            this.cEMAILDataGridViewTextBoxColumn,
            this.cPWDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cUSTOMERSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(635, 267);
            this.dataGridView1.TabIndex = 0;
            // 
            // cUSTOMERSBindingSource
            // 
            this.cUSTOMERSBindingSource.DataMember = "CUSTOMERS";
            this.cUSTOMERSBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERSTableAdapter
            // 
            this.cUSTOMERSTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "회원 리스트";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "블랙 리스트";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDDataGridViewTextBoxColumn1,
            this.bLKLISTDATEDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bLACKLISTBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 436);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(636, 147);
            this.dataGridView2.TabIndex = 2;
            // 
            // cIDDataGridViewTextBoxColumn1
            // 
            this.cIDDataGridViewTextBoxColumn1.DataPropertyName = "C_ID";
            this.cIDDataGridViewTextBoxColumn1.HeaderText = "C_ID";
            this.cIDDataGridViewTextBoxColumn1.Name = "cIDDataGridViewTextBoxColumn1";
            // 
            // bLKLISTDATEDataGridViewTextBoxColumn
            // 
            this.bLKLISTDATEDataGridViewTextBoxColumn.DataPropertyName = "BLKLIST_DATE";
            this.bLKLISTDATEDataGridViewTextBoxColumn.HeaderText = "BLKLIST_DATE";
            this.bLKLISTDATEDataGridViewTextBoxColumn.Name = "bLKLISTDATEDataGridViewTextBoxColumn";
            // 
            // bLACKLISTBindingSource
            // 
            this.bLACKLISTBindingSource.DataMember = "BLACKLIST";
            this.bLACKLISTBindingSource.DataSource = this.dataSet1;
            // 
            // bLACKLISTTableAdapter
            // 
            this.bLACKLISTTableAdapter.ClearBeforeFill = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(275, 361);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(40, 28);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "▼";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.ActionBlackConsumer);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(321, 361);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(40, 28);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "△";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.ActionBlackConsumer);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(561, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "회원 삭제";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ActionCustomerRemove);
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "C_ID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "C_ID";
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            // 
            // C_NAME
            // 
            this.C_NAME.DataPropertyName = "C_NAME";
            this.C_NAME.HeaderText = "C_NAME";
            this.C_NAME.Name = "C_NAME";
            // 
            // cTELDataGridViewTextBoxColumn
            // 
            this.cTELDataGridViewTextBoxColumn.DataPropertyName = "C_TEL";
            this.cTELDataGridViewTextBoxColumn.HeaderText = "C_TEL";
            this.cTELDataGridViewTextBoxColumn.Name = "cTELDataGridViewTextBoxColumn";
            // 
            // cADDRDataGridViewTextBoxColumn
            // 
            this.cADDRDataGridViewTextBoxColumn.DataPropertyName = "C_ADDR";
            this.cADDRDataGridViewTextBoxColumn.HeaderText = "C_ADDR";
            this.cADDRDataGridViewTextBoxColumn.Name = "cADDRDataGridViewTextBoxColumn";
            // 
            // cBIRTHDataGridViewTextBoxColumn
            // 
            this.cBIRTHDataGridViewTextBoxColumn.DataPropertyName = "C_BIRTH";
            this.cBIRTHDataGridViewTextBoxColumn.HeaderText = "C_BIRTH";
            this.cBIRTHDataGridViewTextBoxColumn.Name = "cBIRTHDataGridViewTextBoxColumn";
            // 
            // cEMAILDataGridViewTextBoxColumn
            // 
            this.cEMAILDataGridViewTextBoxColumn.DataPropertyName = "C_EMAIL";
            this.cEMAILDataGridViewTextBoxColumn.HeaderText = "C_EMAIL";
            this.cEMAILDataGridViewTextBoxColumn.Name = "cEMAILDataGridViewTextBoxColumn";
            // 
            // cPWDDataGridViewTextBoxColumn
            // 
            this.cPWDDataGridViewTextBoxColumn.DataPropertyName = "C_PWD";
            this.cPWDDataGridViewTextBoxColumn.HeaderText = "C_PWD";
            this.cPWDDataGridViewTextBoxColumn.Name = "cPWDDataGridViewTextBoxColumn";
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Connection = this.oracleConnection1;
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=MyORCL;PERSIST SECURITY INFO=True;USER ID=B5171580;password=B5171580";
            // 
            // DocMngMembers
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DocMngMembers";
            this.Size = new System.Drawing.Size(670, 610);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLACKLISTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cUSTOMERSBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.CUSTOMERSTableAdapter cUSTOMERSTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bLKLISTDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bLACKLISTBindingSource;
        private DataSet1TableAdapters.BLACKLISTTableAdapter bLACKLISTTableAdapter;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cADDRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBIRTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPWDDataGridViewTextBoxColumn;
        private System.Data.OracleClient.OracleCommand oracleCommand1;
        private System.Data.OracleClient.OracleConnection oracleConnection1;
    }
}
