using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Color color)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Color>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Color>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IDataResult<Color> GetAllByColorId(int cId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.ColorId == cId));  
        }

        public IDataResult<Color> GetByColorName(string cName)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.ColorName == cName));
        }

        public IResult Update()
        {
            throw new NotImplementedException();
        }
    }
}
