using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteLogica
{
    public partial class FrmTestLogic : Form
    {
        int value1;
        int value2;
        int result;
        public FrmTestLogic()
        {
            InitializeComponent();
        }
        
        private void btnAdic_Click(object sender, EventArgs e)
        {
            
            value1 = Convert.ToInt32(txtN1.Text);
            value2 = Convert.ToInt32(txtN2.Text);

            result = value1 + value2;
            txtResult.Text = result.ToString();

        }
       
        private void btnSub_Click_1(object sender, EventArgs e)
        {
        

            value1 = Convert.ToInt32(txtN1.Text);
            value2 = Convert.ToInt32(txtN2.Text);

            result = value1 - value2;

            txtResult.Text = result.ToString();
        }


        private void btnMult_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(txtN1.Text);
            value2 = Convert.ToInt32(txtN2.Text);

            result = value1 * value2;

            txtResult.Text = result.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(txtN1.Text);
            value2 = Convert.ToInt32(txtN2.Text);
            
            result = value1 / value2;

            txtResult.Text = result.ToString();
        }
             
    }
   
}


