using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MNAssignment02;

namespace MNAssignment02.Tests
{
    public class RectangleTest
    {
        [TestFixture]
        public class RectangleTest1
        {

            [Test]
            public void OnebyOneRectangleGetLength()
            {
                Rectangle rectangle = new Rectangle();

                int expected = 1;

                //actual
                int actual = rectangle.GetLength();

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestFixture]
        public class RectangleTest2
        {

            [Test]
            public void ThreebyTwoRectangleGetLength()
            {
                Rectangle rectangle = new Rectangle(3, 2);

                int expected = 2;

                //actual
                int actual = rectangle.GetLength();

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestFixture]
        public class RectangleTest3
        {

            [Test]
            public void ZeroByZeroRectangleGetLength()
            {

                Rectangle rectangle = new Rectangle(0, 0);

                int expected = 0;

                //actual
                int actual = rectangle.GetLength();

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestFixture]
        public class RectangleTest4
        {

            [Test]
            public void RectangleSetLengthToOne()
            {

                Rectangle rectangle = new Rectangle();

                int expected = 1;

                //actual
                int actual = rectangle.SetLength(1);

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestFixture]
        public class RectangleTest5
        {

            [Test]
            public void RectangleSetLengthToZero()
            {

                Rectangle rectangle = new Rectangle();

                int expected = 0;

                //actual
                int actual = rectangle.SetLength(0);

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestFixture]
        public class RectangleTest6
        {

            [Test]
            public void RectangleSetLengthTo1000()
            {

                Rectangle rectangle = new Rectangle();

                int expected = 1000;

                //actual
                int actual = rectangle.SetLength(1000);

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestFixture]
        public class RectangleTest7
        {

            [Test]
            public void OnebyOneRectangleGetWidth()
            {
                Rectangle rectangle = new Rectangle();

                int expected = 1;

                //actual
                int actual = rectangle.GetWidth();

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestFixture]
        public class RectangleTest8
        {

            [Test]
            public void ThreebyTwoRectangleGetWidth()
            {
                Rectangle rectangle = new Rectangle(3, 2);

                int expected = 3;

                //actual
                int actual = rectangle.GetWidth();

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestFixture]
        public class RectangleTest9
        {

            [Test]
            public void ZeroByZeroRectangleGetWidth()
            {

                Rectangle rectangle = new Rectangle(0, 0);

                int expected = 0;

                //actual
                int actual = rectangle.GetWidth();

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestFixture]
        public class RectangleTest10
        {

            [Test]
            public void RectangleSetWidthToOne()
            {

                Rectangle rectangle = new Rectangle();

                int expected = 1;

                //actual
                int actual = rectangle.SetWidth(1);

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestFixture]
        public class RectangleTest11
        {

            [Test]
            public void RectangleSetWidthToZero()
            {

                Rectangle rectangle = new Rectangle();

                int expected = 0;

                //actual
                int actual = rectangle.SetWidth(0);

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestFixture]
        public class RectangleTest12
        {

            [Test]
            public void RectangleSetWidthTo1000()
            {

                Rectangle rectangle = new Rectangle();

                int expected = 1000;

                //actual
                int actual = rectangle.SetLength(1000);

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestFixture]
        public class RectangleTest13
        {

            [Test]
            public void RectangleGetPerimeterOf1By1()
            {

                Rectangle rectangle = new Rectangle();

                int expected = 4;

                //actual
                int actual = rectangle.GetPerimeter();

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestFixture]
        public class RectangleTest14
        {

            [Test]
            public void RectangleGetPerimeterOf2By2()
            {

                Rectangle rectangle = new Rectangle(2,2);

                int expected = 8;

                //actual
                int actual = rectangle.GetPerimeter();

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestFixture]
        public class RectangleTest15
        {

            [Test]
            public void RectangleGetPerimeterOf0By0()
            {

                Rectangle rectangle = new Rectangle(0, 0);

                int expected = 0;

                //actual
                int actual = rectangle.GetPerimeter();

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestFixture]
        public class RectangleTest16
        {

            [Test]
            public void RectangleGetAreaOf1By1()
            {

                Rectangle rectangle = new Rectangle();

                int expected = 4;

                //actual
                int actual = rectangle.GetArea();

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestFixture]
        public class RectangleTest17
        {

            [Test]
            public void RectangleGetAreaOf2By2()
            {

                Rectangle rectangle = new Rectangle(2, 2);

                int expected = 8;

                //actual
                int actual = rectangle.GetArea();

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestFixture]
        public class RectangleTest18
        {

            [Test]
            public void RectangleGetAreaOf0By0()
            {

                Rectangle rectangle = new Rectangle(0, 0);

                int expected = 0;

                //actual
                int actual = rectangle.GetArea();

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
