using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_task
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Гражданин". При необходимости она может быть перемещена или удалена.
            this.гражданинTableAdapter.Fill(this.dataDataSet.Гражданин);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Выплаты". При необходимости она может быть перемещена или удалена.
            this.выплатыTableAdapter.Fill(this.dataDataSet.Выплаты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Категория". При необходимости она может быть перемещена или удалена.
            this.категорияTableAdapter.Fill(this.dataDataSet.Категория);


            
        }
    }
}
