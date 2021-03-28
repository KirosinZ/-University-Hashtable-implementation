
namespace STRIALG_HASH
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
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateFileStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsFileStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.ExitStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddSetCreateModStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteSetDeleteModStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearSetDeleteModStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindSetOpStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CreateFileToolStripItem = new System.Windows.Forms.ToolStripButton();
            this.OpenFileToolStripItem = new System.Windows.Forms.ToolStripButton();
            this.SaveFileToolStripItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddSetCreateModToolStripItem = new System.Windows.Forms.ToolStripButton();
            this.DeleteSetDeleteModToolStripItem = new System.Windows.Forms.ToolStripButton();
            this.ClearSetDeleteModToolStripItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FindSetOpToolStripItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripItem = new System.Windows.Forms.ToolStripButton();
            this.SaveFileDialogWindow = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialogWindow = new System.Windows.Forms.OpenFileDialog();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditingToolStripMenuItem,
            this.SearchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(375, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateFileStripItem,
            this.OpenFileStripItem,
            this.SaveFileStripItem,
            this.SaveAsFileStripItem,
            this.dToolStripMenuItem,
            this.ExitStripItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // CreateFileStripItem
            // 
            this.CreateFileStripItem.Name = "CreateFileStripItem";
            this.CreateFileStripItem.ShortcutKeyDisplayString = "";
            this.CreateFileStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.CreateFileStripItem.Size = new System.Drawing.Size(224, 26);
            this.CreateFileStripItem.Text = "Новый...";
            // 
            // OpenFileStripItem
            // 
            this.OpenFileStripItem.Name = "OpenFileStripItem";
            this.OpenFileStripItem.ShortcutKeyDisplayString = "";
            this.OpenFileStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenFileStripItem.Size = new System.Drawing.Size(224, 26);
            this.OpenFileStripItem.Text = "Открыть...";
            // 
            // SaveFileStripItem
            // 
            this.SaveFileStripItem.Name = "SaveFileStripItem";
            this.SaveFileStripItem.ShortcutKeyDisplayString = "";
            this.SaveFileStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
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
            this.ExitStripItem.ShortcutKeyDisplayString = "";
            this.ExitStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.ExitStripItem.Size = new System.Drawing.Size(224, 26);
            this.ExitStripItem.Text = "Выйти";
            // 
            // EditingToolStripMenuItem
            // 
            this.EditingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSetCreateModStripItem,
            this.DeleteSetDeleteModStripItem,
            this.ClearSetDeleteModStripItem});
            this.EditingToolStripMenuItem.Name = "EditingToolStripMenuItem";
            this.EditingToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.EditingToolStripMenuItem.Text = "Редактирование";
            // 
            // AddSetCreateModStripItem
            // 
            this.AddSetCreateModStripItem.Name = "AddSetCreateModStripItem";
            this.AddSetCreateModStripItem.ShortcutKeyDisplayString = "";
            this.AddSetCreateModStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.AddSetCreateModStripItem.Size = new System.Drawing.Size(270, 26);
            this.AddSetCreateModStripItem.Text = "Добавить слово...";
            // 
            // DeleteSetDeleteModStripItem
            // 
            this.DeleteSetDeleteModStripItem.Name = "DeleteSetDeleteModStripItem";
            this.DeleteSetDeleteModStripItem.ShortcutKeyDisplayString = "";
            this.DeleteSetDeleteModStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.DeleteSetDeleteModStripItem.Size = new System.Drawing.Size(270, 26);
            this.DeleteSetDeleteModStripItem.Text = "Удалить слово...";
            // 
            // ClearSetDeleteModStripItem
            // 
            this.ClearSetDeleteModStripItem.Name = "ClearSetDeleteModStripItem";
            this.ClearSetDeleteModStripItem.ShortcutKeyDisplayString = "";
            this.ClearSetDeleteModStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.ClearSetDeleteModStripItem.Size = new System.Drawing.Size(270, 26);
            this.ClearSetDeleteModStripItem.Text = "Очистить дерево...";
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FindSetOpStripItem});
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.SearchToolStripMenuItem.Text = "Поиск";
            // 
            // FindSetOpStripItem
            // 
            this.FindSetOpStripItem.Name = "FindSetOpStripItem";
            this.FindSetOpStripItem.ShortcutKeyDisplayString = "";
            this.FindSetOpStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.FindSetOpStripItem.Size = new System.Drawing.Size(237, 26);
            this.FindSetOpStripItem.Text = "Поиск слова...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateFileToolStripItem,
            this.OpenFileToolStripItem,
            this.SaveFileToolStripItem,
            this.toolStripSeparator1,
            this.AddSetCreateModToolStripItem,
            this.DeleteSetDeleteModToolStripItem,
            this.ClearSetDeleteModToolStripItem,
            this.toolStripSeparator2,
            this.FindSetOpToolStripItem,
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
            // AddSetCreateModToolStripItem
            // 
            this.AddSetCreateModToolStripItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddSetCreateModToolStripItem.Image = ((System.Drawing.Image)(resources.GetObject("AddSetCreateModToolStripItem.Image")));
            this.AddSetCreateModToolStripItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddSetCreateModToolStripItem.Name = "AddSetCreateModToolStripItem";
            this.AddSetCreateModToolStripItem.Size = new System.Drawing.Size(29, 24);
            this.AddSetCreateModToolStripItem.Text = "Добавить слово (Ctrl+A)";
            // 
            // DeleteSetDeleteModToolStripItem
            // 
            this.DeleteSetDeleteModToolStripItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteSetDeleteModToolStripItem.Image = ((System.Drawing.Image)(resources.GetObject("DeleteSetDeleteModToolStripItem.Image")));
            this.DeleteSetDeleteModToolStripItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteSetDeleteModToolStripItem.Name = "DeleteSetDeleteModToolStripItem";
            this.DeleteSetDeleteModToolStripItem.Size = new System.Drawing.Size(29, 24);
            this.DeleteSetDeleteModToolStripItem.Text = "Удалить слово (Ctrl+D)";
            // 
            // ClearSetDeleteModToolStripItem
            // 
            this.ClearSetDeleteModToolStripItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearSetDeleteModToolStripItem.Image = ((System.Drawing.Image)(resources.GetObject("ClearSetDeleteModToolStripItem.Image")));
            this.ClearSetDeleteModToolStripItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearSetDeleteModToolStripItem.Name = "ClearSetDeleteModToolStripItem";
            this.ClearSetDeleteModToolStripItem.Size = new System.Drawing.Size(29, 24);
            this.ClearSetDeleteModToolStripItem.Text = "Очистить дерево (Ctrl+K)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // FindSetOpToolStripItem
            // 
            this.FindSetOpToolStripItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FindSetOpToolStripItem.Image = ((System.Drawing.Image)(resources.GetObject("FindSetOpToolStripItem.Image")));
            this.FindSetOpToolStripItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FindSetOpToolStripItem.Name = "FindSetOpToolStripItem";
            this.FindSetOpToolStripItem.Size = new System.Drawing.Size(29, 24);
            this.FindSetOpToolStripItem.Text = "Найти слово (Ctrl+F)";
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
            // SaveFileDialogWindow
            // 
            this.SaveFileDialogWindow.DefaultExt = "txt";
            this.SaveFileDialogWindow.Filter = "\"Текстовые файлы|*.txt|Типизированные файлы|*.bin\"";
            // 
            // OpenFileDialogWindow
            // 
            this.OpenFileDialogWindow.DefaultExt = "txt";
            this.OpenFileDialogWindow.Filter = "\"Текстовые файлы|*.txt|Типизированные файлы|*.bin\"";
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
            // MainDataGridView
            // 
            this.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGridView.Location = new System.Drawing.Point(12, 95);
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.RowHeadersWidth = 51;
            this.MainDataGridView.RowTemplate.Height = 24;
            this.MainDataGridView.Size = new System.Drawing.Size(351, 348);
            this.MainDataGridView.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 455);
            this.Controls.Add(this.MainDataGridView);
            this.Controls.Add(this.FileNameLabel);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton CreateFileToolStripItem;
        private System.Windows.Forms.ToolStripButton OpenFileToolStripItem;
        private System.Windows.Forms.ToolStripButton SaveFileToolStripItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton AddSetCreateModToolStripItem;
        private System.Windows.Forms.ToolStripButton DeleteSetDeleteModToolStripItem;
        private System.Windows.Forms.ToolStripButton ClearSetDeleteModToolStripItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton FindSetOpToolStripItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ExitToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem CreateFileStripItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileStripItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFileStripItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsFileStripItem;
        private System.Windows.Forms.ToolStripMenuItem AddSetCreateModStripItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteSetDeleteModStripItem;
        private System.Windows.Forms.ToolStripMenuItem ClearSetDeleteModStripItem;
        private System.Windows.Forms.ToolStripMenuItem FindSetOpStripItem;
        private System.Windows.Forms.ToolStripSeparator dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitStripItem;
        private System.Windows.Forms.SaveFileDialog SaveFileDialogWindow;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogWindow;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.DataGridView MainDataGridView;
    }
}

