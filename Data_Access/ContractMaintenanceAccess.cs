using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using CallCenterProgram;
using CallCenterProgram.Presentation;
using CallCenterProgram.Bussiness_Logic;

namespace CallCenterProgram.Data_Access
{
    class ContractMaintenanceAccess
    {
        string connect = "Data Source=.; Initial Catalog= CallCenterDatabase; Integrated Security= SSPI";
        SqlConnection conn;
        SqlCommand command;
        SqlDataReader reader;

        #region Insert Functions
        //Insert functions: These functions are used to add services, service levels(including security levels),
        // add packages, add contract(aka create a contract)

        // Only the manager can use this method (or anyone with clearance to create services)
        public void InsertService(string name, string equipmentType, string workExpenses, int state)
        {
            string query = $"INSERT INTO [Service] VALUES('{name}', '{equipmentType}', '{workExpenses}', {state})";

            SqlConnection conn = new SqlConnection(connect);
            SqlCommand command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show($"New service: {name} inserted succesfully", "Service Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert new Service: " + ex.Message, "Insert Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        // Only the manager can use this method (or anyone with clearance to create service levels)
        public void InsertServiceLevel(string levelName, string optOutDetails, decimal penaltiesForLateWork, decimal penaltiesForNonPerformance, int state, int securityLevelID)
        {
            string query = $"INSERT INTO ServiceLevel VALUES('{levelName}', '{optOutDetails}', {penaltiesForLateWork},{penaltiesForNonPerformance},{state},{securityLevelID})";

            SqlConnection conn = new SqlConnection(connect);
            SqlCommand command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show($"New service level: {levelName} inserted succesfully", "Service Level Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert new Service Level: " + ex.Message, "Insert Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        // Only the manager can use this method (or anyone with clearance to create packages)
        public void InsertPackage(string packageName, string serviceIDs, string serviceLevelIDs)
        {
            string query = $"INSERT INTO ContractType VALUES('{packageName}', '{serviceIDs}', '{serviceLevelIDs}')";

            SqlConnection conn = new SqlConnection(connect);
            SqlCommand command = new SqlCommand(query, conn);


            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show($"New package: {packageName} inserted succesfully", "Package Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert new Package: " + ex.Message, "Insert Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        // Both the manager and call center personeel can use this method (or anyone with clearance to create contracts)
        // most likely to be used by the call senter personeel, as they deal with clients and create these contracts (sell the services)
        public void InsertContract(int contractTypeID, int clientID, int state)
        {
            string query = $"INSERT INTO [Contract] VALUES({contractTypeID},{clientID},{state})";

            SqlConnection conn = new SqlConnection(connect);
            SqlCommand command = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show($"New contract: {contractTypeID} inserted succesfully", "Contract Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert new Contract: " + ex.Message, "Insert Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        // The manager can use this method (or anyone with clearance to create security levels)
        public void InsertSecuriyLevel(string levelDescription, int availability, string emailSupport, string phoneSupport)
        {
            string query = $"INSERT INTO SecurityLevel VALUES('{levelDescription}', {availability}, '{emailSupport}','{phoneSupport}')";

            SqlConnection conn = new SqlConnection(connect);
            SqlCommand command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show($"New security level: {levelDescription} inserted succesfully", "Security Level Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert new security level: " + ex.Message, "Insert Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region Update Functions: Update data
        // Only the manager can use this method (or anyone with clearance to update services data)
        public void UpdateService(int serviceID, string name, string equipmentType, string workExpenses, int state)
        {
            string query = $"UPDATE Service SET Name = '{name}', EquipmentType = '{equipmentType}', [State] = {state}, WorkExpenses = '{workExpenses}' WHERE ServiceID = {serviceID}";

            conn = new SqlConnection(connect);
            command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show($"Service: {name} updated succesfully", "Service update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update Service: " + ex.Message, "Update Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // Only the manager can use this method (or anyone with clearance to update service levels data)
        public void UpdateServiceLevel(int serviceLevelID,string levelName, string optOutDetails, decimal penaltiesForLateWork, decimal penaltiesForNonPerformance, int securityLevelID, int state)
        {
            string query = $"UPDATE ServiceLevel SET LevelName = '{levelName}', OptOutDetails = '{optOutDetails}', PenaltiesForLateWork = {penaltiesForLateWork}, PenaltiesForNOnPerformance= {penaltiesForNonPerformance}, [State] = {state}, SecurityLevelID = {securityLevelID} WHERE ServiceLevelID = {serviceLevelID}";

            conn = new SqlConnection(connect);
            command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show($"Service Level: {levelName} updated succesfully", "Service Level update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update Service Level: " + ex.Message, "Update Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        // Only the manager can use this method (or anyone with clearance to update packages data)
        public void UpdatePackage(int contractTypeID, string packageName, string serviceIDs, string serviceLevelIDs)
        { 
            string query = $"UPDATE ContractType SET PackageName = '{packageName}', Services = '{serviceIDs}', ServiceLevels = '{serviceLevelIDs}' WHERE ContractTypeID = {contractTypeID}";

            conn = new SqlConnection(connect);
            command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show($"Package: {packageName} updated succesfully", "Package update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update Package: " + ex.Message, "Update Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        // Both the manager and call center personeel can use this method (or anyone with clearance to update contracts data)
        // Only change state nothing else!
        public void UpdateContract(int contractID, int state)
        {
            string query = $"UPDATE Contract SET [State] = {state} WHERE ContractID = {contractID}";

            conn = new SqlConnection(connect);
            command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Contract updated succesfully", "Contract update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update Contract: " + ex.Message, "Update Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        // The manager can use this method (or anyone with clearance to update security levels data)
        public void UpdateSecurityLevel(int securityLevelID,string levelDescription, string emailSupport, string phoneSupport, int availability)
        {
            string query = $"UPDATE SecurityLevel SET LevelDescription= '{levelDescription}', EmailSupport = '{emailSupport}', PhoneSupport = '{phoneSupport}', [Availability] = {availability} WHERE SecurityLevelID = {securityLevelID}";

            conn = new SqlConnection(connect);
            command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show($"Security Level: {levelDescription} updated succesfully", "Security Level update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update Security Level: " + ex.Message, "Update Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region Update Functions: Overloading funcitons for ChangeState Functions
        // The functions in this area are purely for changing the state of items that make up the contracts.
        // All contract maintenance classes that have states will be changed in here
        // e,g when a package is no longer availale 
        // might add more states for when a package is on sale or promotion (e.g BIT promo) 

        // Only the manager can use this method (or anyone with clearance to update services)
        public void UpdateService(int serviceID, int state)
        {
            string query = $"UPDATE Service SET State = {state} WHERE ServiceID = {serviceID}";

            conn = new SqlConnection(connect);
            command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("State updated succesfully", "Service State Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to change status: " + ex.Message, "Update Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        // Only the manager can use this method (or anyone with clearance to update service levels)
        public void UpdateServiceLevel(int serviceLevelID, int state)
        {
            string query = $"UPDATE ServiceLevel SET State = {state} WHERE ServiceLevelID = {serviceLevelID}";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("State updated succesfully", "Service Level State Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to change status: " + ex.Message, "Update Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        // Only the manager can use this method (or anyone with clearance to update security levels)
        public void UpdateSecurityLevel(int securityLevelID, int availability)
        {
            string query = $"UPDATE SecurityLevel SET Availability = {availability} WHERE SecurityLevelID = {securityLevelID}";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("State updated succesfully", "Security Level State Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to change status: " + ex.Message, "Update Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region GetData
        // Get Service
        public SqlDataReader GetService(int serviceID)
        {
            string query = $"SELECT * FROM [Service] WHERE ServiceID = {serviceID}";

            SqlConnection conn = new SqlConnection(connect);
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader service = null;
            try
            {
                conn.Open();
                service = command.ExecuteReader();
                // MessageBox.Show() overload number 7
                //MessageBox.Show("New service inserted succesfully", "Service Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine("Specified Service Found");
            }
            catch (Exception ex)
            {
                // MessageBox.Show() overload number 7
                //MessageBox.Show("Failed to insert new Service: " + ex.Message, "Insert Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                Console.WriteLine("Cannot find specified Service");
            }
            finally
            {
                conn.Close();
            }

            return service;
        }

        public List<Bussiness_Logic.ServiceLevel> GetAllServiceLevels()
        {
            List<Bussiness_Logic.ServiceLevel> levels = new List<ServiceLevel>();
            string query = $"SELECT * FROM ServiceLevel";

            SqlConnection conn = new SqlConnection(connect);
            SqlCommand command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Bussiness_Logic.ServiceLevel level = new ServiceLevel(reader.GetInt32(6), reader.GetBoolean(5), reader.GetInt32(0), reader.GetString(1), reader.GetString(2), double.Parse(reader.GetDecimal(3).ToString()), double.Parse(reader.GetDecimal(4).ToString()));
                    levels.Add(level);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not  find Service Levels " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return levels;
        }

        public List<Bussiness_Logic.SecurityLevel> GetAllSecurityLevels()
        {
            List<Bussiness_Logic.SecurityLevel> levels = new List<SecurityLevel>();
            string query = $"SELECT * FROM SecurityLevel";

            SqlConnection conn = new SqlConnection(connect);
            SqlCommand command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //bool transformData = int.Parse(reader.GetValue(2).ToString()) == 1 ? true : false;
                    Bussiness_Logic.SecurityLevel level = new SecurityLevel(reader.GetInt32(0), reader.GetString(1), reader.GetBoolean(2), reader.GetString(3), reader.GetString(4));
                    levels.Add(level);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not  find Security Levels " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return levels;
        }

        public List<Bussiness_Logic.Service> GetAllServices()
        {
            List<Bussiness_Logic.Service> services = new List<Bussiness_Logic.Service>();
            string query = $"SELECT * FROM [Service]";

            SqlConnection conn = new SqlConnection(connect);
            SqlCommand command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Bussiness_Logic.Service service = new Bussiness_Logic.Service(reader.GetString(1), reader.GetInt32(0), reader.GetString(3), reader.GetString(2), reader.GetBoolean(4));
                    services.Add(service);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not find Services " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return services;
        }

        public List<Bussiness_Logic.Package> GetAllPackages()
        {
            List<Bussiness_Logic.Package> packages = new List<Bussiness_Logic.Package>();
            string query = $"SELECT * FROM ContractType";

            SqlConnection conn = new SqlConnection(connect);
            SqlCommand command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Bussiness_Logic.Package package = new Bussiness_Logic.Package(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(0));
                    packages.Add(package);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not find packages " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return packages;
        }

        public List<Bussiness_Logic.Contract> GetAllContracts(int clientID)
        {
            List<Bussiness_Logic.Contract> contracts = new List<Bussiness_Logic.Contract>();
            string query = $"SELECT * FROM [Contract] WHERE ClientID = {clientID}";

            SqlConnection conn = new SqlConnection(connect);
            SqlCommand command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Bussiness_Logic.Contract contract = new Bussiness_Logic.Contract(reader.GetBoolean(3), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(0));
                    contracts.Add(contract);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not find contracts for this client " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return contracts;
        }
        #endregion

        #region Performance Methods
        public int GetNumberCurrentTotalPackagesInLast30Days()
        {
            // use the current date to get a datediff of 30 days dating back to select that data and use it for calculations
            DateTime now = DateTime.Now;
            DateTime delay30days = now.AddDays(-30);
            // SELECT COUNT(ContractID) FROM [Contract] WHERE Date BETWEEN delaye30days AND now
            string query = $"SELECT COUNT(*) AS 'Total' FROM [Contract] ";
            int number = 0;
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    number = dr.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to calculate contracts " + ex.Message, "Insert Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return number;
        }
        public int BestPackageOrPackagesOfTheMonthQuantity()
        {
            // use the current date to get a datediff of 30 days dating back to select that data and use it for calculations
            DateTime now = DateTime.Now;
            DateTime delay30days = now.AddDays(-30);
            // ...  WHERE Date BETWEEN delaye30days AND now
            string query = $"SELECT TOP 1 ContractTypeID, COUNT(ContractTypeID) FROM  [Contract] GROUP BY ContractTypeID ORDER BY COUNT(ContractTypeID) DESC";
            int quantityOfBestpackage = 0;
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    quantityOfBestpackage = dr.GetInt32(1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to calculate contracts " + ex.Message, "Insert Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return quantityOfBestpackage;
        }

        public List<Bussiness_Logic.Package> BestPackagesDetails(int bestSellingQuntity)
        {
            // use the current date to get a datediff of 30 days dating back to select that data and use it for calculations
            DateTime now = DateTime.Now;
            DateTime delay30days = now.AddDays(-30);
            // ...  WHERE Date BETWEEN delaye30days AND now
            List<Bussiness_Logic.Package> bestSellers = new List<Bussiness_Logic.Package>();
            string query = $"SELECT ContractTypeID FROM [Contract] GROUP BY ContractTypeID HAVING COUNT(ContractTypeID) = {bestSellingQuntity}";
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    //dr.GetInt32(0) is the ContractTypeID
                    bestSellers.Add(GetPackage(dr.GetInt32(0)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to calculate contracts " + ex.Message, "Insert Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return bestSellers;
        }

        public Bussiness_Logic.Package GetPackage(int packageID)
        {
            string query = $"SELECT * FROM ContractType WHERE ContractTypeID = {packageID}";
            Bussiness_Logic.Package package = null;
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    package = new Bussiness_Logic.Package(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not find packages " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return package;
        }

        // sales by city
        public List<string> PackagePerfromance(int packageID)
        {
            string query = $"SELECT COUNT(ContractTypeID) 'Package Sales', City FROM Client INNER JOIN ClientAddress ON Client.ClientID = ClientAddress.ClientID INNER JOIN[Contract] ON Client.ClientID = [Contract].ClientID WHERE ContractTypeID = {packageID} GROUP BY City";
            List<string> salesPerCity = new List<string>();
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    salesPerCity.Add(reader.GetInt32(0).ToString() + "," + reader.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not find packages " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return salesPerCity;
        }
        #endregion
    }
}
