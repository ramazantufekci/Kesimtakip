namespace katir
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label ibmLabel;
            System.Windows.Forms.Label masaLabel;
            System.Windows.Forms.Label adetLabel;
            System.Windows.Forms.Label tarihLabel;
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ibmTextBox = new System.Windows.Forms.TextBox();
            this.masaComboBox = new System.Windows.Forms.ComboBox();
            this.adetTextBox = new System.Windows.Forms.TextBox();
            this.tarihDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.masa1lbl = new System.Windows.Forms.Label();
            this.masa1countlbl = new System.Windows.Forms.Label();
            this.masa2lbl = new System.Windows.Forms.Label();
            this.masa2countlbl = new System.Windows.Forms.Label();
            this.toplamadetlbl = new System.Windows.Forms.Label();
            this.toplamadetcountlbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new katir.DatabaseDataSet();
            this.tableTableAdapter = new katir.DatabaseDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new katir.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.tarih1ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.tarih1ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.tarih2ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.tarih2ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.baslangicdatepicker = new System.Windows.Forms.DateTimePicker();
            this.bitisdatepicker = new System.Windows.Forms.DateTimePicker();
            this.baslangictarihlbl = new System.Windows.Forms.Label();
            this.bitistarihilbl = new System.Windows.Forms.Label();
            this.gosterbtn = new System.Windows.Forms.Button();
            ibmLabel = new System.Windows.Forms.Label();
            masaLabel = new System.Windows.Forms.Label();
            adetLabel = new System.Windows.Forms.Label();
            tarihLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableBindingNavigator
            // 
            this.tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableBindingNavigator.BindingSource = this.tableBindingSource;
            this.tableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tableBindingNavigatorSaveItem});
            this.tableBindingNavigator.Location = new System.Drawing.Point(9, 9);
            this.tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableBindingNavigator.Size = new System.Drawing.Size(272, 25);
            this.tableBindingNavigator.TabIndex = 0;
            this.tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Başa taşı";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Öne taşı";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Konum";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Geçerli konum";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Toplam öğe sayısı";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Arkaya taşı";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Sona taşı";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Yeni ekle";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Sil";
            // 
            // tableBindingNavigatorSaveItem
            // 
            this.tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBindingNavigatorSaveItem.Image")));
            this.tableBindingNavigatorSaveItem.Name = "tableBindingNavigatorSaveItem";
            this.tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tableBindingNavigatorSaveItem.Text = "Veriyi Sakla";
            this.tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableBindingNavigatorSaveItem_Click);
            // 
            // ibmLabel
            // 
            ibmLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            ibmLabel.AutoSize = true;
            ibmLabel.Location = new System.Drawing.Point(12, 41);
            ibmLabel.Name = "ibmLabel";
            ibmLabel.Size = new System.Drawing.Size(27, 13);
            ibmLabel.TabIndex = 3;
            ibmLabel.Text = "Ibm:";
            // 
            // ibmTextBox
            // 
            this.ibmTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ibmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Ibm", true));
            this.ibmTextBox.Location = new System.Drawing.Point(54, 38);
            this.ibmTextBox.Name = "ibmTextBox";
            this.ibmTextBox.Size = new System.Drawing.Size(200, 20);
            this.ibmTextBox.TabIndex = 4;
            // 
            // masaLabel
            // 
            masaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            masaLabel.AutoSize = true;
            masaLabel.Location = new System.Drawing.Point(12, 67);
            masaLabel.Name = "masaLabel";
            masaLabel.Size = new System.Drawing.Size(36, 13);
            masaLabel.TabIndex = 5;
            masaLabel.Text = "Masa:";
            // 
            // masaComboBox
            // 
            this.masaComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.masaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Masa", true));
            this.masaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.masaComboBox.FormattingEnabled = true;
            this.masaComboBox.Items.AddRange(new object[] {
            "MASA SEÇ",
            "MASA1",
            "MASA2"});
            this.masaComboBox.Location = new System.Drawing.Point(54, 64);
            this.masaComboBox.Name = "masaComboBox";
            this.masaComboBox.Size = new System.Drawing.Size(200, 21);
            this.masaComboBox.TabIndex = 6;
            // 
            // adetLabel
            // 
            adetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            adetLabel.AutoSize = true;
            adetLabel.Location = new System.Drawing.Point(12, 94);
            adetLabel.Name = "adetLabel";
            adetLabel.Size = new System.Drawing.Size(32, 13);
            adetLabel.TabIndex = 7;
            adetLabel.Text = "Adet:";
            // 
            // adetTextBox
            // 
            this.adetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.adetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "adet", true));
            this.adetTextBox.Location = new System.Drawing.Point(54, 91);
            this.adetTextBox.Name = "adetTextBox";
            this.adetTextBox.Size = new System.Drawing.Size(200, 20);
            this.adetTextBox.TabIndex = 8;
            // 
            // tarihLabel
            // 
            tarihLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            tarihLabel.AutoSize = true;
            tarihLabel.Location = new System.Drawing.Point(12, 121);
            tarihLabel.Name = "tarihLabel";
            tarihLabel.Size = new System.Drawing.Size(34, 13);
            tarihLabel.TabIndex = 9;
            tarihLabel.Text = "Tarih:";
            // 
            // tarihDateTimePicker
            // 
            this.tarihDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tarihDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tableBindingSource, "Tarih", true));
            this.tarihDateTimePicker.Location = new System.Drawing.Point(54, 117);
            this.tarihDateTimePicker.Name = "tarihDateTimePicker";
            this.tarihDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.tarihDateTimePicker.TabIndex = 10;
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableDataGridView.AutoGenerateColumns = false;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tableDataGridView.DataSource = this.tableBindingSource;
            this.tableDataGridView.Location = new System.Drawing.Point(12, 202);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.Size = new System.Drawing.Size(784, 220);
            this.tableDataGridView.TabIndex = 11;
            // 
            // masa1lbl
            // 
            this.masa1lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.masa1lbl.AutoSize = true;
            this.masa1lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.masa1lbl.Location = new System.Drawing.Point(140, 432);
            this.masa1lbl.Name = "masa1lbl";
            this.masa1lbl.Size = new System.Drawing.Size(53, 16);
            this.masa1lbl.TabIndex = 12;
            this.masa1lbl.Text = "MASA1";
            // 
            // masa1countlbl
            // 
            this.masa1countlbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.masa1countlbl.AutoSize = true;
            this.masa1countlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.masa1countlbl.Location = new System.Drawing.Point(196, 432);
            this.masa1countlbl.Name = "masa1countlbl";
            this.masa1countlbl.Size = new System.Drawing.Size(15, 16);
            this.masa1countlbl.TabIndex = 13;
            this.masa1countlbl.Text = "0";
            // 
            // masa2lbl
            // 
            this.masa2lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.masa2lbl.AutoSize = true;
            this.masa2lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.masa2lbl.Location = new System.Drawing.Point(298, 432);
            this.masa2lbl.Name = "masa2lbl";
            this.masa2lbl.Size = new System.Drawing.Size(53, 16);
            this.masa2lbl.TabIndex = 14;
            this.masa2lbl.Text = "MASA2";
            // 
            // masa2countlbl
            // 
            this.masa2countlbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.masa2countlbl.AutoSize = true;
            this.masa2countlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.masa2countlbl.Location = new System.Drawing.Point(355, 432);
            this.masa2countlbl.Name = "masa2countlbl";
            this.masa2countlbl.Size = new System.Drawing.Size(15, 16);
            this.masa2countlbl.TabIndex = 15;
            this.masa2countlbl.Text = "0";
            // 
            // toplamadetlbl
            // 
            this.toplamadetlbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toplamadetlbl.AutoSize = true;
            this.toplamadetlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.toplamadetlbl.Location = new System.Drawing.Point(443, 432);
            this.toplamadetlbl.Name = "toplamadetlbl";
            this.toplamadetlbl.Size = new System.Drawing.Size(103, 16);
            this.toplamadetlbl.TabIndex = 16;
            this.toplamadetlbl.Text = "TOPLAM ADET";
            // 
            // toplamadetcountlbl
            // 
            this.toplamadetcountlbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toplamadetcountlbl.AutoSize = true;
            this.toplamadetcountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.toplamadetcountlbl.Location = new System.Drawing.Point(547, 432);
            this.toplamadetcountlbl.Name = "toplamadetcountlbl";
            this.toplamadetcountlbl.Size = new System.Drawing.Size(15, 16);
            this.toplamadetcountlbl.TabIndex = 17;
            this.toplamadetcountlbl.Text = "0";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(721, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Dışarı Aktar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ibm";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ibm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Masa";
            this.dataGridViewTextBoxColumn3.HeaderText = "Masa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "adet";
            this.dataGridViewTextBoxColumn4.HeaderText = "adet";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Tarih";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tarih";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = katir.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarih1ToolStripLabel,
            this.tarih1ToolStripTextBox,
            this.tarih2ToolStripLabel,
            this.tarih2ToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(808, 25);
            this.fillByToolStrip.TabIndex = 19;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // tarih1ToolStripLabel
            // 
            this.tarih1ToolStripLabel.Name = "tarih1ToolStripLabel";
            this.tarih1ToolStripLabel.Size = new System.Drawing.Size(40, 22);
            this.tarih1ToolStripLabel.Text = "tarih1:";
            // 
            // tarih1ToolStripTextBox
            // 
            this.tarih1ToolStripTextBox.Name = "tarih1ToolStripTextBox";
            this.tarih1ToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // tarih2ToolStripLabel
            // 
            this.tarih2ToolStripLabel.Name = "tarih2ToolStripLabel";
            this.tarih2ToolStripLabel.Size = new System.Drawing.Size(40, 22);
            this.tarih2ToolStripLabel.Text = "tarih2:";
            // 
            // tarih2ToolStripTextBox
            // 
            this.tarih2ToolStripTextBox.Name = "tarih2ToolStripTextBox";
            this.tarih2ToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // baslangicdatepicker
            // 
            this.baslangicdatepicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baslangicdatepicker.Location = new System.Drawing.Point(562, 28);
            this.baslangicdatepicker.Name = "baslangicdatepicker";
            this.baslangicdatepicker.Size = new System.Drawing.Size(200, 20);
            this.baslangicdatepicker.TabIndex = 20;
            // 
            // bitisdatepicker
            // 
            this.bitisdatepicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bitisdatepicker.Location = new System.Drawing.Point(562, 61);
            this.bitisdatepicker.Name = "bitisdatepicker";
            this.bitisdatepicker.Size = new System.Drawing.Size(200, 20);
            this.bitisdatepicker.TabIndex = 21;
            // 
            // baslangictarihlbl
            // 
            this.baslangictarihlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baslangictarihlbl.AutoSize = true;
            this.baslangictarihlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslangictarihlbl.Location = new System.Drawing.Point(449, 30);
            this.baslangictarihlbl.Name = "baslangictarihlbl";
            this.baslangictarihlbl.Size = new System.Drawing.Size(108, 16);
            this.baslangictarihlbl.TabIndex = 22;
            this.baslangictarihlbl.Text = "Başlangıç Tarihi:";
            // 
            // bitistarihilbl
            // 
            this.bitistarihilbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bitistarihilbl.AutoSize = true;
            this.bitistarihilbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bitistarihilbl.Location = new System.Drawing.Point(449, 65);
            this.bitistarihilbl.Name = "bitistarihilbl";
            this.bitistarihilbl.Size = new System.Drawing.Size(73, 16);
            this.bitistarihilbl.TabIndex = 23;
            this.bitistarihilbl.Text = "Bitiş Tarihi:";
            // 
            // gosterbtn
            // 
            this.gosterbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gosterbtn.Location = new System.Drawing.Point(686, 94);
            this.gosterbtn.Name = "gosterbtn";
            this.gosterbtn.Size = new System.Drawing.Size(75, 23);
            this.gosterbtn.TabIndex = 24;
            this.gosterbtn.Text = "Göster";
            this.gosterbtn.UseVisualStyleBackColor = true;
            this.gosterbtn.Click += new System.EventHandler(this.gosterbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 456);
            this.Controls.Add(this.gosterbtn);
            this.Controls.Add(this.bitistarihilbl);
            this.Controls.Add(this.baslangictarihlbl);
            this.Controls.Add(this.bitisdatepicker);
            this.Controls.Add(this.baslangicdatepicker);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toplamadetcountlbl);
            this.Controls.Add(this.toplamadetlbl);
            this.Controls.Add(this.masa2countlbl);
            this.Controls.Add(this.masa2lbl);
            this.Controls.Add(this.masa1countlbl);
            this.Controls.Add(this.masa1lbl);
            this.Controls.Add(this.tableDataGridView);
            this.Controls.Add(ibmLabel);
            this.Controls.Add(this.ibmTextBox);
            this.Controls.Add(masaLabel);
            this.Controls.Add(this.masaComboBox);
            this.Controls.Add(adetLabel);
            this.Controls.Add(this.adetTextBox);
            this.Controls.Add(tarihLabel);
            this.Controls.Add(this.tarihDateTimePicker);
            this.Controls.Add(this.tableBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "KATIR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private DatabaseDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox ibmTextBox;
        private System.Windows.Forms.ComboBox masaComboBox;
        private System.Windows.Forms.TextBox adetTextBox;
        private System.Windows.Forms.DateTimePicker tarihDateTimePicker;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label masa1lbl;
        private System.Windows.Forms.Label masa1countlbl;
        private System.Windows.Forms.Label masa2lbl;
        private System.Windows.Forms.Label masa2countlbl;
        private System.Windows.Forms.Label toplamadetlbl;
        private System.Windows.Forms.Label toplamadetcountlbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel tarih1ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox tarih1ToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel tarih2ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox tarih2ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DateTimePicker baslangicdatepicker;
        private System.Windows.Forms.DateTimePicker bitisdatepicker;
        private System.Windows.Forms.Label baslangictarihlbl;
        private System.Windows.Forms.Label bitistarihilbl;
        private System.Windows.Forms.Button gosterbtn;
    }
}

