using SportStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportStoreDal.Models
{
    public class ShoppingCart
    {
        private List<ShoppingCartRecord> shoppingCartRecords = new List<ShoppingCartRecord>();

        public virtual void AddItem(ProductViewModel product, int quantity)
        {
            ShoppingCartRecord record = shoppingCartRecords
                                        .Where(p => p.Product.ProductId == product.ProductId)
                                        .FirstOrDefault();

            if(record == null)
            {
                shoppingCartRecords.Add(new ShoppingCartRecord
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                record.Quantity += quantity;
            }
        }

        public virtual void RemoveRecord(int productId) => shoppingCartRecords.RemoveAll(r => r.Product.ProductId ==
                                                                                         productId);

        public decimal ComputeTotalValue() => shoppingCartRecords.Sum(e => e.Product.UnitCost * e.Quantity);

        public virtual void Clear() => shoppingCartRecords.Clear();

        public virtual IEnumerable<ShoppingCartRecord> Records => shoppingCartRecords;
    }
}
