﻿using Tyuiu.PupovAA.Sprint1.Task0.V26.Lib;
namespace Tyuiu.PupovAA.Sprint1.Task0.V26.Test;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds=new DataService();
        var res = ds.Calculate();
        Assert.AreEqual(7, res);


    }
}
