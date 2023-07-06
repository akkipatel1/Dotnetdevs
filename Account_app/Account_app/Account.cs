namespace Account_app
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void idTxt_Click(object sender, EventArgs e)
        {

        }

        private void nameTxt_Click(object sender, EventArgs e)
        {

        }

        //Account a;
        int id;
        string name;
        decimal balance;
        private void create_btn_Click(object sender, EventArgs e)
        {
            //a = new Account();

        }

        private void set_btn_Click(object sender, EventArgs e)
        {
            id = int.Parse(textBox1.Text);
            name = textBox2.Text;
            balance = decimal.Parse(textBox3.Text);
        }

        private void get_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = id.ToString();
            textBox2.Text = name;
            textBox3.Text = balance.ToString();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void destroy_btn_Click(object sender, EventArgs e)
        {
            id = 0;
            name = "";
            balance = 0;
        }

        private void gc_btn_Click(object sender, EventArgs e)
        {

        }
    }
}