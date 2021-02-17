using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Segel_Assignment2;

namespace Assignment02.Tests
{
    public class RectangleTest
    {
        [TestFixture]

        public class TriangleTest1
        {
            [Test]
            public void ValidLengthGetter_Input4_Output4()
            {
                //Arrange
                Rectangle rect = new Rectangle();
                int expectedLength = 4;

                //Act
                rect.SetLength(expectedLength);
                int actualLength = rect.GetLength();

                //Assert
                Assert.AreEqual(expectedLength, actualLength);
            }
            [Test]
            public void ValidLengthGetter_Input0_Output0()
            {
                //Arrange
                Rectangle rect = new Rectangle();
                int expectedResult = 0;

                //Act
                int actualResult = rect.SetLength(0);

                //Assert
                Assert.AreEqual(expectedResult,actualResult);
            }
            [Test]
            public void ValidLengthGetter_Input31_Output31()
            {
                //Arrange
                Rectangle rect = new Rectangle();
                int expectedResult = 31;

                //Act
                int actualResult = rect.SetLength(31);

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

        }

        public class TriangleTest2
        {
            [Test]
            public void ValidLengthSetter_Input6_output_6()
            {
                //Arrange
                Rectangle rect = new Rectangle();
                int expectedLength = 6;

                //Act
                int actualLength = rect.SetLength(6);

                //Assert
                Assert.AreEqual(expectedLength, actualLength);
            }
            [Test]
            public void ValidLengthSetter_Input21_output_21()
            {
                //Arrange
                Rectangle rect = new Rectangle();
                int expectedLength = 21;

                //Act
                int actualLength = rect.SetLength(21);

                //Assert
                Assert.AreEqual(expectedLength, actualLength);
            }
            [Test]
            public void ValidLengthSetter_Input35_output_35()
            {
                //Arrange
                Rectangle rect = new Rectangle();
                int expectedLength = 35;

                //Act
                int actualLength = rect.SetLength(35);

                //Assert
                Assert.AreEqual(expectedLength, actualLength);
            }

        }

        public class TriangleTest3
        {
            [Test]
            public void ValidWidthGetter_Input4_Output4()
            {
                //Arrange
                Rectangle rect = new Rectangle();
                int expectedWidth = 4;

                //Act
                rect.SetLength(expectedWidth);
                int actualWidth = rect.GetLength();

                //Assert
                Assert.AreEqual(expectedWidth, actualWidth);
            }
            [Test]
            public void ValidWidthGetter_Input42_Output42()
            {
                //Arrange
                Rectangle rect = new Rectangle();
                int expectedWidth = 42;

                //Act
                rect.SetLength(expectedWidth);
                int actualWidth = rect.GetLength();

                //Assert
                Assert.AreEqual(expectedWidth, actualWidth);
            }
            [Test]
            public void ValidWidthGetter_Input12_Output12()
            {
                //Arrange
                Rectangle rect = new Rectangle();
                int expectedWidth = 12;

                //Act
                rect.SetLength(expectedWidth);
                int actualWidth = rect.GetLength();

                //Assert
                Assert.AreEqual(expectedWidth, actualWidth);
            }
        }

        public class TriangleTest4
        {
            [Test]
            public void ValidWidthSetter_Input6_output_6()
            {
                //Arrange
                Rectangle rect = new Rectangle();
                int expectedWidth = 6;

                //Act
                int actualWidth = rect.SetWidth(6);

                //Assert
                Assert.AreEqual(expectedWidth, actualWidth);
            }
            [Test]
            public void ValidWidthSetter_Input22_output_22()
            {
                //Arrange
                Rectangle rect = new Rectangle();
                int expectedWidth = 22;

                //Act
                int actualWidth = rect.SetWidth(22);

                //Assert
                Assert.AreEqual(expectedWidth, actualWidth);
            }
            [Test]
            public void ValidWidthSetter_Input5_output_5()
            {
                //Arrange
                Rectangle rect = new Rectangle();
                int expectedWidth = 5;

                //Act
                int actualWidth = rect.SetWidth(5);

                //Assert
                Assert.AreEqual(expectedWidth, actualWidth);
            }

        }

        public class TriangleTest5
        {
            [Test]
            public void ValidAreaCalculator_Input6and4_output_24()
            {
                //Arrange
                Rectangle rect = new Rectangle();
                rect.SetLength(6);
                rect.SetWidth(4);
                int expectedArea = 24;

                //Act
                int actualArea = rect.GetArea();

                //Assert
                Assert.AreEqual(expectedArea, actualArea);
            }
            [Test]
            public void ValidAreaCalculator_Input20and4_output_80()
            {
                //Arrange
                Rectangle rect = new Rectangle();
                rect.SetLength(20);
                rect.SetWidth(4);
                int expectedArea = 80;

                //Act
                int actualArea = rect.GetArea();

                //Assert
                Assert.AreEqual(expectedArea, actualArea);
            }
            [Test]
            public void ValidAreaCalculator_Input16and12_output_192()
            {
                //Arrange
                Rectangle rect = new Rectangle();
                rect.SetLength(16);
                rect.SetWidth(12);
                int expectedArea = 192;

                //Act
                int actualArea = rect.GetArea();

                //Assert
                Assert.AreEqual(expectedArea, actualArea);
            }
        }
        public class TriangleTest6
        {
            [Test]
            public void ValidPerimeterCalculator_Input6and4_output_20()
            {
                //Arrange
                Rectangle rect = new Rectangle();
                rect.SetLength(6);
                rect.SetWidth(4);
                int expectedPerimeter = 20;

                //Act
                int actualPerimeter = rect.GetPerimeter();

                //Assert
                Assert.AreEqual(expectedPerimeter, actualPerimeter);
            }
            [Test]
            public void ValidPerimeterCalculator_Input12and8_output_40()
            {
                //Arrange
                Rectangle rect = new Rectangle();
                rect.SetLength(12);
                rect.SetWidth(8);
                int expectedPerimeter = 40;

                //Act
                int actualPerimeter = rect.GetPerimeter();

                //Assert
                Assert.AreEqual(expectedPerimeter, actualPerimeter);
            }
            [Test]
            public void ValidPerimeterCalculator_Input42and13_output_110()
            {
                //Arrange
                Rectangle rect = new Rectangle();
                rect.SetLength(42);
                rect.SetWidth(13);
                int expectedPerimeter = 110;

                //Act
                int actualPerimeter = rect.GetPerimeter();

                //Assert
                Assert.AreEqual(expectedPerimeter, actualPerimeter);
            }
        }
    }
}
