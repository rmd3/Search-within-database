
namespace D_Anjolell_cc1
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
            this.patientsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.patientsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.patientsDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.txtSearchAddress = new System.Windows.Forms.TextBox();
            this.btnSearchAddress = new System.Windows.Forms.Button();
            this.txtSearchPhone = new System.Windows.Forms.TextBox();
            this.btnSearchPhone = new System.Windows.Forms.Button();
            this.txtSearchEmail = new System.Windows.Forms.TextBox();
            this.btnSearchEmail = new System.Windows.Forms.Button();
            this.txtSearchDeductible = new System.Windows.Forms.TextBox();
            this.btnSearchDeductible = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalDataSet = new D_Anjolell_cc1.MedicalDataSet();
            this.patientsTableAdapter = new D_Anjolell_cc1.MedicalDataSetTableAdapters.PatientsTableAdapter();
            this.tableAdapterManager = new D_Anjolell_cc1.MedicalDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingNavigator)).BeginInit();
            this.patientsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // patientsBindingNavigator
            // 
            this.patientsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patientsBindingNavigator.BindingSource = this.patientsBindingSource;
            this.patientsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patientsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patientsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.patientsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.patientsBindingNavigatorSaveItem});
            this.patientsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patientsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patientsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patientsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patientsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patientsBindingNavigator.Name = "patientsBindingNavigator";
            this.patientsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patientsBindingNavigator.Size = new System.Drawing.Size(1106, 31);
            this.patientsBindingNavigator.TabIndex = 0;
            this.patientsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // patientsBindingNavigatorSaveItem
            // 
            this.patientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patientsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patientsBindingNavigatorSaveItem.Image")));
            this.patientsBindingNavigatorSaveItem.Name = "patientsBindingNavigatorSaveItem";
            this.patientsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.patientsBindingNavigatorSaveItem.Text = "Save Data";
            this.patientsBindingNavigatorSaveItem.Click += new System.EventHandler(this.patientsBindingNavigatorSaveItem_Click);
            // 
            // patientsDataGridView
            // 
            this.patientsDataGridView.AutoGenerateColumns = false;
            this.patientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.patientsDataGridView.DataSource = this.patientsBindingSource;
            this.patientsDataGridView.Location = new System.Drawing.Point(12, 43);
            this.patientsDataGridView.Name = "patientsDataGridView";
            this.patientsDataGridView.RowHeadersWidth = 51;
            this.patientsDataGridView.RowTemplate.Height = 24;
            this.patientsDataGridView.Size = new System.Drawing.Size(1077, 307);
            this.patientsDataGridView.TabIndex = 1;
            // 
            // btnSearchName
            // 
            this.btnSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSearchName.Location = new System.Drawing.Point(29, 429);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(183, 48);
            this.btnSearchName.TabIndex = 2;
            this.btnSearchName.Text = "Search Name";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSearchName.Location = new System.Drawing.Point(12, 369);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(216, 34);
            this.txtSearchName.TabIndex = 3;
            // 
            // txtSearchAddress
            // 
            this.txtSearchAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSearchAddress.Location = new System.Drawing.Point(294, 369);
            this.txtSearchAddress.Name = "txtSearchAddress";
            this.txtSearchAddress.Size = new System.Drawing.Size(216, 34);
            this.txtSearchAddress.TabIndex = 5;
            // 
            // btnSearchAddress
            // 
            this.btnSearchAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSearchAddress.Location = new System.Drawing.Point(294, 429);
            this.btnSearchAddress.Name = "btnSearchAddress";
            this.btnSearchAddress.Size = new System.Drawing.Size(216, 48);
            this.btnSearchAddress.TabIndex = 4;
            this.btnSearchAddress.Text = "Search Address";
            this.btnSearchAddress.UseVisualStyleBackColor = true;
            this.btnSearchAddress.Click += new System.EventHandler(this.btnSearchAddress_Click);
            // 
            // txtSearchPhone
            // 
            this.txtSearchPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSearchPhone.Location = new System.Drawing.Point(585, 369);
            this.txtSearchPhone.Name = "txtSearchPhone";
            this.txtSearchPhone.Size = new System.Drawing.Size(216, 34);
            this.txtSearchPhone.TabIndex = 7;
            // 
            // btnSearchPhone
            // 
            this.btnSearchPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSearchPhone.Location = new System.Drawing.Point(585, 429);
            this.btnSearchPhone.Name = "btnSearchPhone";
            this.btnSearchPhone.Size = new System.Drawing.Size(216, 48);
            this.btnSearchPhone.TabIndex = 6;
            this.btnSearchPhone.Text = "Search Phone";
            this.btnSearchPhone.UseVisualStyleBackColor = true;
            this.btnSearchPhone.Click += new System.EventHandler(this.btnSearchPhone_Click);
            // 
            // txtSearchEmail
            // 
            this.txtSearchEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSearchEmail.Location = new System.Drawing.Point(873, 369);
            this.txtSearchEmail.Name = "txtSearchEmail";
            this.txtSearchEmail.Size = new System.Drawing.Size(216, 34);
            this.txtSearchEmail.TabIndex = 9;
            // 
            // btnSearchEmail
            // 
            this.btnSearchEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSearchEmail.Location = new System.Drawing.Point(890, 429);
            this.btnSearchEmail.Name = "btnSearchEmail";
            this.btnSearchEmail.Size = new System.Drawing.Size(183, 48);
            this.btnSearchEmail.TabIndex = 8;
            this.btnSearchEmail.Text = "Search Email";
            this.btnSearchEmail.UseVisualStyleBackColor = true;
            this.btnSearchEmail.Click += new System.EventHandler(this.btnSearchEmail_Click);
            // 
            // txtSearchDeductible
            // 
            this.txtSearchDeductible.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSearchDeductible.Location = new System.Drawing.Point(294, 508);
            this.txtSearchDeductible.Name = "txtSearchDeductible";
            this.txtSearchDeductible.Size = new System.Drawing.Size(216, 34);
            this.txtSearchDeductible.TabIndex = 11;
            // 
            // btnSearchDeductible
            // 
            this.btnSearchDeductible.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSearchDeductible.Location = new System.Drawing.Point(284, 566);
            this.btnSearchDeductible.Name = "btnSearchDeductible";
            this.btnSearchDeductible.Size = new System.Drawing.Size(236, 48);
            this.btnSearchDeductible.TabIndex = 10;
            this.btnSearchDeductible.Text = "Search Deductible";
            this.btnSearchDeductible.UseVisualStyleBackColor = true;
            this.btnSearchDeductible.Click += new System.EventHandler(this.btnSearchDeductible_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnShowAll.Location = new System.Drawing.Point(602, 529);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(183, 48);
            this.btnShowAll.TabIndex = 12;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PatientID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PatientID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Deductible Limit";
            this.dataGridViewTextBoxColumn6.HeaderText = "Deductible Limit";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.medicalDataSet;
            // 
            // medicalDataSet
            // 
            this.medicalDataSet.DataSetName = "MedicalDataSet";
            this.medicalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PatientsTableAdapter = this.patientsTableAdapter;
            this.tableAdapterManager.UpdateOrder = D_Anjolell_cc1.MedicalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 639);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.txtSearchDeductible);
            this.Controls.Add(this.btnSearchDeductible);
            this.Controls.Add(this.txtSearchEmail);
            this.Controls.Add(this.btnSearchEmail);
            this.Controls.Add(this.txtSearchPhone);
            this.Controls.Add(this.btnSearchPhone);
            this.Controls.Add(this.txtSearchAddress);
            this.Controls.Add(this.btnSearchAddress);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.btnSearchName);
            this.Controls.Add(this.patientsDataGridView);
            this.Controls.Add(this.patientsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingNavigator)).EndInit();
            this.patientsBindingNavigator.ResumeLayout(false);
            this.patientsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MedicalDataSet medicalDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private MedicalDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private MedicalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patientsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton patientsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView patientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.TextBox txtSearchAddress;
        private System.Windows.Forms.Button btnSearchAddress;
        private System.Windows.Forms.TextBox txtSearchPhone;
        private System.Windows.Forms.Button btnSearchPhone;
        private System.Windows.Forms.TextBox txtSearchEmail;
        private System.Windows.Forms.Button btnSearchEmail;
        private System.Windows.Forms.TextBox txtSearchDeductible;
        private System.Windows.Forms.Button btnSearchDeductible;
        private System.Windows.Forms.Button btnShowAll;
    }
}

