namespace financial_accounting
{
    partial class secondaryform
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
            dtpDate = new DateTimePicker();
            cmbType = new ComboBox();
            cmbCategory = new ComboBox();
            txtAmount = new TextBox();
            txtDescription = new TextBox();
            btnAddOperation = new Button();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(23, 12);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(282, 27);
            dtpDate.TabIndex = 0;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Доход", "Расход" });
            cmbType.Location = new Point(23, 72);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(282, 28);
            cmbType.TabIndex = 1;
            cmbType.Text = "Тип";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Базовые продукты", "Зарплата", "Здоровье и медицина", "Кафе/доставка", "Накопления и инвестиции", "Непредвиденные расходы", "Одежда и обувь", "Образование", "Подарки и праздники", "Развлечения", "Связь", "Стипендия", "Транспорт" });
            cmbCategory.Location = new Point(23, 136);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(282, 28);
            cmbCategory.TabIndex = 2;
            cmbCategory.Text = "Категория";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(23, 198);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(282, 27);
            txtAmount.TabIndex = 3;
            txtAmount.Text = "Сумма";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(23, 255);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(282, 27);
            txtDescription.TabIndex = 4;
            txtDescription.Text = "Описание";
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // btnAddOperation
            // 
            btnAddOperation.Location = new Point(60, 343);
            btnAddOperation.Name = "btnAddOperation";
            btnAddOperation.Size = new Size(211, 42);
            btnAddOperation.TabIndex = 5;
            btnAddOperation.Text = "Добавить";
            btnAddOperation.UseVisualStyleBackColor = true;
            btnAddOperation.Click += btnAddOperation_Click;
            // 
            // secondaryform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddOperation);
            Controls.Add(txtDescription);
            Controls.Add(txtAmount);
            Controls.Add(cmbCategory);
            Controls.Add(cmbType);
            Controls.Add(dtpDate);
            Name = "secondaryform";
            Text = "secondaryform";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDate;
        private ComboBox cmbType;
        private ComboBox cmbCategory;
        private TextBox txtAmount;
        private TextBox txtDescription;
        private Button btnAddOperation;
    }
}