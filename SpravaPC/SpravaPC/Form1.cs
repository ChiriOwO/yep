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

namespace SpravaPC
{
    public partial class Form1 : Form
    {
        static SqlConnection pripojeni;
        static SqlDataAdapter adapter;
        static DataSet data;

        public Form1()
        {
            InitializeComponent();
            pripojeni = new SqlConnection(ZiskejPripojovaciRetezec());
            data = new DataSet();
            adapter = new SqlDataAdapter("SELECT * FROM PC", pripojeni);
        }

        private string ZiskejPripojovaciRetezec()
        {
            SqlConnectionStringBuilder sestavovac = new SqlConnectionStringBuilder();
            sestavovac.DataSource = @"C305-PC18\SQLEXPRESS";
            sestavovac.InitialCatalog = "SpravaPC";
            sestavovac.UserID = "sa";
            sestavovac.Password = "sssaaa";
            return (sestavovac.ConnectionString);
        }

        private void buttonGetData_Click(object sender, EventArgs e)
        {
            NaplnDataSet();
            buttonUpravit.Show();
            dataGridView1.DataSource = data.Tables[0];
        }

        private void NaplnDataSet()
        {
            data.Clear();
            adapter.Fill(data, "PC");
        }

        private void buttonUpravit_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder vytvoreniDotazu = new SqlCommandBuilder(adapter);
            adapter.Update(data, "PC");
            MessageBox.Show("Tabulka aktualizovana.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'spravaPCDataSet1.PC' table. You can move, or remove it, as needed.
            this.pCTableAdapter1.Fill(this.spravaPCDataSet1.PC);

        }
    }
}
