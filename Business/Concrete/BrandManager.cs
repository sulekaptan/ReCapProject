using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            throw new NotImplementedException();
        }

        public void Delete(Brand brand)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetAllByBrandId(int bId)
        {
            return _brandDal.Get(b => b.BrandId == bId);
        }

        public Brand GetByBrandName(string bName)
        {
            return _brandDal.Get(b => b.BrandName == bName);
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

}
