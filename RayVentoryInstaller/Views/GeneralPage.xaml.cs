using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;


namespace RayVentoryInstaller.Views
{
    /// <summary>
    /// Interaction logic for GeneralPage.xaml
    /// </summary>
    public partial class GeneralPage : Page
    {
        public GeneralPage()
        {
            InitializeComponent();
        }

        private void tglsw_InstallSQL_Toggled(object sender, RoutedEventArgs e)
        {

        }

        private void tglsw_Instance_Toggled(object sender, RoutedEventArgs e)
        {
            tb_Instance.IsEnabled = false;

        }

        private void b_VerifySQLConn_Click(object sender, RoutedEventArgs e)
        {
            foreach(Control control in LogicalTreeHelper.GetChildren(this))
            {
                if(control is TextBox)
                {
                    (control as TextBox).IsEnabled = false;
                }
            }

            string connection;

            SqlConnection sqlConnection;
            SqlCommand sqlCommand;
            SqlDataReader sqlDataReader;

            string user;

            connection = $"DataSource={ tb_SQLServer.Text}";
            if(tb_Instance.Text != null)
            {
                connection += '\\' + tb_Instance.Text;
            }

            if(tb_PortName != null)
            {
                connection += ':' + tb_PortName.Text;
            }
            connection += $";Initial Catalog=master;";

            if(tb_SQLUser != null)
            {
                connection += $"User ID={tb_SQLUser.Text};Password={pb_SQLPassword.Password}";
                user = tb_SQLUser.Text;
            }
            else
            {
                connection += "Trusted_Connection=True;";
                user = Environment.UserName;
            }

            string sql = "SELECT r.name as Role, m.name as Principal FROM master.sys.server_role_members rm" +
                "INNER JOIN master.sys.server_principals r ON r.principal_id = rm.role_principal_id AND r.type = 'R'" +
                $" INNER JOIN master.sys.server_principals m ON m.principal_id = rm.member_principal_id WHERE m.name = \'{user}\';";

            sqlConnection = new SqlConnection(connection);
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    if((string)sqlDataReader.GetValue(0) == "Sysadmin")
                    {
                        SQLAuthWrong.Visibility = Visibility.Hidden;
                        SQLAuthRight.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        SQLAuthRight.Visibility = Visibility.Hidden;
                        SQLAuthWrong.Visibility = Visibility.Visible;
                    }

                }
                sqlDataReader.Close();
                sqlCommand.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection!");
            }
        }

        private void tglsw_Windows_Toggled(object sender, RoutedEventArgs e)
        {
            if(tglsw_Windows.IsOn)
            {
                tb_SQLUser.IsEnabled = false;
                tb_SQLUser.Text = Environment.UserName;
                lb_SQLUser.Content = "Windows User";
                pb_SQLPassword.Clear();
                pb_SQLPassword.IsEnabled = false;
            }

            else
            {
                tb_SQLUser.IsEnabled = true;
                tb_SQLUser.Clear();
                lb_SQLUser.Content = "SQL User";
                pb_SQLPassword.Clear();
                pb_SQLPassword.IsEnabled = true;
            }
            

        }
    }
}
