using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STRIALG_HASH
{
    public partial class KeyForm : Form
    {
        int result;
        public int Result { get => result; }

        void Do()
        {
            if (int.TryParse(KeyBox.Text, out result))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else MessageBox.Show(this, "Введенные данные не соответствуют формату.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public KeyForm(string header, string instruction)
        {
            InitializeComponent();

            Text = header;
            label1.Text = instruction;

            MainButton.Click += (ob, ev) => Do();
        }
    }
}
