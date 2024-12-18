namespace App_with_MongoDb
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtConnectionUri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEditDocument = new System.Windows.Forms.Button();
            this.btnToggleFilters = new System.Windows.Forms.Button();
            this.lblDocumentCounter = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.richTextBoxDocument = new System.Windows.Forms.RichTextBox();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteDocument = new System.Windows.Forms.Button();
            this.btnAddDocument = new System.Windows.Forms.Button();
            this.TreeViewDatabases = new System.Windows.Forms.TreeView();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxAdd = new System.Windows.Forms.ListBox();
            this.btnAddDocumentAdd = new System.Windows.Forms.Button();
            this.btnResetAdd = new System.Windows.Forms.Button();
            this.btnApplyAdd = new System.Windows.Forms.Button();
            this.txtAddValue = new System.Windows.Forms.TextBox();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxDelete = new System.Windows.Forms.ListBox();
            this.btnAddDocumentDelete = new System.Windows.Forms.Button();
            this.btnResetDelete = new System.Windows.Forms.Button();
            this.btnApplyDelete = new System.Windows.Forms.Button();
            this.txtDeleteValue = new System.Windows.Forms.TextBox();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.richTextBoxEdit = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnResetEdit = new System.Windows.Forms.Button();
            this.btnApplyEdit = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxFilters = new System.Windows.Forms.ListBox();
            this.comboBoxOperators = new System.Windows.Forms.ComboBox();
            this.btnAddFilter = new System.Windows.Forms.Button();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.comboFilterField = new System.Windows.Forms.ComboBox();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.panelDelete.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panelFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(982, 697);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblStatus);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnConnect);
            this.tabPage1.Controls.Add(this.txtConnectionUri);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(974, 659);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Підключення";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(289, 186);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(36, 25);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Статус підключення:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(341, 246);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(300, 45);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Підключитися";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtConnectionUri
            // 
            this.txtConnectionUri.Location = new System.Drawing.Point(128, 128);
            this.txtConnectionUri.Name = "txtConnectionUri";
            this.txtConnectionUri.Size = new System.Drawing.Size(825, 34);
            this.txtConnectionUri.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "URI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "URI підключення";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEditDocument);
            this.tabPage2.Controls.Add(this.btnToggleFilters);
            this.tabPage2.Controls.Add(this.lblDocumentCounter);
            this.tabPage2.Controls.Add(this.btnNext);
            this.tabPage2.Controls.Add(this.btnPrevious);
            this.tabPage2.Controls.Add(this.richTextBoxDocument);
            this.tabPage2.Controls.Add(this.LabelStatus);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnDeleteDocument);
            this.tabPage2.Controls.Add(this.btnAddDocument);
            this.tabPage2.Controls.Add(this.TreeViewDatabases);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(974, 659);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "БД / Колекції / Документи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEditDocument
            // 
            this.btnEditDocument.Location = new System.Drawing.Point(341, 523);
            this.btnEditDocument.Name = "btnEditDocument";
            this.btnEditDocument.Size = new System.Drawing.Size(300, 45);
            this.btnEditDocument.TabIndex = 14;
            this.btnEditDocument.Text = "Редагувати документ";
            this.btnEditDocument.UseVisualStyleBackColor = true;
            this.btnEditDocument.Click += new System.EventHandler(this.btnEditDocument_Click);
            // 
            // btnToggleFilters
            // 
            this.btnToggleFilters.Location = new System.Drawing.Point(341, 584);
            this.btnToggleFilters.Name = "btnToggleFilters";
            this.btnToggleFilters.Size = new System.Drawing.Size(300, 45);
            this.btnToggleFilters.TabIndex = 13;
            this.btnToggleFilters.Text = "Налаштувати фільтри";
            this.btnToggleFilters.UseVisualStyleBackColor = true;
            this.btnToggleFilters.Click += new System.EventHandler(this.btnToggleFilters_Click);
            // 
            // lblDocumentCounter
            // 
            this.lblDocumentCounter.AutoSize = true;
            this.lblDocumentCounter.Location = new System.Drawing.Point(725, 92);
            this.lblDocumentCounter.Name = "lblDocumentCounter";
            this.lblDocumentCounter.Size = new System.Drawing.Size(36, 25);
            this.lblDocumentCounter.TabIndex = 11;
            this.lblDocumentCounter.Text = "---";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(842, 89);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 30);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(564, 89);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 30);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // richTextBoxDocument
            // 
            this.richTextBoxDocument.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDocument.Location = new System.Drawing.Point(518, 125);
            this.richTextBoxDocument.Name = "richTextBoxDocument";
            this.richTextBoxDocument.Size = new System.Drawing.Size(450, 367);
            this.richTextBoxDocument.TabIndex = 8;
            this.richTextBoxDocument.Text = "";
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Location = new System.Drawing.Point(148, 35);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(36, 25);
            this.LabelStatus.TabIndex = 7;
            this.LabelStatus.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Статус:";
            // 
            // btnDeleteDocument
            // 
            this.btnDeleteDocument.Location = new System.Drawing.Point(668, 523);
            this.btnDeleteDocument.Name = "btnDeleteDocument";
            this.btnDeleteDocument.Size = new System.Drawing.Size(300, 45);
            this.btnDeleteDocument.TabIndex = 4;
            this.btnDeleteDocument.Text = "Видалити документ";
            this.btnDeleteDocument.UseVisualStyleBackColor = true;
            this.btnDeleteDocument.Click += new System.EventHandler(this.btnDeleteDocument_Click);
            // 
            // btnAddDocument
            // 
            this.btnAddDocument.Location = new System.Drawing.Point(6, 523);
            this.btnAddDocument.Name = "btnAddDocument";
            this.btnAddDocument.Size = new System.Drawing.Size(300, 45);
            this.btnAddDocument.TabIndex = 3;
            this.btnAddDocument.Text = "Додати документ";
            this.btnAddDocument.UseVisualStyleBackColor = true;
            this.btnAddDocument.Click += new System.EventHandler(this.btnAddDocument_Click);
            // 
            // TreeViewDatabases
            // 
            this.TreeViewDatabases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TreeViewDatabases.Location = new System.Drawing.Point(3, 92);
            this.TreeViewDatabases.Name = "TreeViewDatabases";
            this.TreeViewDatabases.Size = new System.Drawing.Size(450, 400);
            this.TreeViewDatabases.TabIndex = 0;
            this.TreeViewDatabases.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewDatabases_AfterSelect);
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.label8);
            this.panelAdd.Controls.Add(this.label4);
            this.panelAdd.Controls.Add(this.listBoxAdd);
            this.panelAdd.Controls.Add(this.btnAddDocumentAdd);
            this.panelAdd.Controls.Add(this.btnResetAdd);
            this.panelAdd.Controls.Add(this.btnApplyAdd);
            this.panelAdd.Controls.Add(this.txtAddValue);
            this.panelAdd.Location = new System.Drawing.Point(3, 22);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(344, 602);
            this.panelAdd.TabIndex = 7;
            this.panelAdd.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Додавання документу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "name:";
            // 
            // listBoxAdd
            // 
            this.listBoxAdd.FormattingEnabled = true;
            this.listBoxAdd.ItemHeight = 25;
            this.listBoxAdd.Location = new System.Drawing.Point(26, 106);
            this.listBoxAdd.Name = "listBoxAdd";
            this.listBoxAdd.Size = new System.Drawing.Size(300, 204);
            this.listBoxAdd.TabIndex = 6;
            // 
            // btnAddDocumentAdd
            // 
            this.btnAddDocumentAdd.Location = new System.Drawing.Point(25, 452);
            this.btnAddDocumentAdd.Name = "btnAddDocumentAdd";
            this.btnAddDocumentAdd.Size = new System.Drawing.Size(300, 45);
            this.btnAddDocumentAdd.TabIndex = 4;
            this.btnAddDocumentAdd.Text = "Додати документ";
            this.btnAddDocumentAdd.UseVisualStyleBackColor = true;
            this.btnAddDocumentAdd.Click += new System.EventHandler(this.btnAddDocumentAdd_Click);
            // 
            // btnResetAdd
            // 
            this.btnResetAdd.Location = new System.Drawing.Point(25, 503);
            this.btnResetAdd.Name = "btnResetAdd";
            this.btnResetAdd.Size = new System.Drawing.Size(300, 45);
            this.btnResetAdd.TabIndex = 3;
            this.btnResetAdd.Text = "Скинути документи";
            this.btnResetAdd.UseVisualStyleBackColor = true;
            this.btnResetAdd.Click += new System.EventHandler(this.btnResetAdd_Click);
            // 
            // btnApplyAdd
            // 
            this.btnApplyAdd.Location = new System.Drawing.Point(25, 554);
            this.btnApplyAdd.Name = "btnApplyAdd";
            this.btnApplyAdd.Size = new System.Drawing.Size(300, 45);
            this.btnApplyAdd.TabIndex = 2;
            this.btnApplyAdd.Text = "Виконати додавання";
            this.btnApplyAdd.UseVisualStyleBackColor = true;
            this.btnApplyAdd.Click += new System.EventHandler(this.btnApplyAdd_Click);
            // 
            // txtAddValue
            // 
            this.txtAddValue.Location = new System.Drawing.Point(102, 66);
            this.txtAddValue.Name = "txtAddValue";
            this.txtAddValue.Size = new System.Drawing.Size(224, 34);
            this.txtAddValue.TabIndex = 1;
            // 
            // panelDelete
            // 
            this.panelDelete.Controls.Add(this.label7);
            this.panelDelete.Controls.Add(this.label6);
            this.panelDelete.Controls.Add(this.listBoxDelete);
            this.panelDelete.Controls.Add(this.btnAddDocumentDelete);
            this.panelDelete.Controls.Add(this.btnResetDelete);
            this.panelDelete.Controls.Add(this.btnApplyDelete);
            this.panelDelete.Controls.Add(this.txtDeleteValue);
            this.panelDelete.Location = new System.Drawing.Point(3, 10);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(344, 602);
            this.panelDelete.TabIndex = 8;
            this.panelDelete.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Видалення документу";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "name:";
            // 
            // listBoxDelete
            // 
            this.listBoxDelete.FormattingEnabled = true;
            this.listBoxDelete.ItemHeight = 25;
            this.listBoxDelete.Location = new System.Drawing.Point(25, 105);
            this.listBoxDelete.Name = "listBoxDelete";
            this.listBoxDelete.Size = new System.Drawing.Size(300, 204);
            this.listBoxDelete.TabIndex = 6;
            // 
            // btnAddDocumentDelete
            // 
            this.btnAddDocumentDelete.Location = new System.Drawing.Point(25, 452);
            this.btnAddDocumentDelete.Name = "btnAddDocumentDelete";
            this.btnAddDocumentDelete.Size = new System.Drawing.Size(300, 45);
            this.btnAddDocumentDelete.TabIndex = 4;
            this.btnAddDocumentDelete.Text = "Додати документ";
            this.btnAddDocumentDelete.UseVisualStyleBackColor = true;
            this.btnAddDocumentDelete.Click += new System.EventHandler(this.btnAddDocumentDelete_Click);
            // 
            // btnResetDelete
            // 
            this.btnResetDelete.Location = new System.Drawing.Point(25, 503);
            this.btnResetDelete.Name = "btnResetDelete";
            this.btnResetDelete.Size = new System.Drawing.Size(300, 45);
            this.btnResetDelete.TabIndex = 3;
            this.btnResetDelete.Text = "Скинути документи";
            this.btnResetDelete.UseVisualStyleBackColor = true;
            this.btnResetDelete.Click += new System.EventHandler(this.btnResetDelete_Click);
            // 
            // btnApplyDelete
            // 
            this.btnApplyDelete.Location = new System.Drawing.Point(25, 554);
            this.btnApplyDelete.Name = "btnApplyDelete";
            this.btnApplyDelete.Size = new System.Drawing.Size(300, 45);
            this.btnApplyDelete.TabIndex = 2;
            this.btnApplyDelete.Text = "Виконати видалення";
            this.btnApplyDelete.UseVisualStyleBackColor = true;
            this.btnApplyDelete.Click += new System.EventHandler(this.btnApplyDelete_Click);
            // 
            // txtDeleteValue
            // 
            this.txtDeleteValue.Location = new System.Drawing.Point(101, 65);
            this.txtDeleteValue.Name = "txtDeleteValue";
            this.txtDeleteValue.Size = new System.Drawing.Size(224, 34);
            this.txtDeleteValue.TabIndex = 1;
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.richTextBoxEdit);
            this.panelEdit.Controls.Add(this.label10);
            this.panelEdit.Controls.Add(this.btnResetEdit);
            this.panelEdit.Controls.Add(this.btnApplyEdit);
            this.panelEdit.Location = new System.Drawing.Point(3, 3);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(344, 602);
            this.panelEdit.TabIndex = 9;
            this.panelEdit.Visible = false;
            // 
            // richTextBoxEdit
            // 
            this.richTextBoxEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxEdit.Location = new System.Drawing.Point(25, 70);
            this.richTextBoxEdit.Name = "richTextBoxEdit";
            this.richTextBoxEdit.Size = new System.Drawing.Size(300, 384);
            this.richTextBoxEdit.TabIndex = 9;
            this.richTextBoxEdit.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(261, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "Редагування документу";
            // 
            // btnResetEdit
            // 
            this.btnResetEdit.Location = new System.Drawing.Point(25, 503);
            this.btnResetEdit.Name = "btnResetEdit";
            this.btnResetEdit.Size = new System.Drawing.Size(300, 45);
            this.btnResetEdit.TabIndex = 3;
            this.btnResetEdit.Text = "Скинути документ";
            this.btnResetEdit.UseVisualStyleBackColor = true;
            this.btnResetEdit.Click += new System.EventHandler(this.btnResetEdit_Click);
            // 
            // btnApplyEdit
            // 
            this.btnApplyEdit.Location = new System.Drawing.Point(25, 554);
            this.btnApplyEdit.Name = "btnApplyEdit";
            this.btnApplyEdit.Size = new System.Drawing.Size(300, 45);
            this.btnApplyEdit.TabIndex = 2;
            this.btnApplyEdit.Text = "Виконати редагування";
            this.btnApplyEdit.UseVisualStyleBackColor = true;
            this.btnApplyEdit.Click += new System.EventHandler(this.btnApplyEdit_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.panelEdit);
            this.mainPanel.Controls.Add(this.panelDelete);
            this.mainPanel.Controls.Add(this.panelAdd);
            this.mainPanel.Controls.Add(this.panelFilters);
            this.mainPanel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPanel.Location = new System.Drawing.Point(996, 46);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(350, 659);
            this.mainPanel.TabIndex = 12;
            this.mainPanel.Visible = false;
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.label9);
            this.panelFilters.Controls.Add(this.listBoxFilters);
            this.panelFilters.Controls.Add(this.comboBoxOperators);
            this.panelFilters.Controls.Add(this.btnAddFilter);
            this.panelFilters.Controls.Add(this.btnResetFilters);
            this.panelFilters.Controls.Add(this.comboFilterField);
            this.panelFilters.Controls.Add(this.btnApplyFilter);
            this.panelFilters.Controls.Add(this.txtFilterValue);
            this.panelFilters.Location = new System.Drawing.Point(3, 34);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(344, 602);
            this.panelFilters.TabIndex = 3;
            this.panelFilters.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(273, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Фільтрування документу";
            // 
            // listBoxFilters
            // 
            this.listBoxFilters.FormattingEnabled = true;
            this.listBoxFilters.ItemHeight = 25;
            this.listBoxFilters.Location = new System.Drawing.Point(25, 187);
            this.listBoxFilters.Name = "listBoxFilters";
            this.listBoxFilters.Size = new System.Drawing.Size(300, 204);
            this.listBoxFilters.TabIndex = 6;
            // 
            // comboBoxOperators
            // 
            this.comboBoxOperators.FormattingEnabled = true;
            this.comboBoxOperators.Location = new System.Drawing.Point(25, 108);
            this.comboBoxOperators.Name = "comboBoxOperators";
            this.comboBoxOperators.Size = new System.Drawing.Size(300, 33);
            this.comboBoxOperators.TabIndex = 5;
            // 
            // btnAddFilter
            // 
            this.btnAddFilter.Location = new System.Drawing.Point(25, 452);
            this.btnAddFilter.Name = "btnAddFilter";
            this.btnAddFilter.Size = new System.Drawing.Size(300, 45);
            this.btnAddFilter.TabIndex = 4;
            this.btnAddFilter.Text = "Додати фільтр";
            this.btnAddFilter.UseVisualStyleBackColor = true;
            this.btnAddFilter.Click += new System.EventHandler(this.btnAddFilter_Click);
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.Location = new System.Drawing.Point(25, 503);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(300, 45);
            this.btnResetFilters.TabIndex = 3;
            this.btnResetFilters.Text = "Скинути фільтри";
            this.btnResetFilters.UseVisualStyleBackColor = true;
            this.btnResetFilters.Click += new System.EventHandler(this.btnResetFilters_Click);
            // 
            // comboFilterField
            // 
            this.comboFilterField.FormattingEnabled = true;
            this.comboFilterField.Location = new System.Drawing.Point(25, 68);
            this.comboFilterField.Name = "comboFilterField";
            this.comboFilterField.Size = new System.Drawing.Size(300, 33);
            this.comboFilterField.TabIndex = 0;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Location = new System.Drawing.Point(25, 554);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(300, 45);
            this.btnApplyFilter.TabIndex = 2;
            this.btnApplyFilter.Text = "Виконати фільтри";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(25, 147);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(300, 34);
            this.txtFilterValue.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App_with_MongoDB";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtConnectionUri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView TreeViewDatabases;
        private System.Windows.Forms.Button btnDeleteDocument;
        private System.Windows.Forms.Button btnAddDocument;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxDocument;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblDocumentCounter;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox comboFilterField;
        private System.Windows.Forms.Button btnToggleFilters;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.Button btnAddFilter;
        private System.Windows.Forms.ComboBox comboBoxOperators;
        private System.Windows.Forms.ListBox listBoxFilters;
        private System.Windows.Forms.Button btnEditDocument;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxAdd;
        private System.Windows.Forms.Button btnAddDocumentAdd;
        private System.Windows.Forms.Button btnResetAdd;
        private System.Windows.Forms.Button btnApplyAdd;
        private System.Windows.Forms.TextBox txtAddValue;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxDelete;
        private System.Windows.Forms.Button btnAddDocumentDelete;
        private System.Windows.Forms.Button btnResetDelete;
        private System.Windows.Forms.Button btnApplyDelete;
        private System.Windows.Forms.TextBox txtDeleteValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnResetEdit;
        private System.Windows.Forms.Button btnApplyEdit;
        private System.Windows.Forms.RichTextBox richTextBoxEdit;
    }
}

