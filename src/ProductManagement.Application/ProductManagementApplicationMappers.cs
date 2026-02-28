using AutoMapper;
using ProductManagement.Products;
using Riok.Mapperly.Abstractions;
using Volo.Abp.Mapperly;

namespace ProductManagement;

public class ProductManagementApplicationAutoMapperProfile : Profile
{
    public ProductManagementApplicationAutoMapperProfile()
    {
        CreateMap<Product, ProductDto>();
    }
}


//You can add your own mappings here.
[Mapper]
public partial class ProductManagementApplicationMappers : MapperBase<Product, ProductDto>
{
    public override partial ProductDto Map(Product source);

    public override partial void Map(Product source, ProductDto destination);
}
