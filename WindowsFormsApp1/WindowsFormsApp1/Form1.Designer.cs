namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label vardasLabel;
            System.Windows.Forms.Label pavardeLabel;
            System.Windows.Forms.Label vartotojoVardasLabel;
            System.Windows.Forms.Label elPastasLabel;
            this.vartotojasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vartotojasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vartotojasDataGridView = new System.Windows.Forms.DataGridView();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.vardasTextBox = new System.Windows.Forms.TextBox();
            this.pavardeTextBox = new System.Windows.Forms.TextBox();
            this.vartotojoVardasTextBox = new System.Windows.Forms.TextBox();
            this.elPastasTextBox = new System.Windows.Forms.TextBox();
            this.vartotojasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duombazeDataSet = new WindowsFormsApp1.DuombazeDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vartotojasTableAdapter = new WindowsFormsApp1.DuombazeDataSetTableAdapters.VartotojasTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.DuombazeDataSetTableAdapters.TableAdapterManager();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.fillBy2ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            idLabel = new System.Windows.Forms.Label();
            vardasLabel = new System.Windows.Forms.Label();
            pavardeLabel = new System.Windows.Forms.Label();
            vartotojoVardasLabel = new System.Windows.Forms.Label();
            elPastasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vartotojasBindingNavigator)).BeginInit();
            this.vartotojasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vartotojasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vartotojasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duombazeDataSet)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            this.fillBy2ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // vartotojasBindingNavigator
            // 
            this.vartotojasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vartotojasBindingNavigator.BindingSource = this.vartotojasBindingSource;
            this.vartotojasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vartotojasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vartotojasBindingNavigator.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.vartotojasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vartotojasBindingNavigatorSaveItem});
            this.vartotojasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vartotojasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vartotojasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vartotojasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vartotojasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vartotojasBindingNavigator.Name = "vartotojasBindingNavigator";
            this.vartotojasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vartotojasBindingNavigator.Size = new System.Drawing.Size(2172, 38);
            this.vartotojasBindingNavigator.TabIndex = 0;
            this.vartotojasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 35);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(61, 32);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // vartotojasBindingNavigatorSaveItem
            // 
            this.vartotojasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vartotojasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vartotojasBindingNavigatorSaveItem.Image")));
            this.vartotojasBindingNavigatorSaveItem.Name = "vartotojasBindingNavigatorSaveItem";
            this.vartotojasBindingNavigatorSaveItem.Size = new System.Drawing.Size(40, 32);
            this.vartotojasBindingNavigatorSaveItem.Text = "Save Data";
            this.vartotojasBindingNavigatorSaveItem.Click += new System.EventHandler(this.vartotojasBindingNavigatorSaveItem_Click);
            // 
            // vartotojasDataGridView
            // 
            this.vartotojasDataGridView.AutoGenerateColumns = false;
            this.vartotojasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vartotojasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.vartotojasDataGridView.DataSource = this.vartotojasBindingSource;
            this.vartotojasDataGridView.Location = new System.Drawing.Point(12, 126);
            this.vartotojasDataGridView.Name = "vartotojasDataGridView";
            this.vartotojasDataGridView.RowHeadersWidth = 72;
            this.vartotojasDataGridView.RowTemplate.Height = 31;
            this.vartotojasDataGridView.Size = new System.Drawing.Size(1506, 601);
            this.vartotojasDataGridView.TabIndex = 1;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(1672, 115);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(34, 25);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vartotojasBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(1842, 112);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 29);
            this.idTextBox.TabIndex = 3;
            // 
            // vardasLabel
            // 
            vardasLabel.AutoSize = true;
            vardasLabel.Location = new System.Drawing.Point(1672, 150);
            vardasLabel.Name = "vardasLabel";
            vardasLabel.Size = new System.Drawing.Size(81, 25);
            vardasLabel.TabIndex = 4;
            vardasLabel.Text = "Vardas:";
            // 
            // vardasTextBox
            // 
            this.vardasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vartotojasBindingSource, "Vardas", true));
            this.vardasTextBox.Location = new System.Drawing.Point(1842, 147);
            this.vardasTextBox.Name = "vardasTextBox";
            this.vardasTextBox.Size = new System.Drawing.Size(100, 29);
            this.vardasTextBox.TabIndex = 5;
            // 
            // pavardeLabel
            // 
            pavardeLabel.AutoSize = true;
            pavardeLabel.Location = new System.Drawing.Point(1672, 185);
            pavardeLabel.Name = "pavardeLabel";
            pavardeLabel.Size = new System.Drawing.Size(91, 25);
            pavardeLabel.TabIndex = 6;
            pavardeLabel.Text = "Pavarde:";
            // 
            // pavardeTextBox
            // 
            this.pavardeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vartotojasBindingSource, "Pavarde", true));
            this.pavardeTextBox.Location = new System.Drawing.Point(1842, 182);
            this.pavardeTextBox.Name = "pavardeTextBox";
            this.pavardeTextBox.Size = new System.Drawing.Size(100, 29);
            this.pavardeTextBox.TabIndex = 7;
            // 
            // vartotojoVardasLabel
            // 
            vartotojoVardasLabel.AutoSize = true;
            vartotojoVardasLabel.Location = new System.Drawing.Point(1672, 220);
            vartotojoVardasLabel.Name = "vartotojoVardasLabel";
            vartotojoVardasLabel.Size = new System.Drawing.Size(164, 25);
            vartotojoVardasLabel.TabIndex = 8;
            vartotojoVardasLabel.Text = "Vartotojo Vardas:";
            // 
            // vartotojoVardasTextBox
            // 
            this.vartotojoVardasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vartotojasBindingSource, "VartotojoVardas", true));
            this.vartotojoVardasTextBox.Location = new System.Drawing.Point(1842, 217);
            this.vartotojoVardasTextBox.Name = "vartotojoVardasTextBox";
            this.vartotojoVardasTextBox.Size = new System.Drawing.Size(100, 29);
            this.vartotojoVardasTextBox.TabIndex = 9;
            // 
            // elPastasLabel
            // 
            elPastasLabel.AutoSize = true;
            elPastasLabel.Location = new System.Drawing.Point(1672, 255);
            elPastasLabel.Name = "elPastasLabel";
            elPastasLabel.Size = new System.Drawing.Size(100, 25);
            elPastasLabel.TabIndex = 10;
            elPastasLabel.Text = "El Pastas:";
            // 
            // elPastasTextBox
            // 
            this.elPastasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vartotojasBindingSource, "ElPastas", true));
            this.elPastasTextBox.Location = new System.Drawing.Point(1842, 252);
            this.elPastasTextBox.Name = "elPastasTextBox";
            this.elPastasTextBox.Size = new System.Drawing.Size(100, 29);
            this.elPastasTextBox.TabIndex = 11;
            // 
            // vartotojasBindingSource
            // 
            this.vartotojasBindingSource.DataMember = "Vartotojas";
            this.vartotojasBindingSource.DataSource = this.duombazeDataSet;
            // 
            // duombazeDataSet
            // 
            this.duombazeDataSet.DataSetName = "DuombazeDataSet";
            this.duombazeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 175;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Vardas";
            this.dataGridViewTextBoxColumn2.HeaderText = "Vardas";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 175;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Pavarde";
            this.dataGridViewTextBoxColumn3.HeaderText = "Pavarde";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 175;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "VartotojoVardas";
            this.dataGridViewTextBoxColumn4.HeaderText = "VartotojoVardas";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 175;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ElPastas";
            this.dataGridViewTextBoxColumn5.HeaderText = "ElPastas";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 175;
            // 
            // vartotojasTableAdapter
            // 
            this.vartotojasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.DuombazeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VartotojasTableAdapter = this.vartotojasTableAdapter;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy1ToolStripButton,
            this.toolStripButton1});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 38);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(2172, 40);
            this.fillBy1ToolStrip.TabIndex = 12;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillBy1ToolStrip_ItemClicked);
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(75, 34);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(40, 34);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // fillBy2ToolStrip
            // 
            this.fillBy2ToolStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.fillBy2ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy2ToolStripButton});
            this.fillBy2ToolStrip.Location = new System.Drawing.Point(0, 78);
            this.fillBy2ToolStrip.Name = "fillBy2ToolStrip";
            this.fillBy2ToolStrip.Size = new System.Drawing.Size(2172, 40);
            this.fillBy2ToolStrip.TabIndex = 13;
            this.fillBy2ToolStrip.Text = "fillBy2ToolStrip";
            // 
            // fillBy2ToolStripButton
            // 
            this.fillBy2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy2ToolStripButton.Name = "fillBy2ToolStripButton";
            this.fillBy2ToolStripButton.Size = new System.Drawing.Size(75, 19);
            this.fillBy2ToolStripButton.Text = "FillBy2";
            this.fillBy2ToolStripButton.Click += new System.EventHandler(this.fillBy2ToolStripButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2172, 798);
            this.Controls.Add(this.fillBy2ToolStrip);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(vardasLabel);
            this.Controls.Add(this.vardasTextBox);
            this.Controls.Add(pavardeLabel);
            this.Controls.Add(this.pavardeTextBox);
            this.Controls.Add(vartotojoVardasLabel);
            this.Controls.Add(this.vartotojoVardasTextBox);
            this.Controls.Add(elPastasLabel);
            this.Controls.Add(this.elPastasTextBox);
            this.Controls.Add(this.vartotojasDataGridView);
            this.Controls.Add(this.vartotojasBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vartotojasBindingNavigator)).EndInit();
            this.vartotojasBindingNavigator.ResumeLayout(false);
            this.vartotojasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vartotojasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vartotojasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duombazeDataSet)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.fillBy2ToolStrip.ResumeLayout(false);
            this.fillBy2ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DuombazeDataSet duombazeDataSet;
        private System.Windows.Forms.BindingSource vartotojasBindingSource;
        private DuombazeDataSetTableAdapters.VartotojasTableAdapter vartotojasTableAdapter;
        private DuombazeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vartotojasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vartotojasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView vartotojasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox vardasTextBox;
        private System.Windows.Forms.TextBox pavardeTextBox;
        private System.Windows.Forms.TextBox vartotojoVardasTextBox;
        private System.Windows.Forms.TextBox elPastasTextBox;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip fillBy2ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy2ToolStripButton;
    }
}

