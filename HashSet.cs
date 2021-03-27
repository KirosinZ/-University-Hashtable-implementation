using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static implicit operator V(HashSetEntry<K,V> arg)
        {
            return arg.Value;
        }

        public static implicit operator bool(HashSetEntry<K, V> arg) => arg != null;
    }

    [Serializable]
    class HashSet<Key, Value> : IEnumerable<HashSetEntry<Key, Value>>
    {
        const int InitialSize = 8;

        HashSetEntry<Key, Value>[] Data = new HashSetEntry<Key, Value>[InitialSize];
        int rebuildsize = (3 * InitialSize) / 4;
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
            Data = new HashSetEntry<Key, Value>[Data.Length * 2];
            count = 0;
            rebuildsize *= 2;
            foreach (var entry in tmp.Where(x => x != null)) Add(entry.Key, entry.Value);
        }

        public void Add(HashSetEntry<Key, Value> entry)
        {
            int index = MainHash(entry.Key);
            int step = AuxHash(entry.Key);
            int i = 0;
            for (; Data[(index + i * step) % Data.Length]; i++)
            {
                if (Data[(index + i * step) % Data.Length].Key.Equals(entry.Key)) return;
            }
            Data[(index + i * step) % Data.Length] = entry;
            count++;
            if (count > rebuildsize) Rebuild();
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
            Data[(index + i * step) % Data.Length] = new HashSetEntry<Key, Value>(key, item);
            count++;
            if (count > rebuildsize) Rebuild();
        }

        public void Edit(HashSetEntry<Key, Value> entry)
        {
            int index = MainHash(entry.Key);
            int step = AuxHash(entry.Key);
            int i = 0;
            for (; !(Data[(index + i * step) % Data.Length] && Data[(index + i * step) % Data.Length].Key.Equals(entry.Key)); i++)
            {
                if (i > Data.Length) return;
            }
            Data[(index + i * step) % Data.Length] = entry;
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
            Data[(index + i * step) % Data.Length] = new HashSetEntry<Key, Value>(key, item);
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
