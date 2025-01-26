using ContactBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class frmAddEditContact : Form
    {

        public enum enMode { AddNew=1,Update=2};
        private enMode _Mode;
        int _ContactID;
        clsContacts _Contact;


        public frmAddEditContact(int ContactID)
        {
            InitializeComponent();
            _ContactID = ContactID;
            if (_ContactID == -1)
            {
                _Mode = enMode.AddNew;
            }
            else
                _Mode = enMode.Update;

        }

        private void _FillCountriesInComboBox()
        {
            DataTable Table = clsCountry.GetAllCountries();
            foreach(DataRow Row in Table.Rows)
            {
                cbCountry.Items.Add(Row["CountryName"]);
            }
        }
        private void _LoadData()
        {
            _FillCountriesInComboBox();
            cbCountry.SelectedIndex = 0;
            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Contact";
                _Contact = new clsContacts();
                return;
            }
            _Contact = clsContacts.Find(_ContactID);
            if(_Contact==null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _ContactID);
                this.Close();

                return;
            }
            lblMode.Text = "Update Contact ID"+ _ContactID;
            lblContactID.Text = _ContactID.ToString();
            txtFirstName.Text = _Contact.FirstName;
            txtLastName.Text = _Contact.LastName;
            txtEmail.Text = _Contact.Email;
            txtPhone.Text = _Contact.Phone;
            dtDateOfBirth.Value = _Contact.DateOfBirth;
            txtAddress.Text = _Contact.Address;
            if(_Contact.ImagePath!="")
            {
                pbContactImage.Load(_Contact.ImagePath);
            }
            llRemoveImage.Visible = (_Contact.ImagePath == "");
            cbCountry.SelectedIndex = cbCountry.FindString(clsCountry.FindCountryByID(_Contact.CountryID).CountryName);
        }

        private void frmAddEditContact_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int CountryID = clsCountry.FindCountryByName(cbCountry.Text).CountryID;
            _Contact.FirstName = txtFirstName.Text;
            _Contact.LastName = txtLastName.Text;
            _Contact.Email = txtEmail.Text;
            _Contact.Phone = txtPhone.Text;
            _Contact.DateOfBirth = dtDateOfBirth.Value;
            _Contact.Address = txtAddress.Text;
            _Contact.CountryID = CountryID;
            if (pbContactImage.ImageLocation != null)
            {
                _Contact.ImagePath = pbContactImage.ImageLocation;
            }
            else
                _Contact.ImagePath = "";
            if(_Contact.Save())
            {
                MessageBox.Show("Contact Saved Succesfully");
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.");
            _Mode = enMode.Update;
            lblMode.Text = "Update Contact ID=" + contactID;
            lblContactID.Text = _Contact.ID.ToString();




        }
        struct CountryItem
        {
            public string Text;
            public int Value;
            public CountryItem(string Text, int Value)
            {
                this.Text = Text;
                this.Value = Value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                pbContactImage.Load(selectedFilePath);
                // ...
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbContactImage.ImageLocation = null;
            llRemoveImage.Visible = false;
        }
    }
}
