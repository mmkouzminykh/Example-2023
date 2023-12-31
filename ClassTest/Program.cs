﻿using Example;

namespace ClassTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                       
            Account account = new Account();
            account.Name = "Новый счет";
            account.IncreaseBalance(10);
            account.BalanceInfo();
            
            Console.WriteLine($"Created account with id {account.Id}, name {account.Name} and balance {account.Balance}");

            FinanceContext context = new FinanceContext();

            var source = context.Source.Find(new object[1]);
            DateTime incomeDate = new DateTime(2023, 1, 10);
            
            for (int i = 0; i < 10; i++)
            {


                var income = new Income()
                {
                    Id = Guid.NewGuid(),
                    Name = $"Тестовое поступление {i}",
                    Description = "нет",
                    Date = incomeDate,
                    Sum = 1000,
                    DestinationAccount = account,
                    Source = source
                };

                income = (Income)(income + new TransactionElement { Id = 1, Content = "Test", Sum = 1000 });
                context.Incomes.Add(income);
                incomeDate = incomeDate.AddMonths(1);
            }
            /*
            var expense = new Expense()
            {
                Id = Guid.NewGuid(),
                Name = "Тестовое списание",
                Description = "нет",
                Date = DateTime.Now,
                Sum = 1000,
                SourceAccount = account,
                Destination = new Destination() { Name = "Бытовые нужды" }
            };
            */
            
             
            //context.Expenses.Add( expense );
            context.SaveChanges();

            return;
            /*
            List<Transaction> transactions = new List<Transaction>() { income, expense };

            foreach (Transaction transaction in transactions)
            {
                Console.WriteLine(transaction.TransactionInfo()); 
                foreach(var elem in transaction as IEnumerable<TransactionElement>)
                {                    
                    Console.WriteLine($"Элемент {elem.Content} на сумму {elem.Sum}");
                }
            }

            PrintInfo(expense);
            PrintInfo(income);
            */
            IEnumerable<Transaction> obj;
            List<Expense> list = new List<Expense>();
            obj = list;

            Action<Expense> action;
            Action<Transaction> baseAction = (Transaction t) => t.ToString();
            action = baseAction;
        }

        private static void PrintInfo(IFullTransactionInfo info)
        {
            Console.WriteLine(info.FullInfo());
        }
    }
}