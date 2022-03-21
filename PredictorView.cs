using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetManager
{
    public partial class PredictorView : Form
    {
        public PredictorView()
        {
            InitializeComponent();
        }

        private void onPredictValue(object sender, EventArgs e)
        {
            DateTime date = this.dtDatePicker.Value.Date;
            String category = this.cmbCat.Text;
            String type = this.cmbCat.Text;



        }
    }
}
