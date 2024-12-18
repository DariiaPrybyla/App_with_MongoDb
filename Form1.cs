using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace App_with_MongoDb
{
    public partial class Form1 : Form
    {
        private MongoClient _mongoClient;
        private IMongoDatabase _selectedDatabase;
        private IMongoCollection<BsonDocument> _selectedCollection;
        private List<BsonDocument> _documents; // Список документів
        private int _currentDocumentIndex = 0; // Поточний індекс документа  
        private List<Tuple<string, string, string>> _filters = new List<Tuple<string, string, string>>(); // Додаткові поля для збереження фільтрів
        private bool _panelVisible = false; // Для контролю видимості панелі
        private bool _filtersVisible = false; // Для контролю видимості панелі
        private bool _addVisible = false; // Для контролю видимості панелі
        private bool _editVisible = false; // Для контролю видимості панелі
        private bool _deleteVisible = false; // Для контролю видимості панелі
        private string _originalDocument; // Зберігає первісний вигляд документа
        private string _editedDocument;   // Зберігає тимчасовий стан редагування

        public Form1()
        {
            InitializeComponent();
            mainPanel.Width = 300;

            // Заповнення операторів порівняння
            comboBoxOperators.Items.AddRange(new string[] { "=", "!=", "<", ">", "<=", ">=", "Contains" });
            comboBoxOperators.SelectedIndex = 0; // Вибрати перший оператор за замовчуванням
        }

        /* ------------------------------------------------------------------------------------------------------------
         Загальні функції
        ------------------------------------------------------------------------------------------------------------ */

        private void RefreshDatabaseStructure()
        {
            try
            {
                TreeViewDatabases.Nodes.Clear();
                var databases = _mongoClient.ListDatabaseNames().ToList();

                foreach (var dbName in databases)
                {
                    var dbNode = new TreeNode(dbName);
                    TreeViewDatabases.Nodes.Add(dbNode);

                    var collections = _mongoClient.GetDatabase(dbName).ListCollectionNames().ToList();
                    foreach (var collectionName in collections)
                    {
                        dbNode.Nodes.Add(new TreeNode(collectionName));
                    }
                }
                LabelStatus.Text = "Структуру оновлено";
            }
            catch (Exception ex)
            {
                LabelStatus.Text = "Помилка оновлення структури: " + ex.Message;
            }
        }

        private void OpenPanel()
        {
            // Перевірка, чи вибрана колекція
            if (_selectedCollection == null)
            {
                LabelStatus.Text = "Оберіть колекцію!";
                return; // Вихід з методу, якщо колекція не вибрана
            }

            // Перемикання видимості панелі фільтрів, якщо колекція вибрана
            _panelVisible = !_panelVisible;
            mainPanel.Visible = _panelVisible;

            // Зміна ширини основної форми
            if (_panelVisible)
            {
                this.Width += mainPanel.Width; // Збільшуємо ширину вікна
            }
            else
            {
                this.Width -= mainPanel.Width; // Зменшуємо ширину вікна
            }
        }

        /* ------------------------------------------------------------------------------------------------------------
         Підключення MongoDB
        ------------------------------------------------------------------------------------------------------------ */
        private void btnConnect_Click(object sender, EventArgs e)
        {
            string uri = txtConnectionUri.Text.Trim();
            try
            {
                // Підключення до MongoDB за вказаним URI
                _mongoClient = new MongoClient(uri);
                // Спробуємо отримати бази даних для перевірки з'єднання
                var databases = _mongoClient.ListDatabaseNames().ToList();

                // Якщо підключення успішне
                lblStatus.Text = "Підключено";
            }
            catch (Exception ex)
            {
                // У разі виникнення помилки
                lblStatus.Text = "Виникла помилка: " + ex.Message;
            }

            RefreshDatabaseStructure();
        }

        /* ------------------------------------------------------------------------------------------------------------
         Відображення бази даних, колекцій
        ------------------------------------------------------------------------------------------------------------ */

        // Оновлення структури баз даних і колекцій

        private void TreeViewDatabases_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var selectedNode = e.Node;

            if (selectedNode == null) return;

            // Якщо обрано вузол колекції
            if (selectedNode.Parent != null && selectedNode.Parent.Parent == null)
            {
                string selectedDbName = selectedNode.Parent.Text; // Назва бази даних
                string selectedCollectionName = selectedNode.Text; // Назва колекції

                try
                {
                    // Вибираємо базу даних і колекцію
                    _selectedDatabase = _mongoClient.GetDatabase(selectedDbName);
                    _selectedCollection = _selectedDatabase.GetCollection<BsonDocument>(selectedCollectionName);

                    // Завантажуємо всі документи
                    _documents = _selectedCollection.Find(new BsonDocument()).ToList();
                    _currentDocumentIndex = 0; // Починаємо з першого документа

                    // Оновлюємо відображення
                    DisplayCurrentDocument();
                    PopulateFilterFields();

                    // Якщо документи є, активуємо кнопки для перемикання
                    btnPrevious.Enabled = _documents.Count > 1;
                    btnNext.Enabled = _documents.Count > 1;
                }
                catch (Exception ex)
                {
                    LabelStatus.Text = "Помилка завантаження документів" + ex.Message;
                }
            }
            else
            {
                // Якщо обрано вузол бази даних або документа, чистимо richTextBox
                LabelStatus.Text = "Виберіть колекцію для перегляду документів.";
            }
        }

        /* ------------------------------------------------------------------------------------------------------------
         Відображення документів
        ------------------------------------------------------------------------------------------------------------ */

        // Відображення поточного документа
        private void DisplayCurrentDocument()
        {
            if (_documents == null || !_documents.Any()) return;

            // Отримуємо поточний документ
            var currentDocument = _documents[_currentDocumentIndex];

            // Форматуємо його в JSON
            string formattedJson = currentDocument.ToJson(new MongoDB.Bson.IO.JsonWriterSettings
            {
                Indent = true // Відступи для читабельності
            });

            // Відображаємо у richTextBox
            richTextBoxDocument.Text = formattedJson;

            // Оновлюємо лейбл зі статусом
            lblDocumentCounter.Text = $"{_currentDocumentIndex + 1}/{_documents.Count}";
        }

        // Кнопка "Назад"
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_currentDocumentIndex > 0)
            {
                _currentDocumentIndex--; // Переходимо до попереднього документа
                DisplayCurrentDocument(); // Оновлюємо відображення
            }
        }

        // Кнопка "Вперед"
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentDocumentIndex < _documents.Count - 1)
            {
                _currentDocumentIndex++; // Переходимо до наступного документа
                DisplayCurrentDocument(); // Оновлюємо відображення
            }
        }

        /* ------------------------------------------------------------------------------------------------------------
         Фільтри
        ------------------------------------------------------------------------------------------------------------ */
        
        private void PopulateFilterFields()
        {
            try
            {
                comboFilterField.Items.Clear();

                var firstDocument = _selectedCollection.Find(new BsonDocument()).FirstOrDefault();

                if (firstDocument != null)
                {
                    foreach (var key in firstDocument.Names)
                    {
                        comboFilterField.Items.Add(key);
                    }

                    if (comboFilterField.Items.Count > 0)
                    {
                        comboFilterField.SelectedIndex = 0;
                    }
                }
                else
                {
                    lblDocumentCounter.Text = "0/0";
                    LabelStatus.Text = "Колекція порожня. Немає даних для завантаження полів.";
                    richTextBoxDocument.Clear();
                }
            }
            catch (Exception ex)
            {
                LabelStatus.Text = "Помилка завантаження полів:" + ex.Message;
            }
        }
        
        private void btnToggleFilters_Click(object sender, EventArgs e)
        {
            // Перемикання видимості панелі фільтрів, якщо колекція вибрана
            _filtersVisible = !_filtersVisible;
            panelFilters.Visible = _filtersVisible;
            OpenPanel();
        }
        
        private void btnAddFilter_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи вибрано поле, оператор та введено значення
            if (comboFilterField.SelectedIndex == -1 || comboBoxOperators.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtFilterValue.Text))
            {
                listBoxFilters.Text = "Заповніть всі поля для додавання фільтру!";
                return;
            }

            string field = comboFilterField.SelectedItem.ToString();
            string op = comboBoxOperators.SelectedItem.ToString();
            string value = txtFilterValue.Text.Trim();

            // Додати фільтр до списку
            _filters.Add(Tuple.Create(field, op, value));
            listBoxFilters.Items.Add($"{field} {op} {value}");
        }
        
        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            _filters.Clear();
            listBoxFilters.Items.Clear();
        }
        
        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            try
            {
                // Створюємо складений фільтр
                var filterBuilder = Builders<BsonDocument>.Filter;
                FilterDefinition<BsonDocument> finalFilter = filterBuilder.Empty;

                foreach (var filter in _filters)
                {
                    string field = filter.Item1;
                    string op = filter.Item2;
                    string value = filter.Item3;

                    FilterDefinition<BsonDocument> currentFilter = null;

                    // Визначення фільтра залежно від оператора
                    switch (op)
                    {
                        case "=":
                            currentFilter = double.TryParse(value, out double numValue)
                                ? filterBuilder.Eq(field, numValue)
                                : filterBuilder.Eq(field, value);
                            break;

                        case "!=":
                            currentFilter = double.TryParse(value, out numValue)
                                ? filterBuilder.Ne(field, numValue)
                                : filterBuilder.Ne(field, value);
                            break;

                        case "<":
                            currentFilter = double.TryParse(value, out numValue)
                                ? filterBuilder.Lt(field, numValue)
                                : filterBuilder.Lt(field, value);
                            break;

                        case ">":
                            currentFilter = double.TryParse(value, out numValue)
                                ? filterBuilder.Gt(field, numValue)
                                : filterBuilder.Gt(field, value);
                            break;

                        case ">=":
                            currentFilter = double.TryParse(value, out numValue)
                                ? filterBuilder.Gte(field, numValue)
                                : filterBuilder.Gte(field, value);
                            break;

                        case "<=":
                            currentFilter = double.TryParse(value, out numValue)
                                ? filterBuilder.Lte(field, numValue)
                                : filterBuilder.Lte(field, value);
                            break;

                        case "Contains":
                            currentFilter = filterBuilder.Regex(field, new BsonRegularExpression(value, "i"));
                            break;
                    }

                    if (currentFilter != null)
                    {
                        finalFilter = filterBuilder.And(finalFilter, currentFilter);
                    }
                }

                // Застосування фільтру
                _documents = _selectedCollection.Find(finalFilter).ToList();
                _currentDocumentIndex = 0;

                if (_documents.Count == 0)
                {
                    lblDocumentCounter.Text = "0/0";
                    LabelStatus.Text = "Документи не знайдені.";
                }
                else
                {
                    DisplayCurrentDocument();
                }

                LabelStatus.Text = "Знайдено документів: " + _documents.Count;
            }
            catch (Exception ex)
            {
                LabelStatus.Text = "Помилка застосування фільтру: " + ex.Message;
            }
        }

        /* ------------------------------------------------------------------------------------------------------------
         Додавання документів
        ------------------------------------------------------------------------------------------------------------ */
        
        private void btnAddDocument_Click(object sender, EventArgs e)
        {
            _addVisible = !_addVisible;
            panelAdd.Visible = _addVisible;
            OpenPanel();
        }
        
        private void btnAddDocumentAdd_Click(object sender, EventArgs e)
        {
            string documentName = txtAddValue.Text.Trim();
            if (!string.IsNullOrEmpty(documentName))
            {
                listBoxAdd.Items.Add($"name: {documentName}");
                txtAddValue.Clear();
            }
            else
            {
                LabelStatus.Text = "Будь ласка, введіть ім'я документа.";
            }
        }
        
        private void btnResetAdd_Click(object sender, EventArgs e)
        {
            _filters.Clear();
            listBoxAdd.Items.Clear();
        }
        
        private void btnApplyAdd_Click(object sender, EventArgs e)
        {
            if (_selectedCollection == null)
            {
                LabelStatus.Text = "Оберіть колекцію перед додаванням документів.";
                return;
            }

            if (listBoxAdd.Items.Count == 0)
            {
                LabelStatus.Text = "Список документів для додавання порожній.";
                return;
            }

            foreach (var item in listBoxAdd.Items)
            {
                var documentName = item.ToString().Split(':')[1].Trim();
                var newDocument = new BsonDocument { { "name", documentName } };
                _selectedCollection.InsertOne(newDocument);
            }

            listBoxAdd.Items.Clear();
            LabelStatus.Text = "Документи успішно додано.";
        }

        /* ------------------------------------------------------------------------------------------------------------
         Редагування документів
        ------------------------------------------------------------------------------------------------------------ */
        
        private void btnEditDocument_Click(object sender, EventArgs e)
        {
            _editVisible = !_editVisible;
            panelEdit.Visible = _editVisible;

            if (_editVisible)
            {
                // Завантажуємо поточний документ у редактор
                _originalDocument = richTextBoxDocument.Text; // Зберігаємо оригінал
                _editedDocument = _originalDocument;          // Ініціалізуємо редактор тим самим значенням
                richTextBoxEdit.Text = _editedDocument;  // Вставляємо документ у бокову панель
            }

            OpenPanel();
        }
        
        private void btnResetEdit_Click(object sender, EventArgs e)
        {
            richTextBoxEdit.Text = _originalDocument; // Повертаємо оригінал у редактор
        }
        private void btnApplyEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var updatedDocument = BsonDocument.Parse(richTextBoxEdit.Text); // Валідність JSON
                _documents[_currentDocumentIndex] = updatedDocument; // Оновлюємо в локальному списку
                _selectedCollection.ReplaceOne(new BsonDocument("_id", _documents[_currentDocumentIndex]["_id"]), updatedDocument);

                // Оновлюємо в основному richTextBox
                richTextBoxDocument.Text = richTextBoxEdit.Text;

                LabelStatus.Text = "Документ успішно оновлено.";
            }
            catch (Exception ex)
            {
                LabelStatus.Text = "Помилка при оновленні документа: " + ex.Message;
            }
        }

        /* ------------------------------------------------------------------------------------------------------------
         Видалення документів
        ------------------------------------------------------------------------------------------------------------ */

        private void btnDeleteDocument_Click(object sender, EventArgs e)
        {
            _deleteVisible = !_deleteVisible;
            panelDelete.Visible = _deleteVisible;
            OpenPanel();
        }
        
        private void btnAddDocumentDelete_Click(object sender, EventArgs e)
        {
            string documentName = txtDeleteValue.Text.Trim();
            if (!string.IsNullOrEmpty(documentName))
            {
                listBoxDelete.Items.Add($"name: {documentName}");
                txtDeleteValue.Clear();
            }
            else
            {
                LabelStatus.Text = "Будь ласка, введіть ім'я документа.";
            }
        }

        private void btnResetDelete_Click(object sender, EventArgs e)
        {
            _filters.Clear();
            listBoxDelete.Items.Clear();
        }

        private void btnApplyDelete_Click(object sender, EventArgs e)
        {
            if (_selectedCollection == null)
            {
                LabelStatus.Text = "Оберіть колекцію перед видаленням документів.";
                return;
            }

            if (listBoxDelete.Items.Count == 0)
            {
                LabelStatus.Text = "Список документів для видалення порожній.";
                return;
            }

            foreach (var item in listBoxDelete.Items)
            {
                var documentName = item.ToString().Split(':')[1].Trim();
                var filter = Builders<BsonDocument>.Filter.Eq("name", documentName);
                _selectedCollection.DeleteOne(filter);
            }

            listBoxDelete.Items.Clear();
            LabelStatus.Text = "Документи успішно видалено.";
        }
    }
}
