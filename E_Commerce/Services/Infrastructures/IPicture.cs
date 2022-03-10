using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Services.Repository
{
    public interface IPicture
    {
        Picture GetPicture(int id);
        void Insert(Picture picture);
        void Update(Picture picture);
        void Delete(int id);
        void Save();
    }
}
