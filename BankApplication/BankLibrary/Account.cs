using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public abstract class Account : IAccount
    {
        //Событие, возникающее при выводе денег
        protected internal event AccountStateHandler Withdrawed;
        // Событие возникающее при добавление на счет
        protected internal event AccountStateHandler Added;
        // Событие возникающее при открытии счета
        protected internal event AccountStateHandler Opened;
        // Событие возникающее при закрытии счета
        protected internal event AccountStateHandler Closed;
        // Событие возникающее при начислении процентов
        protected internal event AccountStateHandler Calculated;

        static int counter = 0;
        protected int _days = 0; // время с момента открытия счета

        public Account(decimal sum, int percentage)
        {
            Sum = sum;
            Percentage = percentage;
            Id = ++counter;
        }

        // Текущая сумма на счету
        public decimal Sum { get; private set; }
        // Процент начислений
        public int Percentage { get; private set; }
        // Уникальный идентификатор счета
        public int Id { get; private set; }
        // вызов событий
        private void CallEvent(AccountEventArgs e, AccountStateHandler handler)
        {
            if (e != null)
                handler?.Invoke(this, e);
        }
        // вызов отдельных событий. Для каждого события определяется свой витуальный метод
        protected virtual void OnOpened(AccountEventArgs e)
        {
            CallEvent(e, Opened);
        }
        protected virtual void OnWithdrawed(AccountEventArgs e)
        {
            CallEvent(e, Withdrawed);
        }
        protected virtual void OnAdded(AccountEventArgs e)
        {
            CallEvent(e, Added);
        }
        protected virtual void OnClosed(AccountEventArgs e)
        {
            CallEvent(e, Closed);
        }
        protected virtual void OnCalculated(AccountEventArgs e)
        {
            CallEvent(e, Calculated);
        }

        public virtual void Put(decimal sum)
        {
            Sum += sum;
            OnAdded(new AccountEventArgs("На счет поступило " + sum, sum));
        }
        // метод снятия со счета, возвращает сколько снято со счета
        public virtual decimal Withdraw(decimal sum)
        {
            decimal result = 0;
            if (Sum >= sum)
            {
                Sum -= sum;
                result = sum;
                OnWithdrawed(new AccountEventArgs($"Сумма {sum} снята со счета {Id}", sum));
            }
            else
            {
                OnWithdrawed(new AccountEventArgs($"Недостаточно денег на счете {Id}", 0));
            }
            return result;
        }
        // открытие счета
        protected internal virtual void Open()
        {
            OnOpened(new AccountEventArgs($"Открыт новый счет! Id счета: {Id}", Sum));
        }
        // закрытие счета
        protected internal virtual void Close()
        {
            OnClosed(new AccountEventArgs($"Счет {Id} закрыт.  Итоговая сумма: {Sum}", Sum));
        }

        protected internal void IncrementDays()
        {
            _days++;
        }
        // начисление процентов
        protected internal virtual void Calculate()
        {
            decimal increment = Sum * Percentage / 100;
            Sum = Sum + increment;
            OnCalculated(new AccountEventArgs($"Начислены проценты в размере: {increment}", increment));
        }
    }

    public class DemandAccount : Account
    {
        public DemandAccount(decimal sum, int percentage) : base(sum, percentage)
        {
        }

        protected internal override void Open()
        {
            base.OnOpened(new AccountEventArgs($"Открыт новый счет до востребования! Id счета: {this.Id}", this.Sum));
        }
    }

    public class DepositAccount : Account
    {
        public DepositAccount(decimal sum, int percentage) : base(sum, percentage)
        {
        }
        protected internal override void Open()
        {
            base.OnOpened(new AccountEventArgs($"Открыт новый депозитный счет! Id счета: {this.Id}", this.Sum));
        }

        public override void Put(decimal sum)
        {
            if (_days % 30 == 0)
                base.Put(sum);
            else
                base.OnAdded(new AccountEventArgs("На счет можно положить только после 30-ти дневного периода", 0));
        }

        public override decimal Withdraw(decimal sum)
        {
            if (_days % 30 == 0)
                return base.Withdraw(sum);
            else
                base.OnWithdrawed(new AccountEventArgs("Вывести средства можно только после 30-ти дневного периода", 0));
            return 0;
        }

        protected internal override void Calculate()
        {
            if (_days % 30 == 0)
                base.Calculate();
        }
    }
}
