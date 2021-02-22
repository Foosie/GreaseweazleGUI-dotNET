using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greaseweazle
{
    public partial class PictureForm : Form
    {
        public PictureForm(ChooserForm newForm)
        {
            InitializeComponent();
        }

        private void pbGWbig_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region PinForm_Load
        private void PinForm_Load(object sender, EventArgs e)
        {
            // set colors
            pbGWbig.BackColor = ChooserForm.cChocolate;
            this.BackColor = ChooserForm.cChocolate;
        }
        #endregion
    }
}
