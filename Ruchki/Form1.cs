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
    public partial class FrmMaterial : Form
    {
        public FrmMaterial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2._materials_s_import_". При необходимости она может быть перемещена или удалена.
            this.materials_s_import_TableAdapter1.Fill(this.dataSet2._materials_s_import_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1._materials_s_import_". При необходимости она может быть перемещена или удалена.
            this.materials_s_import_TableAdapter.Fill(this.dataSet1._materials_s_import_);
            int i = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int CountInStock = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                int MinCount = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                if (CountInStock < MinCount)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                if (CountInStock * 3 > MinCount)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                i++;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-DUI46P96\SQLEXPRESS01;Initial Catalog=Ruchki;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM materials_s_import$ Order By", con);
            con.Open();
            da.Fill(ds, "materials_s_import$");
            dataGridView1.DataSource = ds.Tables[0];
            da.Dispose();
            con.Dispose();
            ds.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMan frmMan = new FrmMan();
            frmMan.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                dataGridView1.CurrentCell = null;
                dataGridView1.Rows[i].Visible = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(comboBox1.Text))
                        {
                            dataGridView1.Rows[i].Visible = true;
                            break;
                        }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM materials_s_import$ ORDER BY '" + comboBox1.Text + "'";
            SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-DUI46P96\SQLEXPRESS01;Initial Catalog=Ruchki;Integrated Security=True");
            connect.Open();
            SqlTransaction transaction = connect.BeginTransaction();
            SqlCommand command = new SqlCommand(sql, connect, transaction);
            DataSet dataSet = new DataSet();
            DataTable table = dataSet.Tables.Add("materials_s_import$");
            dataSet.Load(command.ExecuteReader(), LoadOption.OverwriteChanges, table);
            transaction.Commit();
            connect.Close();
            dataGridView1.DataSource = dataSet.Tables["materials_s_import$"];
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int kolichestvo = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            kolichestvo++;
                            break;
                        }
            }
            label1.Text = "Количество строк: " + kolichestvo;
        }

        private void UpdateDB()
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataSet2);
            dataSet2.Update("materials_s_import$");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null) ;
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    DataRowView dataRowView = dataGridView1.Cells[i] as DataRowView;
                    if (dataRowView != null)
                    {
                        DataRow dataRow = (DataRow)dataRowView.Row;
                        dataRow.Delete();
                    }
                }
            }
            UpdateDB();
        }
    private void button5_Click(object sender, EventArgs e)
    {
        UpdateDB();
    }
}
}
