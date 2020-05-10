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
    public class DonorsController : ControllerBase
    {
        private IDonorRepository _donorRepository;

        public DonorsController(IDonorRepository donorRepository)
        {
            _donorRepository = donorRepository;
        }

  

        [HttpGet]
        public ActionResult<IEnumerable<Donor>> GetAll()
        {
            IEnumerable<Donor> donors;
            donors = _donorRepository.getAllDonors();
            return Ok(donors);
        }

        [HttpGet("{id}")]
        public ActionResult<Donor> Get(int id)
        {
            Donor donor;
            donor = _donorRepository.getDonor(id);
            return Ok(donor);
        }

        [HttpPost]
        public ActionResult<Donor> CreateDonor(Donor donor)
        {
           
            donor = _donorRepository.createDonor(donor);
            return Ok(donor);
        }

        [HttpPut]
        public ActionResult<Donor> UpdateDonor(Donor donor)
        {

            _donorRepository.updateDonor(donor);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Donor> DeleteDonor(int id)
        {
            _donorRepository.deleteDonor(id);
            return Ok();
        }
    }
}