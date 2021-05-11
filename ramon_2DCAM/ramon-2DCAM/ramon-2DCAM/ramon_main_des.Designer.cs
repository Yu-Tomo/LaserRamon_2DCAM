namespace ramon_2DCAM
{
    partial class ramon_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ramon_main));
            this.objectList = new System.Windows.Forms.ListView();
            this.rB100 = new System.Windows.Forms.RadioButton();
            this.rB10 = new System.Windows.Forms.RadioButton();
            this.rB1 = new System.Windows.Forms.RadioButton();
            this.rB0_1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.handOpe = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.waterTempTrack = new System.Windows.Forms.TrackBar();
            this.water_temp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.razerUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.razeTrack = new System.Windows.Forms.TrackBar();
            this.distanceBox = new System.Windows.Forms.GroupBox();
            this.laserFire = new System.Windows.Forms.Button();
            this.y_down = new System.Windows.Forms.Button();
            this.x_right = new System.Windows.Forms.Button();
            this.x_left = new System.Windows.Forms.Button();
            this.y_up = new System.Windows.Forms.Button();
            this.autoHome = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.gcodeView = new System.Windows.Forms.TabPage();
            this.previewTrack = new System.Windows.Forms.TrackBar();
            this.gcodeSave = new System.Windows.Forms.Button();
            this.objectSet = new System.Windows.Forms.TabPage();
            this.cutSetting = new System.Windows.Forms.TabPage();
            this.gcodePreview = new System.Windows.Forms.TabPage();
            this.controlPanel = new System.Windows.Forms.TabControl();
            this.label13 = new System.Windows.Forms.Label();
            this.workTable = new System.Windows.Forms.TableLayoutPanel();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_file_open = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_save_pro = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_file_close = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_file_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_redo = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_undo = new System.Windows.Forms.ToolStripMenuItem();
            this.ツールTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.saveFile = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.actualTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.expectTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.connectToArduino = new System.Windows.Forms.Button();
            this.cutPause = new System.Windows.Forms.Button();
            this.cutStart = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.emergencyButton = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.handOpe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waterTempTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.razerUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.razeTrack)).BeginInit();
            this.distanceBox.SuspendLayout();
            this.tabControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewTrack)).BeginInit();
            this.objectSet.SuspendLayout();
            this.gcodePreview.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // objectList
            // 
            this.objectList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.objectList.HideSelection = false;
            this.objectList.Location = new System.Drawing.Point(0, 3);
            this.objectList.Name = "objectList";
            this.objectList.Size = new System.Drawing.Size(614, 1207);
            this.objectList.TabIndex = 1;
            this.objectList.UseCompatibleStateImageBehavior = false;
            // 
            // rB100
            // 
            this.rB100.AutoSize = true;
            this.rB100.Location = new System.Drawing.Point(251, 48);
            this.rB100.Name = "rB100";
            this.rB100.Size = new System.Drawing.Size(77, 28);
            this.rB100.TabIndex = 13;
            this.rB100.Text = "100";
            this.rB100.UseVisualStyleBackColor = true;
            // 
            // rB10
            // 
            this.rB10.AutoSize = true;
            this.rB10.Location = new System.Drawing.Point(175, 48);
            this.rB10.Name = "rB10";
            this.rB10.Size = new System.Drawing.Size(65, 28);
            this.rB10.TabIndex = 12;
            this.rB10.Text = "10";
            this.rB10.UseVisualStyleBackColor = true;
            // 
            // rB1
            // 
            this.rB1.AutoSize = true;
            this.rB1.Location = new System.Drawing.Point(99, 48);
            this.rB1.Name = "rB1";
            this.rB1.Size = new System.Drawing.Size(53, 28);
            this.rB1.TabIndex = 11;
            this.rB1.Text = "1";
            this.rB1.UseVisualStyleBackColor = true;
            // 
            // rB0_1
            // 
            this.rB0_1.AutoSize = true;
            this.rB0_1.Checked = true;
            this.rB0_1.Location = new System.Drawing.Point(23, 48);
            this.rB0_1.Name = "rB0_1";
            this.rB0_1.Size = new System.Drawing.Size(70, 28);
            this.rB0_1.TabIndex = 10;
            this.rB0_1.TabStop = true;
            this.rB0_1.Text = "0.1";
            this.rB0_1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(327, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "mm";
            // 
            // handOpe
            // 
            this.handOpe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.handOpe.Controls.Add(this.label6);
            this.handOpe.Controls.Add(this.waterTempTrack);
            this.handOpe.Controls.Add(this.water_temp);
            this.handOpe.Controls.Add(this.label3);
            this.handOpe.Controls.Add(this.razerUpDown);
            this.handOpe.Controls.Add(this.label2);
            this.handOpe.Controls.Add(this.razeTrack);
            this.handOpe.Controls.Add(this.distanceBox);
            this.handOpe.Controls.Add(this.laserFire);
            this.handOpe.Controls.Add(this.y_down);
            this.handOpe.Controls.Add(this.x_right);
            this.handOpe.Controls.Add(this.x_left);
            this.handOpe.Controls.Add(this.y_up);
            this.handOpe.Controls.Add(this.autoHome);
            this.handOpe.Location = new System.Drawing.Point(8, 39);
            this.handOpe.Name = "handOpe";
            this.handOpe.Padding = new System.Windows.Forms.Padding(3);
            this.handOpe.Size = new System.Drawing.Size(622, 1210);
            this.handOpe.TabIndex = 3;
            this.handOpe.Text = "手動操作";
            this.handOpe.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label6.Location = new System.Drawing.Point(555, 598);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 30);
            this.label6.TabIndex = 20;
            this.label6.Text = "％";
            // 
            // waterTempTrack
            // 
            this.waterTempTrack.BackColor = System.Drawing.Color.White;
            this.waterTempTrack.Enabled = false;
            this.waterTempTrack.Location = new System.Drawing.Point(146, 687);
            this.waterTempTrack.Maximum = 100;
            this.waterTempTrack.Name = "waterTempTrack";
            this.waterTempTrack.Size = new System.Drawing.Size(305, 90);
            this.waterTempTrack.TabIndex = 19;
            this.waterTempTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // water_temp
            // 
            this.water_temp.AutoSize = true;
            this.water_temp.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.water_temp.Location = new System.Drawing.Point(457, 696);
            this.water_temp.Name = "water_temp";
            this.water_temp.Size = new System.Drawing.Size(58, 30);
            this.water_temp.TabIndex = 18;
            this.water_temp.Text = "0℃";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(14, 696);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 27);
            this.label3.TabIndex = 16;
            this.label3.Text = "冷却水温";
            // 
            // razerUpDown
            // 
            this.razerUpDown.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.razerUpDown.Location = new System.Drawing.Point(457, 589);
            this.razerUpDown.Name = "razerUpDown";
            this.razerUpDown.Size = new System.Drawing.Size(92, 39);
            this.razerUpDown.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(14, 589);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "光の強度";
            // 
            // razeTrack
            // 
            this.razeTrack.BackColor = System.Drawing.Color.White;
            this.razeTrack.Location = new System.Drawing.Point(146, 582);
            this.razeTrack.Maximum = 100;
            this.razeTrack.Name = "razeTrack";
            this.razeTrack.Size = new System.Drawing.Size(305, 90);
            this.razeTrack.TabIndex = 12;
            this.razeTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // distanceBox
            // 
            this.distanceBox.Controls.Add(this.rB100);
            this.distanceBox.Controls.Add(this.rB10);
            this.distanceBox.Controls.Add(this.rB1);
            this.distanceBox.Controls.Add(this.rB0_1);
            this.distanceBox.Controls.Add(this.label1);
            this.distanceBox.Location = new System.Drawing.Point(19, 435);
            this.distanceBox.Name = "distanceBox";
            this.distanceBox.Size = new System.Drawing.Size(399, 103);
            this.distanceBox.TabIndex = 11;
            this.distanceBox.TabStop = false;
            this.distanceBox.Text = "移動距離";
            // 
            // laserFire
            // 
            this.laserFire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.laserFire.BackColor = System.Drawing.Color.White;
            this.laserFire.Image = ((System.Drawing.Image)(resources.GetObject("laserFire.Image")));
            this.laserFire.Location = new System.Drawing.Point(482, 19);
            this.laserFire.Name = "laserFire";
            this.laserFire.Size = new System.Drawing.Size(126, 126);
            this.laserFire.TabIndex = 10;
            this.laserFire.UseVisualStyleBackColor = false;
            // 
            // y_down
            // 
            this.y_down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.y_down.BackColor = System.Drawing.Color.White;
            this.y_down.Image = ((System.Drawing.Image)(resources.GetObject("y_down.Image")));
            this.y_down.Location = new System.Drawing.Point(195, 266);
            this.y_down.Name = "y_down";
            this.y_down.Size = new System.Drawing.Size(126, 126);
            this.y_down.TabIndex = 4;
            this.y_down.UseVisualStyleBackColor = false;
            // 
            // x_right
            // 
            this.x_right.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.x_right.BackColor = System.Drawing.Color.White;
            this.x_right.Image = ((System.Drawing.Image)(resources.GetObject("x_right.Image")));
            this.x_right.Location = new System.Drawing.Point(318, 144);
            this.x_right.Name = "x_right";
            this.x_right.Size = new System.Drawing.Size(126, 126);
            this.x_right.TabIndex = 3;
            this.x_right.UseVisualStyleBackColor = false;
            // 
            // x_left
            // 
            this.x_left.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.x_left.BackColor = System.Drawing.Color.White;
            this.x_left.Image = ((System.Drawing.Image)(resources.GetObject("x_left.Image")));
            this.x_left.Location = new System.Drawing.Point(72, 143);
            this.x_left.Name = "x_left";
            this.x_left.Size = new System.Drawing.Size(126, 126);
            this.x_left.TabIndex = 2;
            this.x_left.UseVisualStyleBackColor = false;
            // 
            // y_up
            // 
            this.y_up.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.y_up.BackColor = System.Drawing.Color.White;
            this.y_up.Image = ((System.Drawing.Image)(resources.GetObject("y_up.Image")));
            this.y_up.Location = new System.Drawing.Point(195, 19);
            this.y_up.Name = "y_up";
            this.y_up.Size = new System.Drawing.Size(126, 126);
            this.y_up.TabIndex = 1;
            this.y_up.UseVisualStyleBackColor = false;
            // 
            // autoHome
            // 
            this.autoHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.autoHome.BackColor = System.Drawing.Color.White;
            this.autoHome.Image = ((System.Drawing.Image)(resources.GetObject("autoHome.Image")));
            this.autoHome.Location = new System.Drawing.Point(482, 279);
            this.autoHome.Name = "autoHome";
            this.autoHome.Size = new System.Drawing.Size(126, 126);
            this.autoHome.TabIndex = 0;
            this.autoHome.UseVisualStyleBackColor = false;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.gcodeView);
            this.tabControl2.Enabled = false;
            this.tabControl2.Location = new System.Drawing.Point(17, 51);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(594, 1073);
            this.tabControl2.TabIndex = 1;
            // 
            // gcodeView
            // 
            this.gcodeView.AutoScroll = true;
            this.gcodeView.BackColor = System.Drawing.SystemColors.Info;
            this.gcodeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gcodeView.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.gcodeView.Location = new System.Drawing.Point(8, 39);
            this.gcodeView.Name = "gcodeView";
            this.gcodeView.Padding = new System.Windows.Forms.Padding(3);
            this.gcodeView.Size = new System.Drawing.Size(578, 1026);
            this.gcodeView.TabIndex = 0;
            this.gcodeView.Text = "Gコードビュー";
            // 
            // previewTrack
            // 
            this.previewTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewTrack.BackColor = System.Drawing.Color.White;
            this.previewTrack.Location = new System.Drawing.Point(3, 1117);
            this.previewTrack.Maximum = 100;
            this.previewTrack.Name = "previewTrack";
            this.previewTrack.Size = new System.Drawing.Size(616, 90);
            this.previewTrack.TabIndex = 0;
            this.previewTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // gcodeSave
            // 
            this.gcodeSave.BackColor = System.Drawing.Color.PaleTurquoise;
            this.gcodeSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gcodeSave.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gcodeSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gcodeSave.Location = new System.Drawing.Point(422, 22);
            this.gcodeSave.Name = "gcodeSave";
            this.gcodeSave.Size = new System.Drawing.Size(178, 52);
            this.gcodeSave.TabIndex = 2;
            this.gcodeSave.Text = "Gコードを保存";
            this.gcodeSave.UseVisualStyleBackColor = false;
            // 
            // objectSet
            // 
            this.objectSet.Controls.Add(this.objectList);
            this.objectSet.Location = new System.Drawing.Point(8, 39);
            this.objectSet.Name = "objectSet";
            this.objectSet.Padding = new System.Windows.Forms.Padding(3);
            this.objectSet.Size = new System.Drawing.Size(622, 1210);
            this.objectSet.TabIndex = 0;
            this.objectSet.Text = "オブジェクト配置";
            this.objectSet.UseVisualStyleBackColor = true;
            // 
            // cutSetting
            // 
            this.cutSetting.Location = new System.Drawing.Point(8, 39);
            this.cutSetting.Name = "cutSetting";
            this.cutSetting.Padding = new System.Windows.Forms.Padding(3);
            this.cutSetting.Size = new System.Drawing.Size(622, 1210);
            this.cutSetting.TabIndex = 1;
            this.cutSetting.Text = "加工設定";
            this.cutSetting.UseVisualStyleBackColor = true;
            // 
            // gcodePreview
            // 
            this.gcodePreview.Controls.Add(this.gcodeSave);
            this.gcodePreview.Controls.Add(this.tabControl2);
            this.gcodePreview.Controls.Add(this.previewTrack);
            this.gcodePreview.Location = new System.Drawing.Point(8, 39);
            this.gcodePreview.Name = "gcodePreview";
            this.gcodePreview.Padding = new System.Windows.Forms.Padding(3);
            this.gcodePreview.Size = new System.Drawing.Size(622, 1210);
            this.gcodePreview.TabIndex = 2;
            this.gcodePreview.Text = "プレビュー";
            this.gcodePreview.UseVisualStyleBackColor = true;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.Controls.Add(this.objectSet);
            this.controlPanel.Controls.Add(this.cutSetting);
            this.controlPanel.Controls.Add(this.gcodePreview);
            this.controlPanel.Controls.Add(this.handOpe);
            this.controlPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.controlPanel.Location = new System.Drawing.Point(1253, 228);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.SelectedIndex = 0;
            this.controlPanel.Size = new System.Drawing.Size(638, 1257);
            this.controlPanel.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(508, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 24);
            this.label13.TabIndex = 12;
            this.label13.Text = "緊急停止";
            // 
            // workTable
            // 
            this.workTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workTable.AutoSize = true;
            this.workTable.BackColor = System.Drawing.SystemColors.Window;
            this.workTable.ColumnCount = 1;
            this.workTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.workTable.Location = new System.Drawing.Point(9, 226);
            this.workTable.Name = "workTable";
            this.workTable.RowCount = 1;
            this.workTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.workTable.Size = new System.Drawing.Size(1233, 1254);
            this.workTable.TabIndex = 15;
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.Tool_file_open,
            this.Tool_save_pro,
            this.Tool_file_close,
            this.Tool_file_exit});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(129, 44);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(383, 44);
            this.toolStripMenuItem1.Text = "新規作成(&N)";
            // 
            // Tool_file_open
            // 
            this.Tool_file_open.Name = "Tool_file_open";
            this.Tool_file_open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Tool_file_open.Size = new System.Drawing.Size(383, 44);
            this.Tool_file_open.Text = "開く(&O)";
            // 
            // Tool_save_pro
            // 
            this.Tool_save_pro.Name = "Tool_save_pro";
            this.Tool_save_pro.Size = new System.Drawing.Size(383, 44);
            this.Tool_save_pro.Text = "プロジェクトを保存する(&S)";
            // 
            // Tool_file_close
            // 
            this.Tool_file_close.Name = "Tool_file_close";
            this.Tool_file_close.Size = new System.Drawing.Size(383, 44);
            this.Tool_file_close.Text = "閉じる(&C)";
            // 
            // Tool_file_exit
            // 
            this.Tool_file_exit.Name = "Tool_file_exit";
            this.Tool_file_exit.Size = new System.Drawing.Size(383, 44);
            this.Tool_file_exit.Text = "終了(&X)";
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_redo,
            this.Tool_undo});
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(109, 44);
            this.編集EToolStripMenuItem.Text = "編集(&E)";
            // 
            // Tool_redo
            // 
            this.Tool_redo.Name = "Tool_redo";
            this.Tool_redo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.Tool_redo.Size = new System.Drawing.Size(359, 44);
            this.Tool_redo.Text = "元に戻す(&U)";
            // 
            // Tool_undo
            // 
            this.Tool_undo.Name = "Tool_undo";
            this.Tool_undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.Tool_undo.Size = new System.Drawing.Size(359, 44);
            this.Tool_undo.Text = "やり直し(&R)";
            // 
            // ツールTToolStripMenuItem
            // 
            this.ツールTToolStripMenuItem.Name = "ツールTToolStripMenuItem";
            this.ツールTToolStripMenuItem.Size = new System.Drawing.Size(115, 44);
            this.ツールTToolStripMenuItem.Text = "ツール(&T)";
            // 
            // 設SToolStripMenuItem
            // 
            this.設SToolStripMenuItem.Name = "設SToolStripMenuItem";
            this.設SToolStripMenuItem.Size = new System.Drawing.Size(110, 44);
            this.設SToolStripMenuItem.Text = "設定(&S)";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.saveFile, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label12, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.label11, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label8, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.connectToArduino, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cutPause, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.cutStart, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.openFile, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(9, 57);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1233, 156);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // saveFile
            // 
            this.saveFile.BackColor = System.Drawing.Color.White;
            this.saveFile.Image = ((System.Drawing.Image)(resources.GetObject("saveFile.Image")));
            this.saveFile.Location = new System.Drawing.Point(267, 3);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(128, 117);
            this.saveFile.TabIndex = 6;
            this.saveFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveFile.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(544, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 24);
            this.label12.TabIndex = 11;
            this.label12.Text = "一時停止";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(411, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "加工開始";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "接続";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.39631F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.60369F));
            this.tableLayoutPanel2.Controls.Add(this.actualTime, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.expectTime, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(667, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(563, 117);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // actualTime
            // 
            this.actualTime.AutoSize = true;
            this.actualTime.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.actualTime.Location = new System.Drawing.Point(241, 58);
            this.actualTime.Name = "actualTime";
            this.actualTime.Size = new System.Drawing.Size(106, 27);
            this.actualTime.TabIndex = 3;
            this.actualTime.Text = "00:00:00";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label5.Location = new System.Drawing.Point(18, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "実際の加工時間";
            // 
            // expectTime
            // 
            this.expectTime.AutoSize = true;
            this.expectTime.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.expectTime.Location = new System.Drawing.Point(241, 0);
            this.expectTime.Name = "expectTime";
            this.expectTime.Size = new System.Drawing.Size(106, 27);
            this.expectTime.TabIndex = 2;
            this.expectTime.Text = "00:00:00";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label4.Location = new System.Drawing.Point(42, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "予想加工時間";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "開く";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "保存";
            // 
            // connectToArduino
            // 
            this.connectToArduino.BackColor = System.Drawing.Color.White;
            this.connectToArduino.Image = ((System.Drawing.Image)(resources.GetObject("connectToArduino.Image")));
            this.connectToArduino.Location = new System.Drawing.Point(3, 3);
            this.connectToArduino.Name = "connectToArduino";
            this.connectToArduino.Size = new System.Drawing.Size(126, 117);
            this.connectToArduino.TabIndex = 2;
            this.connectToArduino.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.connectToArduino.UseVisualStyleBackColor = false;
            // 
            // cutPause
            // 
            this.cutPause.BackColor = System.Drawing.Color.White;
            this.cutPause.Image = ((System.Drawing.Image)(resources.GetObject("cutPause.Image")));
            this.cutPause.Location = new System.Drawing.Point(533, 3);
            this.cutPause.Name = "cutPause";
            this.cutPause.Size = new System.Drawing.Size(128, 117);
            this.cutPause.TabIndex = 5;
            this.cutPause.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cutPause.UseVisualStyleBackColor = false;
            // 
            // cutStart
            // 
            this.cutStart.BackColor = System.Drawing.Color.White;
            this.cutStart.Image = ((System.Drawing.Image)(resources.GetObject("cutStart.Image")));
            this.cutStart.Location = new System.Drawing.Point(401, 3);
            this.cutStart.Name = "cutStart";
            this.cutStart.Size = new System.Drawing.Size(126, 117);
            this.cutStart.TabIndex = 4;
            this.cutStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cutStart.UseVisualStyleBackColor = false;
            // 
            // openFile
            // 
            this.openFile.BackColor = System.Drawing.Color.White;
            this.openFile.Image = ((System.Drawing.Image)(resources.GetObject("openFile.Image")));
            this.openFile.Location = new System.Drawing.Point(135, 3);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(126, 117);
            this.openFile.TabIndex = 3;
            this.openFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openFile.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.AutoScroll = true;
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.36066F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.63935F));
            this.tableLayoutPanel4.Controls.Add(this.label13, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.emergencyButton, 1, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1253, 57);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(630, 156);
            this.tableLayoutPanel4.TabIndex = 14;
            // 
            // emergencyButton
            // 
            this.emergencyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emergencyButton.BackColor = System.Drawing.Color.White;
            this.emergencyButton.Image = ((System.Drawing.Image)(resources.GetObject("emergencyButton.Image")));
            this.emergencyButton.Location = new System.Drawing.Point(501, 27);
            this.emergencyButton.Name = "emergencyButton";
            this.emergencyButton.Size = new System.Drawing.Size(126, 126);
            this.emergencyButton.TabIndex = 0;
            this.emergencyButton.UseVisualStyleBackColor = false;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.編集EToolStripMenuItem,
            this.ツールTToolStripMenuItem,
            this.設SToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1891, 48);
            this.menu.TabIndex = 11;
            this.menu.TabStop = true;
            this.menu.Text = "menu";
            // 
            // ramon_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1891, 1491);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.workTable);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ramon_main";
            this.Text = "laser-Ramon2DCAM HG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.handOpe.ResumeLayout(false);
            this.handOpe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waterTempTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.razerUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.razeTrack)).EndInit();
            this.distanceBox.ResumeLayout(false);
            this.distanceBox.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previewTrack)).EndInit();
            this.objectSet.ResumeLayout(false);
            this.gcodePreview.ResumeLayout(false);
            this.gcodePreview.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView objectList;
        private System.Windows.Forms.RadioButton rB100;
        private System.Windows.Forms.RadioButton rB10;
        private System.Windows.Forms.RadioButton rB1;
        private System.Windows.Forms.RadioButton rB0_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage handOpe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar waterTempTrack;
        private System.Windows.Forms.Label water_temp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown razerUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar razeTrack;
        private System.Windows.Forms.GroupBox distanceBox;
        private System.Windows.Forms.Button laserFire;
        private System.Windows.Forms.Button y_down;
        private System.Windows.Forms.Button x_right;
        private System.Windows.Forms.Button x_left;
        private System.Windows.Forms.Button y_up;
        private System.Windows.Forms.Button autoHome;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage gcodeView;
        private System.Windows.Forms.TrackBar previewTrack;
        private System.Windows.Forms.Button gcodeSave;
        private System.Windows.Forms.TabPage objectSet;
        private System.Windows.Forms.TabPage cutSetting;
        private System.Windows.Forms.TabPage gcodePreview;
        private System.Windows.Forms.TabControl controlPanel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TableLayoutPanel workTable;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Tool_file_open;
        private System.Windows.Forms.ToolStripMenuItem Tool_save_pro;
        private System.Windows.Forms.ToolStripMenuItem Tool_file_close;
        private System.Windows.Forms.ToolStripMenuItem Tool_file_exit;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tool_redo;
        private System.Windows.Forms.ToolStripMenuItem Tool_undo;
        private System.Windows.Forms.ToolStripMenuItem ツールTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設SToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label actualTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label expectTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button connectToArduino;
        private System.Windows.Forms.Button cutPause;
        private System.Windows.Forms.Button cutStart;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button emergencyButton;
        private System.Windows.Forms.MenuStrip menu;
    }
}

