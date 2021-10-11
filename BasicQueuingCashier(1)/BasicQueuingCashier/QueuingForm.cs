using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class QueuingForm : Form
    {
        public class CashierClass
        {
            private int x; //number6
            public static string getNumberInQueue = "";
            public static Queue<string> CashierQueue;

           

            public CashierClass()
            {
                x = 1000;
                CashierQueue = new Queue<string>();
            }

            public string CashierGenerateNumber(string CashierNumber)
            {
                x++;
                CashierNumber = CashierNumber + x.ToString();
                return CashierNumber;
            }
        }

        CashierClass cashier = new CashierClass(); //call CashierClass and declare its ariable cashier


        public QueuingForm()
        {
            InitializeComponent();
          
        }

        private void QueuingForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCahier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGenerateNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);

        }

        private void lblCTGnum_Click(object sender, EventArgs e)
        {
            CashierWindowQueueForm cashierWindow = new CashierWindowQueueForm();
            cashierWindow.OpenCashier();
        }
    }
}
