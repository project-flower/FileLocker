
namespace FileLocker
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listViewFiles = new DoubleBufferedListView();
            this.columnHeaderFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxOperation = new System.Windows.Forms.GroupBox();
            this.checkBoxDelete = new System.Windows.Forms.CheckBox();
            this.checkBoxWrite = new System.Windows.Forms.CheckBox();
            this.checkBoxRead = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.checkBoxImmediately = new System.Windows.Forms.CheckBox();
            this.buttonLock = new System.Windows.Forms.Button();
            this.buttonRelease = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewFiles
            // 
            this.listViewFiles.AllowDrop = true;
            this.listViewFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFileName,
            this.columnHeaderPath});
            this.listViewFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewFiles.HideSelection = false;
            this.listViewFiles.Location = new System.Drawing.Point(12, 12);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(376, 186);
            this.listViewFiles.SmallImageList = this.imageList;
            this.listViewFiles.TabIndex = 0;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            this.listViewFiles.VirtualMode = true;
            this.listViewFiles.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.listViewFiles_RetrieveVirtualItem);
            this.listViewFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewFiles_DragDrop);
            this.listViewFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewFiles_DragEnter);
            // 
            // columnHeaderFileName
            // 
            this.columnHeaderFileName.Text = "File Name";
            this.columnHeaderFileName.Width = 120;
            // 
            // columnHeaderPath
            // 
            this.columnHeaderPath.Text = "Path";
            this.columnHeaderPath.Width = 240;
            // 
            // groupBoxOperation
            // 
            this.groupBoxOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxOperation.Controls.Add(this.checkBoxDelete);
            this.groupBoxOperation.Controls.Add(this.checkBoxWrite);
            this.groupBoxOperation.Controls.Add(this.checkBoxRead);
            this.groupBoxOperation.Location = new System.Drawing.Point(12, 204);
            this.groupBoxOperation.Name = "groupBoxOperation";
            this.groupBoxOperation.Size = new System.Drawing.Size(74, 84);
            this.groupBoxOperation.TabIndex = 1;
            this.groupBoxOperation.TabStop = false;
            this.groupBoxOperation.Text = "&Operations";
            // 
            // checkBoxDelete
            // 
            this.checkBoxDelete.AutoSize = true;
            this.checkBoxDelete.Checked = true;
            this.checkBoxDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDelete.Location = new System.Drawing.Point(6, 62);
            this.checkBoxDelete.Name = "checkBoxDelete";
            this.checkBoxDelete.Size = new System.Drawing.Size(57, 16);
            this.checkBoxDelete.TabIndex = 2;
            this.checkBoxDelete.Text = "&Delete";
            this.checkBoxDelete.UseVisualStyleBackColor = true;
            // 
            // checkBoxWrite
            // 
            this.checkBoxWrite.AutoSize = true;
            this.checkBoxWrite.Checked = true;
            this.checkBoxWrite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWrite.Location = new System.Drawing.Point(6, 40);
            this.checkBoxWrite.Name = "checkBoxWrite";
            this.checkBoxWrite.Size = new System.Drawing.Size(50, 16);
            this.checkBoxWrite.TabIndex = 1;
            this.checkBoxWrite.Text = "&Write";
            this.checkBoxWrite.UseVisualStyleBackColor = true;
            // 
            // checkBoxRead
            // 
            this.checkBoxRead.AutoSize = true;
            this.checkBoxRead.Checked = true;
            this.checkBoxRead.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRead.Location = new System.Drawing.Point(6, 18);
            this.checkBoxRead.Name = "checkBoxRead";
            this.checkBoxRead.Size = new System.Drawing.Size(50, 16);
            this.checkBoxRead.TabIndex = 0;
            this.checkBoxRead.Text = "&Read";
            this.checkBoxRead.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(151, 204);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.Location = new System.Drawing.Point(232, 204);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Re&move";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(313, 204);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "&Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // checkBoxImmediately
            // 
            this.checkBoxImmediately.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxImmediately.AutoSize = true;
            this.checkBoxImmediately.Checked = true;
            this.checkBoxImmediately.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxImmediately.Location = new System.Drawing.Point(275, 243);
            this.checkBoxImmediately.Name = "checkBoxImmediately";
            this.checkBoxImmediately.Size = new System.Drawing.Size(113, 16);
            this.checkBoxImmediately.TabIndex = 5;
            this.checkBoxImmediately.Text = "Lock &immediately";
            this.checkBoxImmediately.UseVisualStyleBackColor = true;
            // 
            // buttonLock
            // 
            this.buttonLock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLock.Location = new System.Drawing.Point(232, 265);
            this.buttonLock.Name = "buttonLock";
            this.buttonLock.Size = new System.Drawing.Size(75, 23);
            this.buttonLock.TabIndex = 6;
            this.buttonLock.Text = "&Lock";
            this.buttonLock.UseVisualStyleBackColor = true;
            this.buttonLock.Click += new System.EventHandler(this.buttonLock_Click);
            // 
            // buttonRelease
            // 
            this.buttonRelease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRelease.Location = new System.Drawing.Point(313, 265);
            this.buttonRelease.Name = "buttonRelease";
            this.buttonRelease.Size = new System.Drawing.Size(75, 23);
            this.buttonRelease.TabIndex = 7;
            this.buttonRelease.Text = "Re&lease";
            this.buttonRelease.UseVisualStyleBackColor = true;
            this.buttonRelease.Click += new System.EventHandler(this.buttonRelease_Click);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Title = "Add";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.buttonRelease);
            this.Controls.Add(this.buttonLock);
            this.Controls.Add(this.checkBoxImmediately);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxOperation);
            this.Controls.Add(this.listViewFiles);
            this.Name = "FormMain";
            this.Text = "FileLocker";
            this.Shown += new System.EventHandler(this.shown);
            this.groupBoxOperation.ResumeLayout(false);
            this.groupBoxOperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DoubleBufferedListView listViewFiles;
        private System.Windows.Forms.ColumnHeader columnHeaderFileName;
        private System.Windows.Forms.ColumnHeader columnHeaderPath;
        private System.Windows.Forms.GroupBox groupBoxOperation;
        private System.Windows.Forms.CheckBox checkBoxDelete;
        private System.Windows.Forms.CheckBox checkBoxWrite;
        private System.Windows.Forms.CheckBox checkBoxRead;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.CheckBox checkBoxImmediately;
        private System.Windows.Forms.Button buttonLock;
        private System.Windows.Forms.Button buttonRelease;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

