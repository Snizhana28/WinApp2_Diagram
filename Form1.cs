using WinApp2.Domain;

namespace WinApp2
{
    public partial class Form1 : Form
    {
        Goods goods;
        public Form1()
        {
            InitializeComponent();
            goods = new Goods();
        }

        private void FomResize(object sender, EventArgs e)
        {
            if (this.Width > 1000 && this.Height > 600)
            {
                lb_Goods.Width = (int)(this.Width / 1.5);
                lb_Goods.Height = this.Height - 80;
            }
            else
            {
                lb_Goods.Width = 447;
                lb_Goods.Height = 529;
            }
            lb_Goods.Update();
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            if (cb_isDiscount.Checked) //true
            {
                tb_Discount.Enabled = true;
            }
            else //false
            {
                tb_Discount.Text = "";
                tb_Discount.Enabled = false;
            }
        }

        private void lb_SizeChanged()
        {
            if (lb_Goods.Items.Count == 0)
            {
                gb_ResultPanel.Visible = false;
            }
            else
            {
                gb_ResultPanel.Visible = true;
            }
        }

        private void AddToListClick(object sender, EventArgs e)
        {
            var item = new GoodItem(tb_Name.Text, Convert.ToInt32(tb_Count.Text), Convert.ToDecimal(tb_PricePerOne.Text), Convert.ToDecimal(tb_Price.Text));
            goods.Collection.Add(item);
            lb_Goods.DataSource = null;
            lb_Goods.DataSource = goods.Collection;
            lb_SizeChanged();
            if (lb_Goods.Items.Count >= 1)
            {
                tb_ResultPrice.Text = goods.Collection.Sum(x => x.Price).ToString();
            }
            else
            {
                tb_ResultPrice.Text = "0";
            }
        }

        private void GetPrice(object sender, EventArgs e)
        {
            try
            {
                if (tb_Count.Text == "")
                {
                    return;
                }
                else if (tb_PricePerOne.Text == "")
                {
                    return;
                }
                tb_Price.Text = (Convert.ToInt64(tb_Count.Text) * Convert.ToDecimal(tb_PricePerOne.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            BillF billForm = new BillF(goods);
            billForm.Show();
        }
    }
}