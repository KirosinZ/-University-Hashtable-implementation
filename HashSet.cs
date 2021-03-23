using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRIALG_HASH
{
    class HashSet<Key, Value> : IEnumerable<HashSetEntry<Key, Value>>
    {
        const int InitialSize = 8;

        class Entry<K,V>
        {
            public K Key { get; private set; }
            public V Value { get; set; }

            public Entry(K key, V value)
            {
                Key = key;
                Value = value;
            }

            public static implicit operator HashSetEntry<K, V>(Entry<K, V> arg)
            {
                return new HashSetEntry<K, V>(arg.Key, arg.Value);
            }

            public static implicit operator bool(Entry<K, V> arg) => arg != null;
        }

        Entry<Key, Value>[] Data;
        int rebuildsize;
        int count = 0;

        int MainHash(Key item)
        {
            return Math.Abs(item.GetHashCode()) % Data.Length;
        }

        int AuxHash(Key item)
        {
            int i = item.GetHashCode().GetHashCode();
            return 1 + Math.Abs(i+i%2) % (Data.Length - 1);
        }

        void Rebuild()
        {
            var tmp = Data;
            Data = new Entry<Key, Value>[Data.Length * 2];
            count = 0;
            rebuildsize *= 2;
            foreach (var entry in tmp.Where(x => x != null)) Add(entry.Key, entry.Value);
        }

        public HashSet(int numberofitems = InitialSize)
        {
            if (numberofitems < InitialSize) numberofitems = InitialSize;
            Data = new Entry<Key, Value>[numberofitems];
            rebuildsize = (3 * numberofitems) / 4;
        }

        public void Add(Key key, Value item)
        {
            int index = MainHash(key);
            int step = AuxHash(key);
            int i = 0;
            for (; Data[(index + i * step) % Data.Length]; i++)
            {
                if (Data[(index + i * step) % Data.Length].Key.Equals(key)) return;
            }
            Data[(index + i * step) % Data.Length] = new Entry<Key, Value>(key, item);
            count++;
            if (count > rebuildsize) Rebuild();
        }

        public void Edit(Key key, Value item)
        {
            int index = MainHash(key);
            int step = AuxHash(key);
            int i = 0;
            for (;!(Data[(index + i * step) % Data.Length] && Data[(index + i * step) % Data.Length].Key.Equals(key)); i++)
            {
                if (i > Data.Length) return;
            }
            Data[(index + i * step) % Data.Length] = new Entry<Key, Value>(key, item);
        }

        public bool Contains(Key key)
        {
            int index = MainHash(key);
            int step = AuxHash(key);
            int i = 0;
            for (; !(Data[(index + i * step) % Data.Length] && Data[(index + i * step) % Data.Length].Key.Equals(key)); i++)
            {
                if (i > Data.Length) return false;
            }
            return true;
        }

        public HashSetEntry<Key, Value> Find(Key key)
        {
            int index = MainHash(key);
            int step = AuxHash(key);
            int i = 0;
            for (; !(Data[(index + i * step) % Data.Length] && Data[(index + i * step) % Data.Length].Key.Equals(key)); i++)
            {
                if (i > Data.Length) return null;
            }
            return Data[(index + i * step) % Data.Length];
        }

        public void Delete(Key key)
        {
            int index = MainHash(key);
            int step = AuxHash(key);
            int i = 0;
            for (; !(Data[(index + i * step) % Data.Length] && Data[(index + i * step) % Data.Length].Key.Equals(key)); i++)
            {
                if (i > Data.Length) return;
            }
            Data[(index + i * step) % Data.Length] = null;
        }

        public IEnumerator<HashSetEntry<Key, Value>> GetEnumerator()
        {
            foreach (var entry in Data.Where(x => x != null)) yield return entry;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool IsEmpty => count == 0;

        public HashSetEntry<Key, Value> this[Key key] => Find(key);
    }
}
