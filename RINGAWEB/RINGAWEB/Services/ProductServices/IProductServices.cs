using RingaWEB.Entities.ProductPkg;
using RingaWEB.Object;

namespace RingaWEB.Services.ProductServices
{
    public interface IProductServices
    {
        DataRespon<List<Product>> getData();
        DataRespon<ProductDetail> buyProduct(int[] productProperties,int productId); public DataRespon<ProductImg> testImg();
    }
}
