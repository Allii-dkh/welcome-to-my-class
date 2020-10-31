namespace WindowsFormsApp46
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timerLabel_Tick(object sender, System.EventArgs e)
        {
            if (titleLabel.Text == "Welcome To My Class!")
            {
                titleLabel.Text = "I'm Ali Dolatkhani";
                titleLabel.ForeColor = System.Drawing.Color.Yellow;
            }
            else
            {
                titleLabel.Text = "Welcome To My Class!";
                titleLabel.ForeColor = System.Drawing.Color.White;
            }
                
            
        }

        private void titleLabel_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("bye bye");
            System.Windows.Forms.Application.Exit();
           
        }
    }
 
       
       

 
}
