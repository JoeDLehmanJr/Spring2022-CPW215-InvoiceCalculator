namespace InvoiceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcTotal_Click(object sender, EventArgs e)
        {
            // Single line comment
            /*
             * Block comment
             */

            // Get the subtotal and tax rate
            double subtotal = Convert.ToDouble(txtSubtotal.Text);
            double taxRate = Convert.ToDouble(txtTaxRate.Text);

            // Calcule Total
            double total = subtotal * (taxRate / 100 + 1);

            // Display total
            txtTotal.Text = total.ToString("c");

        }
    }
}