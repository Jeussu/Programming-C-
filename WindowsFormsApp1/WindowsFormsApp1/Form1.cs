using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int moneylastmonth;
            int Thismonthsmoney;
            int Unitprice;
            moneylastmonth = Convert.ToInt16(txtMoney1.Text);
            Thismonthsmoney = Convert.ToInt16(txtMoney2.Text);
            Unitprice = Convert.ToInt16(txtUniPrice3.Text);
            int money;
            money = (moneylastmonth + Thismonthsmoney) * Unitprice;
            txtIntomoney4.Text = money.ToString();
        }
    }
}
