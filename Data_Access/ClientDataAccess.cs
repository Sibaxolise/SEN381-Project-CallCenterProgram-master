using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using CallCenterProgram;
using CallCenterProgram.Bussiness_Logic;
using System.Data;

namespace CallCenterProgram.Data_Access
{
    class ClientDataAccess
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.; Initial Catalog = CallCenterDatabase; Integrated Security = SSPI");
        SqlCommand cmd;
        String query;

        public void InsertBusinessClient(BusinessClient client)
        {
            try //this part inserts the ID, name and surname into the Client table
            {
                query = @"INSERT INTO Client VALUES ('" + client.ClientID + "', '" + client.Name + "', '" + client.Surname + "', 'Business')";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not insert to the Client table: {0}", e.Message);
            }
            finally
            {
                conn.Close();
            }

            try //this part inserts the client status and role into the business client info table
            {
                query = @"INSERT INTO BusinessClientInfo VALUES ('" + client.ClientID + "', '" + client.ClientStatus + "', '" + client.ClientRole + "')";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not insert to the BusinessClientInfo table: {0}", e.Message);
            }
            finally
            {
                conn.Close();
            }

            try //this part inserts the client address into the client address table
            {
                query = @"INSERT INTO ClientAddress VALUES ('" + client.ClientID + "', '" + client.Streetnumber + "', '" + client.Streetname + "', '" + client.City + "', '" + client.Country + "')";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not insert to the ClientAddress table: {0}", e.Message);
            }
            finally
            {
                conn.Close();
            }

            try //this part inserts the client contact info into the ClientContactInfo table
            {
                query = @"INSERT INTO ClientContactInfo VALUES ('" + client.ClientID + "', '" + client.Email + "', '" + client.Cellphone + "')";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not insert to the ClientContactInfo table: {0}", e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdateBusinessClient(BusinessClient client)
        {
            try
            {
                try //this part updates the ID, name and surname in the Client table
                {
                    query = @"UPDATE Client SET ClientName = '" + client.Name + "', ClientSurname = '" + client.Surname + "' WHERE ClientID = '" + client.ClientID + "'";
                    cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not update the Client table: {0}", e.Message);
                }
                finally
                {
                    conn.Close();
                }

                try //this part updates the client status and role in the business client info table
                {
                    query = @"UPDATE BusinessClientInfo SET ClientStatus = '" + client.ClientStatus + "', ClientRole = '" + client.ClientRole + "' WHERE ClientID = '" + client.ClientID + "'";
                    cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not update the BusinessClientInfo table: {0}", e.Message);
                }
                finally
                {
                    conn.Close();
                }

                try //this part updates the client address in the client address table
                {
                    query = @"UPDATE ClientAddress SET StreetNumber = '" + client.Streetnumber + "', StreetName = '" + client.Streetname + "', City = '" + client.City + "', Country = '" + client.Country + "' WHERE ClientID = '" + client.ClientID + "'";
                    cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not update the ClientAddress table: {0}", e.Message);
                }
                finally
                {
                    conn.Close();
                }

                try //this part inserts the client contact info into the ClientContactInfo table
                {
                    query = @"UPDATE ClientContactInfo SET Email = '" + client.Email + "', PhoneNumber = '" + client.Cellphone + "' WHERE ClientID = '" + client.ClientID + "'";
                    cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not update the ClientContactInfo table: {0}", e.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please make sure all fields are filled out correctly " + ex.Message);
            }
            finally
            {
                MessageBox.Show("Successfully updated");
            }
        }

        public void UpdateIndividualClient(IndividualClient client)
        {
            try
            {
                try //this part updates the ID, name and surname in the Client table
                {
                    query = @"UPDATE Client SET ClientName = '" + client.Name + "', ClientSurname = '" + client.Surname + "' WHERE ClientID = '" + client.ClientID + "'";
                    cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not update the Client table: {0}", e.Message);
                }
                finally
                {
                    conn.Close();
                }

                try //this part updates the client status and role in the business client info table
                {
                    query = @"UPDATE IndividualClientInfo SET ClientStatus = '" + client.ClientStatus + "', IsCurrentClient = '" + client.IsCurrentClient + "' WHERE ClientID = '" + client.ClientID + "'";
                    cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not update the IndividualClientInfo table: {0}", e.Message);
                }
                finally
                {
                    conn.Close();
                }

                try //this part updates the client address in the client address table
                {
                    query = @"UPDATE ClientAddress SET StreetNumber = '" + client.Streetnumber + "', StreetName = '" + client.Streetname + "', City = '" + client.City + "', Country = '" + client.Country + "' WHERE ClientID = '" + client.ClientID + "'";
                    cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not update the ClientAddress table: {0}", e.Message);
                }
                finally
                {
                    conn.Close();
                }

                try //this part inserts the client contact info into the ClientContactInfo table
                {
                    query = @"UPDATE ClientContactInfo SET Email = '" + client.Email + "', PhoneNumber = '" + client.Cellphone + "' WHERE ClientID = '" + client.ClientID + "'";
                    cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not update the ClientContactInfo table: {0}", e.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please make sure all fields are filled out correctly " + ex.Message);
            }
            finally
            {
                MessageBox.Show("Successfully updated");
            }
        }

        public void InsertIndividualClient(IndividualClient client)
        {
            try //this part inserts the ID, name and surname into the Client table
            {
                query = @"INSERT INTO Client VALUES ('" + client.ClientID + "', '" + client.Name + "', '" + client.Surname + "', 'Individual')";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not insert to the Client table: {0}", e.Message);
            }
            finally
            {
                conn.Close();
            }

            try //this part inserts the client status and if the client is a current client into the individual client info table
            {
                query = @"INSERT INTO IndividualClientInfo VALUES ('" + client.ClientID + "', '" + client.ClientStatus + "', '" + client.IsCurrentClient + "')";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not insert to the IndividualClientInfo table: {0}", e.Message);
            }
            finally
            {
                conn.Close();
            }

            try //this part inserts the client address into the client address table
            {
                query = @"INSERT INTO ClientAddress VALUES ('" + client.ClientID + "', '" + client.Streetnumber + "', '" + client.Streetname + "', '" + client.City + "', '" + client.Country + "')";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not insert to the ClientAddress table: {0}", e.Message);
            }
            finally
            {
                conn.Close();
            }

            try //this part inserts the client contact info into the ClientContactInfo table
            {
                query = @"INSERT INTO ClientContactInfo VALUES ('" + client.ClientID + "', '" + client.Email + "', '" + client.Cellphone + "')";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not insert to the ClientContactInfo table: {0}", e.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public BindingSource FillIndividualDGV()
        {
            BindingSource src = new BindingSource();
            string query = @"SELECT Client.ClientID, Client.ClientName, Client.ClientSurname, IndividualClientInfo.ClientStatus, IndividualClientInfo.IsCurrentClient, ClientAddress.StreetNumber, ClientAddress.StreetName, ClientAddress.City, ClientAddress.Country, ClientContactInfo.Email, ClientContactInfo.PhoneNumber
                             FROM Client INNER JOIN IndividualClientInfo ON Client.ClientID = IndividualClientInfo.ClientID
			                 INNER JOIN ClientAddress ON Client.ClientID = ClientAddress.ClientID
			                 INNER JOIN ClientContactInfo ON Client.ClientID = ClientContactInfo.ClientID
                             WHERE  Client.ClientType = 'Individual'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            src.DataSource = table;
            return src;
        }

        public BindingSource FillBusinessDGV()
        {
            BindingSource src = new BindingSource();
            string query = @"SELECT Client.ClientID, Client.ClientName, Client.ClientSurname, BusinessClientInfo.ClientRole, BusinessClientInfo.ClientStatus, ClientAddress.StreetNumber, ClientAddress.StreetName, ClientAddress.City, ClientAddress.Country, ClientContactInfo.Email, ClientContactInfo.PhoneNumber
                             FROM Client INNER JOIN BusinessClientInfo ON Client.ClientID = BusinessClientInfo.ClientID
			                 INNER JOIN ClientAddress ON Client.ClientID = ClientAddress.ClientID
			                 INNER JOIN ClientContactInfo ON Client.ClientID = ClientContactInfo.ClientID
                             WHERE Client.CLientType = 'Business'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            src.DataSource = table;
            return src;
        }

        public void DeleteBusinessClient(int ID)
        {
            //Delete from all client tables in correct order to prevent foreign key reference error
            //Delete from ClientContactInfo table
            try
            {
                query = @"DELETE FROM ClientContactInfo WHERE ClientID = '" + ID + "' ";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show("Could not delete user with ID: " + ID + " from table ClientContactInfo" + e.Message);
            }
            finally
            {
                conn.Close();
            }

            //Delete from ClientAddress table
            try
            {
                query = @"DELETE FROM ClientAddress WHERE ClientID = '" + ID + "' ";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not delete user with ID: " + ID + " from table ClientAddress" + e.Message);
            }
            finally
            {
                conn.Close();
            }

            //Delete from BusinessClientInfo table
            try
            {
                query = @"DELETE FROM BusinessClientInfo WHERE ClientID = '" + ID + "' ";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not delete user with ID: " + ID + " from table BusinessClientInfo" + e.Message);
            }
            finally
            {
                conn.Close();
            }

            //Delete from Client table
            try
            {
                query = @"DELETE FROM Client WHERE ClientID = '" + ID + "' ";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not delete user with ID: " + ID + " from table Client" + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeleteIndividualClient(int ID)
        {
            //Delete from all client tables in correct order to prevent foreign key reference error
            //Delete from ClientContactInfo table
            try
            {
                query = @"DELETE FROM ClientContactInfo WHERE ClientID = '" + ID + "' ";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not delete user with ID: " + ID + " from table ClientContactInfo" + e.Message);
            }
            finally
            {
                conn.Close();
            }

            //Delete from ClientAddress table
            try
            {
                query = @"DELETE FROM ClientAddress WHERE ClientID = '" + ID + "' ";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not delete user with ID: " + ID + " from table ClientAddress" + e.Message);
            }
            finally
            {
                conn.Close();
            }

            //Delete from IndividualClientInfo table
            try
            {
                query = @"DELETE FROM IndividualClientInfo WHERE ClientID = '" + ID + "' ";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not delete user with ID: " + ID + " from table IndividualClientInfo" + e.Message);
            }
            finally
            {
                conn.Close();
            }

            //Delete from Client table
            try
            {
                query = @"DELETE FROM Client WHERE ClientID = '" + ID + "' ";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not delete user with ID: " + ID + " from table Client" + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
