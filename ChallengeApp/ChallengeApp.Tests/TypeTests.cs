namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestIntNumber()
        {
            // arrange
            int number1 = 3;
            int number2 = 4;

            // act


            //assert
            Assert.AreNotEqual(number1, number2);
        }


        [Test]
        public void TestFloatNumber()
        {
            // arrange
            float number1 = 6;
            float number2 = 4;

            // act


            //assert
            Assert.AreNotEqual(number1, number2);


        }
        [Test]
        public void TestLetter()
        {
            // arrange
            char letter1 = 'w';
            char letter2 = 'k';

            // act


            //assert
            Assert.AreNotEqual(letter1, letter2);
        }
        [Test]
        public void TestEmplloyeeName()
        {
            // arrange
            string emplloyee1 = "Jan";
            string emplloyee2 = "Małgorzata";

            // act


            //assert
            Assert.AreNotEqual(emplloyee1, emplloyee2);
        }

    }

}
                