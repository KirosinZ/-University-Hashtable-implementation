namespace STRIALG_HASH
{
    class HashSetEntry<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }

        public HashSetEntry(K key, V value)
        {
            Key = key;
            Value = value;
        }
    }
}
