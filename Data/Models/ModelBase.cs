using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class ModelBase
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedOriginal { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
