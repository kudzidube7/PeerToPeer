using PeerToPeer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeerToPeer.Repositories.Interface.Implementations
{
    public class DonationRepository : IDonationRepository
    {
        private PeerToPeerContext context;
        public DonationRepository(PeerToPeerContext context)
        {
            this.context = context;
        }
        public Donation createDonation(Donation donation)
        {
            //context.Donations.Add(donation);
            return donation;
        
        }
        public List<Donation> getAllDonations() 
        {
            List<Donation> donations = context.Donations.ToList();
            return donations;
        }
        public Donation getDonation(int id)
        {
            Donation donation = context.Donations.Where(x => x.Id == id).FirstOrDefault();
            return donation;
        }
    }
}
