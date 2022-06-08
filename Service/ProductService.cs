using System;

namespace Service
{
    public class ProductService : IProductService
    {
        public ProductService()
        {
        }

        public int[] Reverse(ref int[] productIds)
        {
            if (productIds == null || productIds.Length < 1)
            {
                return null;
            }
            int productIdsLength = productIds.Length;
            int halfProductIdsLength = productIdsLength / 2;

            for (int i = 0; i < halfProductIdsLength; i++)
            {
                int holdValue = productIds[i];
                productIds[i] = productIds[productIdsLength - i - 1];
                productIds[productIdsLength - i - 1] = holdValue;
            }
            return productIds;
        }

        public int[] DeletePart(int position, ref int[] productIds)
        {
            if (productIds == null || productIds.Length < 1)
            {
                return null;
            }
            int productIdsLength = productIds.Length;
            int productIdsLengthLess1 = productIdsLength - 1;
            if (position <= 0 || position > productIdsLength)
            {
                return productIds;
            }

            for (int i = position - 1; i < productIdsLengthLess1; i++)
            {
                productIds[i] = productIds[i + 1];
            }
            Array.Resize(ref productIds, productIdsLengthLess1);
            return productIds;
        }
    }
}