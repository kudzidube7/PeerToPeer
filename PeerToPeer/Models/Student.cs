using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeerToPeer.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string University { get; set; }
        public string emailAddress { get; set; }
        public string Degree { get; set; }
        public double AmountNeeded { get; set; }

        public double AmountReceived { get; set; }

        public double AmountLeft { get; set; }


       public int yearOfStudy { get; set; }
        public  List<Donation> StudentDonations { get; set; }
        public bool isDeleted { get; set; } = false;

        

    }
}
