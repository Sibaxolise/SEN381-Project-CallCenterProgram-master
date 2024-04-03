using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenterProgram.Data_Access;
using CallCenterProgram.Presentation;
using CallCenterProgram;
using System.Windows.Forms;

namespace CallCenterProgram.Bussiness_Logic
{
    class BusinessClient : IClient
    {

        private int clientID;
        private string name;
        private string surname;
        private string clientStatus;
        private string clientRole;
        private string email;
        private string cellphone;
        private int streetnumber;
        private string streetname;
        private string city;
        private string country;

        public int ClientID { get => clientID; set => clientID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string ClientStatus { get => clientStatus; set => clientStatus = value; }
        public string ClientRole { get => clientRole; set => clientRole = value; }
        public string Email { get => email; set => email = value; }
        public string Cellphone { get => cellphone; set => cellphone = value; }
        public int Streetnumber { get => streetnumber; set => streetnumber = value; }
        public string Streetname { get => streetname; set => streetname = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }

        public BusinessClient(int clientID, string name, string surname, string clientStatus, string clientRole, string email, string cellphone, int streetnumber, string streetname, string city, string country)
        {
            this.clientID = clientID;
            this.name = name;
            this.surname = surname;
            this.clientStatus = clientStatus;
            this.clientRole = clientRole;
            this.email = email;
            this.cellphone = cellphone;
            this.streetnumber = streetnumber;
            this.streetname = streetname;
            this.city = city;
            this.country = country;
        }

        public BusinessClient()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void Display()
        {
            //method for displaying
        }

        public void SendClientToDataAccess(BusinessClient client)
        {
            ClientDataAccess publish = new ClientDataAccess();
            publish.InsertBusinessClient(client);
        }

        public BindingSource GetCustomTable()
        {
            BindingSource src = new BindingSource();
            ClientDataAccess dataAccess = new ClientDataAccess();
            src.DataSource = dataAccess.FillBusinessDGV();
            return src;
        }

        public void DeleteBusinessClient(int ID)
        {
            ClientDataAccess dataAccess = new ClientDataAccess();
            dataAccess.DeleteBusinessClient(ID);
        }

        public void UpdateBusinessClient(BusinessClient client)
        {
            ClientDataAccess dataAccess = new ClientDataAccess();
            dataAccess.UpdateBusinessClient(client);
        }

        public void getDetailsForInsert()
        {
            
        }

        public void getServiceAgreement()
        {
           
        }
    }
}
