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
        /// <summary>
        /// Constructor which sets ID, Name, Telephone and Email.
        /// The ID field is set automatically, depending on how 
        /// many entries there are. It uses a static value
        /// which is incremented when a new entry is created
        /// </summary>
        /// <param name="name">Type: string</param>
        /// <param name="telephone">Type: string</param>
        /// <param name="email">Type: string</param>
        public Person(int? id, string name, string telephone, string email)
        {
            if (id == null)
            {
                ID = identificationNumber++;
            }
            else
            {
                ID = (Int32)id;
            }
            Name = name;
            Telephone = telephone;
            Email = email;
        }
        
    }
}
