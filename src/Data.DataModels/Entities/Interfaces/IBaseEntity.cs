using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.DataModels.Interfaces
{
    public interface IBaseEntity<TKey>
    {
        [Key]
        TKey Id { get; set; }
    }
}
