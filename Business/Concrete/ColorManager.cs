using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public void Add(Color color)
        {
            throw new NotImplementedException();
        }

        public void Delete(Color color)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetAllByColorId(int cId)
        {
            return _colorDal.Get(c => c.ColorId == cId);  
        }

        public Color GetByColorName(string cName)
        {
            return _colorDal.Get(c => c.ColorName == cName);
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
