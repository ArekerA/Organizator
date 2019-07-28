using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organizator.Models
{
    public class Column
    {
        public int Id { get; set; }
        public int TableId { get; set; }
        public Table Table { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Card> Cards { get; set; }

    }
}
