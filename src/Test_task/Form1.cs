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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Категория". При необходимости она может быть перемещена или удалена.
            this.категорияTableAdapter.Fill(this.dataDataSet.Категория);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Гражданин". При необходимости она может быть перемещена или удалена.
            this.гражданинTableAdapter.Fill(this.dataDataSet.Гражданин);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Выплаты". При необходимости она может быть перемещена или удалена.
            this.выплатыTableAdapter.Fill(this.dataDataSet.Выплаты);


            Citizens citizens = new Citizens();
            citizens.Load(@"C:\Users\Гузель\Documents\Visual Studio 2012\Projects\Test_task\Test_task\Data.txt");

            //dataGridView2

           
            for (int i = 0; i < citizens.currentCitizen.HumanCitizen.Count; i++)
            {
                string s = citizens.currentCitizen.HumanCitizen[i];
                dataGridView2[0, 0].Value = "1122";//заносим в первый столбец данные

                //int rowNum = dataGridView2.Rows.Add();
                dataGridView2.Rows[0].Cells[0].Value = "AWDAWDA" ;//ячейку можно указывать номером столбца
                //dataGridView2.Rows[rowNum].Cells["id"] = 123;//... или его именем
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void гражданинBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            // Устанавливаем фильтр в 
            гражданинBindingSource.Filter = "Фамилия = \' " + FindBox.Text + "\'";

        }

        private void Openbutton_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
