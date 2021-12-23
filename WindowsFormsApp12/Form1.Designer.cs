
namespace WindowsFormsApp12
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.абонентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.телефонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myConnect1 = new WindowsFormsApp12.MyConnect();
            this.абонентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.абонентTableAdapter = new WindowsFormsApp12.MyConnectTableAdapters.АбонентTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myConnect1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.абонентBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.абонентToolStripMenuItem,
            this.операторToolStripMenuItem,
            this.телефонToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+1";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // абонентToolStripMenuItem
            // 
            this.абонентToolStripMenuItem.Name = "абонентToolStripMenuItem";
            this.абонентToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+1";
            this.абонентToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.абонентToolStripMenuItem.Text = "Абонент";
            this.абонентToolStripMenuItem.Click += new System.EventHandler(this.абонентToolStripMenuItem_Click);
            // 
            // операторToolStripMenuItem
            // 
            this.операторToolStripMenuItem.Name = "операторToolStripMenuItem";
            this.операторToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+2";
            this.операторToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.операторToolStripMenuItem.Text = "Оператор";
            this.операторToolStripMenuItem.Click += new System.EventHandler(this.операторToolStripMenuItem_Click);
            // 
            // телефонToolStripMenuItem
            // 
            this.телефонToolStripMenuItem.Name = "телефонToolStripMenuItem";
            this.телефонToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+3";
            this.телефонToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.телефонToolStripMenuItem.Text = "Телефон";
            this.телефонToolStripMenuItem.Click += new System.EventHandler(this.телефонToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem1});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.ShortcutKeyDisplayString = "F1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.справкаToolStripMenuItem1.Text = "Справка";
            this.справкаToolStripMenuItem1.Click += new System.EventHandler(this.справкаToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Alt+X";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // myConnect1
            // 
            this.myConnect1.DataSetName = "MyConnect";
            this.myConnect1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // абонентBindingSource
            // 
            this.абонентBindingSource.DataMember = "Абонент";
            this.абонентBindingSource.DataSource = this.myConnect1;
            // 
            // абонентTableAdapter
            // 
            this.абонентTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 554);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "ИС \"Мобильная связь\" ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myConnect1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.абонентBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem абонентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem телефонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MyConnect myConnect1;
        private System.Windows.Forms.BindingSource абонентBindingSource;
        private MyConnectTableAdapters.АбонентTableAdapter абонентTableAdapter;
    }
}

