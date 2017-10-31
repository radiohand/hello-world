using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Workers
    {
        public float PaymentPerHour, PaymentPerMonth;
        public int Hours;
        public Workers()
        { }
        public Workers(float _PaymentPerHour,int _Hours)
        {
            PaymentPerHour = _PaymentPerHour;
            Hours = _Hours;
        }
        public Workers(float _PaymentPerMonth)
        {
            PaymentPerMonth = _PaymentPerMonth;
        }
        public float FixedPayment()
        {
            return (PaymentPerMonth); 
        }
        public float HourlyPayment()
        {
            float payment, paymentph;
            paymentph = Convert.ToSingle(PaymentPerHour);
            payment = paymentph * Hours;
            return (payment);
        }
    }
   /* class Designer
    { }
    class Imposer
    { }
    class MiddleDeveloper
    { }
    class SeniorDeveloper
    { }
    */
    class TeamX
    {
        static void Main()
        {
            float TeamXPayment;
            Workers designer, imposer, middledeveloper, seniordeveloper;
            designer = new Workers(3000);
            imposer = new Workers(5, 120);
            middledeveloper = new Workers(1000);
            seniordeveloper = new Workers(10, 60);
            TeamXPayment =designer.FixedPayment()+imposer.HourlyPayment()+seniordeveloper.HourlyPayment()+2*middledeveloper.FixedPayment();
            Console.WriteLine("Сумма, неоходимая для оплаты работы команды Х: {0}",TeamXPayment);
            Console.ReadKey();
        }
    }
}
