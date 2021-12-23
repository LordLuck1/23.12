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
    public partial class Form4 : Form
    {
        Form1 form1;
        public Form4(Form1 f)
        {
            InitializeComponent();
            form1 = f;
            dataGridView1.DataSource = form1.ds.Tables["Телефон"];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public Form4()
        {
            InitializeComponent();
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
                form1.AbonAdapter.Update(form1.ds, "Телефон");
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
                    form1.AbonAdapter.Update(form1.ds, "Телефон");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("INSERT INTO [Телефон] " + "(Номер, FK_Абонент, FK_Оператор) values(@number,@FK_Subscrider,@FK_Operator)", form1.MyConnect);
            OleDbCommand cmd1 = new OleDbCommand("SELECT @@IDENTITY", form1.MyConnect);
            cmd.Parameters.AddWithValue("@number", "");
            cmd.Parameters.AddWithValue("@FK_Subscrider", "");
            cmd.Parameters.AddWithValue("@FK_Operator", "");
            cmd.ExecuteNonQuery();
            form1.AbonAdapter.Update(form1.ds.Tables[0]);
            int a = Convert.ToInt32(cmd1.ExecuteScalar());
            DataTable MyDT = (DataTable)dataGridView1.DataSource;
            DataRow MyNewPow = MyDT.NewRow();
            MyNewPow["ID_Телефон"] = a;
            MyNewPow["Номер"] = "";
            MyNewPow["FK_Абонент"] = "";
            MyNewPow["FK_Оператор"] = "";
            MyDT.Rows.Add(MyNewPow);
            MyDT.AcceptChanges();
            dataGridView1.CurrentCell = dataGridView1[1, dataGridView1.Rows.Count - 1];
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
