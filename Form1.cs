using System;
using System.Windows.Forms;

namespace FirstWinForm
{
    public partial class Form_Calculator : Form
    {
        public Form_Calculator()
        {
            InitializeComponent();
        }

        //Below method is used for addition of two numbers
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            int first_Number = int.Parse(txt_FirstNumber.Text);
            int second_number = int.Parse(txt_SecondNumber.Text);
            int result = first_Number + second_number;
            txtResult.Text = result.ToString();
        }

        // Below code is used to refresh the controls.
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        //Below method is used for subtraction of two numbers
        private void Btn_Sub_Click(object sender, EventArgs e)
        {
            int first_Number = int.Parse(txt_FirstNumber.Text);
            int second_number = int.Parse(txt_SecondNumber.Text);
            int result = first_Number - second_number;
            txtResult.Text = result.ToString();
        }

        //Below method is used for multiplication of two numbers
        private void Btn_Mul_Click(object sender, EventArgs e)
        {
            int first_Number = int.Parse(txt_FirstNumber.Text);
            int second_number = int.Parse(txt_SecondNumber.Text);
            int result = first_Number * second_number;
            txtResult.Text = result.ToString();
        }

        //Below method is used for division of two numbers
        private void Btn_Div_Click(object sender, EventArgs e)
        {
            int first_Number = int.Parse(txt_FirstNumber.Text);
            int second_number = int.Parse(txt_SecondNumber.Text);
            int result = first_Number / second_number;
            txtResult.Text = result.ToString();
        }
    }
}
