﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Staff_Testing
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //test to see that it exists
            Assert.IsNotNull(ASupplier);
        }
    }

    class clsSupplier
    {
    }
}
