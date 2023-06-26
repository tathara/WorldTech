using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldTech.DI;

namespace WorldTech
{
    public partial class CheckForm : Form
    {
        ICheck check;
        public CheckForm(ICheck currentCheck)
        {
            InitializeComponent();
            check = currentCheck;
            int id = 0;
            foreach(var product in currentCheck.CheckData)
            {
                id++;
                if(productNames.Text != "" && productAmounts.Text!= "" && productPrices.Text != "")
                {
                    productNames.Text += '\n';
                    productAmounts.Text += '\n';
                    productPrices.Text += '\n';
                }
                productNames.Text += $"{id}. {product.Item1}";
                productAmounts.Text += product.Item2.ToString();
                if(product.Item2 != 1)
                {
                    productPrices.Text += $"{product.Item3} x {product.Item2} = {product.Item3 * product.Item2} p.";
                }
                else
                {
                    productPrices.Text += $"{product.Item3} p.";
                }
            }
            if(currentCheck.CheckData.Count() > 1)
            {
                id += 1;
                productPrices.Text += $"\n{check.Price} p.";
            }
            qrCode.Location = new Point(qrCode.Location.X, productPrices.Location.Y + 21 * (id + 1));
            thanksText.Location = new Point(thanksText.Location.X, qrCode.Location.Y + 32);
            Size = new Size(Size.Width, qrCode.Location.Y + qrCode.Size.Height + 50);
        }
    }
}
