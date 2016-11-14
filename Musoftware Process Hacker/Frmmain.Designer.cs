namespace Musoftware_Process_Hacker
{
    partial class Frmmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmmain));
            this.ProList = new GetObjectX.ListViewEX();
            this.Process = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ParentProcessId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ParentProName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThreadCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Processor_Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PageFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PageFaults = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkingSetSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Caption_o = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreationClassName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CSCreationClassName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CSName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Handle_O = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HandleCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InstallDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KernelModeTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaximumWorkingSetSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinimumWorkingSetSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_O = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OSCreationClassName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OSName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OtherOperationCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OtherTransferCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PeakPageFileUsage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PeakVirtualSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PeakWorkingSetSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrivatePageCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuotaNonPagedPoolUsage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuotaPagedPoolUsage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuotaPeakNonPagedPoolUsage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuotaPeakPagedPoolUsage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReadOperationCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReadTransferCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SessionId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserModeTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VirtualSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WindowsVersion_O = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WriteOperationCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WriteTransferCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.KillCheckedProcess = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ImageList2 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProList
            // 
            this.ProList.CheckBoxes = true;
            this.ProList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Process,
            this.ID,
            this.Path,
            this.ParentProcessId,
            this.ParentProName,
            this.ThreadCount,
            this.Priority,
            this.Processor_Time,
            this.PageFileSize,
            this.PageFaults,
            this.WorkingSetSize,
            this.CreationDate,
            this.Caption_o,
            this.CreationClassName,
            this.CSCreationClassName,
            this.CSName,
            this.Description,
            this.Handle_O,
            this.HandleCount,
            this.InstallDate,
            this.KernelModeTime,
            this.MaximumWorkingSetSize,
            this.MinimumWorkingSetSize,
            this.Name_O,
            this.OSCreationClassName,
            this.OSName,
            this.OtherOperationCount,
            this.OtherTransferCount,
            this.PeakPageFileUsage,
            this.PeakVirtualSize,
            this.PeakWorkingSetSize,
            this.PrivatePageCount,
            this.QuotaNonPagedPoolUsage,
            this.QuotaPagedPoolUsage,
            this.QuotaPeakNonPagedPoolUsage,
            this.QuotaPeakPagedPoolUsage,
            this.ReadOperationCount,
            this.ReadTransferCount,
            this.SessionId,
            this.Status,
            this.UserModeTime,
            this.VirtualSize,
            this.WindowsVersion_O,
            this.WriteOperationCount,
            this.WriteTransferCount});
            this.ProList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProList.FullRowSelect = true;
            this.ProList.Location = new System.Drawing.Point(0, 0);
            this.ProList.MultiSelect = false;
            this.ProList.Name = "ProList";
            this.ProList.Size = new System.Drawing.Size(750, 351);
            this.ProList.TabIndex = 2;
            this.ProList.UseCompatibleStateImageBehavior = false;
            this.ProList.View = System.Windows.Forms.View.Details;
            this.ProList.WatermarkAlpha = 200;
            this.ProList.WatermarkImage = ((System.Drawing.Bitmap)(resources.GetObject("ProList.WatermarkImage")));
            this.ProList.SelectedIndexChanged += new System.EventHandler(this.ProList_SelectedIndexChanged);
            // 
            // Process
            // 
            this.Process.Text = "Process";
            this.Process.Width = 100;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 46;
            // 
            // Path
            // 
            this.Path.Text = "Path";
            this.Path.Width = 198;
            // 
            // ParentProcessId
            // 
            this.ParentProcessId.Text = "ParentProcessId";
            this.ParentProcessId.Width = 98;
            // 
            // ParentProName
            // 
            this.ParentProName.Text = "ParentProName";
            this.ParentProName.Width = 92;
            // 
            // ThreadCount
            // 
            this.ThreadCount.Text = "ThreadCount";
            this.ThreadCount.Width = 61;
            // 
            // Priority
            // 
            this.Priority.Text = "Priority";
            // 
            // Processor_Time
            // 
            this.Processor_Time.Text = "Processor Time";
            this.Processor_Time.Width = 90;
            // 
            // PageFileSize
            // 
            this.PageFileSize.Text = "Page File Size";
            this.PageFileSize.Width = 92;
            // 
            // PageFaults
            // 
            this.PageFaults.Text = "Page Faults";
            this.PageFaults.Width = 76;
            // 
            // WorkingSetSize
            // 
            this.WorkingSetSize.Text = "WorkingSetSize";
            this.WorkingSetSize.Width = 99;
            // 
            // CreationDate
            // 
            this.CreationDate.Text = "CreationDate";
            this.CreationDate.Width = 150;
            // 
            // Caption_o
            // 
            this.Caption_o.Text = "Caption";
            // 
            // CreationClassName
            // 
            this.CreationClassName.Text = "CreationClassName";
            // 
            // CSCreationClassName
            // 
            this.CSCreationClassName.Text = "CSCreationClassName";
            // 
            // CSName
            // 
            this.CSName.Text = "CSName";
            // 
            // Description
            // 
            this.Description.Text = "Description";
            // 
            // Handle_O
            // 
            this.Handle_O.Text = "Handle";
            // 
            // HandleCount
            // 
            this.HandleCount.Text = "HandleCount";
            // 
            // InstallDate
            // 
            this.InstallDate.Text = "InstallDate";
            // 
            // KernelModeTime
            // 
            this.KernelModeTime.Text = "KernelModeTime";
            // 
            // MaximumWorkingSetSize
            // 
            this.MaximumWorkingSetSize.Text = "MaximumWorkingSetSize";
            // 
            // MinimumWorkingSetSize
            // 
            this.MinimumWorkingSetSize.Text = "MinimumWorkingSetSize";
            // 
            // Name_O
            // 
            this.Name_O.Text = "Name";
            // 
            // OSCreationClassName
            // 
            this.OSCreationClassName.Text = "OSCreationClassName";
            // 
            // OSName
            // 
            this.OSName.Text = "OSName";
            // 
            // OtherOperationCount
            // 
            this.OtherOperationCount.Text = "OtherOperationCount";
            // 
            // OtherTransferCount
            // 
            this.OtherTransferCount.Text = "OtherTransferCount";
            // 
            // PeakPageFileUsage
            // 
            this.PeakPageFileUsage.Text = "PeakPageFileUsage";
            // 
            // PeakVirtualSize
            // 
            this.PeakVirtualSize.Text = "PeakVirtualSize";
            // 
            // PeakWorkingSetSize
            // 
            this.PeakWorkingSetSize.Text = "PeakWorkingSetSize";
            // 
            // PrivatePageCount
            // 
            this.PrivatePageCount.Text = "PrivatePageCount";
            // 
            // QuotaNonPagedPoolUsage
            // 
            this.QuotaNonPagedPoolUsage.Text = "QuotaNonPagedPoolUsage";
            // 
            // QuotaPagedPoolUsage
            // 
            this.QuotaPagedPoolUsage.Text = "QuotaPagedPoolUsage";
            // 
            // QuotaPeakNonPagedPoolUsage
            // 
            this.QuotaPeakNonPagedPoolUsage.Text = "QuotaPeakNonPagedPoolUsage";
            // 
            // QuotaPeakPagedPoolUsage
            // 
            this.QuotaPeakPagedPoolUsage.Text = "QuotaPeakPagedPoolUsage";
            // 
            // ReadOperationCount
            // 
            this.ReadOperationCount.Text = "ReadOperationCount";
            // 
            // ReadTransferCount
            // 
            this.ReadTransferCount.Text = "ReadTransferCount";
            // 
            // SessionId
            // 
            this.SessionId.Text = "SessionId";
            // 
            // Status
            // 
            this.Status.Text = "Status";
            // 
            // UserModeTime
            // 
            this.UserModeTime.Text = "UserModeTime";
            // 
            // VirtualSize
            // 
            this.VirtualSize.Text = "VirtualSize";
            // 
            // WindowsVersion_O
            // 
            this.WindowsVersion_O.Text = "WindowsVersion";
            // 
            // WriteOperationCount
            // 
            this.WriteOperationCount.Text = "WriteOperationCount";
            // 
            // WriteTransferCount
            // 
            this.WriteTransferCount.Text = "WriteTransferCount";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.KillCheckedProcess);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 49);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(596, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KillCheckedProcess
            // 
            this.KillCheckedProcess.Location = new System.Drawing.Point(12, 12);
            this.KillCheckedProcess.Name = "KillCheckedProcess";
            this.KillCheckedProcess.Size = new System.Drawing.Size(141, 23);
            this.KillCheckedProcess.TabIndex = 10;
            this.KillCheckedProcess.Text = "Kill Checked Process";
            this.KillCheckedProcess.UseVisualStyleBackColor = true;
            this.KillCheckedProcess.Click += new System.EventHandler(this.KillCheckedProcess_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.InWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.AfterDone);
            // 
            // ImageList2
            // 
            this.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ImageList2.ImageSize = new System.Drawing.Size(18, 18);
            this.ImageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(750, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(88, 17);
            this.toolStripStatusLabel1.Text = "Program State :";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel2.Text = "_____";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 422);
            this.Controls.Add(this.ProList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(726, 460);
            this.Name = "Frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musoftware Process";
            this.Load += new System.EventHandler(this.InLoad);
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal GetObjectX.ListViewEX ProList;
        internal System.Windows.Forms.ColumnHeader Process;
        internal System.Windows.Forms.ColumnHeader ID;
        internal System.Windows.Forms.ColumnHeader Path;
        internal System.Windows.Forms.ColumnHeader ParentProcessId;
        internal System.Windows.Forms.ColumnHeader ParentProName;
        internal System.Windows.Forms.ColumnHeader ThreadCount;
        internal System.Windows.Forms.ColumnHeader Priority;
        internal System.Windows.Forms.ColumnHeader Processor_Time;
        internal System.Windows.Forms.ColumnHeader PageFileSize;
        internal System.Windows.Forms.ColumnHeader PageFaults;
        internal System.Windows.Forms.ColumnHeader WorkingSetSize;
        internal System.Windows.Forms.ColumnHeader CreationDate;
        internal System.Windows.Forms.ColumnHeader Caption_o;
        internal System.Windows.Forms.ColumnHeader CreationClassName;
        internal System.Windows.Forms.ColumnHeader CSCreationClassName;
        internal System.Windows.Forms.ColumnHeader CSName;
        internal System.Windows.Forms.ColumnHeader Description;
        internal System.Windows.Forms.ColumnHeader Handle_O;
        internal System.Windows.Forms.ColumnHeader HandleCount;
        internal System.Windows.Forms.ColumnHeader InstallDate;
        internal System.Windows.Forms.ColumnHeader KernelModeTime;
        internal System.Windows.Forms.ColumnHeader MaximumWorkingSetSize;
        internal System.Windows.Forms.ColumnHeader MinimumWorkingSetSize;
        internal System.Windows.Forms.ColumnHeader Name_O;
        internal System.Windows.Forms.ColumnHeader OSCreationClassName;
        internal System.Windows.Forms.ColumnHeader OSName;
        internal System.Windows.Forms.ColumnHeader OtherOperationCount;
        internal System.Windows.Forms.ColumnHeader OtherTransferCount;
        internal System.Windows.Forms.ColumnHeader PeakPageFileUsage;
        internal System.Windows.Forms.ColumnHeader PeakVirtualSize;
        internal System.Windows.Forms.ColumnHeader PeakWorkingSetSize;
        internal System.Windows.Forms.ColumnHeader PrivatePageCount;
        internal System.Windows.Forms.ColumnHeader QuotaNonPagedPoolUsage;
        internal System.Windows.Forms.ColumnHeader QuotaPagedPoolUsage;
        internal System.Windows.Forms.ColumnHeader QuotaPeakNonPagedPoolUsage;
        internal System.Windows.Forms.ColumnHeader QuotaPeakPagedPoolUsage;
        internal System.Windows.Forms.ColumnHeader ReadOperationCount;
        internal System.Windows.Forms.ColumnHeader ReadTransferCount;
        internal System.Windows.Forms.ColumnHeader SessionId;
        internal System.Windows.Forms.ColumnHeader Status;
        internal System.Windows.Forms.ColumnHeader UserModeTime;
        internal System.Windows.Forms.ColumnHeader VirtualSize;
        internal System.Windows.Forms.ColumnHeader WindowsVersion_O;
        internal System.Windows.Forms.ColumnHeader WriteOperationCount;
        internal System.Windows.Forms.ColumnHeader WriteTransferCount;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button KillCheckedProcess;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        internal System.Windows.Forms.ImageList ImageList2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        internal System.Windows.Forms.Button button1;
    }
}

