using PeopleAccountsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAccountsLibrary.Data
{
    public interface IDataConnector
    {
        void CreatePerson(PersonModel model);
    }
}
