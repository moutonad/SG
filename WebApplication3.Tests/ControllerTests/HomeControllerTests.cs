using SG.Controllers;
using SG.Constants;
using SG.Models;
using SG.ViewModels;
using SG.UnitTest.TestData;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using System;
using System.Reflection;

namespace SG.UnitTests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void Home_TestNull_Users()
        {
            List<UserProfileModel> userList = null;
            HomeController homeController = new HomeController(userList);

            var yearList = homeController.Index();

            ViewResult viewResult = (ViewResult)yearList;
            YearViewModel model = (YearViewModel)viewResult.Model;

            System.Diagnostics.Debug.WriteLine("{0}:{1}", MethodBase.GetCurrentMethod().Name, model.GetDisplayYearsResults());

            Assert.AreEqual(UserConstants.NoUserFound, model.GetDisplayYearsResults());
            Assert.IsNotNull(model.YearList);
            Assert.IsTrue(model.YearList.Count() == 0);
        }

        [TestMethod]
        public void Home_TestNoUser_Users()
        {
            List<UserProfileModel> userList = new List<UserProfileModel>();
            HomeController homeController = new HomeController(userList);

            var yearList = homeController.Index();

            ViewResult viewResult = (ViewResult)yearList;
            YearViewModel model = (YearViewModel)viewResult.Model;

            System.Diagnostics.Debug.WriteLine("{0}:{1}", MethodBase.GetCurrentMethod().Name, model.GetDisplayYearsResults());

            Assert.AreEqual(UserConstants.NoUserFound, model.GetDisplayYearsResults());
            Assert.IsNotNull(model.YearList);
            Assert.IsTrue(model.YearList.Count() == 0);
        }

        [TestMethod]
        public void Home_TestRandom_Users()
        {
            List<UserProfileModel> userList = TestData.GetRandomUsersList();
            HomeController homeController = new HomeController(userList);

            var yearList = homeController.Index();

            ViewResult viewResult = (ViewResult)yearList;
            YearViewModel model = (YearViewModel)viewResult.Model;

            System.Diagnostics.Debug.WriteLine("{0}:{1}", MethodBase.GetCurrentMethod().Name, model.GetDisplayYearsResults());

            Assert.AreNotEqual(UserConstants.NoUserFound, model.GetDisplayYearsResults());
            Assert.IsNotNull(model.YearList);
            Assert.IsTrue(model.YearList.Count() > 0);
        }

        [TestMethod]
        public void Home_TestSingleAlive_User()
        {
            UserProfileModel user = TestData.GetSingleAliveUser();
            HomeController homeController = new HomeController(new List<UserProfileModel> { user });

            var yearList = homeController.Index();

            ViewResult viewResult = (ViewResult)yearList;
            YearViewModel model = (YearViewModel)viewResult.Model;

            System.Diagnostics.Debug.WriteLine("{0}:{1}", MethodBase.GetCurrentMethod().Name, model.GetDisplayYearsResults());

            Assert.AreNotEqual(UserConstants.NoUserFound, model.GetDisplayYearsResults());
            Assert.IsNotNull(model.YearList);
            Assert.IsTrue(model.YearList.Count() == 1);
        }

        [TestMethod]
        public void Home_TestSingleDead_User()
        {
            UserProfileModel user = TestData.GetSingleDeadUser();
            HomeController homeController = new HomeController(new List<UserProfileModel> {user});

            var yearList = homeController.Index();

            ViewResult viewResult = (ViewResult)yearList;
            YearViewModel model = (YearViewModel)viewResult.Model;

            System.Diagnostics.Debug.WriteLine("{0}:{1}", MethodBase.GetCurrentMethod().Name, model.GetDisplayYearsResults());

            Assert.AreEqual(UserConstants.NoUserFound, model.GetDisplayYearsResults());
            Assert.IsNotNull(model.YearList);
            Assert.IsTrue(model.YearList.Count() == 0);
        }

        [TestMethod]
        public void Home_TestMultiple_TopYears()
        {
            List<UserProfileModel> userList = TestData.GetUsersMultipleTopYearList();
            HomeController homeController = new HomeController(userList);

            var yearList = homeController.Index();

            ViewResult viewResult = (ViewResult)yearList;
            YearViewModel model = (YearViewModel)viewResult.Model;

            System.Diagnostics.Debug.WriteLine("{0}:{1}", MethodBase.GetCurrentMethod().Name, model.GetDisplayYearsResults());

            Assert.AreNotEqual(UserConstants.NoUserFound, model.GetDisplayYearsResults());
            Assert.IsNotNull(model.YearList);
            Assert.IsTrue(model.YearList.Count() == 2);
        }

        [TestMethod]
        public void Home_TestTopYear_1999()
        {
            List<UserProfileModel> userList = TestData.GetUsersTopYear1999List();
            HomeController homeController = new HomeController(userList);

            var yearList = homeController.Index();

            ViewResult viewResult = (ViewResult)yearList;
            YearViewModel model = (YearViewModel)viewResult.Model;

            System.Diagnostics.Debug.WriteLine("{0}:{1}", MethodBase.GetCurrentMethod().Name, model.GetDisplayYearsResults());

            Assert.AreNotEqual(UserConstants.NoUserFound, model.GetDisplayYearsResults());
            Assert.IsNotNull(model.YearList);
            Assert.IsTrue(model.YearList.Count() == 1);
            Assert.AreEqual(model.YearList.FirstOrDefault(), 1999);
        }
    }
}
