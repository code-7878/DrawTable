using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DrawTable.Tests
{
    [TestClass]
    public class Form1Tests
    {
        [TestMethod]
        public void Form1LoadTest()
        {
            Form1 form = new Form1();
            form.Form1_Load(null, null);

        }
    }
}