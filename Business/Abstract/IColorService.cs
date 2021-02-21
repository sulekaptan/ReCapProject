using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetAllByColorId(int cId);
        Color GetByColorName(string cName);
        void Add(Color color);
        void Delete(Color color);
        void Update();

        //List<ColorDetailDto> GetColorDetails();
    }
}
