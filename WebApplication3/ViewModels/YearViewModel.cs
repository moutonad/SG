using SG.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SG.ViewModels
{
    public class YearViewModel
    {
        /// <summary>
        /// View Model to set top Years
        /// </summary>
        public List<int> YearList { get; set; }

        public string GetDisplayYearsResults()
        {
            string displayYearsResults = UserConstants.NoUserFound;
            if (this.YearList != null && this.YearList.Count() > 0)
            {
                displayYearsResults = String.Format("{0}: {1}", UserConstants.UsersFound, String.Join(",", this.YearList));
            }

            return displayYearsResults;
        }
    }
}
