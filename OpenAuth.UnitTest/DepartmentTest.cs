﻿using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenAuth.Infrastructure;

namespace OpenAuth.UnitTest
{
    [TestClass]
    public class DepartmentTest
    {
        [TestMethod]
        public void TestAllDepartment()
        {
            OpenAuthDBContext context = new OpenAuthDBContext();
            foreach (var department in context.Departments)
            {
                Console.WriteLine(department.FullName);
            }
        }
    }
}