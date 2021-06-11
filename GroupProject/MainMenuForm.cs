using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class MainMenuForm : Form
    {
        public static char userType;
        private static bool logout = false;

        public MainMenuForm()
        {
            InitializeComponent();
            //var x;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_AccountID.Text += LoginForm.userId;
            if (userType == 'u')
            {
                lbl_UserType.Text += "User";
                lbl_CustomerID.Text += LoginForm.customerId;

                // book pickup form
                BookPickupForm bookPickupForm = new BookPickupForm();
                bookPickupForm.TopLevel = false;
                bookPickupForm.Visible = true;
                tbp_BookPickup.Controls.Add(bookPickupForm);
                tbp_BookPickup.Show();


                // check shipment status form
                CheckShipmentStatusForm checkShipmentStatusForm = new CheckShipmentStatusForm();
                checkShipmentStatusForm.TopLevel = false;
                checkShipmentStatusForm.Visible = true;
                tbp_CheckShipmentStatus.Controls.Add(checkShipmentStatusForm);

                // Message box form
                MessageBoxForm messageBoxForm = new MessageBoxForm();
                messageBoxForm.TopLevel = false;
                messageBoxForm.Visible = true;
                tbp_MessageBox.Controls.Add(messageBoxForm);

                // dispose
                tbp_EditPickupOrder.Dispose();
                tbp_ManageMessage.Dispose();
            } 
            else if (userType == 'a')
            {
                lbl_UserType.Text += "Admin";
                lbl_CustomerID.Visible = false;

                // edit pickup order form
                EditShipmentForm editPickupForm = new EditShipmentForm();
                editPickupForm.TopLevel = false;
                editPickupForm.Visible = true;
                tbp_EditPickupOrder.Controls.Add(editPickupForm);
                tbp_EditPickupOrder.Show();

                //
                ManageMessageForm manageMessageForm = new ManageMessageForm();
                manageMessageForm.TopLevel = false;
                manageMessageForm.Visible = true;
                tbp_ManageMessage.Controls.Add(manageMessageForm);
                tbp_ManageMessage.Show();

                // dispose
                tbp_BookPickup.Dispose();
                tbp_CheckShipmentStatus.Dispose();
                tbp_MessageBox.Dispose();
            }
            
            
        }

        private void tbc_Function_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userType == 'u')
            {
                switch ((sender as TabControl).SelectedIndex)
                {
                    case 0:
                        tbp_BookPickup.Show();
                        break;
                    case 1:
                        tbp_CheckShipmentStatus.Show();
                        break;
                    case 2:
                        tbp_MessageBox.Show();
                        break;
                }
            }
            else
            {
                switch ((sender as TabControl).SelectedIndex)
                {
                    case 0:
                        tbp_EditPickupOrder.Show();
                        break;
                    case 1:
                        tbp_ManageMessage.Show();
                        break;

                }
            }
            
        }


        private void btn_Logout_Click(object sender, EventArgs e)
        {
            logout = true;
            this.Dispose();
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (logout == true)
            {
                logout = false;
            }
            else
            {
                Application.Exit();
            }

        }
    }
}
