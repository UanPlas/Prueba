namespace prueba
{
    partial class Productos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mia_storesDataSet1 = new prueba.mia_storesDataSet1();
            this.productosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.miastoresDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mia_storesDataSet = new prueba.mia_storesDataSet();
            this.productosTableAdapter = new prueba.mia_storesDataSetTableAdapters.productosTableAdapter();
            this.buttonNew = new System.Windows.Forms.Button();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedoresTableAdapter = new prueba.mia_storesDataSetTableAdapters.proveedoresTableAdapter();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosNTableAdapter = new prueba.mia_storesDataSet1TableAdapters.productosNTableAdapter();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.productosTableAdapter1 = new prueba.mia_storesDataSetTableAdapters.productosTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mia_storesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miastoresDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mia_storesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productosNBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // productosNBindingSource
            // 
            this.productosNBindingSource.DataMember = "productosN";
            this.productosNBindingSource.DataSource = this.mia_storesDataSet1;
            // 
            // mia_storesDataSet1
            // 
            this.mia_storesDataSet1.DataSetName = "mia_storesDataSet1";
            this.mia_storesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource1
            // 
            this.productosBindingSource1.DataMember = "productos";
            this.productosBindingSource1.DataSource = this.miastoresDataSetBindingSource;
            // 
            // miastoresDataSetBindingSource
            // 
            this.miastoresDataSetBindingSource.DataSource = this.mia_storesDataSet;
            this.miastoresDataSetBindingSource.Position = 0;
            // 
            // mia_storesDataSet
            // 
            this.mia_storesDataSet.DataSetName = "mia_storesDataSet";
            this.mia_storesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.Location = new System.Drawing.Point(17, 4);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(115, 38);
            this.buttonNew.TabIndex = 1;
            this.buttonNew.Text = "Nuevo";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "proveedores";
            this.proveedoresBindingSource.DataSource = this.miastoresDataSetBindingSource;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(259, 51);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(115, 57);
            this.buttonConfirm.TabIndex = 12;
            this.buttonConfirm.Text = "Guardar";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "productos";
            this.productosBindingSource.DataSource = this.miastoresDataSetBindingSource;
            // 
            // productosNTableAdapter
            // 
            this.productosNTableAdapter.ClearBeforeFill = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(138, 4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(115, 41);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Editar";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click_);
            // 
            // productosTableAdapter1
            // 
            this.productosTableAdapter1.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nombre:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(69, 51);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(184, 22);
            this.textBoxID.TabIndex = 18;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(69, 92);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(184, 22);
            this.textBoxName.TabIndex = 19;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(259, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(115, 41);
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click_);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mia_storesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miastoresDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mia_storesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource miastoresDataSetBindingSource;
        private mia_storesDataSet mia_storesDataSet;
        private mia_storesDataSetTableAdapters.productosTableAdapter productosTableAdapter;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.BindingSource productosBindingSource1;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private mia_storesDataSetTableAdapters.proveedoresTableAdapter proveedoresTableAdapter;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private mia_storesDataSet1 mia_storesDataSet1;
        private System.Windows.Forms.BindingSource productosNBindingSource;
        private mia_storesDataSet1TableAdapters.productosNTableAdapter productosNTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonUpdate;
        private mia_storesDataSetTableAdapters.productosTableAdapter productosTableAdapter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonDelete;
    }
}

