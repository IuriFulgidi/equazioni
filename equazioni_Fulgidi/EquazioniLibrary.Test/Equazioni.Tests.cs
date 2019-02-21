using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDet1()
        {
            double a = 3;
            bool asp = true;
            bool ott = Equazioni.IsDetermined(a);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestDet2()
        {
            double a = -3;
            bool asp = true;
            bool ott = Equazioni.IsDetermined(a);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestDet3()
        {
            double a = 0;
            bool asp = false;
            bool ott = Equazioni.IsDetermined(a);

            Assert.AreEqual(asp, ott);
        }


        [TestMethod]
        public void TestNotDet1()
        {
            double a = 5;
            double b = 5;
            bool asp = false;
            bool ott = Equazioni.IsNotDeterminated(a, b);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestNotDet2()
        {
            double a = 0;
            double b = 0;
            bool asp = true;
            bool ott = Equazioni.IsNotDeterminated(a, b);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestNotDet3()
        {
            double a = 5;
            double b = 0;
            bool asp = false;
            bool ott = Equazioni.IsNotDeterminated(a, b);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestNotDet4()
        {
            double a = 0;
            double b = 5;
            bool asp = false;
            bool ott = Equazioni.IsNotDeterminated(a, b);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestImp1()
        {
            double a = 7;
            double b = 7;
            bool asp = false;
            bool ott = Equazioni.IsImpossible(a, b);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestImp2()
        {
            double a = 0;
            double b = 0;
            bool asp = false;
            bool ott = Equazioni.IsImpossible(a, b);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestImp3()
        {
            double a = 7;
            double b = 0;
            bool asp = false;
            bool ott = Equazioni.IsImpossible(a, b);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestImp4()
        {
            double a = 0;
            double b = 7;
            bool asp = true;
            bool ott = Equazioni.IsImpossible(a, b);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestDeg2_1()
        {
            double a = 9;

            bool asp = true;
            bool ott = Equazioni.IsDegree2(a);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestDeg2_2()
        {
            double a = 0;

            bool asp = false;
            bool ott = Equazioni.IsDegree2(a);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestDelta1()
        {
            double a = 0;
            double b = 4;
            double c = 5;
            double asp = 16;
            double ott = Equazioni.Delta(a, b, c);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestDelta2()
        {
            double a = 1;
            double b = 4;
            double c = 4;
            double asp = 0;
            double ott = Equazioni.Delta(a, b, c);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestDelta3()
        {
            double a = 5;
            double b = 7;
            double c = 2;
            double asp = 9;
            double ott = Equazioni.Delta(a, b, c);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestEq2_1()
        {
            double a = 5;
            double b = 7;
            double c = 2;
            string asp="-0,4 e -1";
            string ott = Equazioni.EquationDegree2(a, b, c);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestEq2_2()
        {
            double a = 1;
            double b = 5;
            double c = -14;
            string asp = "2 e -7";
            string ott = Equazioni.EquationDegree2(a, b, c);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestEq()
        {
            double a = 5;
            double b = 3;
            string asp = "-0,6";
            string ott = Equazioni.EquationDegree1(a, b);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestEq1()
        {
            double a = 0;
            double b = 5;
            string asp = "Impossibile";
            string ott = Equazioni.EquationDegree1(a, b);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestEq2()
        {
            double a = 0;
            double b = 0;
            string asp = "Indeterminato";
            string ott = Equazioni.EquationDegree1(a, b);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestEq3()
        {
            double a = 7;
            double b = 0;
            string asp = "0";
            string ott = Equazioni.EquationDegree1(a, b);

            Assert.AreEqual(asp, ott);
        }
    }
}
