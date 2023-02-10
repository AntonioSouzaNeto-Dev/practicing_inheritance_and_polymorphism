using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Exercicio_HerancaEPolimorfismo.Entities
{
    internal sealed class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }

        public sealed override string PriceTag(double price)
        {
            return base.PriceTag(price);
        }
        public double Totalprice()
        {
            return CustomFee + Price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" $ ");
            sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(" (Custom fee: $ ");
            sb.Append(CustomFee.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(')');
            return sb.ToString();
        }
    }
}
