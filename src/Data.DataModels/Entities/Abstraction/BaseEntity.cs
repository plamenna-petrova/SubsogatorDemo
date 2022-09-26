using Data.DataModels.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DataModels.Entities.Abstraction
{
    public abstract class BaseEntity : IBaseEntity<string>, IAuditInfo
    {
        //private string id;

        public BaseEntity()
        {
            Id = new Guid().ToString().Substring(0, 7);
        }

        //public string Id
        //{
        //    get
        //    {
        //        return id;
        //    }
        //    set
        //    {
        //        id = value;
        //    }
        //}

        public string Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
