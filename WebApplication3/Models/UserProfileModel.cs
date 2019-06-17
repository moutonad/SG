using System;

namespace SG.Models
{
    public class UserProfileModel
    {
        /// <summary>
        /// User Model used to set or get values based of user information
        /// </summary>
   
        //First Name of User
        public string FirstName { get; set; }

        //Last Name of user
        public string LastName { get; set; }

        //Email of User
        public string Email { get; set; }

        //Country of User
        public string CountryName { get; set; }

        //Birth Month of User
        public int BirthMonth { get; set; }

        //Birth Day of User
        public int BirthDay { get; set; }

        //Birth Year of User
        public int BirthYear { get; set; }

        //Returns Date of Birth for User
        public string DOB
        {
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    if (DateTime.TryParse(value, out DateTime DateOfBirth))
                    {
                        this.BirthDay = DateOfBirth.Day;
                        this.BirthMonth = DateOfBirth.Month;
                        this.BirthYear = DateOfBirth.Year;
                    }
                }
            }
        }

        //Status if user is alive or dead
        public int UserStatus { get; set; }
    }
}
