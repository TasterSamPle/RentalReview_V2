namespace RentalReview_V2
{
    public partial class Main_Menu : Form
    {

        public Main_Menu()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Car secondForm = new Car();
        private void Car_Button_Click(object sender, EventArgs e)
        {
            secondForm.Show();
            
        }
        
        Van_Screen thirdForm = new Van_Screen();
        private void Van_Button_Click(object sender, EventArgs e)
        {
            thirdForm.Show();
            
        }
    }
}