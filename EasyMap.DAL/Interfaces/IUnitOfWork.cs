using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMap.DAL.Entities;

namespace EasyMap.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Review> Reviews { get; }
        IRepository<Place> Places { get; }
        IRepository<PlacePhoto> PlacePhotos { get; }
        IRepository<User> Users { get; }
        IRepository<UserPhoto> UserPhotos { get; }
        IRepository<UserVerification> UserVerifications { get; }
        void Save();
    }
}
