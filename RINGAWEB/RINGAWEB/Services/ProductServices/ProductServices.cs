using RINGAWEB.Context;
using RINGAWEB.Entities;
using RINGAWEB.Object;

namespace RINGAWEB.Services.ProductServices
{
    public class ProductServices : IProductServices
    {
        private ApplicationContext context = new ApplicationContext();

        public DataRespon<ProductDetail> buyProduct(int[] productProperties,int productId)
        {
            DataRespon<ProductDetail> dataRespon = new DataRespon<ProductDetail>();
            int productDetail = context.ProductDetailPropertyDetails.Where(x => 
            x.PropertyDetailId == productProperties[0] ||
            x.PropertyDetailId == productProperties[1] ||
            x.PropertyDetailId == productProperties[2] && x.ProductId == 1).ToList().GroupBy(x => x.ProductDetailId).Where(x => x.Count() == 3).First().Key;
            ProductDetail pd = context.ProductDetails.Find(productDetail);
            pd.Quantity -= 1;
            int preProperty = (int)pd.ParentId;
            while (preProperty != null)
            {
                ProductDetail prePd = context.ProductDetails.Find(preProperty);
                prePd.Quantity -= 1;
                if (prePd.ParentId == null)
                {
                    break;
                }
                preProperty = (int)prePd.ParentId;
            }
            context.SaveChanges();
            dataRespon.status = 1;
            dataRespon.message = "ok";
            return dataRespon;
        }

        public DataRespon<List<Product>> getData()
        {
            DataRespon<List<Product>> dataRespon = new DataRespon<List<Product>>();
            dataRespon.Data = context.Products.ToList();
            dataRespon.status = 1;
            dataRespon.message = "ok";
            return dataRespon;
        }

    }
}
