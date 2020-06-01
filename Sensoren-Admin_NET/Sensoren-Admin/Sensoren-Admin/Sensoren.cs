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
    public partial class Sensoren : Form {
        public Sensoren() {
            InitializeComponent();

            fillDataGridVieUebersicht();

        }

        private const string connectionString_ = "Server=localhost;Database=sensoren;uid=root;pwd=";

        private string benutzer = "tom";
        private MySqlDataAdapter sqlDataAdapter_;
        private DataTable dataTable_;
        private DataSet dataSet_;

        private void sqlEinfuegen( string sql ) {
            MySqlConnection connection = null;
            try {
                connection = new MySqlConnection( connectionString_ );
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = sql;
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            finally {
                if ( connection != null )
                    connection.Close();
            }
        }

        private DataTable fuelleDataTable( string sql ) {

            MySqlConnection conn = new MySqlConnection( connectionString_ );

            conn.Open();

            MySqlCommand command = new MySqlCommand( sql, conn );
            MySqlDataAdapter adapter = new MySqlDataAdapter( command );

            DataTable dt = new DataTable();

            adapter.Fill( dt );

            conn.Close();

            sqlDataAdapter_ = adapter;

            return dt;
        }

        private DataSet fuelleDataSet( string sql ) {

            MySqlConnection conn = new MySqlConnection( connectionString_ );

            conn.Open();

            MySqlCommand command = new MySqlCommand( sql, conn );
            MySqlDataAdapter adapter = new MySqlDataAdapter( command );

            DataSet ds = new DataSet();

            adapter.Fill( ds );

            conn.Close();

            sqlDataAdapter_ = adapter;
            dataSet_ = ds;

            return ds;
        }

        private void speichereDataGridViewInDb() {

            MySqlCommandBuilder cmbl = new MySqlCommandBuilder( sqlDataAdapter_ );

            sqlDataAdapter_.UpdateCommand = cmbl.GetUpdateCommand();

            sqlDataAdapter_.Update( dataSet_ );
        }

            private void fillDataGridVieUebersicht() {

            StringBuilder sb = new StringBuilder();
            sb.Append( "SELECT " );
            sb.Append( "temperaturen.sensorNr, " );
            sb.Append( "temperaturen.temperatur, " );
            sb.Append( "temperaturen.zeit, " );
            sb.Append( "sensoren.serverschrank, " );
            sb.Append( "sensoren.adresse, " );
            sb.Append( "sensoren.maxTemp, " );
            sb.Append( "hersteller.name, " );
            sb.Append( "benutzer.benutzer " );
            sb.Append( "FROM temperaturen " );
            sb.Append( "JOIN sensoren ON temperaturen.sensorNr = sensoren.id_sensoren " );
            sb.Append( "JOIN sensor_benutzer ON sensoren.id_sensoren = sensor_benutzer.sensorID " );
            sb.Append( "LEFT OUTER JOIN hersteller ON sensoren.herstellerID = hersteller.hersteller_id " );
            sb.Append( "LEFT OUTER JOIN benutzer ON sensor_benutzer.benutzerID = benutzer.id_benutzer " );
            sb.Append( $@"WHERE benutzer.benutzer = '{benutzer}'" );

            dataTable_ = fuelleDataTable( sb.ToString() );

            dataGridView.DataSource = dataTable_;
        }

        private void buttonUeber_Click( object sender, EventArgs e ) {
            fillDataGridVieUebersicht();
        }

        private void buttonSensoren_Click( object sender, EventArgs e ) {
            //dataGridView.DataSource = fuelleDataTable( @"SELECT sensoren.id_sensoren, sensoren.adresse, sensoren.serverschrank, hersteller.name FROM sensoren INNER JOIN hersteller ON hersteller.hersteller_id = sensoren.herstellerID" );
            dataGridView.DataSource = fuelleDataSet( @"SELECT sensoren.id_sensoren, sensoren.adresse, sensoren.serverschrank, hersteller.name FROM sensoren INNER JOIN hersteller ON hersteller.hersteller_id = sensoren.herstellerID" ).Tables[ 0 ];
        }

        private void buttonSensorTemp_Click( object sender, EventArgs e ) {
            dataGridView.DataSource = fuelleDataTable( @"SELECT sensoren.id_sensoren, sensoren.serverschrank, sensoren.adresse, temperaturen.temperatur FROM sensoren LEFT OUTER JOIN temperaturen ON temperaturen.sensorNr = sensoren.id_sensoren" );
        }

        private void buttonTmpSensHer_Click( object sender, EventArgs e ) {
            dataGridView.DataSource = fuelleDataTable( @"SELECT temperaturen.temperatur, sensoren.id_sensoren, hersteller.name FROM temperaturen JOIN sensoren ON sensoren.id_sensoren = temperaturen.sensorNr JOIN hersteller ON hersteller.hersteller_id = sensoren.herstellerID" );
        }

        private void buttonLast_Click( object sender, EventArgs e ) {
            dataGridView.DataSource = fuelleDataTable( @"SELECT * FROM temperaturen ORDER BY temperaturen.id_temperatur DESC LIMIT 10" );
        }

        private void buttonTempDateDesc_Click( object sender, EventArgs e ) {
            dataGridView.DataSource = fuelleDataTable( @"SELECT * FROM temperaturen ORDER BY temperaturen.id_temperatur DESC LIMIT 10" );
        }

        private void buttonTempGen_Click( object sender, EventArgs e ) {
            sqlEinfuegen( @"INSERT INTO `sensoren`.`temperaturen` (`temperatur`, `sensorNr`) VALUES ((SELECT FLOOR(RAND()*(90-50+1))+50), (SELECT FLOOR(RAND()*(0-11+1))+11))" );
            fillDataGridVieUebersicht();
        }

        private void buttonSensMax_Click( object sender, EventArgs e ) {
            dataGridView.DataSource = fuelleDataTable( @"SELECT temperaturen.sensorNr, MAX(temperaturen.temperatur) FROM temperaturen GROUP BY temperaturen.sensorNr" );
        }

        private void buttonSensAvg_Click( object sender, EventArgs e ) {
            dataGridView.DataSource = fuelleDataTable( @"SELECT temperaturen.sensorNr, AVG(temperaturen.temperatur) FROM temperaturen GROUP BY temperaturen.sensorNr" );
        }

        private void buttonSpeichern_Click( object sender, EventArgs e ) {
            speichereDataGridViewInDb();
        }

        private void Test_Click( object sender, EventArgs e ) {
            //dataTable_ = fuelleDataTable( @"SELECT * FROM temperaturen" );
            dataGridView.DataSource = fuelleDataSet( @"SELECT * FROM temperaturen" ).Tables[ 0 ];
        }

        private void dataGridView_CellValueChanged( object sender, DataGridViewCellEventArgs e ) {
            speichereDataGridViewInDb();
            dataGridView.DataSource = dataTable_;
        }

        private void dataGridView_RowValidated( object sender, DataGridViewCellEventArgs e ) {
            speichereDataGridViewInDb();
            dataGridView.DataSource = dataTable_;
        }

        private void buttonBeenden_Click( object sender, EventArgs e ) {
            Application.Exit(); 
        }
    }
}
