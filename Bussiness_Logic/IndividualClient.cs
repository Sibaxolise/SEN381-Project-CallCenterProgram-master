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
    class IndividualClient : IClient
    {
        private int clientID;
        private string name;
        private string surname;
        private string clientStatus;
        private string email;
        private string cellphone;
        private int isCurrentClient;
        private int streetnumber;
        private string streetname;
        private string city;
        private string country;

        public int ClientID { get => clientID; set => clientID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string ClientStatus { get => clientStatus; set => clientStatus = value; }
        public string Email { get => email; set => email = value; }
        public string Cellphone { get => cellphone; set => cellphone = value; }
        public int IsCurrentClient { get => isCurrentClient; set => isCurrentClient = value; }
        public int Streetnumber { get => streetnumber; set => streetnumber = value; }
        public string Streetname { get => streetname; set => streetname = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }

        public IndividualClient(int ID, string name, string surname, string email, string cellphone, string status, int currentclient, int streetnumber, string streetname, string city, string country)
        {
            this.ClientID = ID;
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Cellphone = cellphone;
            this.ClientStatus = status;
            this.IsCurrentClient = currentclient;
            this.Streetnumber = streetnumber;
            this.Streetname = streetname;
            this.City = city;
            this.Country = country;
        }

        public IndividualClient()
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

        public void SendClientToDataAccess(IndividualClient client)
        {
            ClientDataAccess publish = new ClientDataAccess();
            publish.InsertIndividualClient(client);
        }

        public BindingSource GetCustomTable()
        {
            BindingSource src = new BindingSource();
            ClientDataAccess dataAccess = new ClientDataAccess();
            src.DataSource = dataAccess.FillIndividualDGV();
            return src;
        }

        public void DeleteIndividualClient(int ID)
        {
            ClientDataAccess dataAccess = new ClientDataAccess();
            dataAccess.DeleteIndividualClient(ID);
        }

        public void UpdateIndividualClient(IndividualClient client)
        {
            ClientDataAccess dataAccess = new ClientDataAccess();
            dataAccess.UpdateIndividualClient(client);
        }

        public void getServiceAgreement()
        {

        }

    }
}
