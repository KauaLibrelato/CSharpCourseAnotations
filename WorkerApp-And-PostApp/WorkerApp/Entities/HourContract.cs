using System;
using System.Globalization;

namespace WorkerApp.Entities {
    internal class HourContract {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract() {
        }

        public HourContract(DateTime date, double valuePerHour, int hours) {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue() {
            return ValuePerHour * Hours;
        }

        public override string ToString() {
            return $"Date: {Date.ToString("dd/MM/yyyy")}, Value per hour: {ValuePerHour.ToString("F2", CultureInfo.InvariantCulture)}, Hours: {Hours}, Total value: {TotalValue().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}

