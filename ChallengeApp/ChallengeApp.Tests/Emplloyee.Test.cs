namespace ChallengeApp.Tests
{
    public class Tests
    {
      
        [Test]
        public void WhenEmplloyee1CollectTwoSetOfPoints_ShouldReturnSum()
        {
            // arrange
            
            var emplloyee1 = new Emplloyee("Jan", "Kowalski", "38");
            emplloyee1.AddScore(5);
            emplloyee1.AddScore(6);
            emplloyee1.AddScore(9);

            // act
            var result = emplloyee1.Result;

            //assert
            Assert.AreEqual(20, result);

        }
        [Test]
        public void WhenEmplloyee1CollectNegativeScores_ShouldReturnSum()
        {
            var emplloyee2 = new Emplloyee("Ma³gorzata", "Nowakowska", "25");
            emplloyee2.AddScore(-3);
            emplloyee2.AddScore(-13);
            emplloyee2.AddScore(-2);

            var result = emplloyee2.Result;

            Assert.AreEqual(-18, result);

        }
        [Test]
        public void WhenEmplloyee1CollectMixedScores_ShouldReturnSum()
        {
            var emplloyee3 = new Emplloyee("Mia", "Toretto", "29");
            emplloyee3.AddScore(5);
            emplloyee3.AddScore(6);
            emplloyee3.AddScore(-2);

            var result = emplloyee3.Result;

            Assert.AreEqual(9, result);

        }
    }
}