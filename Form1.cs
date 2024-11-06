namespace InvoiceTotalForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // Enable KeyPreview to capture key presses
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_cal_Click(sender, e); // Trigger the calculation button click event
                e.Handled = true;          // Mark the event as handled
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btn_exit_Click(sender, e); // Trigger the exit button click event
                e.Handled = true;          // Mark the event as handled
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {

        }
    }
}
