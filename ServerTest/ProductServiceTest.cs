using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service;

namespace ServerTest
{
    [TestClass]
    public class ProductServiceTest
    {
        [TestMethod]
        public void Reverse_WithValidOdd_ShouldReturnReversed()
        {
            // Arrange
            int[] productIds = { 1, 2, 3, 4, 5 };

            // Act
            ProductService productService = new ProductService();
            productService.Reverse(ref productIds);

            // Assert
            Assert.AreEqual(5, productIds[0], "Incorrect function.");
            Assert.AreEqual(4, productIds[1], "Incorrect function.");
            Assert.AreEqual(3, productIds[2], "Incorrect function.");
            Assert.AreEqual(2, productIds[3], "Incorrect function.");
            Assert.AreEqual(1, productIds[4], "Incorrect function.");
        }
        [TestMethod]
        public void Reverse_WithValidEven_ShouldReturnReversed()
        {
            // Arrange
            int[] productIds = { 1, 2, 3, 4 };

            // Act
            ProductService productService = new ProductService();
            productService.Reverse(ref productIds);

            // Assert
            Assert.AreEqual(4, productIds[0], "Incorrect function.");
            Assert.AreEqual(3, productIds[1], "Incorrect function.");
            Assert.AreEqual(2, productIds[2], "Incorrect function.");
            Assert.AreEqual(1, productIds[3], "Incorrect function.");
        }
        [TestMethod]
        public void Reverse_WithValid1_ShouldReturnReversed()
        {
            // Arrange
            int[] productIds = { 1 };

            // Act
            ProductService productService = new ProductService();
            productService.Reverse(ref productIds);

            // Assert
            Assert.AreEqual(1, productIds[0], "Incorrect function.");
        }
        [TestMethod]
        public void Reverse_WithValidNull_ShouldReturnNull()
        {
            // Arrange
            int[] productIds = null;

            // Act
            ProductService productService = new ProductService();
            productService.Reverse(ref productIds);

            // Assert
            Assert.AreEqual(productIds, null, "Incorrect function.");
        }
        [TestMethod]
        public void DeletePart_WithValid_ShouldReturnCorrect()
        {
            // Arrange
            int[] productIds = { 1, 2, 3, 4, 5 };
            int position = 3;

            // Act
            ProductService productService = new ProductService();
            productService.DeletePart(position, ref productIds);

            // Assert
            Assert.AreEqual(1, productIds[0], "Incorrect function.");
            Assert.AreEqual(2, productIds[1], "Incorrect function.");
            Assert.AreEqual(4, productIds[2], "Incorrect function.");
            Assert.AreEqual(5, productIds[3], "Incorrect function.");
            Assert.AreEqual(4, productIds.Length, "Incorrect function.");
        }
        [TestMethod]
        public void DeletePart_WithOutOfRangePositive_ShouldReturnCorrect()
        {
            // Arrange
            int[] productIds = { 1, 2, 3, 4, 5 };
            int position = 8;

            // Act
            ProductService productService = new ProductService();
            productService.DeletePart(position, ref productIds);

            // Assert
            Assert.AreEqual(1, productIds[0], "Incorrect function.");
            Assert.AreEqual(2, productIds[1], "Incorrect function.");
            Assert.AreEqual(3, productIds[2], "Incorrect function.");
            Assert.AreEqual(4, productIds[3], "Incorrect function.");
            Assert.AreEqual(5, productIds[4], "Incorrect function.");
        }
        [TestMethod]
        public void DeletePart_WithOutOfRange0_ShouldReturnCorrect()
        {
            // Arrange
            int[] productIds = { 1, 2, 3, 4, 5 };
            int position = 0;

            // Act
            ProductService productService = new ProductService();
            productService.DeletePart(position, ref productIds);

            // Assert
            Assert.AreEqual(1, productIds[0], "Incorrect function.");
            Assert.AreEqual(2, productIds[1], "Incorrect function.");
            Assert.AreEqual(3, productIds[2], "Incorrect function.");
            Assert.AreEqual(4, productIds[3], "Incorrect function.");
            Assert.AreEqual(5, productIds[4], "Incorrect function.");
        }
        [TestMethod]
        public void DeletePart_WithOutOfRangeNegative_ShouldReturnCorrect()
        {
            // Arrange
            int[] productIds = { 1, 2, 3, 4, 5 };
            int position = -1;

            // Act
            ProductService productService = new ProductService();
            productService.DeletePart(position, ref productIds);

            // Assert
            Assert.AreEqual(1, productIds[0], "Incorrect function.");
            Assert.AreEqual(2, productIds[1], "Incorrect function.");
            Assert.AreEqual(3, productIds[2], "Incorrect function.");
            Assert.AreEqual(4, productIds[3], "Incorrect function.");
            Assert.AreEqual(5, productIds[4], "Incorrect function.");
        }
    }
}
