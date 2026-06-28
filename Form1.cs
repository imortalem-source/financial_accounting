using System.Transactions;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
namespace financial_accounting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadOperations();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            secondaryform addoper = new secondaryform();
            addoper.Owner = this;
            addoper.ShowDialog();
        }
        public void AddOperationToGrid(Operation operation)
        {
            Operations.Rows.Add(
                operation.Date.ToShortDateString(),
                operation.Type,
                operation.Category,
                operation.Amount,
                operation.Description
            );
            UpdateStatistics();
        }
        private void UpdateStatistics()
        {
            decimal income = 0;
            decimal expense = 0;
            foreach (DataGridViewRow row in Operations.Rows)
            {
                if (row.IsNewRow)//если есть пустая строка для ввода
                {
                    continue;
                }
                string type = row.Cells[1].Value.ToString();
                decimal amount = Convert.ToDecimal(row.Cells[3].Value);

                if (type == "Доход")
                {
                    income += amount;
                }
                else if (type == "Расход")
                {
                    expense += amount;
                }
            }
            lblIncome.Text = $"Доходы: {income}";
            lblExpense.Text = $"Расходы: {expense}";
            lblBalance.Text = $"Баланс: {income - expense}";
        }
        private void Operations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Operations.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Удалить выбранную операцию?", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Operations.Rows.RemoveAt(Operations.SelectedRows[0].Index);
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите строку для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateStatistics();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Для хранения данных используется формат JSON. При сохранении программа преобразует список операций в JSON-файл (сериализация).
            //При запуске приложения данные считываются из JSON-файла и преобразуются обратно в объекты Operation (десериализация),
            //после чего отображаются в таблице DataGridView.
            List<Operation> operations = new List<Operation>();
            foreach (DataGridViewRow row in Operations.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }
                Operation operation = new Operation()//Создает объекты Operation
                {
                    Date = Convert.ToDateTime(row.Cells[0].Value),
                    Type = row.Cells[1].Value.ToString(),
                    Category = row.Cells[2].Value.ToString(),
                    Amount = Convert.ToDecimal(row.Cells[3].Value),
                    Description = row.Cells[4].Value.ToString()

                };
                operations.Add(operation);//добавляются в список
            }
            string json = JsonSerializer.Serialize(operations);//Преобразует список в JSON
            File.WriteAllText("operations.json", json);//И записывает в файл

            MessageBox.Show("Данные сохранены!");
        }
        private void LoadOperations()
        {
            if (!File.Exists("operations.json"))//проверяем наличие файла, если нет-выходим
            {
                return;
            }
            string json = File.ReadAllText("operations.json");//получаем весь текст файла
            List<Operation> operations = JsonSerializer.Deserialize<List<Operation>>(json);//преобразуем в список объектов- десериализация
            foreach (Operation operation in operations)
            {
                Operations.Rows.Add(
                    operation.Date.ToShortDateString(),
                    operation.Type,
                    operation.Category,
                    operation.Amount,
                    operation.Description);
            }
            UpdateStatistics();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            Dictionary<string, decimal> categories = new Dictionary<string, decimal>();
            foreach (DataGridViewRow row in Operations.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }
                string type = row.Cells[1].Value.ToString();
                if (type != "Расход")
                {
                    continue;
                }
                string category = row.Cells[2].Value.ToString();
                decimal amount = Convert.ToDecimal(row.Cells[3].Value);

                if (categories.ContainsKey(category))
                {
                    categories[category] += amount;
                }
                else
                {
                    categories.Add(category, amount);
                }
            }
            decimal totalamount = 0;

            foreach (var item in categories)
            {
                totalamount += item.Value;
            }
            lstStatistics.Items.Clear();
            lstStatistics.Items.Add("СТРУКТУРА РАСХОДОВ");
            lstStatistics.Items.Add("");
          
            foreach (var item in categories)
            {
                decimal percent = item.Value * 100 / totalamount;
                lstStatistics.Items.Add(item.Key + " : " + item.Value + "руб. (" + percent.ToString("0.0") + "%)");
            }
            lstStatistics.Items.Add("");

            string maxCategory = "";
            decimal maxAmount = 0;

            foreach (var item in categories)
            {
                if (item.Value > maxAmount)
                {
                    maxAmount = item.Value;
                    maxCategory = item.Key;
                }
            }

            lstStatistics.Items.Add("Самая затратная категория:");
            lstStatistics.Items.Add(maxCategory + " (" + maxAmount + " руб.)");

            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);//создаем чистое изображение
            Graphics g = Graphics.FromImage(bitmap);//можем рисовать на этом изображении
            g.Clear(Color.White);

        
            if (totalamount == 0)
            {
                pictureBox1.Image = bitmap;
                return;

            }
            float startAngle = 0f; //Начальный угол для первого сектора
            Brush[] brushes =
            {
                Brushes.Red,
                Brushes.Blue,
                Brushes.Green,
                Brushes.Yellow,
                Brushes.Orange,
                Brushes.Purple,
                Brushes.Pink,
                Brushes.Brown
            };

            int i = 0; // Индекс для выбора цвета
            foreach (var item in categories)
            {
                float sweepAngle = (float)(item.Value / totalamount * 360); // Считаем угол сектора: доля от 360 градусов

                g.FillPie(
                    brushes[i % brushes.Length],// Если цветов мало — они повторяются
                    20,// X координата левого верхнего угла прямоугольника
                    20,// Y координата
                    200,// Ширина прямоугольника, в который вписываем круг
                    200,// Высота прямоугольника
                    startAngle,
                    sweepAngle);

                float middleAngle = startAngle + sweepAngle / 2; 
                float x = 120 + (float)(70 * Math.Cos(middleAngle * Math.PI / 180));
                float y = 120 + (float)(70 * Math.Sin(middleAngle * Math.PI / 180));

                decimal percent = item.Value * 100 / totalamount;

                g.DrawString(
                    percent.ToString("0") + "%",
                    new Font("Arial", 10, FontStyle.Bold),
                    Brushes.White,
                    x,
                    y
                );

                g.FillRectangle(
                    brushes[i % brushes.Length],
                    240,
                    30 + i * 30,
                    20,
                    20);

                g.DrawString(
                    item.Key,
                    new Font("Arial", 9),
                    Brushes.Black,
                    270,
                    30 + i * 30);

                startAngle += sweepAngle;// Следующий сектор начинается там, где закончился этот
                i++;// Переходим к следующему цвету
            }
            pictureBox1.Image = bitmap;
            //Для построения диаграммы используется класс Graphics. Сначала вычисляется общая сумма расходов. З
            //атем для каждой категории определяется доля в процентах и соответствующий угол сектора круга.
            //После этого метод FillPie рисует сектор круговой диаграммы.
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string selectedType = cmbFilter.Text;
            string selectedCategory = cmbFilterCategory.Text;
            foreach (DataGridViewRow row in Operations.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }
                string rowType = row.Cells[1].Value.ToString();
                string rowCategory = row.Cells[2].Value.ToString();

                bool typeMatch = selectedType == "Все" || rowType == selectedType;
                bool categoryMatch = selectedCategory == "Все" || rowCategory == selectedCategory;
                row.Visible = typeMatch && categoryMatch;
            }
            //Пользователь выбирает тип операции и категорию. Затем программа перебирает все строки таблицы через цикл foreach.
            //Для каждой строки проверяется совпадение типа и категории. Если оба условия выполняются, строка остается видимой,
            //иначе скрывается через свойство Visible.
        }
        //При нажатии кнопки «Статистика» программа анализирует все расходы, группирует их по категориям, определяет сумму по каждой
        //категории и находит категорию с максимальными затратами. Затем данные выводятся в список и строится круговая диаграмма,
        //которая наглядно показывает структуру расходов пользователя.

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

