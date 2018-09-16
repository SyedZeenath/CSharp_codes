using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_win_Events_UserControls
{
    public partial class Form1 : Form
    {
        private List<Product> products;
        public Form1()
        {
            InitializeComponent();
            this.products = new List<Product>()
            {
                new Product()
                {
                    Name ="Rice",
                    Price =64,
                    ExpiresOn =System.DateTime.Now.AddYears(3)
                },
                 new Product()
                {
                    Name ="Wheat",
                    Price =72,
                    ExpiresOn =System.DateTime.Now.AddYears(2)
                },
                new Product()
                {
                    Name ="Sugar",
                    Price =32,
                    ExpiresOn =System.DateTime.Now.AddDays(90)
                },
                new Product()
                {
                    Name ="Salt",
                    Price =8,
                    ExpiresOn =System.DateTime.Now.AddMonths(3)
                }

            };
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(var p in this.products)
            {
                this.productListBox.Items.Add(p);
            }
            this.labelProductName.Enabled
                =this.labelPrice.Enabled
                =this.labelExpiryDate.Enabled
                =this.textBoxProductName.Enabled
                = this.textBoxPrice.Enabled
                = this.dateTimePickerExpiryDate.Enabled
                = false;
        }

        private void productListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProduct = this.productListBox.SelectedItem as Product;
            this.textBoxProductName.Text = selectedProduct.Name;
            this.textBoxPrice.Text = selectedProduct.Price.ToString();
            this.dateTimePickerExpiryDate.Value = selectedProduct.ExpiresOn;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.None:
                case CloseReason.WindowsShutDown:
                case CloseReason.MdiFormClosing:                
                case CloseReason.TaskManagerClosing:
                case CloseReason.FormOwnerClosing:
                case CloseReason.ApplicationExitCall:
                    break;
                case CloseReason.UserClosing:
                    DialogResult result = MessageBox.Show(
                        owner: this,
                        text: "are you sure u want to exit?",
                        caption: "CONFIRM EXIT",
                        buttons: MessageBoxButtons.YesNo,
                        icon: MessageBoxIcon.Warning,
                        defaultButton: MessageBoxDefaultButton.Button2
                        );
                    //if(result == DialogResult.Yes)
                    //{
                    //    e.Cancel = false;    //do not cancel the form closing event
                    //}
                    //else
                    //{
                    //    e.Cancel = true;    //cancel the  form closing
                    //}
                    e.Cancel = (result == DialogResult.No);   //replacement for if-else block
                    break;
                default:
                    break;
            }
        }

        private void showForm2_Click(object sender, EventArgs e)
        {

            //Form2 objForm = new Form2():
            //objForm.Show(this);  //both the windows can be handled, a bad practice of coding

            using (Form2 objForm = new Form2())
            {
                objForm.ShowDialog(this);
            }
        }
    }
}
