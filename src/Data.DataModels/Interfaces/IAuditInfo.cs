using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DataModels.Entities.Interfaces
{
    public interface IAuditInfo
    {
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
