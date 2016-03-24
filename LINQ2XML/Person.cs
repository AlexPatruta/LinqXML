using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ2XML
{
    class Person
    {
        public static int identificationNumber = 0;
        public int ID { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        public Person(string name, string telephone, string email)
        {
            ID = identificationNumber++;
            Name = name;
            Telephone = telephone;
            Email = email;
        }
        public Person(string name, string telephone)
        {
            ID = identificationNumber++; ;
            Name = name;
            Telephone = telephone;
            Email = null;
        }
        public Person(string name)
        {
            ID = identificationNumber++; ;
            Name = name;
            Telephone = null;
            Email = null;
        }
    }
}
