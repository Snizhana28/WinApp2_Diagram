namespace WinApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            label7 = new Label();
            button1 = new Button();
            tb_Price = new TextBox();
            tb_PricePerOne = new TextBox();
            tb_Count = new TextBox();
            tb_Name = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gb_ResultPanel = new GroupBox();
            btPrint = new Button();
            cb_isDiscount = new CheckBox();
            tb_Discount = new TextBox();
            label6 = new Label();
            tb_ResultPrice = new TextBox();
            label5 = new Label();
            lb_Goods = new ListBox();
            collectionBindingSource = new BindingSource(components);
            goodsBindingSource = new BindingSource(components);
            groupBox1.SuspendLayout();
            gb_ResultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)collectionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goodsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(tb_Price);
            groupBox1.Controls.Add(tb_PricePerOne);
            groupBox1.Controls.Add(tb_Count);
            groupBox1.Controls.Add(tb_Name);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 197);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Товар";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(403, 117);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 9;
            label7.Text = "грн.";
            // 
            // button1
            // 
            button1.Location = new Point(17, 143);
            button1.Name = "button1";
            button1.Size = new Size(446, 44);
            button1.TabIndex = 8;
            button1.Text = "Додати в кошик";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddToListClick;
            // 
            // tb_Price
            // 
            tb_Price.Location = new Point(155, 114);
            tb_Price.Name = "tb_Price";
            tb_Price.Size = new Size(242, 23);
            tb_Price.TabIndex = 7;
            // 
            // tb_PricePerOne
            // 
            tb_PricePerOne.Location = new Point(155, 85);
            tb_PricePerOne.Name = "tb_PricePerOne";
            tb_PricePerOne.Size = new Size(308, 23);
            tb_PricePerOne.TabIndex = 6;
            tb_PricePerOne.TextChanged += GetPrice;
            // 
            // tb_Count
            // 
            tb_Count.Location = new Point(155, 55);
            tb_Count.Name = "tb_Count";
            tb_Count.Size = new Size(308, 23);
            tb_Count.TabIndex = 5;
            tb_Count.TextChanged += GetPrice;
            // 
            // tb_Name
            // 
            tb_Name.Location = new Point(155, 25);
            tb_Name.Name = "tb_Name";
            tb_Name.Size = new Size(308, 23);
            tb_Name.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 114);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 3;
            label4.Text = "Загальна ціна";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 85);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 2;
            label3.Text = "Ціна товару за шт.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 55);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 1;
            label2.Text = "Кількість товару";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 28);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Назва товару";
            // 
            // gb_ResultPanel
            // 
            gb_ResultPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            gb_ResultPanel.Controls.Add(btPrint);
            gb_ResultPanel.Controls.Add(cb_isDiscount);
            gb_ResultPanel.Controls.Add(tb_Discount);
            gb_ResultPanel.Controls.Add(label6);
            gb_ResultPanel.Controls.Add(tb_ResultPrice);
            gb_ResultPanel.Controls.Add(label5);
            gb_ResultPanel.Location = new Point(12, 408);
            gb_ResultPanel.Name = "gb_ResultPanel";
            gb_ResultPanel.Size = new Size(496, 141);
            gb_ResultPanel.TabIndex = 1;
            gb_ResultPanel.TabStop = false;
            gb_ResultPanel.Text = "До сплати";
            gb_ResultPanel.Visible = false;
            // 
            // btPrint
            // 
            btPrint.Location = new Point(17, 71);
            btPrint.Name = "btPrint";
            btPrint.Size = new Size(434, 37);
            btPrint.TabIndex = 12;
            btPrint.Text = "Друкувати чек";
            btPrint.UseVisualStyleBackColor = true;
            btPrint.Click += btPrint_Click;
            // 
            // cb_isDiscount
            // 
            cb_isDiscount.AutoSize = true;
            cb_isDiscount.Location = new Point(423, 29);
            cb_isDiscount.Name = "cb_isDiscount";
            cb_isDiscount.Size = new Size(15, 14);
            cb_isDiscount.TabIndex = 11;
            cb_isDiscount.UseVisualStyleBackColor = true;
            cb_isDiscount.CheckedChanged += CheckedChanged;
            // 
            // tb_Discount
            // 
            tb_Discount.Enabled = false;
            tb_Discount.Location = new Point(308, 25);
            tb_Discount.Name = "tb_Discount";
            tb_Discount.Size = new Size(109, 23);
            tb_Discount.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(253, 28);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 9;
            label6.Text = "Знижка";
            // 
            // tb_ResultPrice
            // 
            tb_ResultPrice.Location = new Point(110, 25);
            tb_ResultPrice.Name = "tb_ResultPrice";
            tb_ResultPrice.Size = new Size(109, 23);
            tb_ResultPrice.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 28);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 0;
            label5.Text = "Загальна сума";
            // 
            // lb_Goods
            // 
            lb_Goods.FormattingEnabled = true;
            lb_Goods.ItemHeight = 15;
            lb_Goods.Location = new Point(525, 24);
            lb_Goods.Name = "lb_Goods";
            lb_Goods.Size = new Size(447, 529);
            lb_Goods.TabIndex = 2;
            // 
            // collectionBindingSource
            // 
            collectionBindingSource.DataMember = "Collection";
            collectionBindingSource.DataSource = goodsBindingSource;
            // 
            // goodsBindingSource
            // 
            goodsBindingSource.DataSource = typeof(Domain.Goods);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(lb_Goods);
            Controls.Add(gb_ResultPanel);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            Resize += FomResize;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gb_ResultPanel.ResumeLayout(false);
            gb_ResultPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)collectionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)goodsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox gb_ResultPanel;
        private ListBox lb_Goods;
        private TextBox tb_ResultPrice;
        private TextBox tb_Price;
        private TextBox tb_PricePerOne;
        private TextBox tb_Count;
        private TextBox tb_Name;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private CheckBox cb_isDiscount;
        private TextBox tb_Discount;
        private Label label6;
        private Button btPrint;
        private Button button1;
        private Label label7;
        private BindingSource goodsBindingSource;
        private BindingSource collectionBindingSource;
    }
}