using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Data.DataProviders
{
    public interface IPeopleProvider
    {
        Person Hash(Person person);

        string Sha256(string randomString);

    }
}
