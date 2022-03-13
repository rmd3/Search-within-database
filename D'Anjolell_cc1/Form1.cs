using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Anjolell_cc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void patientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medicalDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalDataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.medicalDataSet.Patients);

        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            this.patientsTableAdapter.SearchName(this.medicalDataSet.Patients, txtSearchName.Text);
        }

        private void btnSearchAddress_Click(object sender, EventArgs e)
        {
            this.patientsTableAdapter.SearchAddress(this.medicalDataSet.Patients, txtSearchAddress.Text);
        }

        private void btnSearchPhone_Click(object sender, EventArgs e)
        {
            this.patientsTableAdapter.SearchPhone(this.medicalDataSet.Patients, txtSearchPhone.Text);
        }

        private void btnSearchEmail_Click(object sender, EventArgs e)
        {
            this.patientsTableAdapter.SearchEmail(this.medicalDataSet.Patients, txtSearchEmail.Text);
        }

        private void btnSearchDeductible_Click(object sender, EventArgs e)
        {
            this.patientsTableAdapter.SearchDeductible(this.medicalDataSet.Patients, int.Parse(txtSearchDeductible.Text));
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.patientsTableAdapter.Fill(this.medicalDataSet.Patients);
        }
    }
}
