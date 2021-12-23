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
    public partial class Form1 : Form
    {
        public static string MyConStr = @"Provider = Microsoft.ACE.OLEDB.12.0;" + @"Data Source = |DataDirectory|\Data\Mobil.accdb;";
        public System.Data.OleDb.OleDbConnection MyConnect;
        public DataSet ds;
        public OleDbDataAdapter AbonAdapter;
        public OleDbDataAdapter OperAdapter;
        public OleDbDataAdapter TelAdapter;
        DataRelation AbonTelRel;
        DataRelation OperTelRel;
        public string SQLStr0 = "SELECT * FROM Абонент";
        public string SQLStr1 = "SELECT * FROM Оператор";
        public string SQLStr2 = "SELECT * FROM Телефон";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyConnect = new System.Data.OleDb.OleDbConnection(MyConStr);
            MyConnect.Open();
            ds = new DataSet();
            AbonAdapter = new OleDbDataAdapter(SQLStr0, MyConnect);
            AbonAdapter.Fill(ds, "Абонент");
            OperAdapter = new OleDbDataAdapter(SQLStr1, MyConnect);
            OperAdapter.Fill(ds, "Оператор");
            TelAdapter = new OleDbDataAdapter(SQLStr2, MyConnect);
            TelAdapter.Fill(ds, "Телефон");
            AbonTelRel = ds.Relations.Add("AbonTel",
                ds.Tables["Абонент"].Columns["ID_Абонент"], 
                ds.Tables["Телефон"].Columns["FK_Абонент"]);
            OperTelRel = ds.Relations.Add("OperTel",
                ds.Tables["Оператор"].Columns["ID_Оператор"],
                ds.Tables["Телефон"].Columns["FK_Оператор"]);
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (MyConnect != null && MyConnect.State != ConnectionState.Closed)
                MyConnect.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void абонентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2(this);
            Form2.Show();
        }

        private void операторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3(this);
            Form3.Show();
        }

        private void телефонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4(this);
            Form4.Show();
        }

        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Spravka Spr = new Spravka();
            Spr.ShowDialog();
        }
    }
}
