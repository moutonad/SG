using SG.Models;
using SG.ViewModels;
using SG.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;

namespace SG.Controllers
{
    public class HomeController : Controller
    {
        private List<UserProfileModel> _UserProfileList;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="userProfileList">The user Profile List.</param>
        public HomeController(List<UserProfileModel> userProfileList)
        {
            this._UserProfileList = userProfileList;
        }

        /// <summary>
        /// Home Index Page.  Sends list of top years to view.
        /// </summary>
        /// <returns>Integer List</returns>
        public ActionResult Index()
        {
            YearViewModel yearViewModel = new YearViewModel();
            yearViewModel.YearList = GetTopUsersByYear();

            return View(yearViewModel);
        }

        /// <summary>
        /// Gets Top years of Alive users
        /// </summary>
        /// <returns>Integer List</returns>
        /// <exception cref="ErrorResultException"></exception>
        private List<int> GetTopUsersByYear()
        {
            List<int> yearList = null;

            try
            {
                if (_UserProfileList == null || _UserProfileList.Count() == 0)
                {
                    return new List<int>();
                }

                var userListReturn = _UserProfileList.Where(x => x.UserStatus.Equals((int)UserStatusEnum.UserStatus.Alive))
                    .GroupBy(info => info.BirthYear)
                            .Select(years => new
                            {
                                year = years.Key,
                                Count = years.Count()
                            })
                            .OrderByDescending(x => x.Count).ToList();

                yearList = userListReturn.TakeWhile(g => g.Count == userListReturn.First().Count)
                                   .Select(g => g.year).ToList();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error {0}:{1}", MethodBase.GetCurrentMethod().Name, e);
                return new List<int>();
            }

            return yearList;
        }
    }
}
