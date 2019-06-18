using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kursach;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HeapSize_Big_Insert_Test()
        {
            Beap b = new Beap();
            b.Insert(10);
            b.Insert(15);
            b.Insert(25);
            b.Insert(14);
            b.Insert(19);
            b.Insert(13);
            b.Insert(20);
            b.Insert(50);
            b.Insert(22);

            Assert.AreEqual(9, b.HeapSize);
        }

        [TestMethod]
        public void HeapSize_OneElem_Test()
        {
            Beap b = new Beap();
            b.Insert(8);

            Assert.AreEqual(1, b.HeapSize);
        }

        [TestMethod]
        public void HeapSize_EmptyArray_Test()
        {
            Beap b = new Beap();

            Assert.AreEqual(0, b.HeapSize);
        }

        [TestMethod]
        public void Count_FullArray_Test()
        {
            Beap b = new Beap();
            b.Insert(10);
            b.Insert(15);
            b.Insert(25);
            b.Insert(14);
            b.Insert(19);
            b.Insert(13);
            b.Insert(20);
            b.Insert(50);
            b.Insert(22);

            Assert.AreEqual(2, b.Count(14));
        }

        [TestMethod]
        public void Count_OneElem_Test()
        {
            Beap b = new Beap();
            b.Insert(8);

            Assert.AreEqual(0, b.Count(8));
        }

        [TestMethod]
        public void Count_EmptyArray_Test()
        {
            Beap b = new Beap();

            Assert.AreEqual(0, b.Count(0));
        }

        [TestMethod]
        public void HeapSize_AfterClear_Test()
        {
            Beap b = new Beap();
            b.Insert(10);
            b.Insert(4);
            b.Insert(2);
            b.Insert(8);

            b.Clear();

            Assert.AreEqual(0, b.HeapSize);
        }

        [TestMethod]
        public void HeapHeight_FullArray_Test()
        {
            Beap b = new Beap();
            b.Insert(8);
            b.Insert(4);
            b.Insert(10);
            b.Insert(2);

            Assert.AreEqual(2, b.Height);
        }

        [TestMethod]
        public void HeapHeight_OneElemArray_Test()
        {
            Beap b = new Beap();
            b.Insert(8);

            Assert.AreEqual(0, b.Height);
        }

        [TestMethod]
        public void MinElem_FullArray_Test()
        {
            Beap b = new Beap();
            b.Insert(8);
            b.Insert(4);
            b.Insert(10);
            b.Insert(2);
            b.Insert(7);

            Assert.AreEqual(2, b.Min());
        }

        [TestMethod]
        public void MinElem_OneElemArray_Test()
        {
            Beap b = new Beap();
            b.Insert(8);

            Assert.AreEqual(8, b.Min());
        }

        [TestMethod]
        public void MinElem_EmptyArray_Test()
        {
            Beap b = new Beap();

            Assert.AreEqual(0, b.Min());
        }

        [TestMethod]
        public void MaxElem_FullArray_Test()
        {
            Beap b = new Beap();
            b.Insert(8);
            b.Insert(4);
            b.Insert(10);
            b.Insert(2);
            b.Insert(7);

            Assert.AreEqual(10, b.Max());
        }

        [TestMethod]
        public void MaxElem_OneElemArray_Test()
        {
            Beap b = new Beap();
            b.Insert(9999);

            Assert.AreEqual(9999, b.Max());
        }

        [TestMethod]
        public void MaxElem_EmptyArray_Test()
        {
            Beap b = new Beap();

            Assert.AreEqual(0, b.Max());
        }

        [TestMethod]
        [DataRow(2)]
        [DataRow(10)]
        [DataRow(7)]
        public void FindExistingElem_FullArray_Test(int toFind)
        {
            Beap b = new Beap();
            b.Insert(8);
            b.Insert(4);
            b.Insert(10);
            b.Insert(2);
            b.Insert(7);

            Assert.AreEqual(true, b.Find(toFind));
        }

        [TestMethod]
        public void FindExistingElem_OneElemArray_Test()
        {
            Beap b = new Beap();
            b.Insert(5);

            Assert.AreEqual(true, b.Find(5));
        }

        [TestMethod]
        [DataRow(-6)]
        [DataRow(5)]
        [DataRow(100)]
        public void FindAbsentElem_FullArray_Test(int toFind)
        {
            Beap b = new Beap();
            b.Insert(8);
            b.Insert(4);
            b.Insert(10);
            b.Insert(2);
            b.Insert(7);

            Assert.AreEqual(false, b.Find(toFind));
        }

        [TestMethod]
        [DataRow(2)]
        [DataRow(10)]
        [DataRow(7)]
        public void DeletingElem_FullArray_Test(int toDelete)
        {
            Beap b = new Beap();
            b.Insert(8);
            b.Insert(4);
            b.Insert(10);
            b.Insert(2);
            b.Insert(7);

            b.Delete(toDelete);

            Assert.AreEqual(4, b.HeapSize);
        }

        [TestMethod]
        public void DeletingElem_OneElemArray_Test()
        {
            Beap b = new Beap();
            b.Insert(5);

            b.Delete(5);

            Assert.AreEqual(0, b.HeapSize);
        }

        [TestMethod]
        public void DeletingElem_EmptyArray_Test()
        {
            Beap b = new Beap();

            b.Delete(5);

            Assert.AreEqual(0, b.HeapSize);
        }

        [TestMethod]
        [DataRow(10, 50, 25, 13)]// for branch  "else if (Array[right] < Array[_heapSize])"
        [DataRow(25, 50, 20, 13)]
        public void DeletingElem_ForBranches_Test(int a, int q, int c, int d)
        {
            Beap b = new Beap();
            b.Insert(10);
            b.Insert(15);
            b.Insert(14);
            b.Insert(25);
            b.Insert(13);
            b.Insert(19);
            b.Insert(20);
            b.Insert(50);
            b.Insert(22);

            b.Delete(a);
            b.Delete(q);
            b.Delete(c);
            b.Delete(d);

            Assert.AreEqual(5, b.HeapSize);
        }

        [TestMethod]
        [DataRow(25)]
        public void DeletingElem_ForHeightDecrease_Test(int a)
        {
            Beap b = new Beap();
            b.Insert(10);
            b.Insert(15);
            b.Insert(14);
            b.Insert(25);
            b.Insert(13);
            b.Insert(19);
            b.Insert(20);

            b.Delete(a);

            Assert.AreEqual(6, b.HeapSize);
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(-1)]
        [DataRow(2)]
        public void DeletingElem_LowerRow_Test(int a)
        {
            Beap b = new Beap();
            b.Insert(0);
            b.Insert(-1);
            b.Insert(1);
            b.Insert(2);

            b.Delete(a);

            Assert.AreEqual(3, b.HeapSize);
        }
    }
}
