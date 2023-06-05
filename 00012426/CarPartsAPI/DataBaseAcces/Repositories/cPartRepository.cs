using System;
using System.Collections.Generic;
using OnlineStoreAPI.Models;
using OnlineStoreAPI.DAL;
using System.Linq;

namespace OnlineStoreAPI.Repositories
{
    public class cPartRepository : ICPartRepository
    {
        // initializing dbcontext public to private
        private readonly cPartsDbContext __dbContext;
        public cPartRepository(cPartsDbContext dbContext)
        {
            __dbContext = dbContext;
        }

        // Save function implemented later
        public void Save() 
        {
            __dbContext.SaveChanges();
        }

        public void CreateNewProduct(cPart oProduct)
        {
            __dbContext.Add(oProduct);
            Save();

        }

        public void DeleteProductByID(int ProductID)
        {
            var foundProduct = __dbContext.CPart.Find(ProductID);
            __dbContext.CPart.Remove(foundProduct);
            Save();
        }

        public IEnumerable<cPart> RetrieveAll()
        {
            return __dbContext.CPart.ToList();
        }

        public cPart RetrieveByID(int ProductID)
        {
            
            return __dbContext.CPart.Find(ProductID);
        }

        public void UpdateProduct(cPart oProduct)
        {
            __dbContext.Entry(oProduct).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }
    }
}
