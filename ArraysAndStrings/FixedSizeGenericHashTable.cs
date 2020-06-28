using System;
using System.Collections.Generic;

namespace ArraysAndStrings
{
    public class KeyValue<K, V>
    {
        public KeyValue(K key, V value) {
            Key = key;
            Value = value;
        }
        public K Key { get; set; }

        public V Value { get; set; }
    }
    public class FixedSizeGenericHashTable<K, V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] table;

        public FixedSizeGenericHashTable(int size) {
            this.size = size;
            table = new LinkedList<KeyValue<K, V>>[size];
        }

        public KeyValue<K, V> Find(K key)
        {
            var linkedList = FindLinkedList(key);

            foreach (var keyValue in linkedList)
                if (keyValue.Key.Equals(key))
                {
                    return keyValue;
                }
            throw new InvalidOperationException($"key value pair could not be found for the key {key}");
        }

        public void Add(K key, V value) {
            var linkedList = FindLinkedList(key);

            foreach (var keyValue in linkedList)
            { 
                if (keyValue.Key.Equals(key))
                {
                    keyValue.Value = value;
                    return;
                }
            }

            linkedList.AddLast(new KeyValue<K, V>(key, value));
        }
    
        public void Remove(K key)
        {
            var linkedList = FindLinkedList(key);

            foreach (var keyValue in linkedList) {
                if (keyValue.Key.Equals(key)) {
                    linkedList.Remove(keyValue);
                    return;
                }
            }

            throw new InvalidOperationException($"No Existing key value pair for the key {key}");
        }

        private LinkedList<KeyValue<K, V>> FindLinkedList(K key)
        {
            var hashCode = key.GetHashCode();
            var position = Math.Abs(hashCode % size);
            var linkedList = table[position];

            if (linkedList == null) {
                linkedList = new LinkedList<KeyValue<K, V>>();
                table[position] = linkedList;
            }
            return linkedList;
        }
    }
}
