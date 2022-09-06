using System;
using System.Windows.Forms;

namespace Joe_s_Automotive
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Reset checkboxes
            cboxOil.Checked = false;
            cboxLube.Checked = false;
            cboxRadiator.Checked = false;
            cboxTransmission.Checked = false;
            cboxInspection.Checked = false;
            cboxMuffler.Checked = false;
            cboxTire.Checked = false;

            // Clear textboxes
            txtboxParts.Clear();
            txtboxLabor.Clear();
            txtboxSummaryService.Clear();
            txtboxSummaryParts.Clear();
            txtboxSummaryTax.Clear();
            txtboxSummaryTotal.Clear();

            // Let the user know everything was cleared
            MessageBox.Show("All selections have been cleared.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Initialize variable to hold the total charge
            double total = 0;
            double serviceLabor = 0;
            double parts = 0;

            if (cboxOil.Checked)
            {
                total += 26;
            }
            if (cboxLube.Checked)
            {
                total += 18;
            }
            if (cboxRadiator.Checked)
            {
                total += 30;
            }
            if (cboxTransmission.Checked)
            {
                total += 80;
            }
            if (cboxInspection.Checked)
            {
                total += 15;
            }
            if (cboxMuffler.Checked)
            {
                total += 100;
            }
            if (cboxTire.Checked)
            {
                total += 20;
            }

            // 
            try
            {
                // Try parsing and adding the textboxes to the total
                total += double.Parse(txtboxParts.Text);
                total += double.Parse(txtboxLabor.Text);
            }
            catch
            {
                MessageBox.Show("");
            }

            double tax = total * 0.06;
            total = total + tax;

            // Display the charges
            txtboxSummaryTax.Text = (total * 0.06).ToString("c");
            txtboxSummaryTotal.Text = total.ToString("c");
        }
    }
}
