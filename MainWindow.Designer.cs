namespace TASS
{
    partial class MainWindow
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.L_Status = new System.Windows.Forms.Label();
            this.BT_Run = new System.Windows.Forms.Button();
            this.TB_Logs = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_RealmName = new System.Windows.Forms.TextBox();
            this.TB_Guilds = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_GetGuilds = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TB_Logs);
            this.splitContainer1.Size = new System.Drawing.Size(914, 633);
            this.splitContainer1.SplitterDistance = 458;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.9361F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0639F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(458, 633);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BT_GetGuilds);
            this.panel1.Controls.Add(this.TB_Guilds);
            this.panel1.Controls.Add(this.L_Status);
            this.panel1.Controls.Add(this.BT_Run);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TB_RealmName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 246);
            this.panel1.TabIndex = 0;
            // 
            // L_Status
            // 
            this.L_Status.AutoSize = true;
            this.L_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.L_Status.Location = new System.Drawing.Point(9, 180);
            this.L_Status.Name = "L_Status";
            this.L_Status.Size = new System.Drawing.Size(104, 24);
            this.L_Status.TabIndex = 4;
            this.L_Status.Text = "NOTHING";
            // 
            // BT_Run
            // 
            this.BT_Run.Location = new System.Drawing.Point(7, 207);
            this.BT_Run.Name = "BT_Run";
            this.BT_Run.Size = new System.Drawing.Size(191, 34);
            this.BT_Run.TabIndex = 3;
            this.BT_Run.Text = "RUN";
            this.BT_Run.UseVisualStyleBackColor = true;
            this.BT_Run.Click += new System.EventHandler(this.BT_Run_Click);
            // 
            // TB_Logs
            // 
            this.TB_Logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Logs.Location = new System.Drawing.Point(0, 0);
            this.TB_Logs.Name = "TB_Logs";
            this.TB_Logs.ReadOnly = true;
            this.TB_Logs.Size = new System.Drawing.Size(452, 633);
            this.TB_Logs.TabIndex = 2;
            this.TB_Logs.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Realm Name";
            // 
            // TB_RealmName
            // 
            this.TB_RealmName.Location = new System.Drawing.Point(3, 30);
            this.TB_RealmName.Name = "TB_RealmName";
            this.TB_RealmName.Size = new System.Drawing.Size(191, 20);
            this.TB_RealmName.TabIndex = 0;
            this.TB_RealmName.Text = "Darkmoon Faire";
            // 
            // TB_Guilds
            // 
            this.TB_Guilds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Guilds.Location = new System.Drawing.Point(228, 30);
            this.TB_Guilds.Name = "TB_Guilds";
            this.TB_Guilds.Size = new System.Drawing.Size(219, 174);
            this.TB_Guilds.TabIndex = 5;
            this.TB_Guilds.Text = "Aeon\nElysium\nRemnant\nDivine Misfortune\nRaven Knights";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(225, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guilds";
            // 
            // BT_GetGuilds
            // 
            this.BT_GetGuilds.Location = new System.Drawing.Point(228, 207);
            this.BT_GetGuilds.Name = "BT_GetGuilds";
            this.BT_GetGuilds.Size = new System.Drawing.Size(221, 36);
            this.BT_GetGuilds.TabIndex = 6;
            this.BT_GetGuilds.Text = "Get Guilds";
            this.BT_GetGuilds.UseVisualStyleBackColor = true;
            this.BT_GetGuilds.Click += new System.EventHandler(this.BT_GetGuilds_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 633);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(930, 671);
            this.Name = "MainWindow";
            this.Text = "WoW Guild Comparer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TB_RealmName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TB_Logs;
        private System.Windows.Forms.Button BT_Run;
        private System.Windows.Forms.Label L_Status;
        private System.Windows.Forms.RichTextBox TB_Guilds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_GetGuilds;
    }
}