using System.Collections.Generic;
using OnlineStoreAPI.Models;

namespace OnlineStoreAPI.Repositories
{
    public interface ICPartRepository
    {
       
        void CreateNewProduct(cPart oProduct);

      
        IEnumerable<cPart> RetrieveAll();
        
        
        cPart RetrieveByID(int ProductId);

      
        void DeleteProductByID(int ProductId);
        
        
        void UpdateProduct(cPart oProduct);

    }
}
