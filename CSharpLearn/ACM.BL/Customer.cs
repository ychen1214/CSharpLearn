using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer(): this(0) //Constructor Chaining
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }
        public List<Address> AddressList { get; set; }
        private string _lastName;
        public string LastName
        {
            get { return _lastName;  }
            set { _lastName = value;  }
        }
        public string FirstName { get; set; }

        public string EmailAddress { get; set; }

        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }

        public string FullName
        {
            get {
                string fullName = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;  
            }
        }
        public static int InstanceCount { get; set; }
        public override bool Validate()
        {
            if (string.IsNullOrWhiteSpace(LastName)) return false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) return false;
            return true;
        }
        public string log() => $"{CustomerId}";
     
    }
}
