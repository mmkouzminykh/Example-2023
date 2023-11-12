using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class TransactionEnumerator : IEnumerator
    {
        int _current;
        private List<TransactionElement> _elements;
        public TransactionEnumerator(List<TransactionElement> e) 
        {
            _elements = e;
            _current = -1;
        }
        object IEnumerator.Current => _elements[_current];

        bool IEnumerator.MoveNext()
        {
            _current++;
            if (_current >= _elements.Count)
                return false;
            return true;

        }

        void IEnumerator.Reset()
        {
            _current = -1;
        }
    }
}
