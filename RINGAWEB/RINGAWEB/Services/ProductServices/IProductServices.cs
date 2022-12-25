using RINGAWEB.Entities;
using RINGAWEB.Object;

namespace RINGAWEB.Services.ProductServices
{
    public interface IProductServices
    {
        DataRespon<List<Product>> getData();
        DataRespon<ProductDetail> buyProduct(int[] productProperties,int productId);
    }
}
