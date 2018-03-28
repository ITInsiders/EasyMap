using System.Data.Entity;
using EasyMap.DAL.Entities;

namespace EasyMap.DAL.EF
{
    public class Context : DbContext
    {
        public Context() : base("EasyMapDB") { }

        public DbSet<User> Users { get; }
        public DbSet<UserPhoto> UserPhotos { get; }
        public DbSet<UserVerification> UserVerifications { get; }
        public DbSet<Place> Places { get; }
        public DbSet<PlacePhoto> PlacePhotos { get; }
        public DbSet<Review> Reviews { get; }

    }
}
