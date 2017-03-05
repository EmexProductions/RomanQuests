namespace RomanQuests
{
    partial class AdminPasswords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPasswords));
            this.romanQuestsLoginAdminDataSet = new RomanQuests.RomanQuestsLoginAdminDataSet();
            this.romanQuestsLoginAdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.romanQuestsLoginAdminTableAdapter = new RomanQuests.RomanQuestsLoginAdminDataSetTableAdapters.RomanQuestsLoginAdminTableAdapter();
            this.tableAdapterManager = new RomanQuests.RomanQuestsLoginAdminDataSetTableAdapters.TableAdapterManager();
            this.romanQuestsLoginAdminBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.romanQuestsLoginAdminBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.romanQuestsLoginAdminDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.romanQuestsLoginAdminDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.romanQuestsLoginAdminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.romanQuestsLoginAdminBindingNavigator)).BeginInit();
            this.romanQuestsLoginAdminBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.romanQuestsLoginAdminDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // romanQuestsLoginAdminDataSet
            // 
            this.romanQuestsLoginAdminDataSet.DataSetName = "RomanQuestsLoginAdminDataSet";
            this.romanQuestsLoginAdminDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // romanQuestsLoginAdminBindingSource
            // 
            this.romanQuestsLoginAdminBindingSource.DataMember = "RomanQuestsLoginAdmin";
            this.romanQuestsLoginAdminBindingSource.DataSource = this.romanQuestsLoginAdminDataSet;
            // 
            // romanQuestsLoginAdminTableAdapter
            // 
            this.romanQuestsLoginAdminTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RomanQuestsLoginAdminTableAdapter = this.romanQuestsLoginAdminTableAdapter;
            this.tableAdapterManager.UpdateOrder = RomanQuests.RomanQuestsLoginAdminDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // romanQuestsLoginAdminBindingNavigator
            // 
            this.romanQuestsLoginAdminBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.romanQuestsLoginAdminBindingNavigator.BindingSource = this.romanQuestsLoginAdminBindingSource;
            this.romanQuestsLoginAdminBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.romanQuestsLoginAdminBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.romanQuestsLoginAdminBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.romanQuestsLoginAdminBindingNavigatorSaveItem});
            this.romanQuestsLoginAdminBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.romanQuestsLoginAdminBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.romanQuestsLoginAdminBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.romanQuestsLoginAdminBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.romanQuestsLoginAdminBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.romanQuestsLoginAdminBindingNavigator.Name = "romanQuestsLoginAdminBindingNavigator";
            this.romanQuestsLoginAdminBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.romanQuestsLoginAdminBindingNavigator.Size = new System.Drawing.Size(426, 25);
            this.romanQuestsLoginAdminBindingNavigator.TabIndex = 0;
            this.romanQuestsLoginAdminBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 15);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Löschen";
            // 
            // romanQuestsLoginAdminBindingNavigatorSaveItem
            // 
            this.romanQuestsLoginAdminBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.romanQuestsLoginAdminBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("romanQuestsLoginAdminBindingNavigatorSaveItem.Image")));
            this.romanQuestsLoginAdminBindingNavigatorSaveItem.Name = "romanQuestsLoginAdminBindingNavigatorSaveItem";
            this.romanQuestsLoginAdminBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.romanQuestsLoginAdminBindingNavigatorSaveItem.Text = "Daten speichern";
            this.romanQuestsLoginAdminBindingNavigatorSaveItem.Click += new System.EventHandler(this.romanQuestsLoginAdminBindingNavigatorSaveItem_Click);
            // 
            // romanQuestsLoginAdminDataGridView
            // 
            this.romanQuestsLoginAdminDataGridView.AutoGenerateColumns = false;
            this.romanQuestsLoginAdminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.romanQuestsLoginAdminDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.romanQuestsLoginAdminDataGridView.DataSource = this.romanQuestsLoginAdminBindingSource;
            this.romanQuestsLoginAdminDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.romanQuestsLoginAdminDataGridView.Location = new System.Drawing.Point(0, 25);
            this.romanQuestsLoginAdminDataGridView.Name = "romanQuestsLoginAdminDataGridView";
            this.romanQuestsLoginAdminDataGridView.Size = new System.Drawing.Size(426, 298);
            this.romanQuestsLoginAdminDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn2.HeaderText = "Password";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // AdminPasswords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 323);
            this.Controls.Add(this.romanQuestsLoginAdminDataGridView);
            this.Controls.Add(this.romanQuestsLoginAdminBindingNavigator);
            this.Name = "AdminPasswords";
            this.Text = "AdminPasswords";
            this.Load += new System.EventHandler(this.AdminPasswords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.romanQuestsLoginAdminDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.romanQuestsLoginAdminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.romanQuestsLoginAdminBindingNavigator)).EndInit();
            this.romanQuestsLoginAdminBindingNavigator.ResumeLayout(false);
            this.romanQuestsLoginAdminBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.romanQuestsLoginAdminDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RomanQuestsLoginAdminDataSet romanQuestsLoginAdminDataSet;
        private System.Windows.Forms.BindingSource romanQuestsLoginAdminBindingSource;
        private RomanQuestsLoginAdminDataSetTableAdapters.RomanQuestsLoginAdminTableAdapter romanQuestsLoginAdminTableAdapter;
        private RomanQuestsLoginAdminDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator romanQuestsLoginAdminBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton romanQuestsLoginAdminBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView romanQuestsLoginAdminDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}