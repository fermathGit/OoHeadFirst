using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_9_iterator {
    public class DinerMenuIterator : Iterator {
        string[] m_items;
        int m_position = 0;

        public DinerMenuIterator( string[] items ) {
            this.m_items = items;
        }

        public bool hasNext() {
            if ( m_position >= m_items.Length || m_items[m_position] == null ) {
                return false;
            }
            return true;
        }

        public object next() {
            string str = m_items[m_position];
            m_position = m_position + 1;
            return str;
        }
    }
}
