using System;
namespace MobileTestSyncF.Models
{
    public class LoginInfo
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string contactNo;
        private string email;
        private string address;
        private DateTime? birthDate;
        private string groupName;

        public LoginInfo()
        {
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set
            {
                this.middleName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                this.lastName = value;
            }
        }

        public string ContactNumber
        {
            get { return contactNo; }
            set
            {
                this.contactNo = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                address = value;
            }
        }

        public DateTime? BirthDate
        {
            get { return birthDate; }
            set
            {
                birthDate = value;
            }
        }

        //public string GroupName
        //{
        //    get { return groupName; }
        //    set
        //    {
        //        groupName = value;
        //    }
        //}
    }
}
