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
    public partial class Added : Form
    {
        public Added(Image productImage, string productName, string productDescription, string productManufacturer, double productPrice)
        {
            InitializeComponent();
            pbPhoto.Image = productImage;
            lblName.Text = productName;
            lblDesc.Text = productDescription;
            lblManufact.Text = productManufacturer;
            lblPrice.Text = productPrice.ToString();
        }
    }
}
