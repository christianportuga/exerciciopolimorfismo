using System.Globalization;

namespace Exercicio10_herança_polimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice(double customsfee)
        {
            return Price + customsfee;
        }

        public override string PriceTag()
        {
            return Name + 
                " $ " + TotalPrice(CustomsFee).ToString("F2", CultureInfo.InvariantCulture) 
                + " (Customs fee: $ " 
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
