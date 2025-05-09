namespace PDF_Converting_Memory_Stream.Components
{
    public class OrderData
    {
        public static List<OrderData> Orders = new List<OrderData>();

        public OrderData() { }

        public OrderData(int OrderID, string CustomerID, double Freight, DateTime? OrderDate)
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerID;
            this.Freight = Freight;
            this.OrderDate = OrderDate;
        }

        public static List<OrderData> GetAllRecords()
        {
            if (Orders.Count == 0)
            {
                Orders.Add(new OrderData { OrderID = 10248, CustomerID = "VINET", Freight = 32.38, OrderDate = new DateTime(1996, 7, 4) });
                Orders.Add(new OrderData { OrderID = 10249, CustomerID = "TOMSP", Freight = 11.61, OrderDate = new DateTime(1996, 7, 5) });
                Orders.Add(new OrderData { OrderID = 10250, CustomerID = "HANAR", Freight = 65.83, OrderDate = new DateTime(1996, 7, 6) });
                Orders.Add(new OrderData { OrderID = 10251, CustomerID = "VINET", Freight = 41.34, OrderDate = new DateTime(1996, 7, 7) });
                Orders.Add(new OrderData { OrderID = 10252, CustomerID = "SUPRD", Freight = 151.30, OrderDate = new DateTime(1996, 7, 8) });
                Orders.Add(new OrderData { OrderID = 10253, CustomerID = "HANAR", Freight = 58.17, OrderDate = new DateTime(1996, 7, 9) });
                Orders.Add(new OrderData { OrderID = 10254, CustomerID = "CHOPS", Freight = 22.98, OrderDate = new DateTime(1996, 7, 10) });
                Orders.Add(new OrderData { OrderID = 10255, CustomerID = "VINET", Freight = 148.33, OrderDate = new DateTime(1996, 7, 11) });
                Orders.Add(new OrderData { OrderID = 10256, CustomerID = "HANAR", Freight = 13.97, OrderDate = new DateTime(1996, 7, 12) });
            }
            return Orders;
        }

        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public double? Freight { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
