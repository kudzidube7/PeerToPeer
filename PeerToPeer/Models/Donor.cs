using PeerToPeer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeerToPeer.Models
{
    public class Donor
    {
        public int Id { get; set; }
        public FunderType FunderType { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string EmailAddress { get; set; }
        public double TotalAmountDonated { get; set; }

        public  List<Donation> DonorDonations { get; set; }

        public bool isDeleted { get; set; } = false;

    }
}
