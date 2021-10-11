using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BasicQueuingCashier.QueuingForm;

namespace BasicQueuingCashier
{
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = (1 * 100);
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();
            
        }
        Boolean openForm = false;
        FormCollection formCollection = Application.OpenForms;
        Form OpenedForm = new Form();

        private void timer1_tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
          
        }

        private void listCashierQueue_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }


        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach(object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());

            }
        }

        public delegate void PassControl(object sender);
        public PassControl passControl;

        public void OpenCashier()
        {
            if(openForm == false)
            {
                CashierWindowQueueForm cashierWindow = new CashierWindowQueueForm();
                cashierWindow.Visible = true;
                openForm = true;
            }
        }

    }
}
