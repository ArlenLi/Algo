using FluentAssertions;
using NUnit.Framework;
using System;

namespace ArraysAndStrings.Tests
{
    public class FixedSizeGenericHashTableTests
    {
        [Test]
        public void FixedSizeGenericHashTable_Function_Tests()
        {
            // arrange
            var hashTable = new FixedSizeGenericHashTable<string, string>(1000);
            var key1value1 = new KeyValue<string, string>("key1", "value1");            
            var key1value2 = new KeyValue<string, string>("key2", "value2");
            var key3value3 = new KeyValue<string, string>("key3", "value3");

            hashTable.Add(key1value1.Key, key1value1.Value);
            hashTable.Find(key1value1.Key).Value.Should().Be("value1");

            hashTable.Add(key1value2.Key, key1value2.Value);
            hashTable.Find(key1value2.Key).Value.Should().Be("value2");

            hashTable.Add(key3value3.Key, key3value3.Value);
            hashTable.Find(key3value3.Key).Value.Should().Be("value3");
            hashTable.Remove(key3value3.Key);
            Action act = () => hashTable.Find(key3value3.Key);
            act.Should().Throw<InvalidOperationException>("key value pair could not be found for the key key3");
            Action removeAct = () => hashTable.Remove(key3value3.Key);
            act.Should().Throw<InvalidOperationException>("No Existing key value pair for the key key3");
        }
    }
}