using System;
using System.Collections.ObjectModel;

namespace Store.Core.EntityLayer.Sales
{
    public class Order : IAuditEntity
    {
        public Order()
        {
        }

        public Int32? OrderID { get; set; }

        public DateTime? OrderDate { get; set; }

        public Int32? CustomerID { get; set; }

        public Int32? EmployeeID { get; set; }

        public Int32? ShipperID { get; set; }

        public Decimal? Total { get; set; }

        public String Comments { get; set; }

        public String CreationUser { get; set; }

        public DateTime? CreationDateTime { get; set; }

        public String LastUpdateUser { get; set; }

        public DateTime? LastUpdateDateTime { get; set; }

        public virtual Collection<OrderDetail> OrderDetails { get; set; }
    }
}
