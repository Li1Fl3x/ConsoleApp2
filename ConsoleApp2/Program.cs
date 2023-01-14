using System.Text;
using MoneyTransfer;

namespace MoneyTransfer
{
    abstract class Currency
        {
        
        public double rate { get; set; }              
        public double amount { get; set; }              
        double amount_rub { get; set; }                

        public Currency(double rate, double amount, double amount_rub)
        {
            this.rate = rate;
            this.amount = amount;
            this.amount_rub = amount_rub;
        }
        public void ConvertInRub()
        {
            amount_rub = amount * rate;
        }
        public virtual void Print()

        {
            Console.WriteLine("Перевод в рубли: {0}", amount_rub);
        }
        public abstract double fb();
    
    }
    class Dollar : Currency
    {
        private double cent;
        public Dollar(double cent, double rate, double amount, double amount_rub)
            : base(rate, amount, amount_rub)
        {
            this.cent = cent;
        }
        public override double fb()
        {
            
            cent = amount * 67;
            Console.WriteLine("Перевод валюты в центы:{0}", cent);
            return cent;
        }
    }
}
class Euro : Currency
{
    private double cent;
    public Euro(double cent, double rate, double amount, double amount_rub)
        : base(rate, amount, amount_rub)
    {
        this.cent = cent;
    }
    public override double fb()
    {
        
        cent = amount * 73;
        Console.WriteLine("Перевод валюты в центы:{0}", cent);
        return cent;
    }
}
