using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace STRIALG_HASH
{
    public partial class Form1 : Form
    {
        bool HasUnsavedData = false;
        string CurrentFilePath = "*.bin";
        HashSet<int, Record> MainSet;

        static string ToText(HashSetEntry<int, Record> entry) => entry.Key.ToString() + ":" + entry.Value.PersonnelNumber.ToString() + ";" + entry.Value.FIO + ";" + entry.Value.Salary.ToString();

        static HashSetEntry<int, Record> FromText(string s)
        {
            var props = s.Split(':');
            var recprops = props[1].Split(';');
            return new HashSetEntry<int, Record>(Convert.ToInt32(props[0]), new Record(Convert.ToInt32(recprops[0]), recprops[1], Convert.ToDecimal(recprops[2])));
        }

        [Flags]
        public enum Actuators
        {
            All = -1,
            None = 0,
            Create = 1,
            Open = 2,
            Save = 4,
            SetCreateMods = 8,
            SetDeleteMods = 16,
            SetOps = 32,
            Exit = 64
        }

        Actuators State = Actuators.Create | Actuators.Open | Actuators.Exit;

        public bool VerifySave()
        {
            if (HasUnsavedData)
            {
                switch (MessageBox.Show(this, "Имеются несохраненные данные, сохранить?", "Внимание!", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                    {
                        HasUnsavedData = !SaveFile(CurrentFilePath == "*.bin");
                        return !HasUnsavedData;
                    }
                    case DialogResult.No:
                    {
                        return true;
                    }
                    case DialogResult.Cancel:
                    {
                        return false;
                    }
                    default: throw new Exception("Произошла ошибка!");
                }
            }
            return true;
        }

        public void CreateFile()
        {
            if (!VerifySave()) return;

            FileNameLabel.Text = CurrentFilePath = "*.bin";
            MainSet = new HashSet<int, Record>();
            HasUnsavedData = true;

            State = Actuators.All & ~Actuators.SetDeleteMods;
            UpdateState();
        }

        public void OpenFile()
        {
            if (!VerifySave()) return;

            if (OpenFileDialogWindow.ShowDialog(this) == DialogResult.OK)
            {
                FileNameLabel.Text = CurrentFilePath = OpenFileDialogWindow.FileName;
                FileNameLabel.Text = FileNameLabel.Text.Remove(0, FileNameLabel.Text.LastIndexOf('\\') + 1);
                string ext = CurrentFilePath.Remove(0, CurrentFilePath.LastIndexOf('.'));

                switch(ext)
                {
                    case ".txt":
                    {
                        StreamReader text = new StreamReader(CurrentFilePath);
                        MainSet = new HashSet<int, Record>();
                        while (!text.EndOfStream)
                        {
                            string s = text.ReadLine();
                            MainSet.Add(FromText(s));
                        }
                        text.Close();
                        break;
                    }
                    case ".bin":
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        MainSet = (HashSet<int, Record>)bin.Deserialize(new FileStream(CurrentFilePath, FileMode.Open));
                        break;
                    }
                    default: throw new Exception("Файл имел неверное расширение.");
                }
                DrawSet(MainSet, MainDataGridView);

                HasUnsavedData = false;

                State = Actuators.All & ~Actuators.SetDeleteMods;
                UpdateState();
            }
        }

        public bool SaveFile(bool saveAs)
        {
            if (saveAs)
            {
                if (SaveFileDialogWindow.ShowDialog(this) != DialogResult.OK) return false;
                FileNameLabel.Text = CurrentFilePath = SaveFileDialogWindow.FileName;
                FileNameLabel.Text = FileNameLabel.Text.Remove(0, FileNameLabel.Text.LastIndexOf('\\') + 1);
            }
            string ext = CurrentFilePath.Remove(0, CurrentFilePath.LastIndexOf('.'));

            switch(ext)
            {
                case ".txt":
                {
                    StreamWriter text = new StreamWriter(CurrentFilePath);
                    MainSet = new HashSet<int, Record>();
                    foreach (var s in MainSet)
                    {
                        text.WriteLine(ToText(s));
                    }
                    text.Close();
                    break;
                }
                case ".bin":
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(new FileStream(CurrentFilePath, FileMode.Create), MainSet);
                    break;
                }
                default: throw new Exception("Файл имел неверное расширение.");
            }

            HasUnsavedData = false;
            return true;
        }

        public void AddSetCreateMod()
        {
            RecordForm tmp = new RecordForm("Добавить", "Создание записи:");
            if (tmp.ShowDialog(this) == DialogResult.OK)
            {
                HasUnsavedData = true;
                MainSet.Add(tmp.Result.PersonnelNumber, tmp.Result);
                DrawSet(MainSet, MainDataGridView);
            }
        }

        public void DeleteSetDeleteMod()
        {
            
            RecordForm tmp = new RecordForm("Удалить", "Введите слово или слова:");
            if (tmp.ShowDialog(this) == DialogResult.OK)
            {
                HasUnsavedData = true;
                MainSet.DeleteWords(tmp.Output);
                DrawSet(MainSet, MainDataGridView);
            }
        }

        public void ClearSetDeleteMod()
        {
            HasUnsavedData = true;
            MainSet.ClearTree();
            MainDataGridView.Nodes.Clear();
        }

        public void FindSetOp()
        {
            WordsForm tmp = new WordsForm("Найти", "Введите слово или слова:");
            if (tmp.ShowDialog(this) == DialogResult.OK)
            {
                string buffer = "";
                string[] tmps = tmp.Output.ToWords();
                bool[] tmpb = MainSet.FindWords(tmp.Output);
                for (int i = 0; i < tmps.Length; i++)
                {
                    buffer += $"{i + 1}. Слово \"{tmps[i]}\" {(tmpb[i] ? "при" : "от")}сутствует в дереве.\n";
                }
                MessageBox.Show(this, buffer, "Результат", MessageBoxButtons.OK);
            }
        }

        public void Exit(CancelEventArgs e) => e.Cancel = !VerifySave();

        public Form1()
        {
            InitializeComponent();

            UpdateState();

            FileNameLabel.Text = "*.bin";
            SaveFileDialogWindow.Filter = OpenFileDialogWindow.Filter = "Текстовые файлы (*.txt)|*.txt|Типизированные файлы (*.bin)|*.bin";

            // Привязка метода создания файла
            CreateFileStripItem.Click += (obj, ev) => CreateFile();
            CreateFileToolStripItem.Click += (obj, ev) => CreateFile();

            // Привязка метода открытия файла
            OpenFileStripItem.Click += (obj, ev) => OpenFile();
            OpenFileToolStripItem.Click += (obj, ev) => OpenFile();

            // Привязка метода сохранения файла
            SaveFileStripItem.Click += (obj, ev) => SaveFile(CurrentFilePath == "*.bin");
            SaveFileToolStripItem.Click += (obj, ev) => SaveFile(CurrentFilePath == "*.bin");

            SaveAsFileStripItem.Click += (obj, ev) => SaveFile(true);

            // Привязка метода добавления слова в дерево
            AddSetCreateModStripItem.Click += (obj, ev) => AddSetCreateMod();
            AddSetCreateModToolStripItem.Click += (obj, ev) => AddSetCreateMod();

            // Привязка метода удаления слова из дерева
            DeleteSetDeleteModStripItem.Click += (obj, ev) => DeleteSetDeleteMod();
            DeleteSetDeleteModToolStripItem.Click += (obj, ev) => DeleteSetDeleteMod();

            // Привязка метода очистки дерева
            ClearSetDeleteModStripItem.Click += (obj, ev) => ClearSetDeleteMod();
            ClearSetDeleteModToolStripItem.Click += (obj, ev) => ClearSetDeleteMod();

            // Привязка метода поиска слова в дереве
            FindSetOpStripItem.Click += (obj, ev) => FindSetOp();
            FindSetOpToolStripItem.Click += (obj, ev) => FindSetOp();

            // Привязка метода закрытия формы
            ExitStripItem.Click += (obj, ev) => Close();
            ExitToolStripItem.Click += (obj, ev) => Close();
            FormClosing += (obj, ev) => Exit(ev);

        }

        void UpdateState()
        {
            CreateFileStripItem.Enabled = CreateFileToolStripItem.Enabled = ValidateState(Actuators.Create);

            OpenFileStripItem.Enabled = OpenFileToolStripItem.Enabled = ValidateState(Actuators.Open);

            SaveFileStripItem.Enabled = SaveAsFileStripItem.Enabled = SaveFileToolStripItem.Enabled = ValidateState(Actuators.Save);

            AddSetCreateModStripItem.Enabled = AddSetCreateModToolStripItem.Enabled = ValidateState(Actuators.SetCreateMods);

            DeleteSetDeleteModStripItem.Enabled = DeleteSetDeleteModToolStripItem.Enabled =
            ClearSetDeleteModStripItem.Enabled = ClearSetDeleteModToolStripItem.Enabled = ValidateState(Actuators.SetDeleteMods);

            FindSetOpStripItem.Enabled = FindSetOpToolStripItem.Enabled = ValidateState(Actuators.SetOps);

            ExitStripItem.Enabled = ExitToolStripItem.Enabled = ValidateState(Actuators.Exit);
        }

        bool ValidateState(Actuators act)
        {
            return (State & act) == act;
        }

        private void DrawSet(HashSet<int, Record> set, DataGridView viewer)
        {
            viewer.Rows.Clear();
            if (!set.IsEmpty)
            {
                viewer.Columns.Add("PersonnelNumber", "Табельный номер");
                viewer.Columns.Add("FIO", "ФИО");
                viewer.Columns.Add("Salary", "Заработная плата");
                foreach (var entry in set)
                {
                    viewer.Rows.Add(entry.Value.PersonnelNumber, entry.Value.FIO, entry.Value.Salary);
                }
            }
        }
    }
}
