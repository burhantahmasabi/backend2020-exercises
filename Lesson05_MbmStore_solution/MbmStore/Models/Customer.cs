using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Customer
    {
        private DateTime birthdate;

        public int CustomerId { get; set; }
        public string Firstname { get; set;  }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }

        // read only property
        public List<string> PhoneNumbers { get; } = new List<string>();

        // property that validates input (the set accessor)
        public DateTime Birthdate
        {
            set
            {
                if ((DateTime.Now.Year - value.Year) > 120 ||
                    (DateTime.Now.Year - value.Year) < 0)
                {
                    throw new Exception("Age is not accepted");
                }
                else {
                    birthdate = value;
                }
            }
            get { return birthdate; }
        }

        // read only property
        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int age = 0;
                age = now.Year - birthdate.Year;
                if (now.Month < birthdate.Month ||
                    (now.Month == birthdate.Month && now.Day < birthdate.Day))
                {
                    age--;
                }
                return age;
            }
        }

        // cunstructor
        public Customer(int customerId, string firstnavn, string lastnavn, string address, string zip, string city)
        {
            CustomerId = customerId;
            Firstname = firstnavn;
            Lastname = lastnavn;
            Address = address;
            Zip = zip;
            City = city;
        }

        public Customer(string firstnavn, string lastnavn, string address, string zip, string city)
        {
            Firstname = firstnavn;
            Lastname = lastnavn;
            Address = address;
            Zip = zip;
            City = city;    
        }

        // method
        public void AddPhone(string phone)
        {
            PhoneNumbers.Add(phone);
        }

    }
}