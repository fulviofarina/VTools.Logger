namespace VTools
{
    partial class Logger
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
		   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
		   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logger));
		   this.TLP = new System.Windows.Forms.TableLayoutPanel();
		   this.DGV = new System.Windows.Forms.DataGridView();
		   this.BS = new System.Windows.Forms.BindingSource(this.components);
		   this.BN = new System.Windows.Forms.BindingNavigator(this.components);
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
		   this.TLP.SuspendLayout();
		   ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
		   ((System.ComponentModel.ISupportInitialize)(this.BS)).BeginInit();
		   ((System.ComponentModel.ISupportInitialize)(this.BN)).BeginInit();
		   this.BN.SuspendLayout();
		   this.SuspendLayout();
		   // 
		   // TLP
		   // 
		   this.TLP.ColumnCount = 1;
		   this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.61074F));
		   this.TLP.Controls.Add(this.DGV, 0, 1);
		   this.TLP.Controls.Add(this.BN, 0, 0);
		   this.TLP.Dock = System.Windows.Forms.DockStyle.Fill;
		   this.TLP.Location = new System.Drawing.Point(0, 0);
		   this.TLP.Margin = new System.Windows.Forms.Padding(2);
		   this.TLP.Name = "TLP";
		   this.TLP.RowCount = 2;
		   this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.904762F));
		   this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.09524F));
		   this.TLP.Size = new System.Drawing.Size(724, 436);
		   this.TLP.TabIndex = 0;
		   // 
		   // DGV
		   // 
		   this.DGV.AllowUserToOrderColumns = true;
		   this.DGV.AutoGenerateColumns = false;
		   this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
		   this.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
		   this.DGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
		   this.DGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
		   this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		   this.DGV.DataSource = this.BS;
		   dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		   dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
		   dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		   dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
		   dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		   dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		   dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		   this.DGV.DefaultCellStyle = dataGridViewCellStyle1;
		   this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
		   this.DGV.Location = new System.Drawing.Point(2, 27);
		   this.DGV.Margin = new System.Windows.Forms.Padding(2);
		   this.DGV.Name = "DGV";
		   this.DGV.RowTemplate.Height = 24;
		   this.DGV.Size = new System.Drawing.Size(720, 407);
		   this.DGV.TabIndex = 0;
		   // 
		   // BN
		   // 
		   this.BN.AddNewItem = this.bindingNavigatorAddNewItem;
		   this.BN.BindingSource = this.BS;
		   this.BN.CountItem = this.bindingNavigatorCountItem;
		   this.BN.DeleteItem = this.bindingNavigatorDeleteItem;
		   this.BN.Dock = System.Windows.Forms.DockStyle.Fill;
		   this.BN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
		   this.BN.Location = new System.Drawing.Point(0, 0);
		   this.BN.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
		   this.BN.MoveLastItem = this.bindingNavigatorMoveLastItem;
		   this.BN.MoveNextItem = this.bindingNavigatorMoveNextItem;
		   this.BN.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
		   this.BN.Name = "BN";
		   this.BN.PositionItem = this.bindingNavigatorPositionItem;
		   this.BN.Size = new System.Drawing.Size(724, 25);
		   this.BN.TabIndex = 1;
		   this.BN.Text = "bindingNavigator1";
		   // 
		   // bindingNavigatorAddNewItem
		   // 
		   this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		   this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
		   this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
		   this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
		   this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
		   this.bindingNavigatorAddNewItem.Text = "Add new";
		   // 
		   // bindingNavigatorCountItem
		   // 
		   this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
		   this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
		   this.bindingNavigatorCountItem.Text = "of {0}";
		   this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
		   // 
		   // bindingNavigatorDeleteItem
		   // 
		   this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		   this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
		   this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
		   this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
		   this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
		   this.bindingNavigatorDeleteItem.Text = "Delete";
		   // 
		   // bindingNavigatorMoveFirstItem
		   // 
		   this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		   this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
		   this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
		   this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
		   this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
		   this.bindingNavigatorMoveFirstItem.Text = "Move first";
		   // 
		   // bindingNavigatorMovePreviousItem
		   // 
		   this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		   this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
		   this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
		   this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
		   this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
		   this.bindingNavigatorMovePreviousItem.Text = "Move previous";
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
		   this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
		   this.bindingNavigatorPositionItem.Text = "0";
		   this.bindingNavigatorPositionItem.ToolTipText = "Current position";
		   // 
		   // bindingNavigatorSeparator1
		   // 
		   this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
		   this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
		   // 
		   // bindingNavigatorMoveNextItem
		   // 
		   this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		   this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
		   this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
		   this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
		   this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
		   this.bindingNavigatorMoveNextItem.Text = "Move next";
		   // 
		   // bindingNavigatorMoveLastItem
		   // 
		   this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		   this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
		   this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
		   this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
		   this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
		   this.bindingNavigatorMoveLastItem.Text = "Move last";
		   // 
		   // bindingNavigatorSeparator2
		   // 
		   this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
		   this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
		   // 
		   // Logger
		   // 
		   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
		   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		   this.ClientSize = new System.Drawing.Size(724, 436);
		   this.Controls.Add(this.TLP);
		   this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
		   this.Margin = new System.Windows.Forms.Padding(2);
		   this.Name = "Logger";
		   this.Text = "Logger";
		   this.TLP.ResumeLayout(false);
		   this.TLP.PerformLayout();
		   ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
		   ((System.ComponentModel.ISupportInitialize)(this.BS)).EndInit();
		   ((System.ComponentModel.ISupportInitialize)(this.BN)).EndInit();
		   this.BN.ResumeLayout(false);
		   this.BN.PerformLayout();
		   this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP;
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
        private System.Windows.Forms.BindingSource BS;
        private System.Windows.Forms.BindingNavigator BN;
        private System.Windows.Forms.DataGridView DGV;
    }
}