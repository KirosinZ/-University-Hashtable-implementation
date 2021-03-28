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
    public partial class RecordForm : Form
    {
        public Record Result { get; private set; }

        bool CheckFIO(string s, out string fio)
        {
            if (s.IndexOfAny("1234567890()[]{}<>;:,.!?@#$%^&*-_=+\\\'\"|".ToCharArray()) != -1)
            {
                fio = "";
                return false;
            }
            fio = s.Trim(' ');
            return true;
        }

        bool Request()
        {
            int personnelnum;
            string fio;
            decimal sal;
            if (!(int.TryParse(PersonnelNumberBox.Text, out personnelnum) && CheckFIO(FIOBox.Text, out fio) && decimal.TryParse(SalaryBox.Text, out sal))) return false;
            Result = new Record(personnelnum, fio, sal);
            return true;
        }

        void Do()
        {
            if (Request())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else MessageBox.Show(this, "Введенные данные не соответствуют формату.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public RecordForm(string head, string instruction)
        {
            InitializeComponent();

            Text = head;
            InstructionLabel.Text = instruction;

            MainButton.Click += (ob, ev) => Do();
        }
    }
}
