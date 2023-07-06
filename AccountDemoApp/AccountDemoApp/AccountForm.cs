namespace AccountDemoApp
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }
        Account a;

        private void btnCreate_Click(object sender, EventArgs e)
        {

            a = new Account();

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtId.Text = a.Id.ToString();
            txtName.Text = a.Name;
            txtBalance.Text = a.Balance.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccountForm_Load(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            a.Id = int.Parse(txtId.Text);
            a.Name = txtName.Text;
            // a.Balance = decimal.Parse(txtBalance.Text);
            a.Deposite(decimal.Parse(txtBalance.Text));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtBalance.Clear();
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            a = null;
        }

        private void btnGC_Click(object sender, EventArgs e)
        {
            //To forcefully activate garbage collector
            GC.Collect();
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            //We create a temporary refrence to the class
            Account a1;
            a1 = new Account();

            //as object is local, it will be destroyed as soon as btnTemp method is destroyed

            //if we assign a1 to a the object will be pointed by a as well
            a = a1;

            //so even if btnTemp method ends the object will not be collected by garbage collector as a is refrencing 
            //to that object as well
        }

        private void btnGetGeneration_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GC.GetGeneration(a).ToString());
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeposite_Click(object sender, EventArgs e)
        {
            a.Deposite(decimal.Parse(txtAmount.Text));
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            a.Withdraw(decimal.Parse(txtAmount.Text));
        }
    }
}