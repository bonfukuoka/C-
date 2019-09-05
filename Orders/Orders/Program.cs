using System;
namespace Orders
{
    class OrderDetail
    {
        public OrderDetail()
        {
            quantity = 0.0;
            taxStatus = "";
        }
        protected Item[] i;
        protected double quantity;
        protected string taxStatus;

        public double calcSubTotal()
        {
            return 0;
        }

        public double calcWeight()
        {
            return 0;
        }

    }
}

namespace Orders
{
    class Item : OrderDetail
    {
        public Item()
        {
            shippingWeight = "";
            description = "";
        }

        protected string shippingWeight;
        protected string description;

        public double getPriceForQuantity()
        {
            return 0;
        }

        public double getWeight()
        {
            return 0;
        }

        public string GetShippingWeight()
        {
            return shippingWeight;
        }

        public string GetDescription()
        {
            return description;
        }
        public void SetShippingWeight(string shippingWeight)
        {
            this.shippingWeight = shippingWeight;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }
    }
}

namespace Orders
{
    class Order
    {
        public Order()
        {
            status = "";
        }
        protected DateTime date;
        protected string status;

        protected OrderDetail[] o;

        public double calcTax()
        {
            return 0;
        }

        public double calcTotal()
        {
            return 0;
        }
        public double calcTotalWeight()
        {
            return 0;
        }

        public DateTime GetDate()
        {
            return date;
        }

        public string GetStatus()
        {
            return status;
        }
        public void SetDate(DateTime date)
        {
            this.date = date;
        }

        public void SetStatus(string status)
        {
            this.status = status;
        }
    }
}

namespace Orders
{
    class Customer
    {
        public Customer()
        {
            name = "Bon";
            address = "Vinh Ve";
        }
        protected string name;
        protected string address;
        protected Order[] o;
    }
}
