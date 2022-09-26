using Data.DataModels.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DataModels.Entities
{
    public abstract class CrewMember: BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
