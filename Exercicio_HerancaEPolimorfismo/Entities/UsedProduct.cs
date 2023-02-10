using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Exercicio_HerancaEPolimorfismo.Entities
{
    internal sealed class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base (name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public sealed override string PriceTag(double price)
        {
            return base.PriceTag(price);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" (used) $ ");
            sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append("(Manufacture date: ");
            sb.Append(ManufactureDate.ToString("dd/MM/yyyy"));
            sb.Append(')');
            return sb.ToString();
        }
    }
}
