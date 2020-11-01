using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnSale.Common.Entities;
using OnSale.Web.Models;

namespace OnSale.Web.Helpers
{
    public interface IConverterHelper
    {
        Category ToCategory(CategoryViewModel model, Guid imageId, bool isNew);

        CategoryViewModel ToCategoryViewModel(Category category);
    }

}
