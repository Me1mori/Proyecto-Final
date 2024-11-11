namespace Nuevo_Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; 
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e){

        }

        private void button2_Click(object sender, EventArgs e){
            Register r1=new Register();
            this.Hide();
            r1.ShowDialog();
            this.Close();
        }
    }
}
