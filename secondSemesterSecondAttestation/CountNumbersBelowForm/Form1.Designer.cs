namespace CountNumbersBelowForm
{
    partial class mainForm
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
            this.generateBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.inputXNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputKNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.countBeloxResultLabel = new System.Windows.Forms.Label();
            this.inputLevelNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maxResultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputXNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputKNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputLevelNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(13, 12);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(120, 23);
            this.generateBtn.TabIndex = 1;
            this.generateBtn.Text = "Сгенерировать";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.Location = new System.Drawing.Point(13, 47);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1422, 736);
            this.mainPanel.TabIndex = 2;
            // 
            // inputXNumeric
            // 
            this.inputXNumeric.Location = new System.Drawing.Point(179, 15);
            this.inputXNumeric.Name = "inputXNumeric";
            this.inputXNumeric.Size = new System.Drawing.Size(91, 20);
            this.inputXNumeric.TabIndex = 3;
            this.inputXNumeric.ValueChanged += new System.EventHandler(this.inputXNumeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "K:";
            // 
            // inputKNumeric
            // 
            this.inputKNumeric.Location = new System.Drawing.Point(299, 15);
            this.inputKNumeric.Name = "inputKNumeric";
            this.inputKNumeric.Size = new System.Drawing.Size(87, 20);
            this.inputKNumeric.TabIndex = 6;
            this.inputKNumeric.ValueChanged += new System.EventHandler(this.inputKNumeric_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Элементов ниже К меньше X: ";
            // 
            // countBeloxResultLabel
            // 
            this.countBeloxResultLabel.Location = new System.Drawing.Point(559, 15);
            this.countBeloxResultLabel.Name = "countBeloxResultLabel";
            this.countBeloxResultLabel.Size = new System.Drawing.Size(78, 20);
            this.countBeloxResultLabel.TabIndex = 8;
            this.countBeloxResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputLevelNumeric
            // 
            this.inputLevelNumeric.Location = new System.Drawing.Point(712, 14);
            this.inputLevelNumeric.Name = "inputLevelNumeric";
            this.inputLevelNumeric.Size = new System.Drawing.Size(89, 20);
            this.inputLevelNumeric.TabIndex = 9;
            this.inputLevelNumeric.ValueChanged += new System.EventHandler(this.inputLevelNumeric_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(807, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Максимум на уровне:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(655, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Уровень";
            // 
            // maxResultLabel
            // 
            this.maxResultLabel.Location = new System.Drawing.Point(930, 15);
            this.maxResultLabel.Name = "maxResultLabel";
            this.maxResultLabel.Size = new System.Drawing.Size(161, 20);
            this.maxResultLabel.TabIndex = 12;
            this.maxResultLabel.Text = " ";
            this.maxResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 795);
            this.Controls.Add(this.maxResultLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputLevelNumeric);
            this.Controls.Add(this.countBeloxResultLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputKNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputXNumeric);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.generateBtn);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.mainForm_Size_Changed);
            ((System.ComponentModel.ISupportInitialize)(this.inputXNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputKNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputLevelNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.NumericUpDown inputXNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown inputKNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label countBeloxResultLabel;
        private System.Windows.Forms.NumericUpDown inputLevelNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label maxResultLabel;
    }
}

