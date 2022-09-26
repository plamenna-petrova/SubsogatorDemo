using Data.DataModels.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DataModels.Entities
{
    public class Actor: BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
