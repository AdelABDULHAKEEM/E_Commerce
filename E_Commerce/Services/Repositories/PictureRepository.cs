using E_Commerce.Data;
using E_Commerce.Models;
using E_Commerce.Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Services.Repositories
{
    public class PictureRepository : IPicture
    {
        private readonly E_CommerceDbContext _DbContext;

        public PictureRepository(E_CommerceDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        public int Count()
        {
            return _DbContext.Pictures.Count();
        }

        public void Delete(int id)
        {
            var Picture = _DbContext.Pictures.FirstOrDefault(c => c.Id == id);
            if (Picture != null)
            {
                _DbContext.Pictures.Remove(Picture);
            }
        }

        public IEnumerable<Picture> GetPictures()
        {
            return _DbContext.Pictures;
        }

        public Picture GetPicture(int id)
        {
            var Picture = _DbContext.Pictures.FirstOrDefault(c => c.Id == id);

            if (Picture != null)
            {
                return Picture;
            }
            return null;
        }

        public void Insert(Picture picture)
        {
            _DbContext.Pictures.Add(picture);
        }

        public void Save()
        {
            _DbContext.SaveChanges();
        }

        public void Update(Picture picture)
        {
            _DbContext.Pictures.Update(picture);
        }
    }
}
