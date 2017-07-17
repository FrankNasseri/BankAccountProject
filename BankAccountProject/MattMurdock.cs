using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class MattMurdock
    {
        //3 fields for Matt Murdock
        private string name;
        private int phoneNumber;  //eventually change to phone number
        private string address;

        //3 properties for Matt Murdock

        public string Name
        {
            get { return this.name; }
        }
        public int PhoneNumber
        {
            get { return this.phoneNumber; }
        }
        public string Address
        {
            get { return this.address; }
        }

        //Constructors for Matt Murdock

        public MattMurdock()
        {

        }
        public MattMurdock(string name, int phoneNumber, string address)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }
        //client method
        public void ClientInfo()
        {
            this.name =  "Matthew \"Mike\" Murdock";
            this.phoneNumber = 2126780905;
            this.address = "516 W 47th Street \nHells Kitchen, New York, 10036";
            Console.WriteLine(this.name);
            Console.WriteLine(this.phoneNumber);
            Console.WriteLine(this.address);

        }


    }
}
