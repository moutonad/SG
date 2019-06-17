# SG
SG program example with year(s) with the most number of people alive

Problem 1: 
   Description: Given a list of people with their birth and end years (all between 1900 and 2000), find the year with the most number of people alive.
   Code: Solve using a language of your choice and dataset of your own creation.
   Submission: Please upload your code, dataset, and example of the program’s output to Bit Bucket or Github. Please include any graphs or charts created by your program.
   
Assumptions
1. All Users born before 1900 are not considered alive
2. Users born after 1900 have a random chance of being alive
3. More than one year could be returned so "year(s)"
4. UI was kept to a minimum to just display results

Code: All code has been uploaded. The code contains 7 Unit Tests to test different cases against this problem
1. Multiple Years where found to be the top years
2. No users can be returned (no users provided to test against).  Empty List.
3. Null user object was sent
4. Random list of 5000 users generated
5. Only one user that happens to be alive was in dataset
6. Only one user that happens to be dead was in dataset
7. Single Year "1999" was found to be the top year.

Each test contain an Assert for
1. What type of information would a user see (AreNotEqual, AreEqual)
2. Was the year list return properly (IsNotNull)
3. What the year value count the right response (IsTrue)
These test provided a 88% code coverage

Datasets:  All dataset were generated for the various Unit Tests.  These datasets can be found in
https://github.com/moutonad/SG/blob/master/WebApplication3.Tests/TestData.cs

The output for each unit test above:
1. Home_TestMultiple_TopYears(): "Year(s) with the most number of people alive: 1998,1999"
2. Home_TestNoUser_Users(): "No Alive Users found"
3. Home_TestNull_Users(): "No Alive Users found"
4. Home_TestRandom_Users(): "Year(s) with the most number of people alive: 1909,1957"
5. Home_TestSingleAlive_User(): "Year(s) with the most number of people alive: 2000"
6. Home_TestSingleDead_User(): "No Alive Users found"
7. Home_TestTopYear_1999(): "Year(s) with the most number of people alive: 1999"
