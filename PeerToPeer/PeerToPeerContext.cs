using Microsoft.EntityFrameworkCore;
using PeerToPeer.Models;


namespace PeerToPeer
{
    public class PeerToPeerContext : DbContext
    {
        public PeerToPeerContext(DbContextOptions<PeerToPeerContext> options) : base(options)
        { }

        public DbSet<Donor> Donors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Donation> Donations { get; set; }
    }
}
