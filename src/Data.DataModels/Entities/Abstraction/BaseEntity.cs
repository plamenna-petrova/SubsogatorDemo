using Data.DataModels.Entities.Interfaces;
using Data.DataModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DataModels.Abstraction
{
    public abstract class BaseEntity : IBaseEntity<string>, IAuditInfo
    {
        //private string id; - the same as auto-property

        public BaseEntity()
        {
            Id = new Guid().ToString().Substring(0, 7);
        }

        //public string Id { get => id; set => id = value; } the same as auto-property

        public string Id { get; set; }

        public DateTime CreatedOn { get ; set; }

        public DateTime? ModifiedOn { get ; set ; }
    }
}
