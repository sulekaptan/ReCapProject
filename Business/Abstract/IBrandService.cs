using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> GetAllByBrandId(int bId);
        IDataResult<Brand> GetByBrandName(string bName);
        IResult Add(Brand brand);
        IResult Delete(Brand brand);
        IResult Update();
        //List<BrandDetailDto> GetBrandDetails();
    }
}
    