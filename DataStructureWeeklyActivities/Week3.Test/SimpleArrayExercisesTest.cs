using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week3;

namespace Week3.Test
{
    [TestClass]
    public class SimpleArrayExercisesTest
    {
        [TestMethod]
        public void CountVowels()
        {
            CountVowels CountVowels = new CountVowels();
            int expectedResult = 18;
            
            int actualResult = SimpleArrayExercises.CountVowels(text);

            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
