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
    public partial class Form4 : Form
    {
        public Form4(string Size,string Toppings,string Crust ,string WhereToEat,string Price)
        {
            InitializeComponent();

            lbl_Size.Text = Size;
            Lbl_Topings.Text= Toppings;
            Lbl_Crust.Text= Crust;
            lbl_Eat.Text = WhereToEat;
            Lbl_Price.Text = Price;

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
