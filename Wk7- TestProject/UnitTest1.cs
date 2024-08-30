using W7__Unit_Testing__Library;

namespace Wk7__TestProject
    //this is a TEST PROJECT

{ // TEST CLASS 
    [TestClass] // [ ]  = annotations. We are flagging this class + method as "test" class/method
                //  - tells visual studio these aren't regular classes/methods
                // test class HAS to be public

    // UNIT TESTING = testing a small piece of code; a very specific situation 
    public class FractionTest

    /* TEST METHOD
       - HAS to be public, void, and cannot have arguments 
       - 3 sections in a test method:

       1. ARRANGE - arrange values

       2. ACT - call whatever you're testing

       3. ASSERT - test if what we assumed would happen is the same as what actually happened 
           - Assert = a class made for testing 
    */
    {
        [TestMethod]
        public void Constructor_WithZeroArgument() // name = what_how
        {
            // arrange
            int expectedTop = 0;
            int expectedBottom = 1;

            // act 
            Fraction result = new Fraction(); // calling what we are testing - had to "link" this class in order to access it, by adding a "Project Reference"

            // assert  - check the values 
            Assert.AreEqual(expectedTop, result.Top);
            Assert.AreEqual(expectedBottom, result.Bottom);
        }

        [TestMethod]
        public void Constructor_WithOneArgument()
        {
            //arrange
            int expectedTop = 10;
            int expectedBottom = 1;

            //act
            Fraction result = new Fraction(expectedTop);

            //assert
            Assert.AreEqual(expectedTop, result.Top);
            Assert.AreEqual(expectedBottom, result.Bottom);
        }

    }
}