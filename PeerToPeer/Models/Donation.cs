using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeerToPeer.Models
{
    public class Donation
    {
        public int Id { get; set; }
        public string DonationName { get; set; }

        public double Amount { get; set; }

        public  Student Student { get; set; }
        public  Donor Donor { get; set; }
    }
}
