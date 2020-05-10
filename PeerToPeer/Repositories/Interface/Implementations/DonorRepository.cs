using PeerToPeer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeerToPeer.Repositories.Interface.Implementations
{
    public class DonorRepository : IDonorRepository
    {
        private PeerToPeerContext context;
        public DonorRepository(PeerToPeerContext context)
        {
            this.context = context;
        }
        public List<Donor> getAllDonors()
        {
            List<Donor> donors = context.Donors.ToList() ;
            return donors;
        }
        public Donor getDonor(int id)
        {
            Donor donor;
            IEnumerable<Donor> donors = context.Donors.Where(x => x.Id == id);
          donor =   donors.FirstOrDefault();

            return donor;
        
        }

        public Donor updateDonor(Donor donor)
        {
           // Donor updatedDonor = context.Donors.Where(x => x.Id == donor.Id).FirstOrDefault();
            context.Update(donor);
            context.SaveChanges();

            return donor;
            
            
        }

        public Donor deleteDonor(int id)
        {
            Donor donor;
           donor = context.Donors.Where(x => x.Id == id).FirstOrDefault();
            donor.isDeleted = true;
            context.SaveChanges();

            return donor;
            
        }
        public Donor createDonor(Donor donor)
        {
            Donor newDonor = donor;
            context.Donors.Add(donor);
            context.SaveChanges();
            return newDonor;
        }
    }
}
