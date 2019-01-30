﻿using System;
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
            bool ott = Equazioni.IsNotDetermined(a,b);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestNotDet2()
        {
            double a = -5;
            double b = -5;
            bool asp = false;
            bool ott = Equazioni.IsNotDetermined(a,b);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestNotDet3()
        {
            double a = 0;
            double b = 0;
            bool asp = true;
            bool ott = Equazioni.IsNotDetermined(a,b);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestNotDet4()
        {
            double a = -5;
            double b = 5;
            bool asp = false;
            bool ott = Equazioni.IsNotDetermined(a, b);

            Assert.AreEqual(asp, ott);
        }

        [TestMethod]
        public void TestNotDet5()
        {
            double a = 5;
            double b = -5;
            bool asp = false;
            bool ott = Equazioni.IsNotDetermined(a, b);

            Assert.AreEqual(asp, ott);
        }
    }
}
