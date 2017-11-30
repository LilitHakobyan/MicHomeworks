using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockNoteWinForm
{
    public partial class FormAddRecord : Form
    {
        public string RecordName { get; set; }
        public  string Phon { get; private set; }
        public FormAddRecord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.RecordName = this.txtName.Text;
            this.Phon = this.txtPhon.Text;
            this.DialogResult = DialogResult.OK;
           // this.Close();
        }

        private void Cncel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
       //this.Close();
            
        }
    }
}
