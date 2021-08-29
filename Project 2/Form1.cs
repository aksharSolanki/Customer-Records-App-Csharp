using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseClasses;
using CustomerClasses;
using Oracle.DataAccess.Client;

namespace Project_2
{
    public partial class Form1 : Form
    {
        // Database object to perform database operations
        CustomerTable customerOperation;

        // Form1 default constructor
        public Form1()
        {
            InitializeComponent();
            customerOperation = new CustomerTable();

            // On Form1 load event new table will be created however, if table 
            //already exists then it will handle the exception thrown
            try
            {
                customerOperation.CreateTable();
            } catch(Exception e)
            {
                MessageBox.Show("The product table already exists", e.GetType().Name);
            }
            ChangeState(false);
        }

        // ChangeState method to change the ReadOnly property of the Address field
        public void ChangeState(bool status)
        {
            if(status)
                txtAdd.ReadOnly = false;
            else
                txtAdd.ReadOnly = true;
        }

        // Form closing event which will close connection and drop the table
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                customerOperation.DropTable();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("The following problem with the connection was found: " +
                    ex.Message);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following problem with the database was found: " +
                    ex.Message);
                Close();
            }
        }

        // On click event of btnView, all the attributes/columns of the customer object
        // will be retrieved from the customer table. However, if a customer doesn't exist
        // then it will handle the exception
        private void btnView_Click(object sender, EventArgs e)
        {
            RefreshControls();
            List<string> selectedInterest = new List<string>();
            try
            {
                Customer tempCustomer;
                tempCustomer = customerOperation.GetCustomer(txtLName.Text);

                txtFName.Text = tempCustomer.FirstName;
                txtAdd.Text = tempCustomer.Address;
                selectedInterest = tempCustomer.InterestList;

                if (selectedInterest.Contains(clbMailing.Items[0]))
                    clbMailing.SetItemCheckState(0, CheckState.Checked);
                else
                    clbMailing.SetItemCheckState(0, CheckState.Unchecked);

                if (selectedInterest.Contains(clbMailing.Items[1]))
                    clbMailing.SetItemCheckState(1, CheckState.Checked);
                else
                    clbMailing.SetItemCheckState(1, CheckState.Unchecked);

                if (selectedInterest.Contains(clbMailing.Items[2]))
                    clbMailing.SetItemCheckState(2, CheckState.Checked);
                else
                    clbMailing.SetItemCheckState(2, CheckState.Unchecked);

                DialogResult res = MessageBox.Show("Do you want to update address?", "Update Address", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (res == DialogResult.Yes)
                {
                    ChangeState(true);
                    txtAdd.Focus();
                    txtAdd.SelectAll();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("No client with that name exists", ex.GetType().Name);
                txtLName.Focus();
                txtLName.SelectAll();
            }
        }

        // On click event of btnUpdate, the address column in the database will be updated
        // using the provided address by the user.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                customerOperation.UpdateAddress(txtLName.Text, txtAdd.Text);
                ChangeState(false);
                
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Once the user clicks btnView, the controls will be refreshed to the 
        // default state
        private void RefreshControls()
        {
            txtFName.Text = string.Empty;
            txtAdd.Text = string.Empty;
            clbMailing.SetItemCheckState(0, CheckState.Unchecked);
            clbMailing.SetItemCheckState(1, CheckState.Unchecked);
            clbMailing.SetItemCheckState(2, CheckState.Unchecked);
        }

        // btnExit to close the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();   
        }
    }
}
