using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organizator.Models
{
    public class CardLabel
    {
        public int CardId { get; set; }
        public Card Card { get; set; }
        public int LabelId { get; set; }
        public Label Label { get; set; }
    }
}
