
namespace STRIALG_TRIE
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateFileStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsFileStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.ExitStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTreeModStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteTreeModStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearTreeModStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindTreeOpStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CreateFileToolStripItem = new System.Windows.Forms.ToolStripButton();
            this.OpenFileToolStripItem = new System.Windows.Forms.ToolStripButton();
            this.SaveFileToolStripItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddTreeModToolStripItem = new System.Windows.Forms.ToolStripButton();
            this.DeleteTreeModToolStripItem = new System.Windows.Forms.ToolStripButton();
            this.ClearTreeModToolStripItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FindTreeOpToolStripItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripItem = new System.Windows.Forms.ToolStripButton();
            this.MainTreeView = new System.Windows.Forms.TreeView();
            this.SaveFileDialogWindow = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialogWindow = new System.Windows.Forms.OpenFileDialog();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редактированиеToolStripMenuItem,
            this.поискToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(375, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateFileStripItem,
            this.OpenFileStripItem,
            this.SaveFileStripItem,
            this.SaveAsFileStripItem,
            this.dToolStripMenuItem,
            this.ExitStripItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // CreateFileStripItem
            // 
            this.CreateFileStripItem.Name = "CreateFileStripItem";
            this.CreateFileStripItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.CreateFileStripItem.Size = new System.Drawing.Size(224, 26);
            this.CreateFileStripItem.Text = "Новый...";
            // 
            // OpenFileStripItem
            // 
            this.OpenFileStripItem.Name = "OpenFileStripItem";
            this.OpenFileStripItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.OpenFileStripItem.Size = new System.Drawing.Size(224, 26);
            this.OpenFileStripItem.Text = "Открыть...";
            // 
            // SaveFileStripItem
            // 
            this.SaveFileStripItem.Name = "SaveFileStripItem";
            this.SaveFileStripItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.SaveFileStripItem.Size = new System.Drawing.Size(224, 26);
            this.SaveFileStripItem.Text = "Сохранить";
            // 
            // SaveAsFileStripItem
            // 
            this.SaveAsFileStripItem.Name = "SaveAsFileStripItem";
            this.SaveAsFileStripItem.Size = new System.Drawing.Size(224, 26);
            this.SaveAsFileStripItem.Text = "Сохранить как...";
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(221, 6);
            // 
            // ExitStripItem
            // 
            this.ExitStripItem.Name = "ExitStripItem";
            this.ExitStripItem.ShortcutKeyDisplayString = "Ctrl+Q";
            this.ExitStripItem.Size = new System.Drawing.Size(224, 26);
            this.ExitStripItem.Text = "Выйти";
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTreeModStripItem,
            this.DeleteTreeModStripItem,
            this.ClearTreeModStripItem});
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            // 
            // AddTreeModStripItem
            // 
            this.AddTreeModStripItem.Name = "AddTreeModStripItem";
            this.AddTreeModStripItem.ShortcutKeyDisplayString = "Ctrl+A";
            this.AddTreeModStripItem.Size = new System.Drawing.Size(270, 26);
            this.AddTreeModStripItem.Text = "Добавить слово...";
            // 
            // DeleteTreeModStripItem
            // 
            this.DeleteTreeModStripItem.Name = "DeleteTreeModStripItem";
            this.DeleteTreeModStripItem.ShortcutKeyDisplayString = "Ctrl+D";
            this.DeleteTreeModStripItem.Size = new System.Drawing.Size(270, 26);
            this.DeleteTreeModStripItem.Text = "Удалить слово...";
            // 
            // ClearTreeModStripItem
            // 
            this.ClearTreeModStripItem.Name = "ClearTreeModStripItem";
            this.ClearTreeModStripItem.ShortcutKeyDisplayString = "Ctrl+K";
            this.ClearTreeModStripItem.Size = new System.Drawing.Size(270, 26);
            this.ClearTreeModStripItem.Text = "Очистить дерево...";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FindTreeOpStripItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // FindTreeOpStripItem
            // 
            this.FindTreeOpStripItem.Name = "FindTreeOpStripItem";
            this.FindTreeOpStripItem.ShortcutKeyDisplayString = "Ctrl+F";
            this.FindTreeOpStripItem.Size = new System.Drawing.Size(237, 26);
            this.FindTreeOpStripItem.Text = "Поиск слова...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateFileToolStripItem,
            this.OpenFileToolStripItem,
            this.SaveFileToolStripItem,
            this.toolStripSeparator1,
            this.AddTreeModToolStripItem,
            this.DeleteTreeModToolStripItem,
            this.ClearTreeModToolStripItem,
            this.toolStripSeparator2,
            this.FindTreeOpToolStripItem,
            this.toolStripSeparator3,
            this.ExitToolStripItem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(375, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CreateFileToolStripItem
            // 
            this.CreateFileToolStripItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CreateFileToolStripItem.Image = ((System.Drawing.Image)(resources.GetObject("CreateFileToolStripItem.Image")));
            this.CreateFileToolStripItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateFileToolStripItem.Name = "CreateFileToolStripItem";
            this.CreateFileToolStripItem.Size = new System.Drawing.Size(29, 24);
            this.CreateFileToolStripItem.Text = "Новый (Ctrl+N)";
            // 
            // OpenFileToolStripItem
            // 
            this.OpenFileToolStripItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenFileToolStripItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenFileToolStripItem.Image")));
            this.OpenFileToolStripItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFileToolStripItem.Name = "OpenFileToolStripItem";
            this.OpenFileToolStripItem.Size = new System.Drawing.Size(29, 24);
            this.OpenFileToolStripItem.Text = "Открыть (Ctrl+O)";
            // 
            // SaveFileToolStripItem
            // 
            this.SaveFileToolStripItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveFileToolStripItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveFileToolStripItem.Image")));
            this.SaveFileToolStripItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveFileToolStripItem.Name = "SaveFileToolStripItem";
            this.SaveFileToolStripItem.Size = new System.Drawing.Size(29, 24);
            this.SaveFileToolStripItem.Text = "Сохранить (Ctrl+S)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // AddTreeModToolStripItem
            // 
            this.AddTreeModToolStripItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddTreeModToolStripItem.Image = ((System.Drawing.Image)(resources.GetObject("AddTreeModToolStripItem.Image")));
            this.AddTreeModToolStripItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddTreeModToolStripItem.Name = "AddTreeModToolStripItem";
            this.AddTreeModToolStripItem.Size = new System.Drawing.Size(29, 24);
            this.AddTreeModToolStripItem.Text = "Добавить слово (Ctrl+A)";
            // 
            // DeleteTreeModToolStripItem
            // 
            this.DeleteTreeModToolStripItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteTreeModToolStripItem.Image = ((System.Drawing.Image)(resources.GetObject("DeleteTreeModToolStripItem.Image")));
            this.DeleteTreeModToolStripItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteTreeModToolStripItem.Name = "DeleteTreeModToolStripItem";
            this.DeleteTreeModToolStripItem.Size = new System.Drawing.Size(29, 24);
            this.DeleteTreeModToolStripItem.Text = "Удалить слово (Ctrl+D)";
            // 
            // ClearTreeModToolStripItem
            // 
            this.ClearTreeModToolStripItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearTreeModToolStripItem.Image = ((System.Drawing.Image)(resources.GetObject("ClearTreeModToolStripItem.Image")));
            this.ClearTreeModToolStripItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearTreeModToolStripItem.Name = "ClearTreeModToolStripItem";
            this.ClearTreeModToolStripItem.Size = new System.Drawing.Size(29, 24);
            this.ClearTreeModToolStripItem.Text = "Очистить дерево (Ctrl+K)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // FindTreeOpToolStripItem
            // 
            this.FindTreeOpToolStripItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FindTreeOpToolStripItem.Image = ((System.Drawing.Image)(resources.GetObject("FindTreeOpToolStripItem.Image")));
            this.FindTreeOpToolStripItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FindTreeOpToolStripItem.Name = "FindTreeOpToolStripItem";
            this.FindTreeOpToolStripItem.Size = new System.Drawing.Size(29, 24);
            this.FindTreeOpToolStripItem.Text = "Найти слово (Ctrl+F)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // ExitToolStripItem
            // 
            this.ExitToolStripItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExitToolStripItem.Image = ((System.Drawing.Image)(resources.GetObject("ExitToolStripItem.Image")));
            this.ExitToolStripItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitToolStripItem.Name = "ExitToolStripItem";
            this.ExitToolStripItem.Size = new System.Drawing.Size(29, 24);
            this.ExitToolStripItem.Text = "Выйти (Ctrl+Q)";
            // 
            // MainTreeView
            // 
            this.MainTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTreeView.Location = new System.Drawing.Point(12, 95);
            this.MainTreeView.Name = "MainTreeView";
            this.MainTreeView.Size = new System.Drawing.Size(351, 348);
            this.MainTreeView.TabIndex = 2;
            // 
            // SaveFileDialogWindow
            // 
            this.SaveFileDialogWindow.DefaultExt = "txt";
            this.SaveFileDialogWindow.Filter = "\"Текстовые файлы|*.txt\"";
            // 
            // OpenFileDialogWindow
            // 
            this.OpenFileDialogWindow.DefaultExt = "txt";
            this.OpenFileDialogWindow.Filter = "\"Текстовые файлы|*.txt\"";
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileNameLabel.Location = new System.Drawing.Point(12, 67);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(64, 25);
            this.FileNameLabel.TabIndex = 3;
            this.FileNameLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 455);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.MainTreeView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(393, 500);
            this.MinimumSize = new System.Drawing.Size(393, 500);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Trie-дерево";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton CreateFileToolStripItem;
        private System.Windows.Forms.ToolStripButton OpenFileToolStripItem;
        private System.Windows.Forms.ToolStripButton SaveFileToolStripItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton AddTreeModToolStripItem;
        private System.Windows.Forms.ToolStripButton DeleteTreeModToolStripItem;
        private System.Windows.Forms.ToolStripButton ClearTreeModToolStripItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton FindTreeOpToolStripItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ExitToolStripItem;
        private System.Windows.Forms.TreeView MainTreeView;
        private System.Windows.Forms.ToolStripMenuItem CreateFileStripItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileStripItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFileStripItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsFileStripItem;
        private System.Windows.Forms.ToolStripMenuItem AddTreeModStripItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteTreeModStripItem;
        private System.Windows.Forms.ToolStripMenuItem ClearTreeModStripItem;
        private System.Windows.Forms.ToolStripMenuItem FindTreeOpStripItem;
        private System.Windows.Forms.ToolStripSeparator dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitStripItem;
        private System.Windows.Forms.SaveFileDialog SaveFileDialogWindow;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogWindow;
        private System.Windows.Forms.Label FileNameLabel;
    }
}

