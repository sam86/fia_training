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

namespace Sensoren {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();

            textBoxPasswort.Text = "tom";
            textBoxBenutzer.Text = "tom";

            textBoxBenutzer.PasswordChar = '*';
        }

        // Lokale Datenbank
        //private const string connectionString_ = "Server=localhost;Database=sensoren;uid=root;pwd=; Convert Zero Datetime=True";
        private const string connectionString_ = "server=sql7.freemysqlhosting.net; database=sql7344053;uid=sql7344053;password=2HumEs6uvv ;;Convert Zero Datetime=True";
        private string benutzerName = String.Empty;

        private void buttonLogin_Click( object sender, EventArgs e ) {

            bool zugang = false;
            
            MySqlConnection conn = new MySqlConnection( connectionString_ );
            conn.Open();


            string ben = textBoxBenutzer.Text;
            string pw = textBoxPasswort.Text;

            string sql = $@"SELECT benutzer.benutzer, benutzer.passwort FROM benutzer WHERE benutzer.benutzer = '{ben}' AND benutzer.passwort = '{pw}'";

            MySqlCommand sCommand = new MySqlCommand( sql, conn );
            MySqlDataAdapter sAdapter = new MySqlDataAdapter( sCommand );

            DataTable dt = new DataTable();

            sAdapter.Fill( dt );

            if ( dt.Rows.Count > 0 ) {
                zugang = true;
                benutzerName = ben;
            }

            conn.Close();

            if ( zugang ) {
                //Form form = new Sensoren();
                //form.Show();
                //this.Hide();
                Form benutzer = new Admin( this, benutzerName );
                benutzer.Show();
                this.Hide();
            }
        }
    }
}
