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
            bool expected = true;
            bool obtained = Equazioni.IsDetermined(a);

            Assert.AreEqual(expected, obtained);
        }

        [TestMethod]
        public void TestDet2()
        {
            double a = -3;
            bool expected = true;
            bool obtained = Equazioni.IsDetermined(a);

            Assert.AreEqual(expected, obtained);
        }

        [TestMethod]
        public void TestDet3()
        {
            double a = 0;
            bool expected = false;
            bool obtained = Equazioni.IsDetermined(a);

            Assert.AreEqual(expected, obtained);
        }


        [TestMethod]
        public void TestNotDet1()
        {
            double a = 5, b = 5;
            bool expected = false;
            bool obtained = Equazioni.IsNotDeterminated(a, b);

            Assert.AreEqual(expected, obtained);
        }

        [TestMethod]
        public void TestNotDet2()
        {
            double a = 0,b=0;
            bool expected = true;
            bool obtained = Equazioni.IsNotDeterminated(a, b);

            Assert.AreEqual(expected, obtained);
        }

        [TestMethod]
        public void TestNotDet3()
        {
            double a = 5, b=0;
            bool expected = false;
            bool obtained = Equazioni.IsNotDeterminated(a, b);

            Assert.AreEqual(expected, obtained);
        }

        [TestMethod]
        public void TestNotDet4()
        {
            double a = 0,b=5;
            bool expected = false;
            bool obtained = Equazioni.IsNotDeterminated(a, b);

            Assert.AreEqual(expected, obtained);
        }

        [TestMethod]
        public void TestImp1()
        {
            double a = 7,b=7;
            bool expected = false;
            bool obtained = Equazioni.IsImpossible(a, b);

            Assert.AreEqual(expected, obtained);
        }

        [TestMethod]
        public void TestImp2()
        {
            double a = 0,b=0;
            bool expected = false;
            bool obtained = Equazioni.IsImpossible(a, b);

            Assert.AreEqual(expected, obtained);
        }

        [TestMethod]
        public void TestImp3()
        {
            double a = 7,b=0;
            bool expected = false;
            bool obtained = Equazioni.IsImpossible(a, b);

            Assert.AreEqual(expected, obtained);
        }

        [TestMethod]
        public void TestImp4()
        {
            double a = 0,b=7;
            bool expected = true;
            bool obtained = Equazioni.IsImpossible(a, b);

            Assert.AreEqual(expected, obtained);
        }

        [TestMethod]
        public void TestDeg2_1()
        {
            double a = 9;
            bool expected = true;
            bool obtained = Equazioni.IsDegree2(a);

            Assert.AreEqual(expected, obtained);
        }

        [TestMethod]
        public void TestDeg2_2()
        {
            double a = 0;
            bool expected = false;
            bool obtained = Equazioni.IsDegree2(a);

            Assert.AreEqual(expected, obtained);
        }

        [TestMethod]
        public void TestDelta1()
        {
            double a = 0,b=4,c=5;
            double expected = 16;
            double obtained = Equazioni.Delta(a, b, c);

            Assert.AreEqual(expected, obtained);
        }

        [TestMethod]
        public void TestDelta2()
        {
            double a = 1,b=4,c=4;
            double expected = 0;
            double obtained = Equazioni.Delta(a, b, c);

            Assert.AreEqual(expected, obtained);
        }

        [TestMethod]
        public void TestDelta3()
        {
            double a = 5,b=7,c=2;
            double expected = 9;
            double obtained = Equazioni.Delta(a, b, c);

            Assert.AreEqual(expected, obtained);
        }

        [TestMethod]
        public void TestEq2_1()
        {
            double a = 5,b=7,c=2;
            string expected = "-0,4 e -1";
            string obtained = Equazioni.EquationDegree2(a, b, c);

            Assert.AreEqual(expected, obtained);
        }

        [TestMethod]
        public void TestEq2_2()
        {
            double a = 1,b=5,c=-14;
            string expected = "2 e -7";
            string obtained = Equazioni.EquationDegree2(a, b, c);

            Assert.AreEqual(expected, obtained);
        }

        [TestMethod]
        public void TestEq()
        {
            double a = 5,b=3;
            string expected = "-0,6";
            string obtained = Equazioni.EquationDegree1(a, b);

            Assert.AreEqual(expected, obtained);
        }

        [TestMethod]
        public void TestEq1()
        {
            double a = 0,b=5;
            string expected = "Impossibile";
            string obtained = Equazioni.EquationDegree1(a, b);

            Assert.AreEqual(expected, obtained);
        }

        [TestMethod]
        public void TestEq2()
        {
            double a = 0,b=0;
            string expected = "Indeterminato";
            string obtained = Equazioni.EquationDegree1(a, b);

            Assert.AreEqual(expected, obtained);
        }

        [TestMethod]
        public void TestEq3()
        {
            double a = 7,b=0;
            string expected = "0";
            string obtained = Equazioni.EquationDegree1(a, b);

            Assert.AreEqual(expected, obtained);
        }
    }
}
