

namespace WinApp2.Domain
{
    public class Goods
    {
        public List<GoodItem> Collection { get; set; }

        public Goods()
        {
            Collection = new List<GoodItem>();
        }
        public decimal GetAvg()
        {
            decimal sum = 0;
            foreach (var item in Collection)
            {
                sum += item.PricePerOne;
            }
            return sum / Collection.Count;
        }
        public decimal GetMax()
        {
            decimal max = Collection.First().PricePerOne;
            foreach (var item in Collection)
            {
                if (item.PricePerOne > max)
                {
                    max = item.PricePerOne;
                }
            }
            return max;
        }
        public decimal GetMin()
        {
            decimal min = Collection.First().PricePerOne;
            foreach (var item in Collection)
            {
                if (item.PricePerOne < min)
                {
                    min = item.PricePerOne;
                }
            }
            return min;
        }
    }
}
