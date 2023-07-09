using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;
using System;
using System.Text.RegularExpressions;
//using BusinessManager;
namespace UnitTest1
{
    [TestClass]
    public class MsUnittest
    {
        /*  [TestMethod]
          public void Employname()
           {
              //Arrange
               Employee m = new Employee();
                string firstName = "Srikanth";
                string lastName = "yadav";
               string expected = "Srikanth yadav";
               string actual;
               //Act
               actual = m.name(firstName,lastName);
               //Assert
               Assert.AreEqual(expected, actual);

           }*/
        /* [TestMethod]
         public void MobileNumber()
         {
             //Arrange
             Regex r = new Regex("^[6789][0-9]{9}$");
             string mobile = "8333035522";
            // string phone = "4564646";
             //Act
             bool isvalid = r.IsMatch(mobile);
            // string expected = "true";
             Assert.IsTrue(isvalid);
         }*/
      /*  [TestMethod]
        public void Emailvalidation()
        {
            //Arrange
            Regex r = new Regex("^[a-z][a-z-A-Z0-9]+@gmail.[a-z]{2,3}$");
            string email = "srikanthbolleboina456@gmail....com";
            //Act
            bool isvalid = r.IsMatch(email);
            //Assert
            Assert.IsTrue(isvalid);

        }*/
        [TestMethod]
         public void UserNameValidation()
         {
             //Arrange
             Regex r = new Regex("^[A-Z]{1}[a-z]{5,15}$");
             string userName = "Srikanthyadav";
             //Act
             bool isvalid = r.IsMatch(userName);
             //Assert
            Assert.IsTrue(isvalid);
         }
       /*  [TestMethod]
         public void test5()
         {
             //Arrange
             Regex r = new Regex("^[A-Z]{1}(!@#$%^&*){1}[a-zA-Z0-9]{6}$");
             string password = "S#ghKU65";
             string invalidpass = "skghKU65";
             //Act
             bool isvalid = r.IsMatch(password);
             bool isInvalid = r.IsMatch(invalidpass);
             //Assert
             Assert.IsTrue(isvalid);
             Assert.IsFalse(isInvalid);
         }*/
        /*  [TestMethod]
          public void TestAddition()
          {
              int a = 10;
              int b = 20;
              int c = a + b;
             // Assert.AreEqual(30, c);
              Assert.AreEqual(2, c);
          }*/

      }

    }