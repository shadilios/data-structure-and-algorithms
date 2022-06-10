using System;
using Xunit;
using hash_table;
using System.Collections.Generic;

namespace hashtable_test
{
    public class UnitTest1
    {
        [Fact]
        public void SettingWorks()
        {
            HashTable ht = new HashTable(1024);

            ht.Set(0, "Shadi");
            ht.Set(1, "Osama");
            ht.Set(2, "Zaid");
            ht.Set(3, "Ahmad");
            ht.Set(4, "Laith");

            Assert.Equal(ht.Get(2), "Zaid");
        }


        [Fact]
        public void RetreivingIsCorrect()
        {
            HashTable ht = new HashTable(1024);

            ht.Set(0, "Shadi");
            ht.Set(1, "Osama");
            ht.Set(2, "Zaid");
            ht.Set(3, "Ahmad");
            ht.Set(4, "Laith");

            Assert.Equal(ht.Get(3), "Ahmad");
        }

        [Fact]
        public void ReturnsNullForNonexistentKey()
        {
            HashTable ht = new HashTable(1024);

            ht.Set(0, "Shadi");
            ht.Set(1, "Osama");
            ht.Set(2, "Zaid");
            ht.Set(3, "Ahmad");
            ht.Set(4, "Laith");

            Assert.False(ht.Contains(5));

        }

        [Fact]
        public void ReturnsListOfKeys()
        {
            HashTable ht = new HashTable(5);

            ht.Set(0, "Shadi");
            ht.Set(1, "Osama");
            ht.Set(2, "Zaid");
            ht.Set(3, "Ahmad");
            ht.Set(4, "Laith");
            ht.Set(5, "Yousef");

            List<int> expected = new List<int> { 0, 1, 2, 3, 4 };

            Assert.Equal(expected, ht.Keys());


        }

        [Fact]
        public void SuccessfullyHandlesCollisions()
        {
            HashTable ht = new HashTable(5);

            ht.Set(0, "Shadi");
            ht.Set(1, "Osama");
            ht.Set(2, "Zaid");
            ht.Set(3, "Ahmad");
            ht.Set(4, "Laith");
            ht.Set(5, "Yousef");

            // Value with Key (0) should be equal to Yousef and not Shadi, since 0%5 = 0 
            // And 5%5 = 0

            Assert.Equal(ht.Get(0), "Yousef");


        }

        [Fact]
        public void RetrievesValueAtCollision()
        {
            HashTable ht = new HashTable(5);

            ht.Set(0, "Shadi");
            ht.Set(1, "Osama");
            ht.Set(2, "Zaid");
            ht.Set(3, "Ahmad");
            ht.Set(4, "Laith");
            ht.Set(5, "Yousef");

            // There's collision on key 0, it should return "Yousef" and not "Shadi"
            

            Assert.Equal(ht.Get(0), "Yousef");


        }

        [Fact]
        public void HashKeyInRange()
        {
            HashTable ht = new HashTable(3);

            ht.Set(0, "Shadi");
            ht.Set(1, "Osama");
            ht.Set(2, "Zaid");
            ht.Set(3, "Ahmad");
            ht.Set(4, "Laith");


            // 4%3 = 1, so value at key 1 should be equal to "Laith"
            // And Hashing the value 4, should return 1

            Assert.Equal(1, ht.Hash(4));
            Assert.Equal("Laith", ht.Get(1));

            


        }



    }
}
