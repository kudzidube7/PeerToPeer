using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeerToPeer.Models;
using PeerToPeer.Repositories.Interface;

namespace PeerToPeer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationsController : ControllerBase
    {
        private IDonationRepository _donationRepository;
        public DonationsController(IDonationRepository donationRepository)
        {
            _donationRepository = donationRepository;
        
        }
        [HttpGet]
        public ActionResult<IEnumerable<Donation>> GetAll()
        {
            IEnumerable<Donation> donations;
            donations = _donationRepository.getAllDonations();
            return Ok(donations);
        }

        [HttpPost]
        public ActionResult<Student> CreateDonation(Donation donation)
        {
            donation = _donationRepository.createDonation(donation);
            return Ok(donation);
        }
    }
}