using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vertinimas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void prisijungti_Click(object sender, EventArgs e)
        {
            String loginUser = slapyvardis.Text;
            String passUser = slaptazodis.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Slapyvardis` = @uL AND `Slaptažodis` = @uP", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                studento studento = new studento();
                studento.Show();
            }
            else
                MessageBox.Show("Prisijungimo vardas arba slaptažodis neteisingi!");
        }

        private void registracija_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

            ///


        private void dprisijungti_Click(object sender, EventArgs e)
        {
            String loginUser = dslap.Text;
            String passUser = dpass.Text;

            destytojams dest = new destytojams();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Slapyvardis` = @uLD AND `Slaptažodis` = @uPD", dest.GetConnection());
            command.Parameters.Add("@uLD", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uPD", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                destview desto = new destview();
                desto.Show();
            }
            else
                MessageBox.Show("Prisijungimo vardas arba slaptažodis neteisingi!");
        }




            ///
        
        private void aprisijungti_Click(object sender, EventArgs e)
        {
            String loginUser = aslap.Text;
            String passUser = apass.Text;

            admin admink = new admin();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uLA AND `pass` = @uPA", admink.GetConnection());
            command.Parameters.Add("@uLA", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uPA", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                adminams adk = new adminams();
                adk.Show();
            }
            else
                MessageBox.Show("Prisijungimo vardas arba slaptažodis neteisingi!");
        }
    }
}
