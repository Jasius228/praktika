using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace vertinimas
{
    public partial class adminams : Form
    {
        dbconnection con = new dbconnection();
        MySqlCommand command;
        MySqlDataAdapter da;
        DataTable dt;
         

        public adminams()
        {
            InitializeComponent();
            con.Connect();
        }

        private void atnaujinti_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                command = new MySqlCommand("Select * from users", con.cn);
                command.ExecuteNonQuery();
                dt = new DataTable();
                da = new MySqlDataAdapter(command);
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                con.cn.Close();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void prideti_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminPridetPasalintDest appd = new adminPridetPasalintDest();
            appd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login logas = new Login();
            logas.Show();
        }

        private void studsar_Click(object sender, EventArgs e)
        {
            this.Hide();
            studsar stds = new studsar();
            stds.Show();
        }
    }
}
