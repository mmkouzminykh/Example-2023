using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class TransactionList<T>: IEnumerable<T> where T : Transaction 
    {
        private readonly List<T> list = new List<T>();

        public void AddTransaction(T transaction)
        {
            list.Add(transaction);
        }
        public void RemoveTransaction(T transaction)
        {
            list.Remove(transaction);
        }
        public void Clear()
        {
            list.Clear();
        }
        public decimal TotalSum()
        {
            return list.Sum(t => t.Sum);
        }


        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)list).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)list).GetEnumerator();
        }
    }
}
