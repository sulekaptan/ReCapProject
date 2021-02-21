﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        Brand GetAllByBrandId(int bId);
        Brand GetByBrandName(string bName);
        void Add(Brand brand);
        void Delete(Brand brand);
        void Update();
        //List<BrandDetailDto> GetBrandDetails();
    }
}
    