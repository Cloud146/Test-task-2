using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Test_task__2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateArea_WithRadius1_Returns314()
        {
            // Arrange
            Shape circle = new Circle(1);

            // Act
            double area = FigureAreaLibrary.CalculateArea(circle);

            // Assert
            Assert.AreEqual(Math.PI, area);
        }


        [TestMethod]
        public void CircleCalculateArea_ShouldReturnCorrectArea()
        {
            // Arrange
            Shape circle = new Circle(10);

            // Act
            double area = FigureAreaLibrary.CalculateArea(circle);

            // Assert
            Assert.AreEqual(314.1592653589793, area);
        }

        [TestMethod]
        public void TriangleCalculateArea_ShouldReturnCorrectArea()
        {
            // Arrange
            Shape triangle = new Triangle(3, 4, 5);

            // Act
            double area = FigureAreaLibrary.CalculateArea(triangle);

            // Assert
            Assert.AreEqual(6, area);
        }

        [TestMethod]
        public void CircleIsRightTriangle_ShouldReturnFalse()
        {
            // Arrange
            Shape circle = new Circle(10);

            // Act
            bool isRightTriangle = FigureAreaLibrary.IsRightTriangle(circle);

            // Assert
            Assert.IsFalse(isRightTriangle);
        }

        [TestMethod]
        public void TriangleIsRightTriangle_ShouldReturnTrue()
        {
            // Arrange
            Shape triangle = new Triangle(3, 4, 5);

            // Act
            bool isRightTriangle = FigureAreaLibrary.IsRightTriangle(triangle);

            // Assert
            Assert.IsTrue(isRightTriangle);
        }
    }
}
