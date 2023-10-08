namespace WinApp2
{
    partial class BillF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabPages = new TabControl();
            BillTab = new TabPage();
            dg_Goods = new DataGridView();
            AnaliticsTab = new TabPage();
            goodItemBindingSource1 = new BindingSource(components);
            goodItemBindingSource = new BindingSource(components);
            tabPages.SuspendLayout();
            BillTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_Goods).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goodItemBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goodItemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabPages
            // 
            tabPages.Controls.Add(BillTab);
            tabPages.Controls.Add(AnaliticsTab);
            tabPages.Location = new Point(-2, 1);
            tabPages.Name = "tabPages";
            tabPages.SelectedIndex = 0;
            tabPages.Size = new Size(790, 465);
            tabPages.TabIndex = 0;
            // 
            // BillTab
            // 
            BillTab.Controls.Add(dg_Goods);
            BillTab.Location = new Point(4, 24);
            BillTab.Name = "BillTab";
            BillTab.Padding = new Padding(3);
            BillTab.Size = new Size(789, 419);
            BillTab.TabIndex = 0;
            BillTab.Text = "Чек";
            BillTab.UseVisualStyleBackColor = true;
            // 
            // dg_Goods
            // 
            dg_Goods.BackgroundColor = Color.White;
            dg_Goods.Location = new Point(0, 0);
            dg_Goods.Name = "dg_Goods";
            dg_Goods.RowTemplate.Height = 25;
            dg_Goods.Size = new Size(445, 419);
            dg_Goods.TabIndex = 1;
            // 
            // AnaliticsTab
            // 
            AnaliticsTab.Location = new Point(4, 24);
            AnaliticsTab.Name = "AnaliticsTab";
            AnaliticsTab.Padding = new Padding(3);
            AnaliticsTab.Size = new Size(782, 437);
            AnaliticsTab.TabIndex = 1;
            AnaliticsTab.Text = "Аналітика";
            AnaliticsTab.UseVisualStyleBackColor = true;
            // 
            // goodItemBindingSource1
            // 
            goodItemBindingSource1.DataSource = typeof(Domain.GoodItem);
            // 
            // goodItemBindingSource
            // 
            goodItemBindingSource.DataSource = typeof(Domain.GoodItem);
            // 
            // BillF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(tabPages);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "BillF";
            Load += BillFLoad;
            tabPages.ResumeLayout(false);
            BillTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dg_Goods).EndInit();
            ((System.ComponentModel.ISupportInitialize)goodItemBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)goodItemBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPages;
        private TabPage BillTab;
        private TabPage AnaliticsTab;
        private DataGridView dg_Goods;
        private BindingSource goodItemBindingSource;
        private BindingSource goodItemBindingSource1;
    }
}