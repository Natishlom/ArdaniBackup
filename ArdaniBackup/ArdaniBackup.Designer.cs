namespace ArdaniBackup
{
    partial class ArdaniBackup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.bodyMessage = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.dataBackup = new System.Windows.Forms.DataGridView();
            this.colType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnOn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTiming = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panelTitle.SuspendLayout();
            this.bodyMessage.SuspendLayout();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBackup)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Aharoni", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Location = new System.Drawing.Point(449, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ardani Backup";
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1245, 56);
            this.panelTitle.TabIndex = 2;
            // 
            // bodyMessage
            // 
            this.bodyMessage.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.bodyMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(63)))), ((int)(((byte)(115)))));
            this.bodyMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bodyMessage.Controls.Add(this.dataBackup);
            this.bodyMessage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bodyMessage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bodyMessage.Location = new System.Drawing.Point(4, 22);
            this.bodyMessage.Name = "bodyMessage";
            this.bodyMessage.Padding = new System.Windows.Forms.Padding(3);
            this.bodyMessage.Size = new System.Drawing.Size(1237, 660);
            this.bodyMessage.TabIndex = 1;
            this.bodyMessage.Text = "סיכום:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.bodyMessage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 56);
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl.RightToLeftLayout = true;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1245, 686);
            this.tabControl.TabIndex = 3;
            // 
            // dataBackup
            // 
            this.dataBackup.AllowUserToResizeColumns = false;
            this.dataBackup.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataBackup.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataBackup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBackup.BackgroundColor = System.Drawing.Color.White;
            this.dataBackup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataBackup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataBackup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBackup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colType,
            this.colSource,
            this.colTarget,
            this.colTurnOn,
            this.colDate,
            this.colTiming});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataBackup.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataBackup.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataBackup.EnableHeadersVisualStyles = false;
            this.dataBackup.GridColor = System.Drawing.Color.SteelBlue;
            this.dataBackup.Location = new System.Drawing.Point(3, 3);
            this.dataBackup.MultiSelect = false;
            this.dataBackup.Name = "dataBackup";
            this.dataBackup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataBackup.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataBackup.RowHeadersWidth = 20;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.dataBackup.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataBackup.Size = new System.Drawing.Size(1231, 654);
            this.dataBackup.TabIndex = 1;
            // 
            // colType
            // 
            this.colType.FillWeight = 20F;
            this.colType.HeaderText = "סוג:";
            this.colType.Items.AddRange(new object[] {
            "קובץ",
            "תיקייה"});
            this.colType.Name = "colType";
            this.colType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colSource
            // 
            this.colSource.HeaderText = "מיקם מקורי:";
            this.colSource.Name = "colSource";
            // 
            // colTarget
            // 
            this.colTarget.HeaderText = "מיקום יעד:";
            this.colTarget.Name = "colTarget";
            // 
            // colTurnOn
            // 
            this.colTurnOn.FillWeight = 30F;
            this.colTurnOn.HeaderText = "הפעל:";
            this.colTurnOn.Name = "colTurnOn";
            this.colTurnOn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTurnOn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "תאריך גיבוי:";
            this.colDate.Name = "colDate";
            // 
            // colTiming
            // 
            this.colTiming.FillWeight = 30F;
            this.colTiming.HeaderText = "תזמון:";
            this.colTiming.Items.AddRange(new object[] {
            "כל 6 שעות",
            "כל 12 שעות",
            "פעם אחת ביום"});
            this.colTiming.Name = "colTiming";
            this.colTiming.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTiming.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ArdaniBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1245, 742);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ArdaniBackup";
            this.Text = "286906245";
            this.Load += new System.EventHandler(this.ArdaniBackup_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.bodyMessage.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataBackup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.TabPage bodyMessage;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.DataGridView dataBackup;
        private System.Windows.Forms.DataGridViewComboBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarget;
        private System.Windows.Forms.DataGridViewButtonColumn colTurnOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTiming;
    }
}

