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
    public partial class FormMane : Form
    {
    Blocknot blocknot=new Blocknot();
        public FormMane()
        {
            InitializeComponent();
            blocknot.BlocknotChanged += Blocknot_BlocknotChanged;
        }

        private void Blocknot_BlocknotChanged(object sender, BlocknotChangedEventArgs e)
        {
            switch (e.CheType)
            {
                case BlocknotChangeType.Add:
                    this.lbItem.Items.Add(e.Record);
                    break;
                case BlocknotChangeType.Remove:
                    break;
                default:
                    break;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormAddRecord formAdd =new FormAddRecord();
            formAdd.ShowDialog();
            if (formAdd.DialogResult==DialogResult.OK)
            {
                Record record = new Record()
                {
                    Name = formAdd.RecordName,
                    Phon = formAdd.Phon
                };
                blocknot.Add(record);
            }
        }
    }
}
