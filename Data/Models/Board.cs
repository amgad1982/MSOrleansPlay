using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class Board:ModelBase
    {
        public string BoardHeader { get; set; }
        public ICollection<Collection> BoarCollections { get; set; }
    }
}
