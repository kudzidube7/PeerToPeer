using PeerToPeer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeerToPeer.Repositories.Interface
{
    public interface IDonorRepository
    {
        Donor createDonor(Donor donor);
        List<Donor> getAllDonors();
        Donor getDonor(int id);
        Donor updateDonor(Donor donor);

        Donor deleteDonor(int id);

    }
}
