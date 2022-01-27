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
    public partial class adminPridetPasalintDest : Form
    {
        public adminPridetPasalintDest()
        {
            InitializeComponent();
        }

        private void prisijungti_Click(object sender, EventArgs e)
        {
            if (dvardas.Text == "")
            {
                MessageBox.Show("Vardo laukas privalomas!");
                return;
            }

            if (dpavarde.Text == "")
            {
                MessageBox.Show("Pavardės laukas privalomas!");
                return;
            }

            if (dpask.Text == "")
            {
                MessageBox.Show("Grupės laukas privalomas!");
                return;
            }

            if (dslapy.Text == "")
            {
                MessageBox.Show("Slapyvardžio laukas privalomas!");
                return;
            }

            if (dpsw.Text == "")
            {
                MessageBox.Show("Slaptažodžio laukas privalomas!");
                return;
            }

            if (destExist())
                return;

            destytojams dest = new destytojams();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`Vardas`, `Pavardė`, `Slapyvardis`, `Slaptažodis`, `Dalykas`) VALUES (@name, @surename, @login, @pass, @grupe)", dest.GetConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = dvardas.Text;
            command.Parameters.Add("@surename", MySqlDbType.VarChar).Value = dpavarde.Text;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = dslapy.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = dpsw.Text;
            command.Parameters.Add("@grupe", MySqlDbType.Text).Value = dpask.Text;

            dest.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Sėkmingai užsiregistravote");
            else
                MessageBox.Show("Registracija nesėkminga");

            dest.closeConnection();
        }

        public Boolean destExist()

        {
            destytojams desto = new destytojams();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand comma = new MySqlCommand("SELECT * FROM `users` WHERE `Slapyvardis` = @uL", desto.GetConnection());
            comma.Parameters.Add("@uL", MySqlDbType.VarChar).Value = dslapy.Text;

            adapter.SelectCommand = comma;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Naudotojas su tokiu slapyvardžiu jau egzistuoja");
                return true;
            }
            else
                return false;
        }

        private void bck_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminams appd = new adminams();
            appd.Show();
        }
    }
}
