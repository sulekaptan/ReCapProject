using Business.Abstract;
using Core.Utilities.Results;
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

        public IResult Add(Brand brand)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Brand brand)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IDataResult<Brand> GetAllByBrandId(int bId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.BrandId == bId));
        }

        public IDataResult<Brand> GetByBrandName(string bName)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.BrandName == bName));
        }

        public IResult Update()
        {
            throw new NotImplementedException();
        }
    }

}
