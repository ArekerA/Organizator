using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Organizator.Models
{
    public class Table
    {
        public int Id { get; set; }
        public string PersonId { get; set; }
        public Person Person { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Column> Columns { get; set; }
    }
}
