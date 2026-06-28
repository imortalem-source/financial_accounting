namespace financial_accounting
{
    partial class Form1
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
            Operations = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            lblIncome = new Label();
            lblExpense = new Label();
            lblBalance = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnStatistics = new Button();
            cmbFilter = new ComboBox();
            cmbFilterCategory = new ComboBox();
            btnFilter = new Button();
            pictureBox1 = new PictureBox();
            lstStatistics = new ListBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Operations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Operations
            // 
            Operations.AllowUserToAddRows = false;
            Operations.AllowUserToDeleteRows = false;
            Operations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Operations.Columns.AddRange(new DataGridViewColumn[] { Date, Type, Category, Amount, Description });
            Operations.Location = new Point(45, 107);
            Operations.Name = "Operations";
            Operations.ReadOnly = true;
            Operations.RowHeadersWidth = 51;
            Operations.Size = new Size(792, 188);
            Operations.TabIndex = 0;
            Operations.CellContentClick += Operations_CellContentClick;
            // 
            // Date
            // 
            Date.HeaderText = "Дата";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 130;
            // 
            // Type
            // 
            Type.HeaderText = "Тип";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.ReadOnly = true;
            Type.Width = 130;
            // 
            // Category
            // 
            Category.HeaderText = "Категория";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.ReadOnly = true;
            Category.Width = 150;
            // 
            // Amount
            // 
            Amount.HeaderText = "Сумма";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 160;
            // 
            // Description
            // 
            Description.HeaderText = "Описание";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Width = 170;
            // 
            // lblIncome
            // 
            lblIncome.AutoSize = true;
            lblIncome.Location = new Point(45, 47);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(78, 20);
            lblIncome.TabIndex = 1;
            lblIncome.Text = "Доходы: 0";
            // 
            // lblExpense
            // 
            lblExpense.AutoSize = true;
            lblExpense.Location = new Point(399, 47);
            lblExpense.Name = "lblExpense";
            lblExpense.Size = new Size(82, 20);
            lblExpense.TabIndex = 2;
            lblExpense.Text = "Расходы: 0";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(748, 47);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(73, 20);
            lblBalance.TabIndex = 3;
            lblBalance.Text = "Баланс: 0";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(45, 390);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(214, 48);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Добавить операцию";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(45, 454);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(214, 48);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Удалить операцию";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(569, 390);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(214, 48);
            btnSave.TabIndex = 6;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnStatistics
            // 
            btnStatistics.Location = new Point(569, 454);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(214, 48);
            btnStatistics.TabIndex = 7;
            btnStatistics.Text = "Статистика";
            btnStatistics.UseVisualStyleBackColor = true;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "Все", "Доход", "Расход" });
            cmbFilter.Location = new Point(164, 526);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(205, 28);
            cmbFilter.TabIndex = 8;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // cmbFilterCategory
            // 
            cmbFilterCategory.FormattingEnabled = true;
            cmbFilterCategory.Items.AddRange(new object[] { "Все", "Базовые продукты", "Зарплата", "Здоровье и медицина", "Кафе/доставка", "Накопления и инвестиции", "Непредвиденные расходы", "Одежда и обувь", "Образование", "Подарки и праздники", "Развлечения", "Связь", "Стипендия", "Транспорт", "", "" });
            cmbFilterCategory.Location = new Point(164, 587);
            cmbFilterCategory.Name = "cmbFilterCategory";
            cmbFilterCategory.Size = new Size(205, 28);
            cmbFilterCategory.TabIndex = 10;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(92, 647);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(129, 38);
            btnFilter.TabIndex = 11;
            btnFilter.Text = "Фильтр";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(948, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lstStatistics
            // 
            lstStatistics.FormattingEnabled = true;
            lstStatistics.Location = new Point(948, 390);
            lstStatistics.Name = "lstStatistics";
            lstStatistics.Size = new Size(450, 284);
            lstStatistics.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 526);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 14;
            label1.Text = "Тип:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 590);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 15;
            label2.Text = "Категория:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1529, 714);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstStatistics);
            Controls.Add(pictureBox1);
            Controls.Add(btnFilter);
            Controls.Add(cmbFilterCategory);
            Controls.Add(cmbFilter);
            Controls.Add(btnStatistics);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lblBalance);
            Controls.Add(lblExpense);
            Controls.Add(lblIncome);
            Controls.Add(Operations);
            Name = "Form1";
            Text = "Учет доходов и расходов";
            ((System.ComponentModel.ISupportInitialize)Operations).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Operations;
        private Label lblIncome;
        private Label lblExpense;
        private Label lblBalance;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSave;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Description;
        private Button btnStatistics;
        private ComboBox cmbFilter;
        private ComboBox cmbFilterCategory;
        private Button btnFilter;
        private PictureBox pictureBox1;
        private ListBox lstStatistics;
        private Label label1;
        private Label label2;
    }
}
