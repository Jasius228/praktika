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
    public partial class destview : Form
    {

        dbconnectionstud con = new dbconnectionstud();
        MySqlCommand comma;
        MySqlDataAdapter da;
        DataTable dt;
        public destview()
        {
            InitializeComponent();
            con.Connect();
        }

        private void satnaujinti_Click(object sender, EventArgs e)
        {
            try
            {
            con.cd.Open();
            comma = new MySqlCommand("Select * from users", con.cd);
            comma.ExecuteNonQuery();
            dt = new DataTable();
            da = new MySqlDataAdapter(comma);
            da.Fill(dt);
            dataGridView2.DataSource = dt.DefaultView;
            con.cd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login logas = new Login();
            logas.Show();
        }
    }
}
