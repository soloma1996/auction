using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auction.DAL.Model
{
    public class Lot
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public int InitialRate { get; set; }
        
        public int CurrentWinnerId { get; set; }

        public virtual User CurrentWinner { get; set; }
    }
}
