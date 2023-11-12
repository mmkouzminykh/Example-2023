using System.Collections;
using System.Net.WebSockets;

namespace Example
{
    public class Account
    {        
        private int _id;
        private decimal _amount;
        private string _name;

        public Account()
        {

        }

        public Account(int id = 1, decimal amount = 0, string name = "New account")
        {
            _id = id;
            this.Balance = amount;
            this.Name = name != null ? name: "New account";            
        }
        
        public int Id 
        {
            get => _id;
            set
            {
                _id = value;
            }
        }

        public decimal Balance
        {
            get => _amount;   
            set
            {
                if (value > 0)
                {
                    _amount = value;
                }
                else
                {
                    _amount = 0;
                }
            }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void IncreaseBalance(decimal value)
        {
            if (value > 0)
            {
                _amount += value;
            }
            
        }       

    }
}