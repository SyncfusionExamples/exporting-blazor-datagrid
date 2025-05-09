namespace Rotate_header.Components
{
        public class OrderData
        {
            public static List<OrderData> Orders = new List<OrderData>();

            public OrderData(int orderID, string customerID, double freight, string shipCity, string shipName)
            {
                this.OrderID = orderID;
                this.CustomerID = customerID;
                this.Freight = freight;
                this.ShipCity = shipCity;
                this.ShipName = shipName;
            }

            public static List<OrderData> GetAllRecords()
            {
                if (Orders.Count == 0)
                {
                    Orders.Add(new OrderData(10248, "VINET", 32.38, "Reims", "Vins et alcools Chevalier"));
                    Orders.Add(new OrderData(10249, "TOMSP", 11.61, "Münster", "Toms Spezialitäten"));
                    Orders.Add(new OrderData(10250, "HANAR", 65.83, "Rio de Janeiro", "Hanari Carnes"));
                    Orders.Add(new OrderData(10251, "VICTE", 41.34, "Lyon", "Victuailles en stock"));
                    Orders.Add(new OrderData(10252, "SUPRD", 51.3, "Charleroi", "Suprêmes délices"));
                    Orders.Add(new OrderData(10253, "HANAR", 58.17, "Rio de Janeiro", "Hanari Carnes"));
                    Orders.Add(new OrderData(10254, "CHOPS", 22.98, "Bern", "Chop-suey Chinese"));
                    Orders.Add(new OrderData(10255, "RICSU", 148.33, "Genève", "Richter Supermarkt"));
                    Orders.Add(new OrderData(10256, "WELLI", 13.97, "Resende", "Wellington Import Export"));
                    Orders.Add(new OrderData(10257, "HILAA", 81.91, "San Cristóbal", "Hila Alimentos"));
                    Orders.Add(new OrderData(10258, "ERNSH", 140.51, "Graz", "Ernst Handel"));
                    Orders.Add(new OrderData(10259, "CENTC", 3.25, "México D.F.", "Centro comercial"));
                    Orders.Add(new OrderData(10260, "OTTIK", 55.09, "Köln", "Ottilies Käseladen"));
                    Orders.Add(new OrderData(10261, "QUEDE", 3.05, "Rio de Janeiro", "Que delícia"));
                    Orders.Add(new OrderData(10262, "RATTC", 48.29, "Albuquerque", "Rattlesnake Canyon Grocery"));
                }

                return Orders;
            }

            public int OrderID { get; set; }
            public string CustomerID { get; set; }
            public double Freight { get; set; }
            public string ShipCity { get; set; }
            public string ShipName { get; set; }
        }
    }

