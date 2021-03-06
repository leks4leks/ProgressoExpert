﻿using ProgressoExpert.Models.Models.BaseVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressoExpert.Models.Models
{
    public class LiveStreamModel : BaseViewModel
    {
        #region Сегодня

        /// <summary>
        /// Продажи
        /// </summary>
        public decimal SalesToday
        {
            get { return _salesToday; }
            set { SetValue(ref _salesToday, value, "SalesToday"); }
        }
        private decimal _salesToday;

        /// <summary>
        /// Валовая прибыль
        /// </summary>
        public decimal GrossProfitToday
        {
            get { return _grossProfitToday; }
            set { SetValue(ref _grossProfitToday, value, "GrossProfitToday"); }
        }
        private decimal _grossProfitToday;

        /// <summary>
        /// Рентабельность
        /// </summary>
        public decimal ProfitabilityToday
        {
            get { return _profitabilityToday; }
            set { SetValue(ref _profitabilityToday, value, "ProfitabilityToday"); }
        }
        private decimal _profitabilityToday;

        /// <summary>
        /// Оплата клиентов
        /// </summary>
        public decimal PaymentCustomersToday
        {
            get { return _paymentCustomersToday; }
            set { SetValue(ref _paymentCustomersToday, value, "PaymentCustomersToday"); }
        }
        private decimal _paymentCustomersToday;

        /// <summary>
        /// Диаграмма денег
        /// </summary>
        public Dictionary<string, decimal> CycleMoneyDiagram
        {
            get { return _cycleMoneyDiagram; }
            set { SetValue(ref _cycleMoneyDiagram, value, "CycleMoneyDiagram"); }
        }
        private Dictionary<string, decimal> _cycleMoneyDiagram;

        /// <summary>
        /// Деньги итого
        /// </summary>
        public decimal MoneyTotal
        {
            get { return _moneyTotal; }
            set { SetValue(ref _moneyTotal, value, "MoneyTotal"); }
        }
        private decimal _moneyTotal;

        /// <summary>
        /// Долги клиентов
        /// </summary>
        public decimal DebtOfCustomers
        {
            get { return _debtOfCustomers; }
            set { SetValue(ref _debtOfCustomers, value, "DebtOfCustomers"); }
        }
        private decimal _debtOfCustomers;

        /// <summary>
        /// Остаток товара
        /// </summary>
        public decimal GoodsBalance
        {
            get { return _goodsBalance; }
            set { SetValue(ref _goodsBalance, value, "GoodsBalance"); }
        }
        private decimal _goodsBalance;

        /// <summary>
        /// Задолженность перед поставщиками
        /// </summary>
        public decimal PayblesToSupplier
        {
            get { return _payblesToSupplier; }
            set { SetValue(ref _payblesToSupplier, value, "PayblesToSupplier"); }
        }
        private decimal _payblesToSupplier;

        /// <summary>
        /// Покрытие текущей задолженности деньгами
        /// </summary>
        public decimal CoveringCurrentDebtMoney
        {
            get { return _coveringCurrentDebtMoney; }
            set { SetValue(ref _coveringCurrentDebtMoney, value, "CoveringCurrentDebtMoney"); }
        }
        private decimal _coveringCurrentDebtMoney;

        /// <summary>
        /// Покрытие текущей задолженности деньгами + долгами клиентов
        /// </summary>
        public decimal CoveringCurrentDebtMoneyAndCustomerDebt
        {
            get { return _coveringCurrentDebtMoneyAndCustomerDebt; }
            set { SetValue(ref _coveringCurrentDebtMoneyAndCustomerDebt, value, "CoveringCurrentDebtMoneyAndCustomerDebt"); }
        }
        private decimal _coveringCurrentDebtMoneyAndCustomerDebt;

        /// <summary>
        /// Покрытие текущей задолженности деньгами + долгами клиентов + остатком товара
        /// </summary>
        public decimal CoveringCurrentDebtOfCurrentAssets
        {
            get { return _coveringCurrentDebtOfCurrentAssets; }
            set { SetValue(ref _coveringCurrentDebtOfCurrentAssets, value, "CoveringCurrentDebtOfCurrentAssets"); }
        }
        private decimal _coveringCurrentDebtOfCurrentAssets;





        #endregion
        
        #region Текущий месяц

        /// <summary>
        /// Продажи
        /// </summary>
        public decimal SalesMonth
        {
            get { return _salesMonth; }
            set { SetValue(ref _salesMonth, value, "SalesMonth"); }
        }
        private decimal _salesMonth;

        /// <summary>
        /// Валовая прибыль
        /// </summary>
        public decimal GrossProfitMonth
        {
            get { return _grossProfitMonth; }
            set { SetValue(ref _grossProfitMonth, value, "GrossProfitMonth"); }
        }
        private decimal _grossProfitMonth;

        /// <summary>
        /// Рентабельность
        /// </summary>
        public decimal ProfitabilityMonth
        {
            get { return _profitabilityMonth; }
            set { SetValue(ref _profitabilityMonth, value, "ProfitabilityMonth"); }
        }
        private decimal _profitabilityMonth;

        /// <summary>
        /// Оплата клиентов
        /// </summary>
        public decimal PaymentCustomersMonth
        {
            get { return _paymentCustomersMonth; }
            set { SetValue(ref _paymentCustomersMonth, value, "PaymentCustomersMonth"); }
        }
        private decimal _paymentCustomersMonth;

        /// <summary>
        /// Диаграмма текущий месяц
        /// </summary>
        public Dictionary<string, decimal> CurrentMonthDiagram
        {
            get { return _currentMonthDiagram; }
            set { SetValue(ref _currentMonthDiagram, value, "CurrentMonthDiagram"); }
        }
        private Dictionary<string, decimal> _currentMonthDiagram;

        /// <summary>
        /// Диаграмма предыдущий месяц
        /// </summary>
        public Dictionary<string, decimal> LastMonthDiagram
        {
            get { return _lastMonthDiagram; }
            set { SetValue(ref _lastMonthDiagram, value, "LastMonthDiagram"); }
        }
        private Dictionary<string, decimal> _lastMonthDiagram;

        /// <summary>
        /// Разница оплат
        /// </summary>
        public decimal AveragePayment
        {
            get { return _averagePayment; }
            set { SetValue(ref _averagePayment, value, "AveragePayment"); }
        }
        private decimal _averagePayment;

        /// <summary>
        /// Разница валовой прибыли
        /// </summary>
        public decimal AverageGrossProfit
        {
            get { return _averageGrossProfit; }
            set { SetValue(ref _averageGrossProfit, value, "AverageGrossProfit"); }
        }
        private decimal _averageGrossProfit;

        /// <summary>
        /// Разница продаж
        /// </summary>
        public decimal AverageSales
        {
            get { return _averageSales; }
            set { SetValue(ref _averageSales, value, "AverageSales"); }
        }
        private decimal _averageSales;

        /// <summary>
        /// Количество дней до конца месяца
        /// </summary>
        public int CountDaysToEndOfMonth
        {
            get { return _countDaysToEndOfMonth; }
            set { SetValue(ref _countDaysToEndOfMonth, value, "CountDaysToEndOfMonth"); }
        }
        private int _countDaysToEndOfMonth;



        #endregion


        #region Прошлый месяц

        /// <summary>
        /// Продажи прошлый месяц
        /// </summary>
        public decimal SalesPastMonth
        {
            get { return _salesPastMonth; }
            set { SetValue(ref _salesPastMonth, value, "SalesPastMonth"); }
        }
        private decimal _salesPastMonth;

        /// <summary>
        /// Валовая прибыль прошлый месяц
        /// </summary>
        public decimal GrossProfitPastMonth
        {
            get { return _grossProfitPastMonth; }
            set { SetValue(ref _grossProfitPastMonth, value, "GrossProfitPastMonth"); }
        }
        private decimal _grossProfitPastMonth;
        
        /// <summary>
        /// Оплата клиентов прошлый месяц
        /// </summary>
        public decimal PaymentCustomersPastMonth
        {
            get { return _paymentCustomersPastMonth; }
            set { SetValue(ref _paymentCustomersPastMonth, value, "PaymentCustomersPastMonth"); }
        }
        private decimal _paymentCustomersPastMonth;      
        #endregion
    }
}
