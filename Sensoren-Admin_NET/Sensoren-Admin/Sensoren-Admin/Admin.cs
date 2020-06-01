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
    public partial class Admin : Form {

        private Form form_;
        private string benutzer_;

        public Admin( Form form, string benutzer ) {
            InitializeComponent();
            benutzer_ = benutzer;
            form_ = form;
            dataBenutzer();
            initialFlag_ = true;
            // Handle the ApplicationExit event to know when the application is exiting.
            Application.ApplicationExit += new EventHandler( this.onApplicationExit );
        }

        // XAMPP
        //private const string connectionString_ = "Server=localhost;Database=sensoren2;uid=root;pwd=; Convert Zero Datetime=True";
        private const string connectionString_ = "server=sql7.freemysqlhosting.net; database=sql7344053;uid=sql7344053;password=2HumEs6uvv ;;Convert Zero Datetime=True";
        private MySqlDataAdapter sqlDataAdapter_;
        private DataTable dataTable_;
        private DataSet dataSet_;
        private DataGridView gridView_;
        private bool initialFlag_;

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

        private void addEditColumn( DataGridView dataGridView ) {

            //DataGridViewButtonColumn save_column = new DataGridViewButtonColumn();
            //save_column.Name = "add_col";
            //save_column.HeaderText = "";
            //save_column.Text = "neu";
            //save_column.UseColumnTextForButtonValue = true;
            //save_column.CellTemplate.Style.BackColor = Color.WhiteSmoke;

            DataGridViewButtonColumn delete_column = new DataGridViewButtonColumn();
            delete_column.Name = "loeschen_col";
            delete_column.HeaderText = "";
            delete_column.Text = "loeschen";
            delete_column.UseColumnTextForButtonValue = true;
            delete_column.CellTemplate.Style.BackColor = Color.WhiteSmoke;

            //dataGridView.Columns.Add( save_column );
            dataGridView.Columns.Add( delete_column );
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Hier werden die Änderungen aus dem DataGridView  Maximaltemperaturen ge-logt
        /// </summary>
        /// <param name="geänderteDaten"></param>
        private void saveMaxTemperature( DataTable geänderteDaten ) {

            int benutzerId = 0;

            using ( MySqlConnection con = new MySqlConnection( connectionString_ ) ) {
                con.Open();

                // auslesen der Benutzer-ID anhand des Benutzernamen
                MySqlCommand command = con.CreateCommand();

                // Ermittlung der Benutzer ID anhand des angemeldeten Benutzers
                string sqlGetUserId = @"SELECT benutzer.id_benutzer FROM benutzer WHERE benutzer.benutzer = @Benutzer;";
                command.CommandText = sqlGetUserId;
                command.Parameters.AddWithValue( "@Benutzer", benutzer_ );

                MySqlDataReader reader = command.ExecuteReader();

                while ( reader.Read() ) {
                    benutzerId = reader.GetInt32( "id_benutzer" );
                }
                con.Close();

                // Log-Eintrag
                con.Open();
                foreach ( DataRow row in geänderteDaten.Rows ) {

                    int sensornummer = ( int ) row[ 0 ];
                    float temperatur = ( float ) row[ 1 ];

                    // anlegen des Log-Eintrages
                    string sqlLogEntry = @"INSERT INTO logs ( sensorID, id_benutzer, maxTemp, datum) VALUES (@sensorID, @Id_benutzer, @maxTemp, NOW())";
                    command.CommandText = sqlLogEntry;
                    command.Parameters.AddWithValue( "@sensorID", sensornummer );
                    command.Parameters.AddWithValue( "@Id_benutzer", benutzerId );
                    command.Parameters.AddWithValue( "@MaxTemp", temperatur );

                    command.ExecuteNonQuery();

                }
                con.Close();
            }
        }


        private void speichereDataGridViewInDb() {

            try {
                using ( MySqlCommandBuilder cmbl = new MySqlCommandBuilder( sqlDataAdapter_ ) ) {


                    sqlDataAdapter_.UpdateCommand = cmbl.GetUpdateCommand();

                    // Abhandlung loggen von Maximaltemperaturen
                    if ( tabControlTemp.SelectedTab.Name == "tabPageSensorMaxTemp" ) {

                        DataTable geänderteDaten = ( ( DataTable ) dataGridViewMaxTempSensor.DataSource ).GetChanges( DataRowState.Modified );

                        if ( geänderteDaten != null ) {
                            saveMaxTemperature( geänderteDaten );
                        }
                    }
                    sqlDataAdapter_.Update( dataSet_ );
                }

                gridView_.Update();
            } catch ( Exception ex ) {
                MessageBox.Show( ex.Message, "Es gab ein Fehler beim Speichern in die Datenbank" );
            }
        }

        private void dataBenutzer() {
            dataGridViewBenutzer.DataSource = fuelleDataSet( @"SELECT * FROM benutzer" ).Tables[ 0 ];
            gridView_ = dataGridViewBenutzer;
        }

        private void buttonClose_Click( object sender, EventArgs e ) {
            sqlDataAdapter_.Dispose();
            form_.Dispose();
            Application.Exit();
        }

        private void buttonSpeichern_Click( object sender, EventArgs e ) {
            speichereDataGridViewInDb();
        }

        private void tabControlTemp_SelectedIndexChanged( object sender, EventArgs e ) {

            TabPage current = ( sender as TabControl ).SelectedTab;
            if ( current.Name == "tabPageTemp" ) {
                buttonSpeichern.Show();
                dataGridViewTemperatur.DataSource = fuelleDataSet( @"SELECT * FROM temperaturen" ).Tables[ 0 ];
                gridView_ = dataGridViewTemperatur;

                if ( initialFlag_ ) {
                    addEditColumn( dataGridViewTemperatur );
                    initialFlag_ = false;
                }

            }

            if ( current.Name == "tabPageSensoren" ) {
                buttonSpeichern.Show();
                dataGridViewSensoren.DataSource = fuelleDataSet( @"SELECT * FROM sensoren" ).Tables[ 0 ];
                gridView_ = dataGridViewSensoren;

                if ( dataGridViewSensoren.RowCount > 0 ) {
                    dataGridViewSensoren.Columns[ "maxTemp" ].ReadOnly = true;
                }
            }
            if ( current.Name == "tabPageSensorMaxTemp" ) {
                buttonSpeichern.Show();
                dataGridViewMaxTempSensor.DataSource = fuelleDataSet( @"SELECT sensoren.id_sensoren, sensoren.maxTemp FROM sensoren" ).Tables[ 0 ];
                gridView_ = dataGridViewMaxTempSensor;
            }
            if ( current.Name == "tabPageBen" ) {
                buttonSpeichern.Show();
                dataBenutzer();
            }
            if ( current.Name == "tabPageLogs" ) {
                buttonSpeichern.Hide();
                dataGridViewLogs.DataSource = fuelleDataSet( @"SELECT * FROM logs" ).Tables[ 0 ];

                if ( dataGridViewLogs.RowCount > 0 ) {
                    dataGridViewLogs.Columns[ "id_logs" ].HeaderText = "Lognummer";
                    dataGridViewLogs.Columns[ "sensorID" ].HeaderText = "Sensornummer";
                    dataGridViewLogs.Columns[ "id_benutzer" ].HeaderText = "Benutzernummer";
                    dataGridViewLogs.Columns[ "maxTemp" ].HeaderText = "Neue maximal Temperatur";
                    dataGridViewLogs.Columns[ "datum" ].HeaderText = "Geändert am";

                    //dataGridViewLogs.Columns[ "loeschen_col" ].HeaderText = "";
                    //dataGridViewLogs.Columns[ "speichern_col" ].HeaderText = "";

                }


            }
        }

        /// <summary>
        /// Führt übergendes SQL aus.
        /// </summary>
        /// <param name="sql"></param>
        private bool executeSql( string sql ) {
            try {
                using ( MySqlConnection con = new MySqlConnection( connectionString_ ) ) {
                    con.Open();
                    // auslesen der Benutzer-ID anhand des Benutzernamen
                    MySqlCommand command = con.CreateCommand();
                    command.CommandText = sql;
                    if ( command.ExecuteNonQuery() == 1 ) {
                        con.Close();
                        return true;
                    }

                }
            } catch ( Exception ex ) {
                MessageBox.Show( ex.Message, "Es gab ein Fehler beim Speichern in die Datenbank" );
            }
            return false;
        }

        private void dataGridViewTemperatur_CellClick( object sender, DataGridViewCellEventArgs e ) {
            if ( e.ColumnIndex == dataGridViewTemperatur.Columns[ "loeschen_col" ].Index ) {
                //dataGridViewTemperatur.Update();

                if ( DialogResult.Yes == MessageBox.Show( "Soll der Temperatur-Eintrag gelöscht werden?", "", MessageBoxButtons.YesNo ) ) {
                    if ( e.RowIndex > -1 ) {
                        string temp_id = this.dataGridViewTemperatur[ 0, e.RowIndex ].Value.ToString();
                        string temp_id2 = dataGridViewTemperatur.Rows[ e.RowIndex ].Cells[ "id_temperatur" ].Value.ToString();
                        if ( executeSql( $"DELETE FROM temperaturen WHERE temperaturen.id_temperatur = {temp_id2}" ) ) {
                            dataGridViewTemperatur.Rows.RemoveAt( e.RowIndex );
                        }
                    }
                }
            }
        }

        private void onApplicationExit( object sender, EventArgs e ) {
            sqlDataAdapter_.Dispose();
            form_.Dispose();
        }
    }
}
