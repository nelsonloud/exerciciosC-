using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Channels;
using ex_fix_enum.Entities.Enums;

namespace ex_fix_enum.Entities {
    internal class Order {

        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }

        public Client Client{ get; set; }

        //public List<HourContract> Contracts { get; private set; } = new List<HourContract>();

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();


        public Order() {}

        public Order(DateTime date, OrderStatus status, Client client) {
            Date = date;
            Status = status;
            Client = client;
        }

        public void addItem(OrderItem items) {
            Items.Add(items);
        }

        public void removeItem(OrderItem items) {
            Items.Remove(items); 
        }

        public double total() {

            double total = 0;
            foreach (OrderItem item in Items) {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Date);
            sb.AppendLine("Order Status: " + Status);
            sb.Append("Client: ");
            sb.Append(Client.Name + " ");
            sb.Append(Client.BithDate.ToString("(dd/MM/yyyy)"));
            sb.Append(" - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order items:");

            foreach (OrderItem item in Items) {
                sb.AppendLine(item.ToString());
            }

            sb.Append("Total price: ");
            sb.AppendLine(total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();

        }
    }
}
