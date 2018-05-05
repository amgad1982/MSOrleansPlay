using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class Collection:ModelBase
    {
        public Collection()=>this.CollectionItems=new List<CollectionItem>();
        public string CollectionHead { get; set; }
        public Guid BoardId { get; set; }
        public virtual  Board Board { get; set; }
        public ICollection<CollectionItem> CollectionItems { get; set; }
    }
}
