using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace STRIALG_TRIE
{
    public partial class Form1 : Form
    {
        bool HasUnsavedData = false;
        string CurrentFilePath = "*.txt";
        TrieTree MainTree;

        [Flags]
        public enum Actuators
        {
            All = -1,
            None = 0,
            Create = 1,
            Open = 2,
            Save = 4,
            TreeOps = 8,
            Exit = 16
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
                        HasUnsavedData = !SaveFile(CurrentFilePath == "*.txt");
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

            FileNameLabel.Text = CurrentFilePath = "*.txt";
            MainTree = new TrieTree();
            HasUnsavedData = true;

            State = Actuators.All;
            UpdateState();
        }

        public void OpenFile()
        {
            if (!VerifySave()) return;

            if (OpenFileDialogWindow.ShowDialog(this) == DialogResult.OK)
            {
                FileNameLabel.Text = CurrentFilePath = OpenFileDialogWindow.FileName;
                FileNameLabel.Text = FileNameLabel.Text.Remove(0, FileNameLabel.Text.LastIndexOf('\\') + 1);
                StreamReader text = new StreamReader(CurrentFilePath);
                MainTree = new TrieTree();
                while (!text.EndOfStream)
                {
                    MainTree.AddWord(text.ReadLine());
                }
                text.Close();
                DrawTree(MainTree, MainTreeView);

                HasUnsavedData = false;

                State = Actuators.All;
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
            StreamWriter text = new StreamWriter(CurrentFilePath, false);
            foreach (string s in MainTree)
            {
                text.WriteLine(s);
            }
            text.Close();

            HasUnsavedData = false;
            return true;
        }

        public void AddTreeMod()
        {
            WordsForm tmp = new WordsForm("Добавить", "Введите слово или слова:");
            if (tmp.ShowDialog(this) == DialogResult.OK)
            {
                HasUnsavedData = true;
                MainTree.AddWords(tmp.Output);
                DrawTree(MainTree, MainTreeView);
            }
        }

        public void DeleteTreeMod()
        {
            WordsForm tmp = new WordsForm("Удалить", "Введите слово или слова:");
            if (tmp.ShowDialog(this) == DialogResult.OK)
            {
                HasUnsavedData = true;
                MainTree.DeleteWords(tmp.Output);
                DrawTree(MainTree, MainTreeView);
            }
        }

        public void ClearTreeMod()
        {
            HasUnsavedData = true;
            MainTree.ClearTree();
            MainTreeView.Nodes.Clear();
        }

        public void FindTreeOp()
        {
            WordsForm tmp = new WordsForm("Найти", "Введите слово или слова:");
            if (tmp.ShowDialog(this) == DialogResult.OK)
            {
                string buffer = "";
                string[] tmps = tmp.Output.ToWords();
                bool[] tmpb = MainTree.FindWords(tmp.Output);
                for (int i = 0; i < tmps.Length; i++)
                {
                    buffer += $"{i + 1}. Слово \"{tmps[i]}\" {(tmpb[i] ? "при" : "от")}сутствует в дереве.\n";
                }
                MessageBox.Show(this, buffer, "Результат", MessageBoxButtons.OK);
            }
        }

        public void SuggestTreeOp()
        {
            UseWaitCursor = true;
            WordsForm tmp = new WordsForm("Достроить слово", "Введите часть слова:", WordsForm.InputFormat.Word);
            if (tmp.ShowDialog(this) == DialogResult.OK)
            {
                string req = tmp.Output.ToWord();
                string buffer = $"Возможные продолжения {req}-\n";
                string[] tmpres = MainTree.Suggest(tmp.Output);
                for (int i = 0; i < tmpres.Length - 1; i++)
                {
                    buffer += $"{req}{tmpres[i]}, ";
                }
                if (tmpres.Length != 0) buffer += $"{req}{tmpres[tmpres.Length - 1]}.";
                MessageBox.Show(this, buffer, "Результат", MessageBoxButtons.OK);
            }
            UseWaitCursor = false;
        }

        public void TaskTreeOp()
        {
            WordsForm tmp = new WordsForm("Удалить по букве", "Введите букву:", WordsForm.InputFormat.Letter);
            if (tmp.ShowDialog(this) == DialogResult.OK)
            {
                HasUnsavedData = true;
                char c = tmp.Output[0];
                MainTree.DeleteByLetter(c);
                DrawTree(MainTree, MainTreeView);
            }
        }

        public void Exit(CancelEventArgs e) => e.Cancel = !VerifySave();

        public Form1()
        {
            InitializeComponent();

            UpdateState();

            FileNameLabel.Text = "*.txt";
            SaveFileDialogWindow.Filter = OpenFileDialogWindow.Filter = "Текстовые файлы|*.txt";

            // Привязка метода создания файла
            CreateFileStripItem.Click += (obj, ev) => CreateFile();
            CreateFileToolStripItem.Click += (obj, ev) => CreateFile();

            // Привязка метода открытия файла
            OpenFileStripItem.Click += (obj, ev) => OpenFile();
            OpenFileToolStripItem.Click += (obj, ev) => OpenFile();

            // Привязка метода сохранения файла
            SaveFileStripItem.Click += (obj, ev) => SaveFile(CurrentFilePath == "*.txt");
            SaveFileToolStripItem.Click += (obj, ev) => SaveFile(CurrentFilePath == "*.txt");

            SaveAsFileStripItem.Click += (obj, ev) => SaveFile(true);

            // Привязка метода добавления слова в дерево
            AddTreeModStripItem.Click += (obj, ev) => AddTreeMod();
            AddTreeModToolStripItem.Click += (obj, ev) => AddTreeMod();

            // Привязка метода удаления слова из дерева
            DeleteTreeModStripItem.Click += (obj, ev) => DeleteTreeMod();
            DeleteTreeModToolStripItem.Click += (obj, ev) => DeleteTreeMod();

            // Привязка метода очистки дерева
            ClearTreeModStripItem.Click += (obj, ev) => ClearTreeMod();
            ClearTreeModToolStripItem.Click += (obj, ev) => ClearTreeMod();

            // Привязка метода поиска слова в дереве
            FindTreeOpStripItem.Click += (obj, ev) => FindTreeOp();
            FindTreeOpToolStripItem.Click += (obj, ev) => FindTreeOp();

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

            AddTreeModStripItem.Enabled = AddTreeModToolStripItem.Enabled =
            DeleteTreeModStripItem.Enabled = DeleteTreeModToolStripItem.Enabled =
            ClearTreeModStripItem.Enabled = ClearTreeModToolStripItem.Enabled =
            FindTreeOpStripItem.Enabled = FindTreeOpToolStripItem.Enabled = ValidateState(Actuators.TreeOps);


            ExitStripItem.Enabled = ExitToolStripItem.Enabled = ValidateState(Actuators.Exit);
        }

        bool ValidateState(Actuators act)
        {
            return (State & act) == act;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.N:
                    {
                        if (ValidateState(Actuators.Create)) CreateFile();
                        break;
                    }
                    case Keys.O:
                    {
                        if (ValidateState(Actuators.Open)) OpenFile();
                        break;
                    }
                    case Keys.S:
                    {
                        if (ValidateState(Actuators.Save)) SaveFile(CurrentFilePath == "*.txt");
                        break;
                    }
                    case Keys.A:
                    {
                        if (ValidateState(Actuators.TreeOps)) AddTreeMod();
                        break;
                    }
                    case Keys.D:
                    {
                        if (ValidateState(Actuators.TreeOps)) DeleteTreeMod();
                        break;
                    }
                    case Keys.K:
                    {
                        if (ValidateState(Actuators.TreeOps)) ClearTreeMod();
                        break;
                    }
                    case Keys.F:
                    {
                        if (ValidateState(Actuators.TreeOps)) FindTreeOp();
                        break;
                    }
                    case Keys.P:
                    {
                        if (ValidateState(Actuators.TreeOps)) SuggestTreeOp();
                        break;
                    }
                    case Keys.T:
                    {
                        if (ValidateState(Actuators.TreeOps)) TaskTreeOp();
                        break;
                    }
                    case Keys.Q:
                    {
                        if (ValidateState(Actuators.Exit)) Close();
                        break;
                    }
                }
            }
        }

        private void DrawTree(TrieTree tree, TreeView viewer)
        {
            viewer.Nodes.Clear();
            if (!tree.IsEmpty) viewer.Nodes.Add(tree.ToNode("Корневой элемент"));
        }
    }
}
