using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetAllByColorId(int cId);
        IDataResult<Color> GetByColorName(string cName);
        IResult Add(Color color);
        IResult Delete(Color color);
        IResult Update();

        //List<ColorDetailDto> GetColorDetails();
    }
}
