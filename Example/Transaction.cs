using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    
    public abstract class Transaction: IEntity, IFullTransactionInfo, IEnumerable, IEnumerable<TransactionElement>
    {
        protected List<TransactionElement> _elements = new List<TransactionElement>();
        
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(200)]
        public string Name { get; set; }
        
        [Column("Description", TypeName = "nvarchar(max)")]
        public string Description { get; set; }
        
        public DateTime Date { get; set; }
        
        [Precision(15,2)]
        public decimal Sum { get; set; }

        [NotMapped]
        public string TestProperty {  get; set; }

        public ICollection<TransactionElement> Elements { get; set; }

        public ICollection<Category> Categories { get; set; }
        
        public void AddElement(string content, decimal sum)
        {
            _elements.Add(new TransactionElement
            {
                Id = _elements.Count >0 ? _elements.Max(x => x.Id) + 1: 1,
                Content = content,
                Sum = sum > 0 ? sum : 0
            });
        }

        public void RemoveElement(TransactionElement element)
        {
            _elements.Remove(element);
        }

        public static Transaction operator +(Transaction transaction, TransactionElement element)
        {
            transaction.AddElement(element.Content, element.Sum);
            return transaction;
        }

        public static Transaction operator -(Transaction transaction, TransactionElement element)
        {
            transaction.RemoveElement(element);
            return transaction;
        }

        public TransactionElement? this[int id]
        {
            get
            {
                return _elements.FirstOrDefault(e => e.Id == id);
            }
        }

        public TransactionElement? this[string content]
        {
            get
            {
                return _elements.FirstOrDefault(e => e.Content == content);
            }
        }

        public abstract string TransactionInfo();
        public abstract string FullInfo();

        public override string ToString()
        {
            return this.TransactionInfo();
        }

        public IEnumerator GetEnumerator()
        {
            return new TransactionEnumerator(this._elements);
        }

        IEnumerator<TransactionElement> IEnumerable<TransactionElement>.GetEnumerator()
        {
            foreach(TransactionElement element in _elements)
            {
                yield return element;
            }
        }
    }
}
