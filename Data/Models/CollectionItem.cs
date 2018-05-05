using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class CollectionItem:ModelBase
    {
        public string ItemHeader { get; set; }
        public string ItemContent { get; set; }
        public Guid CollectionId { get; set; }
       public virtual Collection Collection { get; set; }
    }
}
