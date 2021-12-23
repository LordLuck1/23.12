using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace WindowsFormsApp12
{
    public partial class Form3 : Form
    {
        Form1 form1;
        public Form3(Form1 f)
        {
            InitializeComponent();
            form1 = f;
            dataGridView1.DataSource = form1.ds.Tables["Оператор"];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder MyBuider = new OleDbCommandBuilder(form1.AbonAdapter);
            try
            {
                dataGridView1.DataSource = form1.ds.Tables[0];
                form1.AbonAdapter.Update(form1.ds, "Оператор");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder MyBuider = new OleDbCommandBuilder(form1.AbonAdapter);
            try
            {
                CurrencyManager CurMan = (CurrencyManager)
                    dataGridView1.BindingContext[dataGridView1.DataSource];
                if (CurMan.Count > 0)
                {
                    CurMan.RemoveAt(CurMan.Position);
                    form1.AbonAdapter.Update(form1.ds, "Оператор");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("INSERT INTO [Оператор] " + "(Название, Регион) values(@title,@region)", form1.MyConnect);
            OleDbCommand cmd1 = new OleDbCommand("SELECT @@IDENTITY", form1.MyConnect);
            cmd.Parameters.AddWithValue("@title", "");
            cmd.Parameters.AddWithValue("@region", "");
            cmd.ExecuteNonQuery();
            form1.AbonAdapter.Update(form1.ds.Tables[0]);
            int a = Convert.ToInt32(cmd1.ExecuteScalar());
            DataTable MyDT = (DataTable)dataGridView1.DataSource;
            DataRow MyNewPow = MyDT.NewRow();
            MyNewPow["ID_Оператор"] = a;
            MyNewPow["Название"] = "";
            MyNewPow["Регион"] = "";
            MyDT.Rows.Add(MyNewPow);
            MyDT.AcceptChanges();
            dataGridView1.CurrentCell = dataGridView1[1, dataGridView1.Rows.Count - 1];
        }
    }
}
