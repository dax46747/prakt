using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ruchki
{
    public partial class FrmMan : Form
    {
        public FrmMan()
        {
            InitializeComponent();
        }

        private void FrmMan_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMaterial frmMaterial = new FrmMaterial();
            FrmMan.ActiveForm.Close();
            frmMaterial.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-DUI46P96\SQLEXPRESS01;Initial Catalog=Ruchki;Integrated Security=True");
            string НаименованиеМатериала = textBox1.Text.Trim();
            string ТипМатериала = textBox2.Text.Trim();
            string Изображение = textBox3.Text.Trim();
            string Цена = textBox4.Text.Trim();
            string КоличествоНаСкладе = textBox5.Text.Trim();
            string МинимальноеКоличество = textBox6.Text.Trim();
            string КоличествоВУпаковке = textBox7.Text.Trim();
            string ЕдиницаИзмерения = textBox8.Text.Trim();

            MessageBox.Show("Вы действительно хотите добавить новую запись?");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
