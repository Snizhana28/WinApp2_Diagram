
using WinApp2.Domain;

namespace WinApp2
{
    public partial class BillF : Form
    {
        Goods goods;
        public BillF(Goods goods)
        {
            this.goods = goods;
            InitializeComponent();
            dg_Goods.DataSource = goods.Collection;
        }

        private void BillFLoad(object sender, EventArgs e)
        {
            AnaliticsTab.Paint += AnaliticsTab_Paint;
        }
        private void DrawDiagram(PaintEventArgs e, Point center, int radius, decimal max, decimal avg, decimal min)
        {
            decimal total = max + avg + min;
            decimal maxAngle = 360 * (max / total);
            decimal avgAngle = 360 * (avg / total);
            decimal minAngle = 360 * (min / total);

            using (SolidBrush maxBrush = new SolidBrush(Color.AliceBlue))
            using (SolidBrush avgBrush = new SolidBrush(Color.Azure))
            using (SolidBrush minBrush = new SolidBrush(Color.Bisque))
            {
                e.Graphics.FillPie(maxBrush, center.X - radius, center.Y - radius, 2 * radius, 2 * radius, 0, (float)maxAngle);
                e.Graphics.FillPie(avgBrush, center.X - radius, center.Y - radius, 2 * radius, 2 * radius, (float)maxAngle, (float)avgAngle);
                e.Graphics.FillPie(minBrush, center.X - radius, center.Y - radius, 2 * radius, 2 * radius, (float)(maxAngle + avgAngle), (float)minAngle);
            }
        }
        private void AnaliticsTab_Paint(object? sender, PaintEventArgs e)
        {
            int centerX = AnaliticsTab.Width / 2;
            int centerY = AnaliticsTab.Height / 2;
            int radius = 100; 

            decimal maxPrice = goods.GetMax();
            decimal avgPrice = goods.GetAvg();
            decimal minPrice = goods.GetMin();

            
            DrawDiagram(e, new Point(centerX, centerY), radius, maxPrice, avgPrice, minPrice);

            e.Graphics.DrawString("Max", Font, Brushes.Black, centerX + radius - 120, centerY + 100);
            e.Graphics.DrawString("Avg", Font, Brushes.Black, centerX - 125, centerY - radius + 25);
            e.Graphics.DrawString("Min", Font, Brushes.Black, centerX + radius, centerY - 20);


            string maxPercent = $"{((maxPrice / (maxPrice + avgPrice + minPrice)) * 100):0.0}%";
            string avgPercent = $"{((avgPrice / (maxPrice + avgPrice + minPrice)) * 100):0.0}%";
            string minPercent = $"{((minPrice / (maxPrice + avgPrice + minPrice)) * 100):0.0}%";

            e.Graphics.DrawString(maxPercent, Font, Brushes.Black, centerX + radius - 120, centerY + 115);
            e.Graphics.DrawString(avgPercent, Font, Brushes.Black, centerX - 132, centerY - radius + 45);
            e.Graphics.DrawString(minPercent, Font, Brushes.Black, centerX + radius , centerY - 5);
        }
    }
}


