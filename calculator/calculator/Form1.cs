namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int Substract(int a, int b) { return (a-b); }
        private float Division(int a, int b) 
        {
            if (b == 0) { throw new DivideByZeroException(); }
            return a / b;
        }
    }
}