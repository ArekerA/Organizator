using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organizator.Models
{
    public class Card
    {
        public int Id { get; set; }
        public int ColumnId { get; set; }
        public Column Column { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CardLabel> CardLabels { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
