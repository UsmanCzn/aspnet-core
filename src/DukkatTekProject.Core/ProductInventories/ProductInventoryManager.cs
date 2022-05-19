using Abp.Domain.Repositories;
using DukkatTekProject.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkatTekProject.ProductInventories
{
    public class ProductInventoryManager
    {
        private readonly IRepository<ProductInventory, long> _inventoryRepository;
        private readonly ProductManager _productManager;
        public ProductInventoryManager(IRepository<ProductInventory, long> inventoryRepository, ProductManager productManager)
        {
            _inventoryRepository = inventoryRepository;
            _productManager = productManager;
        }
        public async Task<IEnumerable<ProductInventory>> GetAll()
        {
            return await _inventoryRepository.GetAllListAsync();
        }
        public async Task<IEnumerable<ProductInventory>> GetInventoryByName(string invName)
        {
            return await _inventoryRepository.GetAllListAsync(x => x.InventoryName == invName);
        }
        public async Task<IEnumerable<ProductInventory>> GetInventoryById(long invId)
        {
            return await _inventoryRepository.GetAllListAsync(x => x.Id == invId);
        }

        public async Task<IEnumerable<ProductInventory>> SellProduct(long productId)
        {
            var productInventories= await _inventoryRepository.GetAllListAsync(x => x.ProductId == productId && (x.InventoryName== ProductStatus.InStock.ToString() || x.InventoryName== ProductStatus.Sold.ToString()));//Get InStock and Sold To Update Inventories
            foreach (var InvItem in productInventories)
            {
                
                if (InvItem.InventoryName == ProductStatus.InStock.ToString() && InvItem.InventoryQuantity >= 1) {
                    InvItem.InventoryQuantity--;
                    if (InvItem.InventoryQuantity == 0) {
                       await _productManager.ChangeStatus(productId, ProductStatus.Sold);
                    }
                }
                if (InvItem.InventoryName == ProductStatus.Sold.ToString())
                {
                    InvItem.InventoryQuantity++;
                }
            }
            return productInventories;

        }

        public async Task<IEnumerable<ProductInventory>> MarkedDamaged(long productId)
        {
            var productInventories = await _inventoryRepository.GetAllListAsync(x => x.ProductId == productId && (x.InventoryName == ProductStatus.InStock.ToString() || x.InventoryName == ProductStatus.Damaged.ToString()));//Get InStock and Sold To Update Inventories
            foreach (var InvItem in productInventories)
            {

                if (InvItem.InventoryName == ProductStatus.InStock.ToString() && InvItem.InventoryQuantity >= 1)
                {
                    InvItem.InventoryQuantity--;
                }
                if (InvItem.InventoryName == ProductStatus.Damaged.ToString())
                {
                    InvItem.InventoryQuantity++;
                }
            }
            return productInventories;

        }

    }
}
