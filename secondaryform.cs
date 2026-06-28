using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace financial_accounting
{
    public partial class secondaryform : Form
    {
        public secondaryform()
        {
            InitializeComponent();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void btnAddOperation_Click(object sender, EventArgs e)
        {
            Form1 Main = this.Owner as Form1;
            if (txtAmount.Text != "" && txtDescription.Text != "" && this.cmbType.SelectedIndex != -1 && this.cmbCategory.SelectedIndex != -1)
            {
                Operation operation = new Operation()
                {
                    Date = dtpDate.Value,
                    Type = cmbType.Text,
                    Category = cmbCategory.Text,
                    Amount = decimal.Parse(txtAmount.Text),
                    Description = txtDescription.Text

                };
                Main.AddOperationToGrid(operation);
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }
    }
}
