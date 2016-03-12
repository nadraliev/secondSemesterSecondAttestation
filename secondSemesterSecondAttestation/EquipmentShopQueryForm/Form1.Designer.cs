namespace EquipmentShopQueryForm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.generatedDataGrid = new System.Windows.Forms.DataGridView();
            this.widthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortedDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sortBtn = new System.Windows.Forms.Button();
            this.minAreaNumeric = new System.Windows.Forms.NumericUpDown();
            this.areaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaColumnSorted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.generatedDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortedDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minAreaNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // generatedDataGrid
            // 
            this.generatedDataGrid.AllowUserToAddRows = false;
            this.generatedDataGrid.AllowUserToDeleteRows = false;
            this.generatedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.generatedDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.widthColumn,
            this.lengthColumn,
            this.priceColumn,
            this.quantityColumn,
            this.areaColumn});
            this.generatedDataGrid.Location = new System.Drawing.Point(13, 13);
            this.generatedDataGrid.Name = "generatedDataGrid";
            this.generatedDataGrid.ReadOnly = true;
            this.generatedDataGrid.Size = new System.Drawing.Size(545, 217);
            this.generatedDataGrid.TabIndex = 0;
            // 
            // widthColumn
            // 
            this.widthColumn.HeaderText = "Width";
            this.widthColumn.Name = "widthColumn";
            this.widthColumn.ReadOnly = true;
            // 
            // lengthColumn
            // 
            this.lengthColumn.HeaderText = "Length";
            this.lengthColumn.Name = "lengthColumn";
            this.lengthColumn.ReadOnly = true;
            // 
            // priceColumn
            // 
            this.priceColumn.HeaderText = "Price";
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            // 
            // quantityColumn
            // 
            this.quantityColumn.HeaderText = "Quantity";
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.ReadOnly = true;
            // 
            // sortedDataGrid
            // 
            this.sortedDataGrid.AllowUserToAddRows = false;
            this.sortedDataGrid.AllowUserToDeleteRows = false;
            this.sortedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sortedDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.areaColumnSorted});
            this.sortedDataGrid.Location = new System.Drawing.Point(13, 373);
            this.sortedDataGrid.Name = "sortedDataGrid";
            this.sortedDataGrid.ReadOnly = true;
            this.sortedDataGrid.Size = new System.Drawing.Size(545, 217);
            this.sortedDataGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Width";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Length";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(622, 13);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(129, 38);
            this.generateBtn.TabIndex = 2;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вывести в порядке возрастания цены сведения о тех стеновых панелях,\r\n \r\nобщая пло" +
    "щадь которых не менее\r\n";
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(317, 281);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(75, 24);
            this.sortBtn.TabIndex = 5;
            this.sortBtn.Text = "ok";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // minAreaNumeric
            // 
            this.minAreaNumeric.Location = new System.Drawing.Point(208, 285);
            this.minAreaNumeric.Maximum = new decimal(new int[] {
            40000000,
            0,
            0,
            0});
            this.minAreaNumeric.Name = "minAreaNumeric";
            this.minAreaNumeric.Size = new System.Drawing.Size(91, 20);
            this.minAreaNumeric.TabIndex = 6;
            // 
            // areaColumn
            // 
            this.areaColumn.HeaderText = "Area";
            this.areaColumn.Name = "areaColumn";
            this.areaColumn.ReadOnly = true;
            // 
            // areaColumnSorted
            // 
            this.areaColumnSorted.HeaderText = "Area";
            this.areaColumnSorted.Name = "areaColumnSorted";
            this.areaColumnSorted.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 602);
            this.Controls.Add(this.minAreaNumeric);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.sortedDataGrid);
            this.Controls.Add(this.generatedDataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.generatedDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortedDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minAreaNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView generatedDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridView sortedDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.NumericUpDown minAreaNumeric;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaColumnSorted;
    }
}

