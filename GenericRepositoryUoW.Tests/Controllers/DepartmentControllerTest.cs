﻿using System;
using System.Collections.Generic;
using System.Web.Mvc;
using GenericRepositoryUoW.Data.Models;
using GenericRepositoryUoW.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using GenericRepositoryUoW.Services.Interfaces;

namespace GenericRepositoryUoW.Tests.Controllers
{
    [TestClass]
    public class DepartmentControllerTest
    {
        [TestMethod]
        public void DetailsViewData()
        {
            Mock<IDepartmentService> mock = new Mock<IDepartmentService>();
            Mock<IDepartmentCourseService> mock1 = new Mock<IDepartmentCourseService>();
            DepartmentController controller = new DepartmentController(mock.Object, mock1.Object);
            var result = controller.Details(1) as ViewResult;
            var departmentCourse = (List<DepartmentCourse>)result.ViewData.Model;
            Assert.AreEqual(4, departmentCourse.Count);
        }

        [TestMethod]
        public void IndexViewData()
        {
            Mock<IDepartmentService> mock = new Mock<IDepartmentService>();
            Mock<IDepartmentCourseService> mock1 = new Mock<IDepartmentCourseService>();
            DepartmentController controller = new DepartmentController(mock.Object, mock1.Object);
            var result = controller.Index() as ViewResult;
            var lstdepartment = (List<Department>)result.ViewData.Model;
            Assert.AreEqual(6, lstdepartment.Count);
        }
    }
}
