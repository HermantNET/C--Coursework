namespace Chapter_14.Exercises
{
    partial class Exercise_8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercise_8));
            System.Windows.Forms.Label courseNumberLabel;
            System.Windows.Forms.Label iSBNLabel;
            this.courseBooksDS = new Chapter_14.CourseBooksDS();
            this.courseBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseBooksTableAdapter = new Chapter_14.CourseBooksDSTableAdapters.CourseBooksTableAdapter();
            this.tableAdapterManager = new Chapter_14.CourseBooksDSTableAdapters.TableAdapterManager();
            this.courseBooksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            this.courseNumberTextBox = new System.Windows.Forms.TextBox();
            courseNumberLabel = new System.Windows.Forms.Label();
            iSBNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseBooksDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBooksBindingNavigator)).BeginInit();
            this.courseBooksBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseBooksDS
            // 
            this.courseBooksDS.DataSetName = "CourseBooksDS";
            this.courseBooksDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBooksBindingSource
            // 
            this.courseBooksBindingSource.DataMember = "CourseBooks";
            this.courseBooksBindingSource.DataSource = this.courseBooksDS;
            // 
            // courseBooksTableAdapter
            // 
            this.courseBooksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CourseBooksTableAdapter = this.courseBooksTableAdapter;
            this.tableAdapterManager.UpdateOrder = Chapter_14.CourseBooksDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // courseBooksBindingNavigator
            // 
            this.courseBooksBindingNavigator.AddNewItem = null;
            this.courseBooksBindingNavigator.BindingSource = this.courseBooksBindingSource;
            this.courseBooksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.courseBooksBindingNavigator.DeleteItem = null;
            this.courseBooksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.courseBooksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.courseBooksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.courseBooksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.courseBooksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.courseBooksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.courseBooksBindingNavigator.Name = "courseBooksBindingNavigator";
            this.courseBooksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.courseBooksBindingNavigator.Size = new System.Drawing.Size(284, 25);
            this.courseBooksBindingNavigator.TabIndex = 0;
            this.courseBooksBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBooksBindingSource, "ISBN", true));
            this.iSBNTextBox.Location = new System.Drawing.Point(132, 57);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.ReadOnly = true;
            this.iSBNTextBox.Size = new System.Drawing.Size(100, 20);
            this.iSBNTextBox.TabIndex = 2;
            // 
            // courseNumberTextBox
            // 
            this.courseNumberTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.courseNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBooksBindingSource, "CourseNumber", true));
            this.courseNumberTextBox.Location = new System.Drawing.Point(132, 83);
            this.courseNumberTextBox.Name = "courseNumberTextBox";
            this.courseNumberTextBox.ReadOnly = true;
            this.courseNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.courseNumberTextBox.TabIndex = 4;
            // 
            // courseNumberLabel
            // 
            courseNumberLabel.AutoSize = true;
            courseNumberLabel.Location = new System.Drawing.Point(43, 86);
            courseNumberLabel.Name = "courseNumberLabel";
            courseNumberLabel.Size = new System.Drawing.Size(83, 13);
            courseNumberLabel.TabIndex = 3;
            courseNumberLabel.Text = "Course Number:";
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Location = new System.Drawing.Point(43, 60);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(35, 13);
            iSBNLabel.TabIndex = 1;
            iSBNLabel.Text = "ISBN:";
            // 
            // Exercise_8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 135);
            this.Controls.Add(iSBNLabel);
            this.Controls.Add(this.iSBNTextBox);
            this.Controls.Add(courseNumberLabel);
            this.Controls.Add(this.courseNumberTextBox);
            this.Controls.Add(this.courseBooksBindingNavigator);
            this.Name = "Exercise_8";
            this.Text = "Exercise_8";
            this.Load += new System.EventHandler(this.Exercise_8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseBooksDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBooksBindingNavigator)).EndInit();
            this.courseBooksBindingNavigator.ResumeLayout(false);
            this.courseBooksBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CourseBooksDS courseBooksDS;
        private System.Windows.Forms.BindingSource courseBooksBindingSource;
        private CourseBooksDSTableAdapters.CourseBooksTableAdapter courseBooksTableAdapter;
        private CourseBooksDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator courseBooksBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox iSBNTextBox;
        private System.Windows.Forms.TextBox courseNumberTextBox;
    }
}