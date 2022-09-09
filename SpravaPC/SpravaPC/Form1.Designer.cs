namespace SpravaPC
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
            this.buttonGetData = new System.Windows.Forms.Button();
            this.buttonUpravit = new System.Windows.Forms.Button();
            this.spravaPCDataSet = new SpravaPC.SpravaPCDataSet();
            this.pCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pCTableAdapter = new SpravaPC.SpravaPCDataSetTableAdapters.PCTableAdapter();
            this.spravaPCDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spravaPCDataSet1 = new SpravaPC.SpravaPCDataSet1();
            this.pCBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pCTableAdapter1 = new SpravaPC.SpravaPCDataSet1TableAdapters.PCTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.spravaPCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spravaPCDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spravaPCDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGetData
            // 
            this.buttonGetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGetData.Location = new System.Drawing.Point(13, 358);
            this.buttonGetData.Name = "buttonGetData";
            this.buttonGetData.Size = new System.Drawing.Size(785, 63);
            this.buttonGetData.TabIndex = 1;
            this.buttonGetData.Text = "Get Data";
            this.buttonGetData.UseVisualStyleBackColor = true;
            this.buttonGetData.Click += new System.EventHandler(this.buttonGetData_Click);
            // 
            // buttonUpravit
            // 
            this.buttonUpravit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUpravit.Location = new System.Drawing.Point(13, 428);
            this.buttonUpravit.Name = "buttonUpravit";
            this.buttonUpravit.Size = new System.Drawing.Size(785, 59);
            this.buttonUpravit.TabIndex = 3;
            this.buttonUpravit.Text = "Update";
            this.buttonUpravit.UseVisualStyleBackColor = true;
            this.buttonUpravit.Visible = false;
            this.buttonUpravit.Click += new System.EventHandler(this.buttonUpravit_Click);
            // 
            // spravaPCDataSet
            // 
            this.spravaPCDataSet.DataSetName = "SpravaPCDataSet";
            this.spravaPCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pCBindingSource
            // 
            this.pCBindingSource.DataMember = "PC";
            this.pCBindingSource.DataSource = this.spravaPCDataSet;
            // 
            // pCTableAdapter
            // 
            this.pCTableAdapter.ClearBeforeFill = true;
            // 
            // spravaPCDataSetBindingSource
            // 
            this.spravaPCDataSetBindingSource.DataSource = this.spravaPCDataSet;
            this.spravaPCDataSetBindingSource.Position = 0;
            // 
            // spravaPCDataSet1
            // 
            this.spravaPCDataSet1.DataSetName = "SpravaPCDataSet1";
            this.spravaPCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pCBindingSource1
            // 
            this.pCBindingSource1.DataMember = "PC";
            this.pCBindingSource1.DataSource = this.spravaPCDataSet1;
            // 
            // pCTableAdapter1
            // 
            this.pCTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(785, 339);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 494);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonUpravit);
            this.Controls.Add(this.buttonGetData);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.spravaPCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spravaPCDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spravaPCDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGetData;
        private System.Windows.Forms.Button buttonUpravit;
        private SpravaPCDataSet spravaPCDataSet;
        private System.Windows.Forms.BindingSource pCBindingSource;
        private SpravaPCDataSetTableAdapters.PCTableAdapter pCTableAdapter;
        private System.Windows.Forms.BindingSource spravaPCDataSetBindingSource;
        private SpravaPCDataSet1 spravaPCDataSet1;
        private System.Windows.Forms.BindingSource pCBindingSource1;
        private SpravaPCDataSet1TableAdapters.PCTableAdapter pCTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

