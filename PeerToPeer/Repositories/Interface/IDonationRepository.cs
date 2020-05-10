using PeerToPeer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeerToPeer.Repositories.Interface
{
    public interface IDonationRepository
    {
        Donation createDonation(Donation donation);
        List<Donation> getAllDonations();
        Donation getDonation(int id);
    }
}
