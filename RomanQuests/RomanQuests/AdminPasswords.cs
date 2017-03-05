using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanQuests
{
    public partial class AdminPasswords : Form
    {
        public AdminPasswords()
        {
            InitializeComponent();
        }

        private void romanQuestsLoginAdminBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.romanQuestsLoginAdminBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.romanQuestsLoginAdminDataSet);

        }

        private void AdminPasswords_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "romanQuestsLoginAdminDataSet.RomanQuestsLoginAdmin". Sie können sie bei Bedarf verschieben oder entfernen.
            this.romanQuestsLoginAdminTableAdapter.Fill(this.romanQuestsLoginAdminDataSet.RomanQuestsLoginAdmin);

        }
    }
}
