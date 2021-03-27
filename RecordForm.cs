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
            string[] props;
            if ((props = s.Split(' ')).Length != 3)
            {
                fio = "";
                return false;
            }
            foreach(string si in props)
            {
                if (si[0].ToString() == s[0].ToString().ToLower())
                {
                    fio = "";
                    return false;
                }
                string tmp = si.Remove(0, 1);
                if (tmp.ToLower() != tmp)
                {
                    fio = "";
                    return false;
                }
            }
            fio = s;
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
            if (Request()) Close();
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
