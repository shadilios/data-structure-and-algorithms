using System;
using Xunit;
using repeated_word;

namespace test_repeated_word
{
    public class UnitTest1
    {
        [Fact]
        public void Expected()
        {
            string text = "Hello! hello@ shadi, Shadi, shAdi Hello! heLLo/";

            Assert.Equal("hello", Program.MostRepeated(text));
        }


        [Fact]
        public void Failure()
        {
            string text = "Hello! hello@ shadi, Shadi, shAdi Hello! heLLo/";

            Assert.NotEqual("shadi", Program.MostRepeated(text));

        }
    }
}
