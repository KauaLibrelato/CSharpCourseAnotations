using QuintoProjeto.Entities.Enums;
using System;
using System.Globalization;
namespace QuintoProjeto.Entities {
    internal class Order {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString() {
            return $"Id: {Id}, Moment: {Moment}, Status: {Status}";
        }
    }
}
