using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueAutopark
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnterCarNoEnter_Click(object sender, EventArgs e)
        {
           
            App.run();

            txtCarlist.Text = App.getNormalCarListOutput();
            txtPriorityQueue.Text = App.getPrioritizedCarListOutput();

            // TODO: araç sayısını göstermek için label oluştur ve aşağıdaki sonucu oraya yazdır
            lblTotalCar.Text = App.getTotalCars();

            lblNormalTotalWaitingPeriod.Text = App.getNormalTotalWaitingPeriodTime();
            lblPrioritizedTotalWaitingPeriod.Text = App.getPrioritizedTotalWaitingPeriodTime();


        }

    }
}
