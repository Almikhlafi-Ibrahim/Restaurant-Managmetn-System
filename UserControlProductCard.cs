using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Managmetn_System
{
    public partial class UserControlProductCard: UserControl
    {
        public UserControlProductCard()
        {
            InitializeComponent();
        }
        public string productName {
            get
            {
                return lblProductName.Text;
            }
            set
            {
                lblProductName.Text = value;
            }
        
        }
        public string productQuantity
        {
            get
            {
                return txtQuntity.Text;
            }
            set
            {
                txtQuntity.Text = value;
            }
        }
        public string Category { set; get; }
        public string ProductStock
        
        { 
                        get
                    {
                        return lblStock.Text;
                    }
                    set
                    {
                        lblStock.Text = value;
                    }
                
                
         }
        public string ProductPrice 
        { 
                    set
                    {
                        lblPrice.Text = value;
                    }

                         get
                    {
                        return lblPrice.Text;
                    }
                
         }

      public  string productPicter
        {
            set
            {
                pictureBox1.Text = value;
            }

            get
            {
                return pictureBox1.Text;
            }

        }

        public Image productImage
        {
            set
            {
                pictureBox1.Image = value;
            }

            get
            {
                return pictureBox1.Image;
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public int productId { set; get; }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            selectCard.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler selectCard = null;
    }
}
