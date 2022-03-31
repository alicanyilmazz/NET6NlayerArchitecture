using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayer.Core.DTOs.CategoryDtos;
using NLayer.Core.DTOs.ProductDtos;

namespace NLayer.Core.DTOs.CustomDtos
{
    public class ProductWithCategoryDto : ProductDto
    {
        public CategoryDto Category { get; set; }
    }
}
