using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Pizza
{
    
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        float CalculateToppingPrice()
        {
            float Totaltoppings = 0;
            if (CB_ExtraCheese.Checked)
            {
                Totaltoppings += Convert.ToSingle(CB_ExtraCheese.Tag);
              
            }
            if (CB_Mushrooms.Checked)
            {
                Totaltoppings += Convert.ToSingle(CB_Mushrooms.Tag);


            }
            if (CB_Olives.Checked)
            {
                Totaltoppings += Convert.ToSingle(CB_Olives.Tag);


            }
            if (CB_Onion.Checked)
            {


                Totaltoppings += Convert.ToSingle(CB_Onion.Tag);

            }
            if (CB_Tomatoes.Checked)
            {
                Totaltoppings += Convert.ToSingle(CB_Tomatoes.Tag);



            }
            if (checkBox6.Checked)
            {
                Totaltoppings += Convert.ToSingle(checkBox6.Tag);

            }

            return Totaltoppings;
        }
        float GetSelectedSizePrice()
        {

            if (RBSmall.Checked)
            {
                return Convert.ToSingle(RBSmall.Tag);
            }
            else if (RB_larg.Checked)
            {

                return Convert.ToSingle(RB_larg.Tag);
            }
            else
            {
                return Convert.ToSingle(RB_Meduim.Tag);
            }


        }
        float GetSelectedCrustPrice()
        {
           if (RB_ThinCrust.Checked)
            {

                return Convert.ToSingle(RB_ThinCrust.Tag);

            }
            else
            {
                return Convert.ToSingle(RB_Thinkcrust.Tag);
            }
        }
        float CalculateTotalPrice()
        {


            return (GetSelectedSizePrice() + CalculateToppingPrice() + GetSelectedCrustPrice());

        }
        void UpdateCrustType()
        {
            UpdateTotalPrice();
            if (RB_ThinCrust.Checked)
            {
                Lbl_Crust.Text="Thin Crust";
                return;
            }
            if (RB_Thinkcrust.Checked)
            {

                Lbl_Crust.Text = "Think Crust";
                return;
            }

        }
        void UpdateWhereToEat()
        {
            if (RB_EatIn.Checked)
            {
                Where_To_Eat.Text = "Eat In";

            }
            else
            {
                Where_To_Eat.Text = "Take Out";
            }

        }
        void ResetForm()
        {


            GB_Crust_Type.Enabled = true;
            GB_Size.Enabled = true;
            GB_WhereTo.Enabled = true;
            GB_Toppings.Enabled = true;


            CB_ExtraCheese.Enabled = false;
            CB_Mushrooms.Enabled = false;
            CB_Olives.Enabled = false;
            CB_Onion.Enabled = false;
            CB_Tomatoes.Enabled = false;
            checkBox6.Enabled = false;

        }
       void  UpdateOrderSummary()
        {
            UpdateCrustType();
            UpdateSize();
            UpdateToppings();
            UpdateTotalPrice();
            UpdateWhereToEat();


        }
        void UpdateToppings()
        {
            UpdateTotalPrice();
            string sToppings = "";
            if (CB_ExtraCheese.Checked)
            {
                sToppings = "Extra Cheese";
                numericUpDown1.Enabled = true;
            }
            if (CB_Mushrooms.Checked)
            {
                sToppings += ", Mushrooms";
                numericUpDown1.Enabled = true;
            }
            if (CB_Olives.Checked)
            {
                sToppings += ", Olives";
                numericUpDown1.Enabled = true;
            }
            if (CB_Onion.Checked)
            {

                sToppings += ", Onion";
                numericUpDown1.Enabled = true;
            }
            if (CB_Tomatoes.Checked)
            {
                sToppings += ", Tomatoes";
                numericUpDown1.Enabled = true;
            }

            if (checkBox6.Checked)
            {
                sToppings += ", Green Peppers";
                numericUpDown1.Enabled = true;

            }

            if (sToppings.StartsWith(","))
            {
                sToppings=sToppings.Substring(1,sToppings.Length-1);
            }
            if (sToppings == "")
            {
                sToppings = "No Toppings";
            }
            lbl_Toppings.Text = sToppings;
        }
        void UpdateTotalPrice()
        {
            Label_Price.Text = "$" +( (float)numericUpDown1.Value* CalculateTotalPrice()).ToString();



        }
        void UpdateSize()
        {

            UpdateTotalPrice();
            if (RBSmall.Checked)
            {
                Lbl_Size.Text = "Small";
                return;



            }

            if (RB_larg.Checked)
            {
                Lbl_Size.Text = "Larg";
                return;

            }
            if (RB_Meduim.Checked)
            {


                Lbl_Size.Text = "Meduim";
                return;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void Makeyorpizza_Click(object sender, EventArgs e)
        {

        }

        private void GB_Size_Enter(object sender, EventArgs e)
        {
          



            
        }

        private void GB_Crust_Type_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void Makeyorpizza_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void RBSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();



        }

        private void RB_Meduim_CheckedChanged(object sender, EventArgs e)
        {

            UpdateSize();
        }

        private void RB_larg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void CB_ExtraCheese_CheckedChanged(object sender, EventArgs e)
        {

            UpdateToppings();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CB_Tomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void CB_Onion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void CB_Olives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void RB_EatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void RB_TakeOut_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Where_To_Eat_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
           
        }

        private void RB_ThinCrust_CheckedChanged(object sender, EventArgs e)
        {

            UpdateCrustType();
        }

        private void RB_Thinkcrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();

        }

        private void B_OrderPizza_Click(object sender, EventArgs e)
        {
          if ( MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                MessageBox.Show("Order Plased Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GB_Crust_Type.Enabled = false;
                    
                    GB_Size.Enabled = false;
                    GB_WhereTo.Enabled = false;
                    GB_Toppings.Enabled = false;

                Form4 frmOrder = new Form4(Lbl_Size.Text, lbl_Toppings.Text, Lbl_Crust.Text, Where_To_Eat.Text, Label_Price.Text);

                frmOrder.ShowDialog();//Show();


            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Reset Groub Box
            GB_Crust_Type.Enabled = true;
            GB_Size.Enabled = true;
            GB_WhereTo.Enabled = true;
            GB_Toppings.Enabled = true;
        //Reset rbbutton  RBSmall
            RBSmall.Checked= true;

            // Reset rbBtton RB_thin
            RB_ThinCrust.Checked = true;

            // Reset Groub Check box
            CB_ExtraCheese.Checked = false;
            CB_Mushrooms.Checked = false;
            CB_Olives.Checked = false;
            CB_Onion.Checked = false;
            CB_Tomatoes.Checked = false;
            checkBox6.Checked = false;

            //  Reset Take out
            RB_TakeOut.Checked = true;

            // Reset buttom order pizza
            B_OrderPizza.Enabled = true;

        }

        private void Crust_Type_Click(object sender, EventArgs e)
        {

        }

        private void GB_OrderSamary_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            RB_ThinCrust.Text = "Thin Crust";
        }

        private void Toppings_Click(object sender, EventArgs e)
        {

        }
     
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            if (numericUpDown1.Enabled)
            {

                UpdateTotalPrice();

            }
           

        }
    }
}
