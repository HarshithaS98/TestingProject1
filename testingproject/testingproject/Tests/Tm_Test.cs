


namespace testingproject.Tests
{
    [TestFixture]
    [Parallelizable]
    public class Tm_Test : CommonDriver
    {
       
         [Test , Order(1),Description("check if user created New record with valid data")]
        public void CreateTm()
        {
            // Home page object initialization and definition
            homepage homePageObj = new homepage();
            homePageObj.GoToTMPage(driver);

            //TM Page object initialization and definition
            Tmpage tmPageObj = new Tmpage();
            tmPageObj.CreateTM(driver);
        }

        [Test , Order(2), Description("check if user edited an existing data with valid data")]
        public void EditTm()

        {
            // Home page object initialization and definition
            homepage homePageObj = new homepage();
            homePageObj.GoToTMPage(driver);

            Tmpage tmPageObj = new Tmpage();
            tmPageObj.EditTM(driver);
        }
        [Test , Order(3), Description("check if user can delete the existing data ")]
        public void DeleteTm()
        {
            // Home page object initialization and definition
            homepage homePageObj = new homepage();
            homePageObj.GoToTMPage(driver);

            Tmpage tmPageObj = new Tmpage();
            tmPageObj.DeleteTM(driver);
        }



    }

}
