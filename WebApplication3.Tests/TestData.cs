using System;
using System.Collections.Generic;
using SG.Models;
using SG.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SG.UnitTest.TestData
{
    class TestData
    {
        //Single user that is still Alive
        public static UserProfileModel GetSingleAliveUser()
        {
            return new UserProfileModel()
            {
                Email = "test@gmail.com",
                FirstName = "test",
                LastName = "test",
                BirthMonth = 1,
                BirthDay = 1,
                BirthYear = 2000,
                CountryName = "United States",
                UserStatus = (int)UserStatusEnum.UserStatus.Alive
            };
        }

        //Single user that thad died
        public static UserProfileModel GetSingleDeadUser()
        {
            return new UserProfileModel()
            {
                Email = "test@gmail.com",
                FirstName = "test",
                LastName = "test",
                BirthMonth = 1,
                BirthDay = 1,
                BirthYear = 2000,
                CountryName = "United States",
                UserStatus = (int)UserStatusEnum.UserStatus.Dead
            };
        }

        //User list with 5000 random years where people are still Alive
        public static List<UserProfileModel> GetRandomUsersList()
        {
            List<UserProfileModel> userList = new List<UserProfileModel>();

            Random r = new Random();
            int year;
            for (int i = 0; i < 5000; i++)
            {
                year = r.Next(1900, 2000);
                userList.Add(new UserProfileModel
                {
                    Email = String.Format("test{0}@gmail.com",i),
                    FirstName = String.Format("FirstName{0}", i),
                    LastName = String.Format("LastName{0}", i),
                    BirthMonth = r.Next(1, 12),
                    BirthDay = r.Next(1, 28),
                    BirthYear = year,
                    CountryName = "United States",
                    UserStatus = year <= 1900 ? (int)UserStatusEnum.UserStatus.Dead : r.Next((int)UserStatusEnum.UserStatus.Alive, (int)UserStatusEnum.UserStatus.Alive)
                });
            }
            return userList;
        }

        //User list with one year, "1999", with people still Alive
        public static List<UserProfileModel> GetUsersTopYear1999List()
        {
            List<UserProfileModel> userList = new List<UserProfileModel>();

            Random r = new Random();
            for (int i = 1900; i <= 2000; i++)
            {
                userList.Add(new UserProfileModel
                {
                    Email = String.Format("test{0}@gmail.com", i),
                    FirstName = String.Format("FirstName{0}", i),
                    LastName = String.Format("LastName{0}", i),
                    BirthMonth = r.Next(1, 12),
                    BirthDay = r.Next(1, 28),
                    BirthYear = i,
                    CountryName = "United States",
                    UserStatus = i <= 1900 ? (int)UserStatusEnum.UserStatus.Dead : r.Next((int)UserStatusEnum.UserStatus.Alive, (int)UserStatusEnum.UserStatus.Alive)
                });
            }

            userList.Add(new UserProfileModel
            {
                Email = String.Format("test{0}@gmail.com", 2001),
                FirstName = String.Format("FirstName{0}", 2001),
                LastName = String.Format("LastName{0}", 2001),
                BirthMonth = r.Next(1, 12),
                BirthDay = r.Next(1, 28),
                BirthYear = 1999,
                CountryName = "United States",
                UserStatus = (int)UserStatusEnum.UserStatus.Alive
            });

            userList.Add(new UserProfileModel
            {
                Email = String.Format("test{0}@gmail.com", 2002),
                FirstName = String.Format("FirstName{0}", 2002),
                LastName = String.Format("LastName{0}", 2002),
                BirthMonth = r.Next(1, 12),
                BirthDay = r.Next(1, 28),
                BirthYear = 1999,
                CountryName = "United States",
                UserStatus = (int)UserStatusEnum.UserStatus.Alive
            });

            return userList;
        }

        //User list with more than one year with people still Alive
        public static List<UserProfileModel> GetUsersMultipleTopYearList()
        {
            List<UserProfileModel> userList = new List<UserProfileModel>();

            Random r = new Random();
            for (int i = 1900; i <= 2000; i++)
            {
                userList.Add(new UserProfileModel
                {
                    Email = String.Format("test{0}@gmail.com", i),
                    FirstName = String.Format("FirstName{0}", i),
                    LastName = String.Format("LastName{0}", i),
                    BirthMonth = r.Next(1, 12),
                    BirthDay = r.Next(1, 28),
                    BirthYear = i,
                    CountryName = "United States",
                    UserStatus = i <= 1900 ? (int)UserStatusEnum.UserStatus.Dead : (int)UserStatusEnum.UserStatus.Alive
                });
            }

            userList.Add(new UserProfileModel
            {
                Email = String.Format("test{0}@gmail.com", 2001),
                FirstName = String.Format("FirstName{0}", 2001),
                LastName = String.Format("LastName{0}", 2001),
                BirthMonth = r.Next(1, 12),
                BirthDay = r.Next(1, 28),
                BirthYear = 1999,
                CountryName = "United States",
                UserStatus = (int)UserStatusEnum.UserStatus.Alive
            });

            userList.Add(new UserProfileModel
            {
                Email = String.Format("test{0}@gmail.com", 2001),
                FirstName = String.Format("FirstName{0}", 2001),
                LastName = String.Format("LastName{0}", 2001),
                BirthMonth = r.Next(1, 12),
                BirthDay = r.Next(1, 28),
                BirthYear = 1998,
                CountryName = "United States",
                UserStatus = (int)UserStatusEnum.UserStatus.Alive
            });

            return userList;
        }

    }
}
