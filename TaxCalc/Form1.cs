using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pricetBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalcButtonClicked(object sender, EventArgs e)
        {
            int price;
            bool success = int.TryParse(this.pricetBox.Text, out price);

            if (success)
            {
                //消費税を計算する
                int taxPrice = (int)(price * 1.1);
                this.taxPriceBox.Text = taxPrice.ToString();
            }
            else  // TryParseが失敗した場合はエラーメッセージを表示
            {
                MessageBox.Show("税抜価格を正しく入力してください");
            }

        }
    }
}
