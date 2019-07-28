using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organizator.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string PersonId { get; set; }
        public Person Person { get; set; }
        public string Text { get; set; }
        public string Date { get; set; }
        public int CardId { get; set; }
        public Card Card { get; set; }
    }
}
