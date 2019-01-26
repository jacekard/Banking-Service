using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Data.DataProviders
{
    public class PeopleProvider : IPeopleProvider
    {
        public Person Hash(Person person)
        {
            string hash = person.Username + person.Password;
            person.HashId = Sha256(hash);

            return person;
        }

        public string Sha256(string data)
        {
            var crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(data));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }

            return hash;
        }
    }
}
