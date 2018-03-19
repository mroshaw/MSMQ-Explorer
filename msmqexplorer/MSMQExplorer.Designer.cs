namespace MSMQExplorer
{
    partial class FormMsmqExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMsmqExplorer));
            this.splitContainerReceive = new System.Windows.Forms.SplitContainer();
            this.splitContainerDetail = new System.Windows.Forms.SplitContainer();
            this.bufferedTreeViewRecQueues = new MSMQExplorer.BufferedTreeView();
            this.contextMenuStripQueue = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemNewQueueSend = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteQueueSend = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemQueuePurge = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemQueueProps = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListMsmq = new System.Windows.Forms.ImageList(this.components);
            this.labelSelectedQueueName = new System.Windows.Forms.Label();
            this.textBoxSelectedRecQueue = new System.Windows.Forms.TextBox();
            this.labelCurrHost = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxRecHost = new System.Windows.Forms.TextBox();
            this.textBoxSelectedMsgId = new System.Windows.Forms.TextBox();
            this.labelSelectedMsgId = new System.Windows.Forms.Label();
            this.fastObjectListViewMessages = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumnId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnLabel = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnMachineName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnSentTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnArrivedTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnPriority = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnMessageType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTransactionId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnAppSpecific = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnAuthenticated = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnAuthenticationProviderName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnAuthenticationProviderType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnCorrelationId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnDigitalSignature = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnEncryptionAlgorithm = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnHashAlgorithm = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnIsFirstInTransaction = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnIsLastInTransaction = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnLookupId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnRecoverable = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnSenderId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnSenderVersion = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.contextMenuStripMessage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemMsgDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMsgPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMsgCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemQueueReceive = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemMsgProps = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxRecTrans = new System.Windows.Forms.CheckBox();
            this.labelCurrQueue = new System.Windows.Forms.Label();
            this.textBoxQueue = new System.Windows.Forms.TextBox();
            this.buttonRefreshMessages = new System.Windows.Forms.Button();
            this.labelRecFormat = new System.Windows.Forms.Label();
            this.comboBoxRecFormat = new System.Windows.Forms.ComboBox();
            this.textBoxMsgId = new System.Windows.Forms.TextBox();
            this.labelMsgId = new System.Windows.Forms.Label();
            this.tabControlReceiveType = new System.Windows.Forms.TabControl();
            this.tabPageXML = new System.Windows.Forms.TabPage();
            this.scintillaRecXML = new ScintillaNET.Scintilla();
            this.tabPageHex = new System.Windows.Forms.TabPage();
            this.hexBoxRecHex = new Be.Windows.Forms.HexBox();
            this.tabPageText = new System.Windows.Forms.TabPage();
            this.textBoxRecText = new System.Windows.Forms.TextBox();
            this.textBoxXSDIn = new System.Windows.Forms.TextBox();
            this.buttonXSDIn = new System.Windows.Forms.Button();
            this.buttonValidateIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageSend = new System.Windows.Forms.TabPage();
            this.splitContainerSend = new System.Windows.Forms.SplitContainer();
            this.labelQueue = new System.Windows.Forms.Label();
            this.textBoxSelectedSendQueue = new System.Windows.Forms.TextBox();
            this.bufferedTreeViewSendQueues = new MSMQExplorer.BufferedTreeView();
            this.contextMenuStripSendQueue = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemNewQueueRec = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteQueueRec = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPurge = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemSendQueueProps = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSendHost = new System.Windows.Forms.Label();
            this.buttonSendConnect = new System.Windows.Forms.Button();
            this.textBoxSendHost = new System.Windows.Forms.TextBox();
            this.splitContainerSendMsgDetail = new System.Windows.Forms.SplitContainer();
            this.tabControlSendType = new System.Windows.Forms.TabControl();
            this.tabPageSendXML = new System.Windows.Forms.TabPage();
            this.scintillaSendXML = new ScintillaNET.Scintilla();
            this.buttonXSDOut = new System.Windows.Forms.Button();
            this.labelValidateOut = new System.Windows.Forms.Label();
            this.buttonValidateOut = new System.Windows.Forms.Button();
            this.textBoxXSDOut = new System.Windows.Forms.TextBox();
            this.tabPageSendHex = new System.Windows.Forms.TabPage();
            this.hexBoxSendHex = new Be.Windows.Forms.HexBox();
            this.tabPageSendText = new System.Windows.Forms.TabPage();
            this.textBoxSendText = new System.Windows.Forms.TextBox();
            this.groupBoxMsgProps = new System.Windows.Forms.GroupBox();
            this.labelSendFormat = new System.Windows.Forms.Label();
            this.comboBoxSendFormat = new System.Windows.Forms.ComboBox();
            this.checkBoxUserJournal = new System.Windows.Forms.CheckBox();
            this.checkBoxUseTracing = new System.Windows.Forms.CheckBox();
            this.checkBoxUseEncryption = new System.Windows.Forms.CheckBox();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.labelPriority = new System.Windows.Forms.Label();
            this.textBoxMsgLabel = new System.Windows.Forms.TextBox();
            this.labelMSGLabel = new System.Windows.Forms.Label();
            this.checkBoxTrans = new System.Windows.Forms.CheckBox();
            this.checkBoxUserDeadLetter = new System.Windows.Forms.CheckBox();
            this.labelTimeToReceive = new System.Windows.Forms.Label();
            this.labelTimeReachQueue = new System.Windows.Forms.Label();
            this.numericUpDownTimeToReachQueue = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTimeToReceive = new System.Windows.Forms.NumericUpDown();
            this.comboBoxTimeReachQueue = new System.Windows.Forms.ComboBox();
            this.comboBoxTimeToReceive = new System.Windows.Forms.ComboBox();
            this.tabPageReceive = new System.Windows.Forms.TabPage();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.fastObjectListViewLog = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumnTimestamp = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnEventType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnLogEntry = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageListTabs = new System.Windows.Forms.ImageList(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.automaticUpdater = new wyDay.Controls.AutomaticUpdater();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.ribbonMain = new System.Windows.Forms.Ribbon();
            this.ribbonOrbMenuItemOpenXML = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItemOpenOther = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItemSaveAsXml = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItemSaveAsOther = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItemExit = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonButtonOpenXML = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonCheckForUpdate = new System.Windows.Forms.RibbonButton();
            this.ribbonTabMain = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelEdit = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonPaste = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonCut = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonCopy = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonFormat = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelQueue = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonQueueNew = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonQueueDelete = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonQueuePurge = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonQueueProperties = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelMessages = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonMsgSend = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonMsgReceive = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonMsgPreview = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonMsgDelete = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonMsgCopy = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonMsgProps = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelSearch = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonFind = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonIncSearch = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonReplace = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelHelp = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonAbout = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonUpdate = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonHelp = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelView = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonStyle = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonStyle2007 = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonStyle2010 = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonStyle2013 = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonTheme = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonNormal = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonBlue = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonBlack = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonGreen = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonPurple = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonJellyBelly = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonHalloween = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelSettings = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonSettings = new System.Windows.Forms.RibbonButton();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.formMsmqExplorerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerReceive)).BeginInit();
            this.splitContainerReceive.Panel1.SuspendLayout();
            this.splitContainerReceive.Panel2.SuspendLayout();
            this.splitContainerReceive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDetail)).BeginInit();
            this.splitContainerDetail.Panel1.SuspendLayout();
            this.splitContainerDetail.Panel2.SuspendLayout();
            this.splitContainerDetail.SuspendLayout();
            this.contextMenuStripQueue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListViewMessages)).BeginInit();
            this.contextMenuStripMessage.SuspendLayout();
            this.tabControlReceiveType.SuspendLayout();
            this.tabPageXML.SuspendLayout();
            this.tabPageHex.SuspendLayout();
            this.tabPageText.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageSend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSend)).BeginInit();
            this.splitContainerSend.Panel1.SuspendLayout();
            this.splitContainerSend.Panel2.SuspendLayout();
            this.splitContainerSend.SuspendLayout();
            this.contextMenuStripSendQueue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSendMsgDetail)).BeginInit();
            this.splitContainerSendMsgDetail.Panel1.SuspendLayout();
            this.splitContainerSendMsgDetail.Panel2.SuspendLayout();
            this.splitContainerSendMsgDetail.SuspendLayout();
            this.tabControlSendType.SuspendLayout();
            this.tabPageSendXML.SuspendLayout();
            this.tabPageSendHex.SuspendLayout();
            this.tabPageSendText.SuspendLayout();
            this.groupBoxMsgProps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeToReachQueue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeToReceive)).BeginInit();
            this.tabPageReceive.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListViewLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automaticUpdater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formMsmqExplorerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerReceive
            // 
            resources.ApplyResources(this.splitContainerReceive, "splitContainerReceive");
            this.splitContainerReceive.Name = "splitContainerReceive";
            // 
            // splitContainerReceive.Panel1
            // 
            this.splitContainerReceive.Panel1.Controls.Add(this.splitContainerDetail);
            // 
            // splitContainerReceive.Panel2
            // 
            this.splitContainerReceive.Panel2.Controls.Add(this.labelRecFormat);
            this.splitContainerReceive.Panel2.Controls.Add(this.comboBoxRecFormat);
            this.splitContainerReceive.Panel2.Controls.Add(this.textBoxMsgId);
            this.splitContainerReceive.Panel2.Controls.Add(this.labelMsgId);
            this.splitContainerReceive.Panel2.Controls.Add(this.tabControlReceiveType);
            this.splitContainerReceive.Panel2.Controls.Add(this.textBoxXSDIn);
            this.splitContainerReceive.Panel2.Controls.Add(this.buttonXSDIn);
            this.splitContainerReceive.Panel2.Controls.Add(this.buttonValidateIn);
            this.splitContainerReceive.Panel2.Controls.Add(this.label1);
            this.splitContainerReceive.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainerReceive_Paint);
            // 
            // splitContainerDetail
            // 
            resources.ApplyResources(this.splitContainerDetail, "splitContainerDetail");
            this.splitContainerDetail.Name = "splitContainerDetail";
            // 
            // splitContainerDetail.Panel1
            // 
            this.splitContainerDetail.Panel1.Controls.Add(this.bufferedTreeViewRecQueues);
            this.splitContainerDetail.Panel1.Controls.Add(this.labelSelectedQueueName);
            this.splitContainerDetail.Panel1.Controls.Add(this.textBoxSelectedRecQueue);
            this.splitContainerDetail.Panel1.Controls.Add(this.labelCurrHost);
            this.splitContainerDetail.Panel1.Controls.Add(this.buttonConnect);
            this.splitContainerDetail.Panel1.Controls.Add(this.textBoxRecHost);
            // 
            // splitContainerDetail.Panel2
            // 
            this.splitContainerDetail.Panel2.Controls.Add(this.textBoxSelectedMsgId);
            this.splitContainerDetail.Panel2.Controls.Add(this.labelSelectedMsgId);
            this.splitContainerDetail.Panel2.Controls.Add(this.fastObjectListViewMessages);
            this.splitContainerDetail.Panel2.Controls.Add(this.checkBoxRecTrans);
            this.splitContainerDetail.Panel2.Controls.Add(this.labelCurrQueue);
            this.splitContainerDetail.Panel2.Controls.Add(this.textBoxQueue);
            this.splitContainerDetail.Panel2.Controls.Add(this.buttonRefreshMessages);
            this.splitContainerDetail.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainerDetail_Paint);
            // 
            // bufferedTreeViewRecQueues
            // 
            resources.ApplyResources(this.bufferedTreeViewRecQueues, "bufferedTreeViewRecQueues");
            this.bufferedTreeViewRecQueues.ContextMenuStrip = this.contextMenuStripQueue;
            this.bufferedTreeViewRecQueues.HideSelection = false;
            this.bufferedTreeViewRecQueues.ImageList = this.imageListMsmq;
            this.bufferedTreeViewRecQueues.Name = "bufferedTreeViewRecQueues";
            this.bufferedTreeViewRecQueues.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewQueues_AfterSelect);
            this.bufferedTreeViewRecQueues.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeViewQueues_MouseDown);
            // 
            // contextMenuStripQueue
            // 
            this.contextMenuStripQueue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNewQueueSend,
            this.toolStripMenuItemDeleteQueueSend,
            this.toolStripMenuItemQueuePurge,
            this.toolStripSeparator2,
            this.toolStripMenuItemQueueProps});
            this.contextMenuStripQueue.Name = "contextMenuStripQueue";
            resources.ApplyResources(this.contextMenuStripQueue, "contextMenuStripQueue");
            // 
            // toolStripMenuItemNewQueueSend
            // 
            this.toolStripMenuItemNewQueueSend.Image = global::MSMQExplorer.Resource.MSMQ_folder_add2_16;
            this.toolStripMenuItemNewQueueSend.Name = "toolStripMenuItemNewQueueSend";
            resources.ApplyResources(this.toolStripMenuItemNewQueueSend, "toolStripMenuItemNewQueueSend");
            this.toolStripMenuItemNewQueueSend.Click += new System.EventHandler(this.toolStripMenuItemNewQueueSend_Click);
            // 
            // toolStripMenuItemDeleteQueueSend
            // 
            this.toolStripMenuItemDeleteQueueSend.Image = global::MSMQExplorer.Resource.MSMQ_folder_delete2_16;
            this.toolStripMenuItemDeleteQueueSend.Name = "toolStripMenuItemDeleteQueueSend";
            resources.ApplyResources(this.toolStripMenuItemDeleteQueueSend, "toolStripMenuItemDeleteQueueSend");
            this.toolStripMenuItemDeleteQueueSend.Click += new System.EventHandler(this.toolStripMenuItemDeleteQueueSend_Click);
            // 
            // toolStripMenuItemQueuePurge
            // 
            this.toolStripMenuItemQueuePurge.Image = global::MSMQExplorer.Resource.MSMQ_trash_bin_delete2_16;
            this.toolStripMenuItemQueuePurge.Name = "toolStripMenuItemQueuePurge";
            resources.ApplyResources(this.toolStripMenuItemQueuePurge, "toolStripMenuItemQueuePurge");
            this.toolStripMenuItemQueuePurge.Click += new System.EventHandler(this.toolStripMenuItemQueuePurge_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // toolStripMenuItemQueueProps
            // 
            this.toolStripMenuItemQueueProps.Image = global::MSMQExplorer.Resource.MSMQ_folder_info_16;
            this.toolStripMenuItemQueueProps.Name = "toolStripMenuItemQueueProps";
            resources.ApplyResources(this.toolStripMenuItemQueueProps, "toolStripMenuItemQueueProps");
            this.toolStripMenuItemQueueProps.Click += new System.EventHandler(this.toolStripMenuItemQueueProps_Click);
            // 
            // imageListMsmq
            // 
            this.imageListMsmq.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMsmq.ImageStream")));
            this.imageListMsmq.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMsmq.Images.SetKeyName(0, "MSMQ_folder_16.png");
            this.imageListMsmq.Images.SetKeyName(1, "MSMQ_folder_mail_16.png");
            this.imageListMsmq.Images.SetKeyName(2, "MSMQ_folder_bookmark.png");
            this.imageListMsmq.Images.SetKeyName(3, "MSMQ_folder_remove_16.png");
            this.imageListMsmq.Images.SetKeyName(4, "MSMQ_folder_update_16.png");
            this.imageListMsmq.Images.SetKeyName(5, "MSMQ_mail_16.png");
            // 
            // labelSelectedQueueName
            // 
            resources.ApplyResources(this.labelSelectedQueueName, "labelSelectedQueueName");
            this.labelSelectedQueueName.Name = "labelSelectedQueueName";
            // 
            // textBoxSelectedRecQueue
            // 
            resources.ApplyResources(this.textBoxSelectedRecQueue, "textBoxSelectedRecQueue");
            this.textBoxSelectedRecQueue.Name = "textBoxSelectedRecQueue";
            this.textBoxSelectedRecQueue.ReadOnly = true;
            // 
            // labelCurrHost
            // 
            resources.ApplyResources(this.labelCurrHost, "labelCurrHost");
            this.labelCurrHost.Name = "labelCurrHost";
            // 
            // buttonConnect
            // 
            resources.ApplyResources(this.buttonConnect, "buttonConnect");
            this.buttonConnect.Image = global::MSMQExplorer.Resource.MSMQ_computer_update_16;
            this.buttonConnect.Name = "buttonConnect";
            this.toolTip.SetToolTip(this.buttonConnect, resources.GetString("buttonConnect.ToolTip"));
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxRecHost
            // 
            resources.ApplyResources(this.textBoxRecHost, "textBoxRecHost");
            this.textBoxRecHost.Name = "textBoxRecHost";
            this.toolTip.SetToolTip(this.textBoxRecHost, resources.GetString("textBoxRecHost.ToolTip"));
            this.textBoxRecHost.TextChanged += new System.EventHandler(this.textBoxRecHost_TextChanged);
            // 
            // textBoxSelectedMsgId
            // 
            resources.ApplyResources(this.textBoxSelectedMsgId, "textBoxSelectedMsgId");
            this.textBoxSelectedMsgId.Name = "textBoxSelectedMsgId";
            this.textBoxSelectedMsgId.ReadOnly = true;
            // 
            // labelSelectedMsgId
            // 
            resources.ApplyResources(this.labelSelectedMsgId, "labelSelectedMsgId");
            this.labelSelectedMsgId.Name = "labelSelectedMsgId";
            // 
            // fastObjectListViewMessages
            // 
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnId);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnLabel);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnMachineName);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnSentTime);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnArrivedTime);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnPriority);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnMessageType);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnTransactionId);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnAppSpecific);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnAuthenticated);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnAuthenticationProviderName);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnAuthenticationProviderType);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnCorrelationId);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnDigitalSignature);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnEncryptionAlgorithm);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnHashAlgorithm);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnIsFirstInTransaction);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnIsLastInTransaction);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnLookupId);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnRecoverable);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnSenderId);
            this.fastObjectListViewMessages.AllColumns.Add(this.olvColumnSenderVersion);
            this.fastObjectListViewMessages.AllowColumnReorder = true;
            resources.ApplyResources(this.fastObjectListViewMessages, "fastObjectListViewMessages");
            this.fastObjectListViewMessages.CellEditUseWholeCell = false;
            this.fastObjectListViewMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnId,
            this.olvColumnLabel,
            this.olvColumnMachineName,
            this.olvColumnSentTime,
            this.olvColumnArrivedTime,
            this.olvColumnPriority,
            this.olvColumnMessageType});
            this.fastObjectListViewMessages.ContextMenuStrip = this.contextMenuStripMessage;
            this.fastObjectListViewMessages.FullRowSelect = true;
            this.fastObjectListViewMessages.GridLines = true;
            this.fastObjectListViewMessages.MultiSelect = false;
            this.fastObjectListViewMessages.Name = "fastObjectListViewMessages";
            this.fastObjectListViewMessages.ShowGroups = false;
            this.fastObjectListViewMessages.SmallImageList = this.imageListMsmq;
            this.fastObjectListViewMessages.UseCompatibleStateImageBehavior = false;
            this.fastObjectListViewMessages.View = System.Windows.Forms.View.Details;
            this.fastObjectListViewMessages.VirtualMode = true;
            this.fastObjectListViewMessages.Click += new System.EventHandler(this.fastObjectListViewMessages_SelectionChanged);
            this.fastObjectListViewMessages.DoubleClick += new System.EventHandler(this.fastObjectListViewMessages_DoubleClick);
            // 
            // olvColumnId
            // 
            this.olvColumnId.AspectName = "Id";
            resources.ApplyResources(this.olvColumnId, "olvColumnId");
            // 
            // olvColumnLabel
            // 
            this.olvColumnLabel.AspectName = "Label";
            resources.ApplyResources(this.olvColumnLabel, "olvColumnLabel");
            // 
            // olvColumnMachineName
            // 
            this.olvColumnMachineName.AspectName = "SourceMachine";
            resources.ApplyResources(this.olvColumnMachineName, "olvColumnMachineName");
            // 
            // olvColumnSentTime
            // 
            this.olvColumnSentTime.AspectName = "SentTime";
            resources.ApplyResources(this.olvColumnSentTime, "olvColumnSentTime");
            // 
            // olvColumnArrivedTime
            // 
            this.olvColumnArrivedTime.AspectName = "ArrivedTime";
            resources.ApplyResources(this.olvColumnArrivedTime, "olvColumnArrivedTime");
            // 
            // olvColumnPriority
            // 
            this.olvColumnPriority.AspectName = "Priority";
            resources.ApplyResources(this.olvColumnPriority, "olvColumnPriority");
            // 
            // olvColumnMessageType
            // 
            this.olvColumnMessageType.AspectName = "MessageType";
            resources.ApplyResources(this.olvColumnMessageType, "olvColumnMessageType");
            // 
            // olvColumnTransactionId
            // 
            this.olvColumnTransactionId.AspectName = "TransactionId";
            resources.ApplyResources(this.olvColumnTransactionId, "olvColumnTransactionId");
            this.olvColumnTransactionId.IsVisible = false;
            // 
            // olvColumnAppSpecific
            // 
            this.olvColumnAppSpecific.AspectName = "AppSpecific";
            this.olvColumnAppSpecific.IsVisible = false;
            resources.ApplyResources(this.olvColumnAppSpecific, "olvColumnAppSpecific");
            // 
            // olvColumnAuthenticated
            // 
            this.olvColumnAuthenticated.AspectName = "Authenticated";
            resources.ApplyResources(this.olvColumnAuthenticated, "olvColumnAuthenticated");
            this.olvColumnAuthenticated.IsVisible = false;
            // 
            // olvColumnAuthenticationProviderName
            // 
            this.olvColumnAuthenticationProviderName.AspectName = "AuthenticationProviderName";
            this.olvColumnAuthenticationProviderName.IsVisible = false;
            resources.ApplyResources(this.olvColumnAuthenticationProviderName, "olvColumnAuthenticationProviderName");
            // 
            // olvColumnAuthenticationProviderType
            // 
            this.olvColumnAuthenticationProviderType.AspectName = "AuthenticationProviderType";
            this.olvColumnAuthenticationProviderType.IsVisible = false;
            resources.ApplyResources(this.olvColumnAuthenticationProviderType, "olvColumnAuthenticationProviderType");
            // 
            // olvColumnCorrelationId
            // 
            this.olvColumnCorrelationId.AspectName = "CorrelationId";
            this.olvColumnCorrelationId.IsVisible = false;
            resources.ApplyResources(this.olvColumnCorrelationId, "olvColumnCorrelationId");
            // 
            // olvColumnDigitalSignature
            // 
            this.olvColumnDigitalSignature.AspectName = "DigitalSignature";
            this.olvColumnDigitalSignature.IsVisible = false;
            resources.ApplyResources(this.olvColumnDigitalSignature, "olvColumnDigitalSignature");
            // 
            // olvColumnEncryptionAlgorithm
            // 
            this.olvColumnEncryptionAlgorithm.AspectName = "EncryptionAlgorithm";
            this.olvColumnEncryptionAlgorithm.IsVisible = false;
            resources.ApplyResources(this.olvColumnEncryptionAlgorithm, "olvColumnEncryptionAlgorithm");
            // 
            // olvColumnHashAlgorithm
            // 
            this.olvColumnHashAlgorithm.AspectName = "HashAlgorithm";
            resources.ApplyResources(this.olvColumnHashAlgorithm, "olvColumnHashAlgorithm");
            this.olvColumnHashAlgorithm.IsVisible = false;
            // 
            // olvColumnIsFirstInTransaction
            // 
            this.olvColumnIsFirstInTransaction.AspectName = "IsFirstInTransaction";
            this.olvColumnIsFirstInTransaction.IsVisible = false;
            resources.ApplyResources(this.olvColumnIsFirstInTransaction, "olvColumnIsFirstInTransaction");
            // 
            // olvColumnIsLastInTransaction
            // 
            this.olvColumnIsLastInTransaction.AspectName = "IsLastInTransaction";
            this.olvColumnIsLastInTransaction.IsVisible = false;
            resources.ApplyResources(this.olvColumnIsLastInTransaction, "olvColumnIsLastInTransaction");
            // 
            // olvColumnLookupId
            // 
            this.olvColumnLookupId.AspectName = "LookupId";
            this.olvColumnLookupId.IsVisible = false;
            resources.ApplyResources(this.olvColumnLookupId, "olvColumnLookupId");
            // 
            // olvColumnRecoverable
            // 
            this.olvColumnRecoverable.AspectName = "Recoverable";
            this.olvColumnRecoverable.IsVisible = false;
            resources.ApplyResources(this.olvColumnRecoverable, "olvColumnRecoverable");
            // 
            // olvColumnSenderId
            // 
            this.olvColumnSenderId.AspectName = "SenderId";
            this.olvColumnSenderId.IsVisible = false;
            resources.ApplyResources(this.olvColumnSenderId, "olvColumnSenderId");
            // 
            // olvColumnSenderVersion
            // 
            this.olvColumnSenderVersion.AspectName = "SenderVersion";
            this.olvColumnSenderVersion.IsVisible = false;
            resources.ApplyResources(this.olvColumnSenderVersion, "olvColumnSenderVersion");
            // 
            // contextMenuStripMessage
            // 
            this.contextMenuStripMessage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemMsgDelete,
            this.toolStripMenuItemMsgPreview,
            this.toolStripMenuItemMsgCopy,
            this.toolStripMenuItemQueueReceive,
            this.toolStripSeparator1,
            this.toolStripMenuItemMsgProps});
            this.contextMenuStripMessage.Name = "contextMenuStripMessage";
            resources.ApplyResources(this.contextMenuStripMessage, "contextMenuStripMessage");
            // 
            // toolStripMenuItemMsgDelete
            // 
            this.toolStripMenuItemMsgDelete.Image = global::MSMQExplorer.Resource.MSMQ_mail_delete2_16;
            this.toolStripMenuItemMsgDelete.Name = "toolStripMenuItemMsgDelete";
            resources.ApplyResources(this.toolStripMenuItemMsgDelete, "toolStripMenuItemMsgDelete");
            this.toolStripMenuItemMsgDelete.Click += new System.EventHandler(this.toolStripMenuItemMsgDelete_Click);
            // 
            // toolStripMenuItemMsgPreview
            // 
            this.toolStripMenuItemMsgPreview.Image = global::MSMQExplorer.Resource.MSMQ_mail_search_16;
            this.toolStripMenuItemMsgPreview.Name = "toolStripMenuItemMsgPreview";
            resources.ApplyResources(this.toolStripMenuItemMsgPreview, "toolStripMenuItemMsgPreview");
            this.toolStripMenuItemMsgPreview.Click += new System.EventHandler(this.toolStripMenuItemMsgPreview_Click);
            // 
            // toolStripMenuItemMsgCopy
            // 
            this.toolStripMenuItemMsgCopy.Image = global::MSMQExplorer.Resource.MSMQ_mail_edit_16;
            this.toolStripMenuItemMsgCopy.Name = "toolStripMenuItemMsgCopy";
            resources.ApplyResources(this.toolStripMenuItemMsgCopy, "toolStripMenuItemMsgCopy");
            this.toolStripMenuItemMsgCopy.Click += new System.EventHandler(this.toolStripMenuItemMsgCopy_Click);
            // 
            // toolStripMenuItemQueueReceive
            // 
            this.toolStripMenuItemQueueReceive.Image = global::MSMQExplorer.Resource.MSMQ_mail_import_16;
            this.toolStripMenuItemQueueReceive.Name = "toolStripMenuItemQueueReceive";
            resources.ApplyResources(this.toolStripMenuItemQueueReceive, "toolStripMenuItemQueueReceive");
            this.toolStripMenuItemQueueReceive.Click += new System.EventHandler(this.toolStripMenuItemQueueReceive_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripMenuItemMsgProps
            // 
            this.toolStripMenuItemMsgProps.Image = global::MSMQExplorer.Resource.MSMQ_mail_info_16;
            this.toolStripMenuItemMsgProps.Name = "toolStripMenuItemMsgProps";
            resources.ApplyResources(this.toolStripMenuItemMsgProps, "toolStripMenuItemMsgProps");
            this.toolStripMenuItemMsgProps.Click += new System.EventHandler(this.toolStripMenuItemMsgProps_Click);
            // 
            // checkBoxRecTrans
            // 
            resources.ApplyResources(this.checkBoxRecTrans, "checkBoxRecTrans");
            this.checkBoxRecTrans.Checked = true;
            this.checkBoxRecTrans.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRecTrans.Name = "checkBoxRecTrans";
            this.toolTip.SetToolTip(this.checkBoxRecTrans, resources.GetString("checkBoxRecTrans.ToolTip"));
            this.checkBoxRecTrans.UseVisualStyleBackColor = true;
            this.checkBoxRecTrans.CheckedChanged += new System.EventHandler(this.checkBoxRecTrans_CheckedChanged);
            // 
            // labelCurrQueue
            // 
            resources.ApplyResources(this.labelCurrQueue, "labelCurrQueue");
            this.labelCurrQueue.Name = "labelCurrQueue";
            // 
            // textBoxQueue
            // 
            resources.ApplyResources(this.textBoxQueue, "textBoxQueue");
            this.textBoxQueue.Name = "textBoxQueue";
            this.textBoxQueue.ReadOnly = true;
            this.toolTip.SetToolTip(this.textBoxQueue, resources.GetString("textBoxQueue.ToolTip"));
            // 
            // buttonRefreshMessages
            // 
            resources.ApplyResources(this.buttonRefreshMessages, "buttonRefreshMessages");
            this.buttonRefreshMessages.Image = global::MSMQExplorer.Resource.MSMQ_folder_update_16;
            this.buttonRefreshMessages.Name = "buttonRefreshMessages";
            this.toolTip.SetToolTip(this.buttonRefreshMessages, resources.GetString("buttonRefreshMessages.ToolTip"));
            this.buttonRefreshMessages.UseVisualStyleBackColor = true;
            this.buttonRefreshMessages.Click += new System.EventHandler(this.buttonRefreshMessages_Click);
            // 
            // labelRecFormat
            // 
            resources.ApplyResources(this.labelRecFormat, "labelRecFormat");
            this.labelRecFormat.Name = "labelRecFormat";
            // 
            // comboBoxRecFormat
            // 
            resources.ApplyResources(this.comboBoxRecFormat, "comboBoxRecFormat");
            this.comboBoxRecFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRecFormat.FormattingEnabled = true;
            this.comboBoxRecFormat.Items.AddRange(new object[] {
            resources.GetString("comboBoxRecFormat.Items"),
            resources.GetString("comboBoxRecFormat.Items1"),
            resources.GetString("comboBoxRecFormat.Items2")});
            this.comboBoxRecFormat.Name = "comboBoxRecFormat";
            this.comboBoxRecFormat.SelectedIndexChanged += new System.EventHandler(this.comboBoxRecFormat_SelectedIndexChanged);
            // 
            // textBoxMsgId
            // 
            resources.ApplyResources(this.textBoxMsgId, "textBoxMsgId");
            this.textBoxMsgId.Name = "textBoxMsgId";
            this.textBoxMsgId.ReadOnly = true;
            // 
            // labelMsgId
            // 
            resources.ApplyResources(this.labelMsgId, "labelMsgId");
            this.labelMsgId.Name = "labelMsgId";
            // 
            // tabControlReceiveType
            // 
            resources.ApplyResources(this.tabControlReceiveType, "tabControlReceiveType");
            this.tabControlReceiveType.Controls.Add(this.tabPageXML);
            this.tabControlReceiveType.Controls.Add(this.tabPageHex);
            this.tabControlReceiveType.Controls.Add(this.tabPageText);
            this.tabControlReceiveType.Name = "tabControlReceiveType";
            this.tabControlReceiveType.SelectedIndex = 0;
            this.tabControlReceiveType.SelectedIndexChanged += new System.EventHandler(this.tabControlReceiveType_SelectedIndexChanged);
            // 
            // tabPageXML
            // 
            this.tabPageXML.Controls.Add(this.scintillaRecXML);
            resources.ApplyResources(this.tabPageXML, "tabPageXML");
            this.tabPageXML.Name = "tabPageXML";
            this.tabPageXML.UseVisualStyleBackColor = true;
            // 
            // scintillaRecXML
            // 
            resources.ApplyResources(this.scintillaRecXML, "scintillaRecXML");
            this.scintillaRecXML.Lexer = ScintillaNET.Lexer.Xml;
            this.scintillaRecXML.Name = "scintillaRecXML";
            // 
            // tabPageHex
            // 
            this.tabPageHex.Controls.Add(this.hexBoxRecHex);
            resources.ApplyResources(this.tabPageHex, "tabPageHex");
            this.tabPageHex.Name = "tabPageHex";
            this.tabPageHex.UseVisualStyleBackColor = true;
            // 
            // hexBoxRecHex
            // 
            resources.ApplyResources(this.hexBoxRecHex, "hexBoxRecHex");
            this.hexBoxRecHex.Name = "hexBoxRecHex";
            this.hexBoxRecHex.ReadOnly = true;
            this.hexBoxRecHex.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexBoxRecHex.StringViewVisible = true;
            this.hexBoxRecHex.VScrollBarVisible = true;
            // 
            // tabPageText
            // 
            this.tabPageText.Controls.Add(this.textBoxRecText);
            resources.ApplyResources(this.tabPageText, "tabPageText");
            this.tabPageText.Name = "tabPageText";
            this.tabPageText.UseVisualStyleBackColor = true;
            // 
            // textBoxRecText
            // 
            resources.ApplyResources(this.textBoxRecText, "textBoxRecText");
            this.textBoxRecText.Name = "textBoxRecText";
            this.textBoxRecText.ReadOnly = true;
            // 
            // textBoxXSDIn
            // 
            resources.ApplyResources(this.textBoxXSDIn, "textBoxXSDIn");
            this.textBoxXSDIn.Name = "textBoxXSDIn";
            this.toolTip.SetToolTip(this.textBoxXSDIn, resources.GetString("textBoxXSDIn.ToolTip"));
            // 
            // buttonXSDIn
            // 
            resources.ApplyResources(this.buttonXSDIn, "buttonXSDIn");
            this.buttonXSDIn.Name = "buttonXSDIn";
            this.toolTip.SetToolTip(this.buttonXSDIn, resources.GetString("buttonXSDIn.ToolTip"));
            this.buttonXSDIn.UseVisualStyleBackColor = true;
            this.buttonXSDIn.Click += new System.EventHandler(this.buttonXSDIn_Click);
            // 
            // buttonValidateIn
            // 
            resources.ApplyResources(this.buttonValidateIn, "buttonValidateIn");
            this.buttonValidateIn.Image = global::MSMQExplorer.Resource.MSMQ_document_ok_16;
            this.buttonValidateIn.Name = "buttonValidateIn";
            this.toolTip.SetToolTip(this.buttonValidateIn, resources.GetString("buttonValidateIn.ToolTip"));
            this.buttonValidateIn.UseVisualStyleBackColor = true;
            this.buttonValidateIn.Click += new System.EventHandler(this.buttonValidateIn_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControlMain
            // 
            resources.ApplyResources(this.tabControlMain, "tabControlMain");
            this.tabControlMain.Controls.Add(this.tabPageSend);
            this.tabControlMain.Controls.Add(this.tabPageReceive);
            this.tabControlMain.Controls.Add(this.tabPageLog);
            this.tabControlMain.ImageList = this.imageListTabs;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPageSend
            // 
            this.tabPageSend.Controls.Add(this.splitContainerSend);
            resources.ApplyResources(this.tabPageSend, "tabPageSend");
            this.tabPageSend.Name = "tabPageSend";
            this.tabPageSend.UseVisualStyleBackColor = true;
            // 
            // splitContainerSend
            // 
            resources.ApplyResources(this.splitContainerSend, "splitContainerSend");
            this.splitContainerSend.Name = "splitContainerSend";
            // 
            // splitContainerSend.Panel1
            // 
            this.splitContainerSend.Panel1.Controls.Add(this.labelQueue);
            this.splitContainerSend.Panel1.Controls.Add(this.textBoxSelectedSendQueue);
            this.splitContainerSend.Panel1.Controls.Add(this.bufferedTreeViewSendQueues);
            this.splitContainerSend.Panel1.Controls.Add(this.labelSendHost);
            this.splitContainerSend.Panel1.Controls.Add(this.buttonSendConnect);
            this.splitContainerSend.Panel1.Controls.Add(this.textBoxSendHost);
            // 
            // splitContainerSend.Panel2
            // 
            this.splitContainerSend.Panel2.Controls.Add(this.splitContainerSendMsgDetail);
            this.splitContainerSend.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainerSend_Paint);
            // 
            // labelQueue
            // 
            resources.ApplyResources(this.labelQueue, "labelQueue");
            this.labelQueue.Name = "labelQueue";
            // 
            // textBoxSelectedSendQueue
            // 
            resources.ApplyResources(this.textBoxSelectedSendQueue, "textBoxSelectedSendQueue");
            this.textBoxSelectedSendQueue.Name = "textBoxSelectedSendQueue";
            this.textBoxSelectedSendQueue.ReadOnly = true;
            // 
            // bufferedTreeViewSendQueues
            // 
            resources.ApplyResources(this.bufferedTreeViewSendQueues, "bufferedTreeViewSendQueues");
            this.bufferedTreeViewSendQueues.ContextMenuStrip = this.contextMenuStripSendQueue;
            this.bufferedTreeViewSendQueues.HideSelection = false;
            this.bufferedTreeViewSendQueues.ImageList = this.imageListMsmq;
            this.bufferedTreeViewSendQueues.Name = "bufferedTreeViewSendQueues";
            this.bufferedTreeViewSendQueues.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.bufferedTreeViewSendQueues_AfterSelect);
            this.bufferedTreeViewSendQueues.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bufferedTreeViewSendQueues_MouseDown);
            // 
            // contextMenuStripSendQueue
            // 
            this.contextMenuStripSendQueue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNewQueueRec,
            this.toolStripMenuItemDeleteQueueRec,
            this.toolStripMenuItemPurge,
            this.toolStripSeparator3,
            this.toolStripMenuItemSendQueueProps});
            this.contextMenuStripSendQueue.Name = "contextMenuStripQueue";
            resources.ApplyResources(this.contextMenuStripSendQueue, "contextMenuStripSendQueue");
            // 
            // toolStripMenuItemNewQueueRec
            // 
            this.toolStripMenuItemNewQueueRec.Image = global::MSMQExplorer.Resource.MSMQ_folder_add2_16;
            this.toolStripMenuItemNewQueueRec.Name = "toolStripMenuItemNewQueueRec";
            resources.ApplyResources(this.toolStripMenuItemNewQueueRec, "toolStripMenuItemNewQueueRec");
            this.toolStripMenuItemNewQueueRec.Click += new System.EventHandler(this.toolStripMenuItemNewQueueRec_Click);
            // 
            // toolStripMenuItemDeleteQueueRec
            // 
            this.toolStripMenuItemDeleteQueueRec.Image = global::MSMQExplorer.Resource.MSMQ_folder_delete2_16;
            this.toolStripMenuItemDeleteQueueRec.Name = "toolStripMenuItemDeleteQueueRec";
            resources.ApplyResources(this.toolStripMenuItemDeleteQueueRec, "toolStripMenuItemDeleteQueueRec");
            this.toolStripMenuItemDeleteQueueRec.Click += new System.EventHandler(this.toolStripMenuItemDeleteQueueRec_Click);
            // 
            // toolStripMenuItemPurge
            // 
            this.toolStripMenuItemPurge.Image = global::MSMQExplorer.Resource.MSMQ_trash_bin_delete2_16;
            this.toolStripMenuItemPurge.Name = "toolStripMenuItemPurge";
            resources.ApplyResources(this.toolStripMenuItemPurge, "toolStripMenuItemPurge");
            this.toolStripMenuItemPurge.Click += new System.EventHandler(this.toolStripMenuItemPurge_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // toolStripMenuItemSendQueueProps
            // 
            this.toolStripMenuItemSendQueueProps.Image = global::MSMQExplorer.Resource.MSMQ_folder_info_32;
            this.toolStripMenuItemSendQueueProps.Name = "toolStripMenuItemSendQueueProps";
            resources.ApplyResources(this.toolStripMenuItemSendQueueProps, "toolStripMenuItemSendQueueProps");
            this.toolStripMenuItemSendQueueProps.Click += new System.EventHandler(this.toolStripMenuItemSendQueueProps_Click);
            // 
            // labelSendHost
            // 
            resources.ApplyResources(this.labelSendHost, "labelSendHost");
            this.labelSendHost.Name = "labelSendHost";
            // 
            // buttonSendConnect
            // 
            resources.ApplyResources(this.buttonSendConnect, "buttonSendConnect");
            this.buttonSendConnect.Image = global::MSMQExplorer.Resource.MSMQ_computer_update_16;
            this.buttonSendConnect.Name = "buttonSendConnect";
            this.toolTip.SetToolTip(this.buttonSendConnect, resources.GetString("buttonSendConnect.ToolTip"));
            this.buttonSendConnect.UseVisualStyleBackColor = true;
            this.buttonSendConnect.Click += new System.EventHandler(this.buttonSendConnect_Click);
            // 
            // textBoxSendHost
            // 
            resources.ApplyResources(this.textBoxSendHost, "textBoxSendHost");
            this.textBoxSendHost.Name = "textBoxSendHost";
            this.toolTip.SetToolTip(this.textBoxSendHost, resources.GetString("textBoxSendHost.ToolTip"));
            this.textBoxSendHost.TextChanged += new System.EventHandler(this.textBoxSendHost_TextChanged);
            // 
            // splitContainerSendMsgDetail
            // 
            resources.ApplyResources(this.splitContainerSendMsgDetail, "splitContainerSendMsgDetail");
            this.splitContainerSendMsgDetail.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerSendMsgDetail.Name = "splitContainerSendMsgDetail";
            // 
            // splitContainerSendMsgDetail.Panel1
            // 
            this.splitContainerSendMsgDetail.Panel1.Controls.Add(this.tabControlSendType);
            // 
            // splitContainerSendMsgDetail.Panel2
            // 
            this.splitContainerSendMsgDetail.Panel2.Controls.Add(this.groupBoxMsgProps);
            // 
            // tabControlSendType
            // 
            resources.ApplyResources(this.tabControlSendType, "tabControlSendType");
            this.tabControlSendType.Controls.Add(this.tabPageSendXML);
            this.tabControlSendType.Controls.Add(this.tabPageSendHex);
            this.tabControlSendType.Controls.Add(this.tabPageSendText);
            this.tabControlSendType.Name = "tabControlSendType";
            this.tabControlSendType.SelectedIndex = 0;
            // 
            // tabPageSendXML
            // 
            this.tabPageSendXML.Controls.Add(this.scintillaSendXML);
            this.tabPageSendXML.Controls.Add(this.buttonXSDOut);
            this.tabPageSendXML.Controls.Add(this.labelValidateOut);
            this.tabPageSendXML.Controls.Add(this.buttonValidateOut);
            this.tabPageSendXML.Controls.Add(this.textBoxXSDOut);
            resources.ApplyResources(this.tabPageSendXML, "tabPageSendXML");
            this.tabPageSendXML.Name = "tabPageSendXML";
            this.tabPageSendXML.UseVisualStyleBackColor = true;
            // 
            // scintillaSendXML
            // 
            resources.ApplyResources(this.scintillaSendXML, "scintillaSendXML");
            this.scintillaSendXML.Lexer = ScintillaNET.Lexer.Xml;
            this.scintillaSendXML.Name = "scintillaSendXML";
            this.scintillaSendXML.TextChanged += new System.EventHandler(this.scintillaSendXML_TextChanged);
            // 
            // buttonXSDOut
            // 
            resources.ApplyResources(this.buttonXSDOut, "buttonXSDOut");
            this.buttonXSDOut.Name = "buttonXSDOut";
            this.toolTip.SetToolTip(this.buttonXSDOut, resources.GetString("buttonXSDOut.ToolTip"));
            this.buttonXSDOut.UseVisualStyleBackColor = true;
            this.buttonXSDOut.Click += new System.EventHandler(this.buttonXSDOut_Click);
            // 
            // labelValidateOut
            // 
            resources.ApplyResources(this.labelValidateOut, "labelValidateOut");
            this.labelValidateOut.Name = "labelValidateOut";
            // 
            // buttonValidateOut
            // 
            resources.ApplyResources(this.buttonValidateOut, "buttonValidateOut");
            this.buttonValidateOut.Image = global::MSMQExplorer.Resource.MSMQ_document_ok_16;
            this.buttonValidateOut.Name = "buttonValidateOut";
            this.toolTip.SetToolTip(this.buttonValidateOut, resources.GetString("buttonValidateOut.ToolTip"));
            this.buttonValidateOut.UseVisualStyleBackColor = true;
            this.buttonValidateOut.Click += new System.EventHandler(this.buttonValidateOut_Click);
            // 
            // textBoxXSDOut
            // 
            resources.ApplyResources(this.textBoxXSDOut, "textBoxXSDOut");
            this.textBoxXSDOut.Name = "textBoxXSDOut";
            this.toolTip.SetToolTip(this.textBoxXSDOut, resources.GetString("textBoxXSDOut.ToolTip"));
            // 
            // tabPageSendHex
            // 
            this.tabPageSendHex.Controls.Add(this.hexBoxSendHex);
            resources.ApplyResources(this.tabPageSendHex, "tabPageSendHex");
            this.tabPageSendHex.Name = "tabPageSendHex";
            this.tabPageSendHex.UseVisualStyleBackColor = true;
            // 
            // hexBoxSendHex
            // 
            resources.ApplyResources(this.hexBoxSendHex, "hexBoxSendHex");
            this.hexBoxSendHex.Name = "hexBoxSendHex";
            this.hexBoxSendHex.ReadOnly = true;
            this.hexBoxSendHex.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexBoxSendHex.StringViewVisible = true;
            this.hexBoxSendHex.VScrollBarVisible = true;
            // 
            // tabPageSendText
            // 
            this.tabPageSendText.Controls.Add(this.textBoxSendText);
            resources.ApplyResources(this.tabPageSendText, "tabPageSendText");
            this.tabPageSendText.Name = "tabPageSendText";
            this.tabPageSendText.UseVisualStyleBackColor = true;
            // 
            // textBoxSendText
            // 
            resources.ApplyResources(this.textBoxSendText, "textBoxSendText");
            this.textBoxSendText.Name = "textBoxSendText";
            this.textBoxSendText.TextChanged += new System.EventHandler(this.textBoxSendText_TextChanged);
            // 
            // groupBoxMsgProps
            // 
            resources.ApplyResources(this.groupBoxMsgProps, "groupBoxMsgProps");
            this.groupBoxMsgProps.Controls.Add(this.labelSendFormat);
            this.groupBoxMsgProps.Controls.Add(this.comboBoxSendFormat);
            this.groupBoxMsgProps.Controls.Add(this.checkBoxUserJournal);
            this.groupBoxMsgProps.Controls.Add(this.checkBoxUseTracing);
            this.groupBoxMsgProps.Controls.Add(this.checkBoxUseEncryption);
            this.groupBoxMsgProps.Controls.Add(this.comboBoxPriority);
            this.groupBoxMsgProps.Controls.Add(this.labelPriority);
            this.groupBoxMsgProps.Controls.Add(this.textBoxMsgLabel);
            this.groupBoxMsgProps.Controls.Add(this.labelMSGLabel);
            this.groupBoxMsgProps.Controls.Add(this.checkBoxTrans);
            this.groupBoxMsgProps.Controls.Add(this.checkBoxUserDeadLetter);
            this.groupBoxMsgProps.Controls.Add(this.labelTimeToReceive);
            this.groupBoxMsgProps.Controls.Add(this.labelTimeReachQueue);
            this.groupBoxMsgProps.Controls.Add(this.numericUpDownTimeToReachQueue);
            this.groupBoxMsgProps.Controls.Add(this.numericUpDownTimeToReceive);
            this.groupBoxMsgProps.Controls.Add(this.comboBoxTimeReachQueue);
            this.groupBoxMsgProps.Controls.Add(this.comboBoxTimeToReceive);
            this.groupBoxMsgProps.Name = "groupBoxMsgProps";
            this.groupBoxMsgProps.TabStop = false;
            // 
            // labelSendFormat
            // 
            resources.ApplyResources(this.labelSendFormat, "labelSendFormat");
            this.labelSendFormat.Name = "labelSendFormat";
            // 
            // comboBoxSendFormat
            // 
            this.comboBoxSendFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSendFormat.FormattingEnabled = true;
            this.comboBoxSendFormat.Items.AddRange(new object[] {
            resources.GetString("comboBoxSendFormat.Items"),
            resources.GetString("comboBoxSendFormat.Items1"),
            resources.GetString("comboBoxSendFormat.Items2")});
            resources.ApplyResources(this.comboBoxSendFormat, "comboBoxSendFormat");
            this.comboBoxSendFormat.Name = "comboBoxSendFormat";
            this.comboBoxSendFormat.SelectedIndexChanged += new System.EventHandler(this.comboBoxSendFormat_SelectedIndexChanged);
            // 
            // checkBoxUserJournal
            // 
            resources.ApplyResources(this.checkBoxUserJournal, "checkBoxUserJournal");
            this.checkBoxUserJournal.Name = "checkBoxUserJournal";
            this.checkBoxUserJournal.UseVisualStyleBackColor = true;
            this.checkBoxUserJournal.CheckedChanged += new System.EventHandler(this.checkBoxUserJournal_CheckedChanged);
            // 
            // checkBoxUseTracing
            // 
            resources.ApplyResources(this.checkBoxUseTracing, "checkBoxUseTracing");
            this.checkBoxUseTracing.Name = "checkBoxUseTracing";
            this.checkBoxUseTracing.UseVisualStyleBackColor = true;
            this.checkBoxUseTracing.CheckedChanged += new System.EventHandler(this.checkBoxUseTracing_CheckedChanged);
            // 
            // checkBoxUseEncryption
            // 
            resources.ApplyResources(this.checkBoxUseEncryption, "checkBoxUseEncryption");
            this.checkBoxUseEncryption.Name = "checkBoxUseEncryption";
            this.checkBoxUseEncryption.UseVisualStyleBackColor = true;
            this.checkBoxUseEncryption.CheckedChanged += new System.EventHandler(this.checkBoxUseEncryption_CheckedChanged);
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPriority.Items.AddRange(new object[] {
            resources.GetString("comboBoxPriority.Items"),
            resources.GetString("comboBoxPriority.Items1"),
            resources.GetString("comboBoxPriority.Items2"),
            resources.GetString("comboBoxPriority.Items3"),
            resources.GetString("comboBoxPriority.Items4"),
            resources.GetString("comboBoxPriority.Items5"),
            resources.GetString("comboBoxPriority.Items6"),
            resources.GetString("comboBoxPriority.Items7")});
            resources.ApplyResources(this.comboBoxPriority, "comboBoxPriority");
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.SelectedIndexChanged += new System.EventHandler(this.comboBoxPriority_SelectedIndexChanged);
            // 
            // labelPriority
            // 
            resources.ApplyResources(this.labelPriority, "labelPriority");
            this.labelPriority.Name = "labelPriority";
            // 
            // textBoxMsgLabel
            // 
            resources.ApplyResources(this.textBoxMsgLabel, "textBoxMsgLabel");
            this.textBoxMsgLabel.Name = "textBoxMsgLabel";
            this.toolTip.SetToolTip(this.textBoxMsgLabel, resources.GetString("textBoxMsgLabel.ToolTip"));
            this.textBoxMsgLabel.TextChanged += new System.EventHandler(this.textBoxMsgLabel_TextChanged);
            // 
            // labelMSGLabel
            // 
            resources.ApplyResources(this.labelMSGLabel, "labelMSGLabel");
            this.labelMSGLabel.Name = "labelMSGLabel";
            // 
            // checkBoxTrans
            // 
            resources.ApplyResources(this.checkBoxTrans, "checkBoxTrans");
            this.checkBoxTrans.Checked = true;
            this.checkBoxTrans.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTrans.Name = "checkBoxTrans";
            this.toolTip.SetToolTip(this.checkBoxTrans, resources.GetString("checkBoxTrans.ToolTip"));
            this.checkBoxTrans.UseVisualStyleBackColor = true;
            this.checkBoxTrans.CheckedChanged += new System.EventHandler(this.checkBoxTrans_CheckedChanged);
            // 
            // checkBoxUserDeadLetter
            // 
            resources.ApplyResources(this.checkBoxUserDeadLetter, "checkBoxUserDeadLetter");
            this.checkBoxUserDeadLetter.Checked = true;
            this.checkBoxUserDeadLetter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUserDeadLetter.Name = "checkBoxUserDeadLetter";
            this.checkBoxUserDeadLetter.UseVisualStyleBackColor = true;
            this.checkBoxUserDeadLetter.CheckedChanged += new System.EventHandler(this.checkBoxUserDeadLetter_CheckedChanged);
            // 
            // labelTimeToReceive
            // 
            resources.ApplyResources(this.labelTimeToReceive, "labelTimeToReceive");
            this.labelTimeToReceive.Name = "labelTimeToReceive";
            // 
            // labelTimeReachQueue
            // 
            resources.ApplyResources(this.labelTimeReachQueue, "labelTimeReachQueue");
            this.labelTimeReachQueue.Name = "labelTimeReachQueue";
            // 
            // numericUpDownTimeToReachQueue
            // 
            resources.ApplyResources(this.numericUpDownTimeToReachQueue, "numericUpDownTimeToReachQueue");
            this.numericUpDownTimeToReachQueue.Name = "numericUpDownTimeToReachQueue";
            this.numericUpDownTimeToReachQueue.ValueChanged += new System.EventHandler(this.numericUpDownTimeToReachQueue_ValueChanged);
            // 
            // numericUpDownTimeToReceive
            // 
            resources.ApplyResources(this.numericUpDownTimeToReceive, "numericUpDownTimeToReceive");
            this.numericUpDownTimeToReceive.Name = "numericUpDownTimeToReceive";
            this.numericUpDownTimeToReceive.ValueChanged += new System.EventHandler(this.numericUpDownTimeToReceive_ValueChanged);
            // 
            // comboBoxTimeReachQueue
            // 
            this.comboBoxTimeReachQueue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTimeReachQueue.FormattingEnabled = true;
            this.comboBoxTimeReachQueue.Items.AddRange(new object[] {
            resources.GetString("comboBoxTimeReachQueue.Items"),
            resources.GetString("comboBoxTimeReachQueue.Items1"),
            resources.GetString("comboBoxTimeReachQueue.Items2"),
            resources.GetString("comboBoxTimeReachQueue.Items3")});
            resources.ApplyResources(this.comboBoxTimeReachQueue, "comboBoxTimeReachQueue");
            this.comboBoxTimeReachQueue.Name = "comboBoxTimeReachQueue";
            this.comboBoxTimeReachQueue.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimeReachQueue_SelectedIndexChanged);
            // 
            // comboBoxTimeToReceive
            // 
            this.comboBoxTimeToReceive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTimeToReceive.FormattingEnabled = true;
            this.comboBoxTimeToReceive.Items.AddRange(new object[] {
            resources.GetString("comboBoxTimeToReceive.Items"),
            resources.GetString("comboBoxTimeToReceive.Items1"),
            resources.GetString("comboBoxTimeToReceive.Items2"),
            resources.GetString("comboBoxTimeToReceive.Items3")});
            resources.ApplyResources(this.comboBoxTimeToReceive, "comboBoxTimeToReceive");
            this.comboBoxTimeToReceive.Name = "comboBoxTimeToReceive";
            this.comboBoxTimeToReceive.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimeToReceive_SelectedIndexChanged);
            // 
            // tabPageReceive
            // 
            this.tabPageReceive.Controls.Add(this.splitContainerReceive);
            resources.ApplyResources(this.tabPageReceive, "tabPageReceive");
            this.tabPageReceive.Name = "tabPageReceive";
            this.tabPageReceive.UseVisualStyleBackColor = true;
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.fastObjectListViewLog);
            resources.ApplyResources(this.tabPageLog, "tabPageLog");
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // fastObjectListViewLog
            // 
            this.fastObjectListViewLog.AllColumns.Add(this.olvColumnTimestamp);
            this.fastObjectListViewLog.AllColumns.Add(this.olvColumnEventType);
            this.fastObjectListViewLog.AllColumns.Add(this.olvColumnLogEntry);
            resources.ApplyResources(this.fastObjectListViewLog, "fastObjectListViewLog");
            this.fastObjectListViewLog.CellEditUseWholeCell = false;
            this.fastObjectListViewLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnTimestamp,
            this.olvColumnEventType,
            this.olvColumnLogEntry});
            this.fastObjectListViewLog.GridLines = true;
            this.fastObjectListViewLog.Name = "fastObjectListViewLog";
            this.fastObjectListViewLog.ShowGroups = false;
            this.fastObjectListViewLog.UseCompatibleStateImageBehavior = false;
            this.fastObjectListViewLog.View = System.Windows.Forms.View.Details;
            this.fastObjectListViewLog.VirtualMode = true;
            // 
            // olvColumnTimestamp
            // 
            this.olvColumnTimestamp.AspectName = "TimeStamp";
            resources.ApplyResources(this.olvColumnTimestamp, "olvColumnTimestamp");
            // 
            // olvColumnEventType
            // 
            this.olvColumnEventType.AspectName = "LogType";
            resources.ApplyResources(this.olvColumnEventType, "olvColumnEventType");
            // 
            // olvColumnLogEntry
            // 
            this.olvColumnLogEntry.AspectName = "LogEntry";
            resources.ApplyResources(this.olvColumnLogEntry, "olvColumnLogEntry");
            // 
            // imageListTabs
            // 
            this.imageListTabs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTabs.ImageStream")));
            this.imageListTabs.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTabs.Images.SetKeyName(0, "Edit_Receive.png");
            this.imageListTabs.Images.SetKeyName(1, "Edit_Send.png");
            // 
            // automaticUpdater
            // 
            resources.ApplyResources(this.automaticUpdater, "automaticUpdater");
            this.automaticUpdater.ContainerForm = this;
            this.automaticUpdater.GUID = "cfc87673-2c0f-4cf6-9764-10537f49d52b";
            this.automaticUpdater.Name = "automaticUpdater";
            this.automaticUpdater.wyUpdateCommandline = null;
            // 
            // BottomToolStripPanel
            // 
            resources.ApplyResources(this.BottomToolStripPanel, "BottomToolStripPanel");
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            // 
            // TopToolStripPanel
            // 
            resources.ApplyResources(this.TopToolStripPanel, "TopToolStripPanel");
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            // 
            // RightToolStripPanel
            // 
            resources.ApplyResources(this.RightToolStripPanel, "RightToolStripPanel");
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            // 
            // LeftToolStripPanel
            // 
            resources.ApplyResources(this.LeftToolStripPanel, "LeftToolStripPanel");
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            // 
            // ContentPanel
            // 
            resources.ApplyResources(this.ContentPanel, "ContentPanel");
            // 
            // ribbonMain
            // 
            resources.ApplyResources(this.ribbonMain, "ribbonMain");
            this.ribbonMain.Minimized = false;
            this.ribbonMain.Name = "ribbonMain";
            // 
            // 
            // 
            this.ribbonMain.OrbDropDown.BorderRoundness = 8;
            this.ribbonMain.OrbDropDown.Location = ((System.Drawing.Point)(resources.GetObject("ribbonMain.OrbDropDown.Location")));
            this.ribbonMain.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItemOpenXML);
            this.ribbonMain.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItemOpenOther);
            this.ribbonMain.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItemSaveAsXml);
            this.ribbonMain.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItemSaveAsOther);
            this.ribbonMain.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItemExit);
            this.ribbonMain.OrbDropDown.Name = "";
            this.ribbonMain.OrbDropDown.Size = ((System.Drawing.Size)(resources.GetObject("ribbonMain.OrbDropDown.Size")));
            this.ribbonMain.OrbDropDown.TabIndex = ((int)(resources.GetObject("ribbonMain.OrbDropDown.TabIndex")));
            this.ribbonMain.OrbImage = null;
            this.ribbonMain.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            this.ribbonMain.OrbText = "File";
            // 
            // 
            // 
            this.ribbonMain.QuickAcessToolbar.Items.Add(this.ribbonButtonOpenXML);
            this.ribbonMain.QuickAcessToolbar.Items.Add(this.ribbonButtonCheckForUpdate);
            this.ribbonMain.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbonMain.Tabs.Add(this.ribbonTabMain);
            this.ribbonMain.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbonMain.ThemeColor = System.Windows.Forms.RibbonTheme.Black;
            // 
            // ribbonOrbMenuItemOpenXML
            // 
            this.ribbonOrbMenuItemOpenXML.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItemOpenXML.Image = global::MSMQExplorer.Resource.MSMQ_document_open_16;
            this.ribbonOrbMenuItemOpenXML.SmallImage = global::MSMQExplorer.Resource.MSMQ_document_open_16;
            resources.ApplyResources(this.ribbonOrbMenuItemOpenXML, "ribbonOrbMenuItemOpenXML");
            this.ribbonOrbMenuItemOpenXML.Click += new System.EventHandler(this.ribbonOrbMenuItemOpenXML_Click);
            // 
            // ribbonOrbMenuItemOpenOther
            // 
            this.ribbonOrbMenuItemOpenOther.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItemOpenOther.Image = global::MSMQExplorer.Resource.MSMQ_document_open_16;
            this.ribbonOrbMenuItemOpenOther.SmallImage = global::MSMQExplorer.Resource.MSMQ_document_open_16;
            resources.ApplyResources(this.ribbonOrbMenuItemOpenOther, "ribbonOrbMenuItemOpenOther");
            this.ribbonOrbMenuItemOpenOther.Click += new System.EventHandler(this.ribbonOrbMenuItemOpenOther_Click);
            // 
            // ribbonOrbMenuItemSaveAsXml
            // 
            this.ribbonOrbMenuItemSaveAsXml.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItemSaveAsXml.Image = global::MSMQExplorer.Resource.MSMQ_document_save_16;
            this.ribbonOrbMenuItemSaveAsXml.SmallImage = global::MSMQExplorer.Resource.MSMQ_document_save_16;
            resources.ApplyResources(this.ribbonOrbMenuItemSaveAsXml, "ribbonOrbMenuItemSaveAsXml");
            this.ribbonOrbMenuItemSaveAsXml.Click += new System.EventHandler(this.ribbonOrbMenuItemSaveAsXml_Click);
            // 
            // ribbonOrbMenuItemSaveAsOther
            // 
            this.ribbonOrbMenuItemSaveAsOther.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItemSaveAsOther.Image = global::MSMQExplorer.Resource.MSMQ_document_save_16;
            this.ribbonOrbMenuItemSaveAsOther.SmallImage = global::MSMQExplorer.Resource.MSMQ_document_save_16;
            resources.ApplyResources(this.ribbonOrbMenuItemSaveAsOther, "ribbonOrbMenuItemSaveAsOther");
            this.ribbonOrbMenuItemSaveAsOther.Click += new System.EventHandler(this.ribbonOrbMenuItemSaveAsOther_Click);
            // 
            // ribbonOrbMenuItemExit
            // 
            this.ribbonOrbMenuItemExit.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItemExit.Image = global::MSMQExplorer.Resource.MSMQ_close_window_16;
            this.ribbonOrbMenuItemExit.SmallImage = global::MSMQExplorer.Resource.MSMQ_close_window_16;
            resources.ApplyResources(this.ribbonOrbMenuItemExit, "ribbonOrbMenuItemExit");
            this.ribbonOrbMenuItemExit.Click += new System.EventHandler(this.ribbonOrbMenuItemExit_Click);
            // 
            // ribbonButtonOpenXML
            // 
            this.ribbonButtonOpenXML.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonOpenXML.Image")));
            this.ribbonButtonOpenXML.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonOpenXML.SmallImage = global::MSMQExplorer.Resource.MSMQ_document_open_16;
            resources.ApplyResources(this.ribbonButtonOpenXML, "ribbonButtonOpenXML");
            this.ribbonButtonOpenXML.Click += new System.EventHandler(this.ribbonButtonOpenXML_Click);
            // 
            // ribbonButtonCheckForUpdate
            // 
            this.ribbonButtonCheckForUpdate.Image = global::MSMQExplorer.Resource.MSMQ_install_16;
            this.ribbonButtonCheckForUpdate.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonCheckForUpdate.SmallImage = global::MSMQExplorer.Resource.MSMQ_install_16;
            resources.ApplyResources(this.ribbonButtonCheckForUpdate, "ribbonButtonCheckForUpdate");
            this.ribbonButtonCheckForUpdate.Click += new System.EventHandler(this.ribbonButtonCheckForUpdate_Click);
            // 
            // ribbonTabMain
            // 
            this.ribbonTabMain.Panels.Add(this.ribbonPanelEdit);
            this.ribbonTabMain.Panels.Add(this.ribbonPanelQueue);
            this.ribbonTabMain.Panels.Add(this.ribbonPanelMessages);
            this.ribbonTabMain.Panels.Add(this.ribbonPanelSearch);
            this.ribbonTabMain.Panels.Add(this.ribbonPanelHelp);
            this.ribbonTabMain.Panels.Add(this.ribbonPanelView);
            this.ribbonTabMain.Panels.Add(this.ribbonPanelSettings);
            resources.ApplyResources(this.ribbonTabMain, "ribbonTabMain");
            // 
            // ribbonPanelEdit
            // 
            this.ribbonPanelEdit.ButtonMoreEnabled = false;
            this.ribbonPanelEdit.ButtonMoreVisible = false;
            this.ribbonPanelEdit.Items.Add(this.ribbonButtonPaste);
            this.ribbonPanelEdit.Items.Add(this.ribbonButtonCut);
            this.ribbonPanelEdit.Items.Add(this.ribbonButtonCopy);
            this.ribbonPanelEdit.Items.Add(this.ribbonButtonFormat);
            resources.ApplyResources(this.ribbonPanelEdit, "ribbonPanelEdit");
            // 
            // ribbonButtonPaste
            // 
            this.ribbonButtonPaste.Image = global::MSMQExplorer.Resource.MSMQ_clipboard_paste_32;
            this.ribbonButtonPaste.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPaste.SmallImage")));
            resources.ApplyResources(this.ribbonButtonPaste, "ribbonButtonPaste");
            this.ribbonButtonPaste.Click += new System.EventHandler(this.ribbonButtonPaste_Click);
            // 
            // ribbonButtonCut
            // 
            this.ribbonButtonCut.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonCut.Image")));
            this.ribbonButtonCut.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonCut.SmallImage = global::MSMQExplorer.Resource.MSMQ_clipboard_cut_16;
            resources.ApplyResources(this.ribbonButtonCut, "ribbonButtonCut");
            this.ribbonButtonCut.Click += new System.EventHandler(this.ribbonButtonCut_Click);
            // 
            // ribbonButtonCopy
            // 
            this.ribbonButtonCopy.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonCopy.Image")));
            this.ribbonButtonCopy.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonCopy.SmallImage = global::MSMQExplorer.Resource.MSMQ_clipboard_copy_16;
            resources.ApplyResources(this.ribbonButtonCopy, "ribbonButtonCopy");
            this.ribbonButtonCopy.Click += new System.EventHandler(this.ribbonButtonCopy_Click);
            // 
            // ribbonButtonFormat
            // 
            this.ribbonButtonFormat.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonFormat.Image")));
            this.ribbonButtonFormat.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonFormat.SmallImage = global::MSMQExplorer.Resource.MSMQ_clipboard_edit_16;
            resources.ApplyResources(this.ribbonButtonFormat, "ribbonButtonFormat");
            this.ribbonButtonFormat.Click += new System.EventHandler(this.ribbonButtonFormat_Click);
            // 
            // ribbonPanelQueue
            // 
            this.ribbonPanelQueue.ButtonMoreEnabled = false;
            this.ribbonPanelQueue.ButtonMoreVisible = false;
            this.ribbonPanelQueue.Items.Add(this.ribbonButtonQueueNew);
            this.ribbonPanelQueue.Items.Add(this.ribbonButtonQueueDelete);
            this.ribbonPanelQueue.Items.Add(this.ribbonButtonQueuePurge);
            this.ribbonPanelQueue.Items.Add(this.ribbonButtonQueueProperties);
            resources.ApplyResources(this.ribbonPanelQueue, "ribbonPanelQueue");
            // 
            // ribbonButtonQueueNew
            // 
            this.ribbonButtonQueueNew.Image = global::MSMQExplorer.Resource.MSMQ_folderadd2_32;
            this.ribbonButtonQueueNew.SmallImage = global::MSMQExplorer.Resource.MSMQ_folder_add2_16;
            resources.ApplyResources(this.ribbonButtonQueueNew, "ribbonButtonQueueNew");
            this.ribbonButtonQueueNew.Click += new System.EventHandler(this.ribbonButtonQueueNew_Click);
            // 
            // ribbonButtonQueueDelete
            // 
            this.ribbonButtonQueueDelete.Image = global::MSMQExplorer.Resource.MSMQ_folder_delete2_32;
            this.ribbonButtonQueueDelete.SmallImage = global::MSMQExplorer.Resource.MSMQ_folder_delete2_16;
            resources.ApplyResources(this.ribbonButtonQueueDelete, "ribbonButtonQueueDelete");
            this.ribbonButtonQueueDelete.Click += new System.EventHandler(this.ribbonButtonQueueDelete_Click);
            // 
            // ribbonButtonQueuePurge
            // 
            this.ribbonButtonQueuePurge.Image = global::MSMQExplorer.Resource.MSMQ_trash_bin_delete2_32;
            this.ribbonButtonQueuePurge.SmallImage = global::MSMQExplorer.Resource.MSMQ_trash_bin_delete2_16;
            resources.ApplyResources(this.ribbonButtonQueuePurge, "ribbonButtonQueuePurge");
            this.ribbonButtonQueuePurge.Click += new System.EventHandler(this.ribbonButtonQueuePurge_Click);
            // 
            // ribbonButtonQueueProperties
            // 
            this.ribbonButtonQueueProperties.Image = global::MSMQExplorer.Resource.MSMQ_folder_info_32;
            this.ribbonButtonQueueProperties.SmallImage = global::MSMQExplorer.Resource.MSMQ_folder_info_16;
            resources.ApplyResources(this.ribbonButtonQueueProperties, "ribbonButtonQueueProperties");
            this.ribbonButtonQueueProperties.Click += new System.EventHandler(this.ribbonButtonQueueProperties_Click);
            // 
            // ribbonPanelMessages
            // 
            this.ribbonPanelMessages.ButtonMoreEnabled = false;
            this.ribbonPanelMessages.ButtonMoreVisible = false;
            this.ribbonPanelMessages.Items.Add(this.ribbonButtonMsgSend);
            this.ribbonPanelMessages.Items.Add(this.ribbonButtonMsgReceive);
            this.ribbonPanelMessages.Items.Add(this.ribbonButtonMsgPreview);
            this.ribbonPanelMessages.Items.Add(this.ribbonButtonMsgDelete);
            this.ribbonPanelMessages.Items.Add(this.ribbonButtonMsgCopy);
            this.ribbonPanelMessages.Items.Add(this.ribbonButtonMsgProps);
            resources.ApplyResources(this.ribbonPanelMessages, "ribbonPanelMessages");
            // 
            // ribbonButtonMsgSend
            // 
            this.ribbonButtonMsgSend.Image = global::MSMQExplorer.Resource.MSMQ_mail_export_32;
            this.ribbonButtonMsgSend.SmallImage = global::MSMQExplorer.Resource.MSMQ_mail_export_16;
            resources.ApplyResources(this.ribbonButtonMsgSend, "ribbonButtonMsgSend");
            this.ribbonButtonMsgSend.Click += new System.EventHandler(this.ribbonButtonSend_Click);
            // 
            // ribbonButtonMsgReceive
            // 
            this.ribbonButtonMsgReceive.Image = global::MSMQExplorer.Resource.MSMQ_mail_import_32;
            this.ribbonButtonMsgReceive.SmallImage = global::MSMQExplorer.Resource.MSMQ_mail_import_16;
            resources.ApplyResources(this.ribbonButtonMsgReceive, "ribbonButtonMsgReceive");
            this.ribbonButtonMsgReceive.Click += new System.EventHandler(this.ribbonButtonMsgReceive_Click);
            // 
            // ribbonButtonMsgPreview
            // 
            this.ribbonButtonMsgPreview.Image = global::MSMQExplorer.Resource.MSMQ_mail_search_32;
            this.ribbonButtonMsgPreview.SmallImage = global::MSMQExplorer.Resource.MSMQ_mail_search_16;
            resources.ApplyResources(this.ribbonButtonMsgPreview, "ribbonButtonMsgPreview");
            this.ribbonButtonMsgPreview.Click += new System.EventHandler(this.ribbonButtonMsgPreview_Click);
            // 
            // ribbonButtonMsgDelete
            // 
            this.ribbonButtonMsgDelete.Image = global::MSMQExplorer.Resource.MSMQ_mail_delete2_32;
            this.ribbonButtonMsgDelete.SmallImage = global::MSMQExplorer.Resource.MSMQ_mail_delete2_16;
            resources.ApplyResources(this.ribbonButtonMsgDelete, "ribbonButtonMsgDelete");
            this.ribbonButtonMsgDelete.Click += new System.EventHandler(this.ribbonButtonMsgDelete_Click);
            // 
            // ribbonButtonMsgCopy
            // 
            this.ribbonButtonMsgCopy.Image = global::MSMQExplorer.Resource.MSMQ_mail_edit_32;
            this.ribbonButtonMsgCopy.SmallImage = global::MSMQExplorer.Resource.MSMQ_mail_edit_16;
            resources.ApplyResources(this.ribbonButtonMsgCopy, "ribbonButtonMsgCopy");
            this.ribbonButtonMsgCopy.Click += new System.EventHandler(this.ribbonButtonMsgCopy_Click);
            // 
            // ribbonButtonMsgProps
            // 
            this.ribbonButtonMsgProps.Image = global::MSMQExplorer.Resource.MSMQ_mail_info_32;
            this.ribbonButtonMsgProps.SmallImage = global::MSMQExplorer.Resource.MSMQ_mail_info_16;
            resources.ApplyResources(this.ribbonButtonMsgProps, "ribbonButtonMsgProps");
            this.ribbonButtonMsgProps.Click += new System.EventHandler(this.ribbonButtonMsgProps_Click);
            // 
            // ribbonPanelSearch
            // 
            this.ribbonPanelSearch.ButtonMoreEnabled = false;
            this.ribbonPanelSearch.ButtonMoreVisible = false;
            this.ribbonPanelSearch.Items.Add(this.ribbonButtonFind);
            this.ribbonPanelSearch.Items.Add(this.ribbonButtonIncSearch);
            this.ribbonPanelSearch.Items.Add(this.ribbonButtonReplace);
            resources.ApplyResources(this.ribbonPanelSearch, "ribbonPanelSearch");
            // 
            // ribbonButtonFind
            // 
            this.ribbonButtonFind.Image = global::MSMQExplorer.Resource.MSMQ_find_32;
            this.ribbonButtonFind.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonFind.SmallImage")));
            resources.ApplyResources(this.ribbonButtonFind, "ribbonButtonFind");
            this.ribbonButtonFind.Click += new System.EventHandler(this.ribbonButtonFind_Click);
            // 
            // ribbonButtonIncSearch
            // 
            this.ribbonButtonIncSearch.Image = global::MSMQExplorer.Resource.MSMQ_incfind_32;
            this.ribbonButtonIncSearch.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonIncSearch.SmallImage")));
            resources.ApplyResources(this.ribbonButtonIncSearch, "ribbonButtonIncSearch");
            this.ribbonButtonIncSearch.Click += new System.EventHandler(this.ribbonButtonIncSearch_Click);
            // 
            // ribbonButtonReplace
            // 
            this.ribbonButtonReplace.Image = global::MSMQExplorer.Resource.MSMQ_replace_32;
            this.ribbonButtonReplace.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonReplace.SmallImage")));
            resources.ApplyResources(this.ribbonButtonReplace, "ribbonButtonReplace");
            this.ribbonButtonReplace.Click += new System.EventHandler(this.ribbonButtonReplace_Click);
            // 
            // ribbonPanelHelp
            // 
            this.ribbonPanelHelp.ButtonMoreEnabled = false;
            this.ribbonPanelHelp.ButtonMoreVisible = false;
            this.ribbonPanelHelp.Items.Add(this.ribbonButtonAbout);
            this.ribbonPanelHelp.Items.Add(this.ribbonButtonUpdate);
            this.ribbonPanelHelp.Items.Add(this.ribbonButtonHelp);
            resources.ApplyResources(this.ribbonPanelHelp, "ribbonPanelHelp");
            // 
            // ribbonButtonAbout
            // 
            this.ribbonButtonAbout.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonAbout.Image = global::MSMQExplorer.Resource.MSMQ_info_32;
            this.ribbonButtonAbout.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAbout.SmallImage")));
            resources.ApplyResources(this.ribbonButtonAbout, "ribbonButtonAbout");
            this.ribbonButtonAbout.Click += new System.EventHandler(this.ribbonButtonAbout_Click);
            // 
            // ribbonButtonUpdate
            // 
            this.ribbonButtonUpdate.Image = global::MSMQExplorer.Resource.MSMQ_install_32;
            this.ribbonButtonUpdate.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonUpdate.SmallImage")));
            resources.ApplyResources(this.ribbonButtonUpdate, "ribbonButtonUpdate");
            this.ribbonButtonUpdate.Click += new System.EventHandler(this.ribbonButtonUpdate_Click);
            // 
            // ribbonButtonHelp
            // 
            this.ribbonButtonHelp.Image = global::MSMQExplorer.Resource.MSMQ_help2_32;
            this.ribbonButtonHelp.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonHelp.SmallImage")));
            resources.ApplyResources(this.ribbonButtonHelp, "ribbonButtonHelp");
            this.ribbonButtonHelp.Click += new System.EventHandler(this.ribbonButtonHelp_Click);
            // 
            // ribbonPanelView
            // 
            this.ribbonPanelView.ButtonMoreEnabled = false;
            this.ribbonPanelView.ButtonMoreVisible = false;
            this.ribbonPanelView.Items.Add(this.ribbonButtonStyle);
            this.ribbonPanelView.Items.Add(this.ribbonButtonTheme);
            resources.ApplyResources(this.ribbonPanelView, "ribbonPanelView");
            // 
            // ribbonButtonStyle
            // 
            this.ribbonButtonStyle.DropDownItems.Add(this.ribbonButtonStyle2007);
            this.ribbonButtonStyle.DropDownItems.Add(this.ribbonButtonStyle2010);
            this.ribbonButtonStyle.DropDownItems.Add(this.ribbonButtonStyle2013);
            this.ribbonButtonStyle.DropDownItems.Add(this.ribbonButtonAbout);
            this.ribbonButtonStyle.Image = global::MSMQExplorer.Resource.MSMQ_application_gear_32;
            this.ribbonButtonStyle.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonStyle.SmallImage")));
            this.ribbonButtonStyle.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            resources.ApplyResources(this.ribbonButtonStyle, "ribbonButtonStyle");
            this.ribbonButtonStyle.DropDownItemClicked += new System.Windows.Forms.RibbonButton.RibbonItemEventHandler(this.ribbonButtonStyle_DropDownItemClicked);
            // 
            // ribbonButtonStyle2007
            // 
            this.ribbonButtonStyle2007.CheckedGroup = "StyleGroup";
            this.ribbonButtonStyle2007.CheckOnClick = true;
            this.ribbonButtonStyle2007.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonStyle2007.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonStyle2007.Image")));
            this.ribbonButtonStyle2007.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonStyle2007.SmallImage")));
            resources.ApplyResources(this.ribbonButtonStyle2007, "ribbonButtonStyle2007");
            // 
            // ribbonButtonStyle2010
            // 
            this.ribbonButtonStyle2010.CheckedGroup = "StyleGroup";
            this.ribbonButtonStyle2010.CheckOnClick = true;
            this.ribbonButtonStyle2010.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonStyle2010.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonStyle2010.Image")));
            this.ribbonButtonStyle2010.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonStyle2010.SmallImage")));
            resources.ApplyResources(this.ribbonButtonStyle2010, "ribbonButtonStyle2010");
            // 
            // ribbonButtonStyle2013
            // 
            this.ribbonButtonStyle2013.CheckedGroup = "StyleGroup";
            this.ribbonButtonStyle2013.CheckOnClick = true;
            this.ribbonButtonStyle2013.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonStyle2013.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonStyle2013.Image")));
            this.ribbonButtonStyle2013.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonStyle2013.SmallImage")));
            resources.ApplyResources(this.ribbonButtonStyle2013, "ribbonButtonStyle2013");
            // 
            // ribbonButtonTheme
            // 
            this.ribbonButtonTheme.DropDownItems.Add(this.ribbonButtonNormal);
            this.ribbonButtonTheme.DropDownItems.Add(this.ribbonButtonBlue);
            this.ribbonButtonTheme.DropDownItems.Add(this.ribbonButtonBlack);
            this.ribbonButtonTheme.DropDownItems.Add(this.ribbonButtonGreen);
            this.ribbonButtonTheme.DropDownItems.Add(this.ribbonButtonPurple);
            this.ribbonButtonTheme.DropDownItems.Add(this.ribbonButtonJellyBelly);
            this.ribbonButtonTheme.DropDownItems.Add(this.ribbonButtonHalloween);
            this.ribbonButtonTheme.Image = global::MSMQExplorer.Resource.MSMQ_favorite_32;
            this.ribbonButtonTheme.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonTheme.SmallImage")));
            this.ribbonButtonTheme.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            resources.ApplyResources(this.ribbonButtonTheme, "ribbonButtonTheme");
            this.ribbonButtonTheme.DropDownItemClicked += new System.Windows.Forms.RibbonButton.RibbonItemEventHandler(this.ribbonButtonTheme_DropDownItemClicked);
            // 
            // ribbonButtonNormal
            // 
            this.ribbonButtonNormal.CheckedGroup = "Colours";
            this.ribbonButtonNormal.CheckOnClick = true;
            this.ribbonButtonNormal.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonNormal.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNormal.Image")));
            this.ribbonButtonNormal.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNormal.SmallImage")));
            resources.ApplyResources(this.ribbonButtonNormal, "ribbonButtonNormal");
            // 
            // ribbonButtonBlue
            // 
            this.ribbonButtonBlue.CheckedGroup = "Colours";
            this.ribbonButtonBlue.CheckOnClick = true;
            this.ribbonButtonBlue.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonBlue.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonBlue.Image")));
            this.ribbonButtonBlue.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonBlue.SmallImage")));
            resources.ApplyResources(this.ribbonButtonBlue, "ribbonButtonBlue");
            // 
            // ribbonButtonBlack
            // 
            this.ribbonButtonBlack.CheckedGroup = "Colours";
            this.ribbonButtonBlack.CheckOnClick = true;
            this.ribbonButtonBlack.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonBlack.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonBlack.Image")));
            this.ribbonButtonBlack.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonBlack.SmallImage")));
            resources.ApplyResources(this.ribbonButtonBlack, "ribbonButtonBlack");
            // 
            // ribbonButtonGreen
            // 
            this.ribbonButtonGreen.CheckedGroup = "Colours";
            this.ribbonButtonGreen.CheckOnClick = true;
            this.ribbonButtonGreen.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonGreen.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonGreen.Image")));
            this.ribbonButtonGreen.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonGreen.SmallImage")));
            resources.ApplyResources(this.ribbonButtonGreen, "ribbonButtonGreen");
            // 
            // ribbonButtonPurple
            // 
            this.ribbonButtonPurple.CheckedGroup = "Colours";
            this.ribbonButtonPurple.CheckOnClick = true;
            this.ribbonButtonPurple.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonPurple.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPurple.Image")));
            this.ribbonButtonPurple.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPurple.SmallImage")));
            resources.ApplyResources(this.ribbonButtonPurple, "ribbonButtonPurple");
            // 
            // ribbonButtonJellyBelly
            // 
            this.ribbonButtonJellyBelly.CheckedGroup = "Colours";
            this.ribbonButtonJellyBelly.CheckOnClick = true;
            this.ribbonButtonJellyBelly.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonJellyBelly.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonJellyBelly.Image")));
            this.ribbonButtonJellyBelly.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonJellyBelly.SmallImage")));
            resources.ApplyResources(this.ribbonButtonJellyBelly, "ribbonButtonJellyBelly");
            // 
            // ribbonButtonHalloween
            // 
            this.ribbonButtonHalloween.CheckedGroup = "Colours";
            this.ribbonButtonHalloween.CheckOnClick = true;
            this.ribbonButtonHalloween.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonHalloween.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonHalloween.Image")));
            this.ribbonButtonHalloween.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonHalloween.SmallImage")));
            resources.ApplyResources(this.ribbonButtonHalloween, "ribbonButtonHalloween");
            // 
            // ribbonPanelSettings
            // 
            this.ribbonPanelSettings.Items.Add(this.ribbonButtonSettings);
            resources.ApplyResources(this.ribbonPanelSettings, "ribbonPanelSettings");
            // 
            // ribbonButtonSettings
            // 
            this.ribbonButtonSettings.Image = global::MSMQExplorer.Resource.MSMQ_gear_32;
            this.ribbonButtonSettings.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSettings.SmallImage")));
            resources.ApplyResources(this.ribbonButtonSettings, "ribbonButtonSettings");
            this.ribbonButtonSettings.Click += new System.EventHandler(this.ribbonButtonSettings_Click);
            // 
            // textBoxStatus
            // 
            resources.ApplyResources(this.textBoxStatus, "textBoxStatus");
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            // 
            // labelStatus
            // 
            resources.ApplyResources(this.labelStatus, "labelStatus");
            this.labelStatus.Name = "labelStatus";
            // 
            // formMsmqExplorerBindingSource
            // 
            this.formMsmqExplorerBindingSource.DataSource = typeof(MSMQExplorer.FormMsmqExplorer);
            // 
            // FormMsmqExplorer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.automaticUpdater);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.ribbonMain);
            this.DoubleBuffered = true;
            this.Name = "FormMsmqExplorer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMSMQExplorer_FormClosed);
            this.Load += new System.EventHandler(this.FormMsmqExplorer_Load);
            this.Shown += new System.EventHandler(this.FormMSMQTestHarness_Shown);
            this.splitContainerReceive.Panel1.ResumeLayout(false);
            this.splitContainerReceive.Panel2.ResumeLayout(false);
            this.splitContainerReceive.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerReceive)).EndInit();
            this.splitContainerReceive.ResumeLayout(false);
            this.splitContainerDetail.Panel1.ResumeLayout(false);
            this.splitContainerDetail.Panel1.PerformLayout();
            this.splitContainerDetail.Panel2.ResumeLayout(false);
            this.splitContainerDetail.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDetail)).EndInit();
            this.splitContainerDetail.ResumeLayout(false);
            this.contextMenuStripQueue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListViewMessages)).EndInit();
            this.contextMenuStripMessage.ResumeLayout(false);
            this.tabControlReceiveType.ResumeLayout(false);
            this.tabPageXML.ResumeLayout(false);
            this.tabPageHex.ResumeLayout(false);
            this.tabPageText.ResumeLayout(false);
            this.tabPageText.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageSend.ResumeLayout(false);
            this.splitContainerSend.Panel1.ResumeLayout(false);
            this.splitContainerSend.Panel1.PerformLayout();
            this.splitContainerSend.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSend)).EndInit();
            this.splitContainerSend.ResumeLayout(false);
            this.contextMenuStripSendQueue.ResumeLayout(false);
            this.splitContainerSendMsgDetail.Panel1.ResumeLayout(false);
            this.splitContainerSendMsgDetail.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSendMsgDetail)).EndInit();
            this.splitContainerSendMsgDetail.ResumeLayout(false);
            this.tabControlSendType.ResumeLayout(false);
            this.tabPageSendXML.ResumeLayout(false);
            this.tabPageSendXML.PerformLayout();
            this.tabPageSendHex.ResumeLayout(false);
            this.tabPageSendText.ResumeLayout(false);
            this.tabPageSendText.PerformLayout();
            this.groupBoxMsgProps.ResumeLayout(false);
            this.groupBoxMsgProps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeToReachQueue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeToReceive)).EndInit();
            this.tabPageReceive.ResumeLayout(false);
            this.tabPageLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListViewLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automaticUpdater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formMsmqExplorerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonXSDIn;
        private System.Windows.Forms.Button buttonValidateIn;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageSend;
        private System.Windows.Forms.Label labelValidateOut;
        private System.Windows.Forms.Button buttonXSDOut;
        private System.Windows.Forms.TextBox textBoxXSDOut;
        private System.Windows.Forms.Button buttonValidateOut;
        private System.Windows.Forms.TabPage tabPageReceive;
        private System.Windows.Forms.SplitContainer splitContainerReceive;
        private System.Windows.Forms.TextBox textBoxXSDIn;
        private System.Windows.Forms.SplitContainer splitContainerDetail;
        private System.Windows.Forms.TextBox textBoxMsgLabel;
        private System.Windows.Forms.Label labelMSGLabel;
        private System.Windows.Forms.Button buttonRefreshMessages;
        private System.Windows.Forms.TextBox textBoxSendHost;
        private System.Windows.Forms.Label labelSendHost;
        private System.Windows.Forms.TextBox textBoxRecHost;
        private System.Windows.Forms.ImageList imageListTabs;
        private System.Windows.Forms.TextBox textBoxQueue;
        private System.Windows.Forms.Label labelCurrHost;
        private System.Windows.Forms.Label labelCurrQueue;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonSendConnect;
        private System.Windows.Forms.ToolTip toolTip;
        private wyDay.Controls.AutomaticUpdater automaticUpdater;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripQueue;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMessage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQueuePurge;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMsgDelete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMsgPreview;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMsgCopy;
        private System.Windows.Forms.SplitContainer splitContainerSend;
        private BufferedTreeView bufferedTreeViewSendQueues;
        private System.Windows.Forms.TextBox textBoxSelectedSendQueue;
        private System.Windows.Forms.TextBox textBoxSelectedRecQueue;
        private System.Windows.Forms.ImageList imageListMsmq;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSendQueue;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPurge;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQueueReceive;
        private System.Windows.Forms.CheckBox checkBoxTrans;
        private System.Windows.Forms.CheckBox checkBoxRecTrans;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ComboBox comboBoxTimeReachQueue;
        private System.Windows.Forms.Label labelTimeReachQueue;
        private System.Windows.Forms.ComboBox comboBoxTimeToReceive;
        private System.Windows.Forms.Label labelTimeToReceive;
        private System.Windows.Forms.CheckBox checkBoxUserDeadLetter;
        private System.Windows.Forms.NumericUpDown numericUpDownTimeToReachQueue;
        private System.Windows.Forms.NumericUpDown numericUpDownTimeToReceive;
        private System.Windows.Forms.BindingSource formMsmqExplorerBindingSource;
        private System.Windows.Forms.TabControl tabControlReceiveType;
        private System.Windows.Forms.TabPage tabPageXML;
        private System.Windows.Forms.TabPage tabPageHex;
        private Be.Windows.Forms.HexBox hexBoxRecHex;
        private System.Windows.Forms.TabPage tabPageText;
        private System.Windows.Forms.TextBox textBoxRecText;
        private System.Windows.Forms.TabControl tabControlSendType;
        private System.Windows.Forms.TabPage tabPageSendXML;
        private System.Windows.Forms.TabPage tabPageSendHex;
        private Be.Windows.Forms.HexBox hexBoxSendHex;
        private System.Windows.Forms.TabPage tabPageSendText;
        private System.Windows.Forms.TextBox textBoxSendText;
        private BrightIdeasSoftware.FastObjectListView fastObjectListViewMessages;
        private BrightIdeasSoftware.OLVColumn olvColumnId;
        private BrightIdeasSoftware.OLVColumn olvColumnLabel;
        private BrightIdeasSoftware.OLVColumn olvColumnSentTime;
        private BrightIdeasSoftware.OLVColumn olvColumnMachineName;
        private BrightIdeasSoftware.OLVColumn olvColumnArrivedTime;
        private BrightIdeasSoftware.OLVColumn olvColumnAuthenticated;
        private BrightIdeasSoftware.OLVColumn olvColumnMessageType;
        private BrightIdeasSoftware.OLVColumn olvColumnPriority;
        private BrightIdeasSoftware.OLVColumn olvColumnTransactionId;
        private BrightIdeasSoftware.OLVColumn olvColumnAppSpecific;
        private BrightIdeasSoftware.OLVColumn olvColumnAuthenticationProviderName;
        private BrightIdeasSoftware.OLVColumn olvColumnAuthenticationProviderType;
        private BrightIdeasSoftware.OLVColumn olvColumnCorrelationId;
        private BrightIdeasSoftware.OLVColumn olvColumnDigitalSignature;
        private BrightIdeasSoftware.OLVColumn olvColumnEncryptionAlgorithm;
        private BrightIdeasSoftware.OLVColumn olvColumnHashAlgorithm;
        private BrightIdeasSoftware.OLVColumn olvColumnIsFirstInTransaction;
        private BrightIdeasSoftware.OLVColumn olvColumnIsLastInTransaction;
        private BrightIdeasSoftware.OLVColumn olvColumnLookupId;
        private BrightIdeasSoftware.OLVColumn olvColumnRecoverable;
        private BrightIdeasSoftware.OLVColumn olvColumnSenderId;
        private BrightIdeasSoftware.OLVColumn olvColumnSenderVersion;
        private System.Windows.Forms.TextBox textBoxMsgId;
        private System.Windows.Forms.Label labelMsgId;
        private System.Windows.Forms.Label labelSelectedQueueName;
        private System.Windows.Forms.TextBox textBoxSelectedMsgId;
        private System.Windows.Forms.Label labelSelectedMsgId;
        private BufferedTreeView bufferedTreeViewRecQueues;
        private System.Windows.Forms.Label labelQueue;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Ribbon ribbonMain;
        private System.Windows.Forms.RibbonTab ribbonTabMain;
        private System.Windows.Forms.RibbonPanel ribbonPanelQueue;
        private System.Windows.Forms.RibbonPanel ribbonPanelMessages;
        private System.Windows.Forms.RibbonButton ribbonButtonQueueNew;
        private System.Windows.Forms.RibbonButton ribbonButtonQueueDelete;
        private System.Windows.Forms.RibbonButton ribbonButtonQueuePurge;
        private System.Windows.Forms.RibbonButton ribbonButtonQueueProperties;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItemOpenXML;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItemOpenOther;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItemSaveAsXml;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItemSaveAsOther;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItemExit;
        private System.Windows.Forms.RibbonButton ribbonButtonMsgDelete;
        private System.Windows.Forms.RibbonButton ribbonButtonMsgPreview;
        private System.Windows.Forms.RibbonButton ribbonButtonMsgReceive;
        private System.Windows.Forms.RibbonButton ribbonButtonMsgCopy;
        private System.Windows.Forms.RibbonButton ribbonButtonMsgProps;
        private System.Windows.Forms.RibbonButton ribbonButtonCheckForUpdate;
        private System.Windows.Forms.RibbonPanel ribbonPanelHelp;
        private System.Windows.Forms.RibbonButton ribbonButtonAbout;
        private System.Windows.Forms.RibbonPanel ribbonPanelView;
        private System.Windows.Forms.RibbonButton ribbonButtonStyle;
        private System.Windows.Forms.RibbonButton ribbonButtonStyle2007;
        private System.Windows.Forms.RibbonButton ribbonButtonStyle2010;
        private System.Windows.Forms.RibbonButton ribbonButtonStyle2013;
        private System.Windows.Forms.RibbonButton ribbonButtonMsgSend;
        private System.Windows.Forms.SplitContainer splitContainerSendMsgDetail;
        private System.Windows.Forms.GroupBox groupBoxMsgProps;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.RibbonPanel ribbonPanelEdit;
        private System.Windows.Forms.RibbonButton ribbonButtonPaste;
        private System.Windows.Forms.RibbonButton ribbonButtonCut;
        private System.Windows.Forms.RibbonButton ribbonButtonCopy;
        private System.Windows.Forms.RibbonButton ribbonButtonFormat;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.CheckBox checkBoxUseTracing;
        private System.Windows.Forms.CheckBox checkBoxUseEncryption;
        private System.Windows.Forms.CheckBox checkBoxUserJournal;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQueueProps;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMsgProps;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.RibbonButton ribbonButtonUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSendQueueProps;
        private System.Windows.Forms.RibbonPanel ribbonPanelSearch;
        private System.Windows.Forms.RibbonButton ribbonButtonFind;
        private System.Windows.Forms.RibbonButton ribbonButtonReplace;
        private System.Windows.Forms.RibbonButton ribbonButtonHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNewQueueSend;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteQueueSend;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNewQueueRec;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteQueueRec;
        private System.Windows.Forms.RibbonButton ribbonButtonOpenXML;
        private System.Windows.Forms.RibbonButton ribbonButtonTheme;
        private System.Windows.Forms.RibbonButton ribbonButtonNormal;
        private System.Windows.Forms.RibbonButton ribbonButtonBlue;
        private System.Windows.Forms.RibbonButton ribbonButtonBlack;
        private System.Windows.Forms.RibbonButton ribbonButtonGreen;
        private System.Windows.Forms.RibbonButton ribbonButtonPurple;
        private System.Windows.Forms.RibbonButton ribbonButtonJellyBelly;
        private System.Windows.Forms.RibbonButton ribbonButtonHalloween;
        private System.Windows.Forms.Label labelSendFormat;
        private System.Windows.Forms.ComboBox comboBoxSendFormat;
        private System.Windows.Forms.Label labelRecFormat;
        private System.Windows.Forms.ComboBox comboBoxRecFormat;
        private ScintillaNET.Scintilla scintillaSendXML;
        private ScintillaNET.Scintilla scintillaRecXML;
        private System.Windows.Forms.RibbonPanel ribbonPanelSettings;
        private System.Windows.Forms.RibbonButton ribbonButtonSettings;
        private System.Windows.Forms.RibbonButton ribbonButtonIncSearch;
        private System.Windows.Forms.TabPage tabPageLog;
        private BrightIdeasSoftware.FastObjectListView fastObjectListViewLog;
        private BrightIdeasSoftware.OLVColumn olvColumnTimestamp;
        private BrightIdeasSoftware.OLVColumn olvColumnEventType;
        private BrightIdeasSoftware.OLVColumn olvColumnLogEntry;
    }
}

