Imports InTheHand.Net
Imports InTheHand.Net.Sockets
Imports InTheHand.Net.Bluetooth
Imports InTheHand.Net.Bluetooth.AttributeIds
Imports System.Net.Sockets

Public Class Form1
    Inherits System.Windows.Forms.Form
    Friend WithEvents MenuItemMenuSdp As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemQueryOpp As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemQueryInstalled As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemQueryAllL2cap As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6Sep As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemMenuTestsSdp As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemTestRecordSdp As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemDumpRecordsNameChannel As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemTestRecordOpp As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemTestRssi As System.Windows.Forms.MenuItem
    Friend WithEvents PanelClient As System.Windows.Forms.Panel
    Friend WithEvents PanelSdp As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxDevices As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxUsePin As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxPin As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxEncrypt As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxAuthenticate As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBoxServices As System.Windows.Forms.ComboBox
    Private WithEvents comboBoxEncoding As System.Windows.Forms.ComboBox
    Private WithEvents labelState As System.Windows.Forms.Label
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents textBoxSend As System.Windows.Forms.TextBox
    Private WithEvents textBoxReceive As System.Windows.Forms.TextBox
    Friend WithEvents MenuItemAopcBug As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemTestDiscoveryUi As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemQuit As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemMenuSetService As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSetSvcT As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSetSvcF As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3Sep As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemAddTestDevices As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemMenuTestsOther As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemDumpRawRecords As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemRadioInfo As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSdpSaveText As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemNewBtCli As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemBtCliDiscover As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7Sep As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSdpCopy As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemDiscoverAll As System.Windows.Forms.MenuItem
    Private WithEvents MenuItemDiscoverNewOnly As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSeMmv100 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSecurityRemoveDevice As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSecurityPairRequest As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1Sepa As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemMenuSecurity As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemQuerySelectedClass As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSetRadioName As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemDiscoverAuthenticatedOnly As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemDiscoverRememberedOnly As System.Windows.Forms.MenuItem
    Friend WithEvents PanelServer As System.Windows.Forms.Panel
    Private WithEvents TextBoxServerReceive As System.Windows.Forms.TextBox
    Private WithEvents LabelServerState As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents TextBoxServerSend As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxServerUsePin As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxServerPin As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxServerEncrypt As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxServerAuthenticate As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBoxServerServices As System.Windows.Forms.ComboBox
    Private WithEvents ComboBoxServerEncoding As System.Windows.Forms.ComboBox
    Friend WithEvents MenuItemMenuServer As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemServerListen As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemServerDisconnect As System.Windows.Forms.MenuItem
    Friend WithEvents CheckBoxServerLoopback As System.Windows.Forms.CheckBox
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemClientConnect As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemClientDisconnect As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemMenuDiscover As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemDiscoverDiscoverableOnly As System.Windows.Forms.MenuItem
    Private WithEvents MenuItem4Sep As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemMenuLocal As System.Windows.Forms.MenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelDiscoveringState As System.Windows.Forms.Label
    Friend WithEvents MenuItemMenuView As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemViewSdp As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemViewClient As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemViewServer As System.Windows.Forms.MenuItem
    Friend WithEvents LabelTabSdp As System.Windows.Forms.Label
    Friend WithEvents LabelTabClient As System.Windows.Forms.Label
    Friend WithEvents LabelTabServer As System.Windows.Forms.Label
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemDiscoverDumpsRssi As System.Windows.Forms.MenuItem
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        MyBase.Dispose(disposing)
    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.MenuItemSetRadioName = New System.Windows.Forms.MenuItem
        Me.MenuItemDumpRawRecords = New System.Windows.Forms.MenuItem
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItemMenuView = New System.Windows.Forms.MenuItem
        Me.MenuItemViewSdp = New System.Windows.Forms.MenuItem
        Me.MenuItemViewClient = New System.Windows.Forms.MenuItem
        Me.MenuItemViewServer = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItemMenuDiscover = New System.Windows.Forms.MenuItem
        Me.MenuItemDiscoverRememberedOnly = New System.Windows.Forms.MenuItem
        Me.MenuItemDiscoverAuthenticatedOnly = New System.Windows.Forms.MenuItem
        Me.MenuItemDiscoverAll = New System.Windows.Forms.MenuItem
        Me.MenuItemDiscoverNewOnly = New System.Windows.Forms.MenuItem
        Me.MenuItemDiscoverDiscoverableOnly = New System.Windows.Forms.MenuItem
        Me.MenuItemMenuSdp = New System.Windows.Forms.MenuItem
        Me.MenuItemQueryOpp = New System.Windows.Forms.MenuItem
        Me.MenuItemQueryInstalled = New System.Windows.Forms.MenuItem
        Me.MenuItemQueryAllL2cap = New System.Windows.Forms.MenuItem
        Me.MenuItemQuerySelectedClass = New System.Windows.Forms.MenuItem
        Me.MenuItem6Sep = New System.Windows.Forms.MenuItem
        Me.MenuItemDumpRecordsNameChannel = New System.Windows.Forms.MenuItem
        Me.MenuItem7Sep = New System.Windows.Forms.MenuItem
        Me.MenuItemMenuTestsSdp = New System.Windows.Forms.MenuItem
        Me.MenuItemTestRecordSdp = New System.Windows.Forms.MenuItem
        Me.MenuItemTestRecordOpp = New System.Windows.Forms.MenuItem
        Me.MenuItemSeMmv100 = New System.Windows.Forms.MenuItem
        Me.MenuItem4Sep = New System.Windows.Forms.MenuItem
        Me.MenuItemSdpSaveText = New System.Windows.Forms.MenuItem
        Me.MenuItemSdpCopy = New System.Windows.Forms.MenuItem
        Me.MenuItemMenuLocal = New System.Windows.Forms.MenuItem
        Me.MenuItemRadioInfo = New System.Windows.Forms.MenuItem
        Me.MenuItemMenuSetService = New System.Windows.Forms.MenuItem
        Me.MenuItemSetSvcT = New System.Windows.Forms.MenuItem
        Me.MenuItemSetSvcF = New System.Windows.Forms.MenuItem
        Me.MenuItemMenuSecurity = New System.Windows.Forms.MenuItem
        Me.MenuItemSecurityPairRequest = New System.Windows.Forms.MenuItem
        Me.MenuItemSecurityRemoveDevice = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItemClientConnect = New System.Windows.Forms.MenuItem
        Me.MenuItemClientDisconnect = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItemMenuServer = New System.Windows.Forms.MenuItem
        Me.MenuItemServerListen = New System.Windows.Forms.MenuItem
        Me.MenuItemServerDisconnect = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItemMenuTestsOther = New System.Windows.Forms.MenuItem
        Me.MenuItemTestRssi = New System.Windows.Forms.MenuItem
        Me.MenuItemTestDiscoveryUi = New System.Windows.Forms.MenuItem
        Me.MenuItemAddTestDevices = New System.Windows.Forms.MenuItem
        Me.MenuItem3Sep = New System.Windows.Forms.MenuItem
        Me.MenuItemAopcBug = New System.Windows.Forms.MenuItem
        Me.MenuItemNewBtCli = New System.Windows.Forms.MenuItem
        Me.MenuItemBtCliDiscover = New System.Windows.Forms.MenuItem
        Me.MenuItem1Sepa = New System.Windows.Forms.MenuItem
        Me.MenuItemQuit = New System.Windows.Forms.MenuItem
        Me.LabelTabSdp = New System.Windows.Forms.Label
        Me.PanelSdp = New System.Windows.Forms.Panel
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.PanelClient = New System.Windows.Forms.Panel
        Me.ComboBoxServices = New System.Windows.Forms.ComboBox
        Me.CheckBoxAuthenticate = New System.Windows.Forms.CheckBox
        Me.CheckBoxEncrypt = New System.Windows.Forms.CheckBox
        Me.CheckBoxUsePin = New System.Windows.Forms.CheckBox
        Me.TextBoxPin = New System.Windows.Forms.TextBox
        Me.comboBoxEncoding = New System.Windows.Forms.ComboBox
        Me.textBoxSend = New System.Windows.Forms.TextBox
        Me.textBoxReceive = New System.Windows.Forms.TextBox
        Me.LabelTabClient = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.labelState = New System.Windows.Forms.Label
        Me.label8 = New System.Windows.Forms.Label
        Me.PanelServer = New System.Windows.Forms.Panel
        Me.LabelTabServer = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBoxServerServices = New System.Windows.Forms.ComboBox
        Me.CheckBoxServerAuthenticate = New System.Windows.Forms.CheckBox
        Me.CheckBoxServerEncrypt = New System.Windows.Forms.CheckBox
        Me.CheckBoxServerUsePin = New System.Windows.Forms.CheckBox
        Me.TextBoxServerPin = New System.Windows.Forms.TextBox
        Me.ComboBoxServerEncoding = New System.Windows.Forms.ComboBox
        Me.CheckBoxServerLoopback = New System.Windows.Forms.CheckBox
        Me.TextBoxServerSend = New System.Windows.Forms.TextBox
        Me.TextBoxServerReceive = New System.Windows.Forms.TextBox
        Me.LabelServerState = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBoxDevices = New System.Windows.Forms.ComboBox
        Me.LabelDiscoveringState = New System.Windows.Forms.Label
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItemDiscoverDumpsRssi = New System.Windows.Forms.MenuItem
        '
        'MenuItemSetRadioName
        '
        Me.MenuItemSetRadioName.Text = "Set Radio Name"
        '
        'MenuItemDumpRawRecords
        '
        Me.MenuItemDumpRawRecords.Text = "Byte Array of last records"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.Add(Me.MenuItemMenuView)
        Me.MainMenu1.MenuItems.Add(Me.MenuItem14)
        '
        'MenuItemMenuView
        '
        Me.MenuItemMenuView.MenuItems.Add(Me.MenuItemViewSdp)
        Me.MenuItemMenuView.MenuItems.Add(Me.MenuItemViewClient)
        Me.MenuItemMenuView.MenuItems.Add(Me.MenuItemViewServer)
        Me.MenuItemMenuView.Text = "View"
        '
        'MenuItemViewSdp
        '
        Me.MenuItemViewSdp.Text = "SDP"
        '
        'MenuItemViewClient
        '
        Me.MenuItemViewClient.Text = "Client"
        '
        'MenuItemViewServer
        '
        Me.MenuItemViewServer.Text = "Server"
        '
        'MenuItem14
        '
        Me.MenuItem14.MenuItems.Add(Me.MenuItemMenuDiscover)
        Me.MenuItem14.MenuItems.Add(Me.MenuItemMenuSdp)
        Me.MenuItem14.MenuItems.Add(Me.MenuItemMenuLocal)
        Me.MenuItem14.MenuItems.Add(Me.MenuItemMenuSecurity)
        Me.MenuItem14.MenuItems.Add(Me.MenuItem3)
        Me.MenuItem14.MenuItems.Add(Me.MenuItemMenuServer)
        Me.MenuItem14.MenuItems.Add(Me.MenuItemMenuTestsOther)
        Me.MenuItem14.MenuItems.Add(Me.MenuItemQuit)
        Me.MenuItem14.Text = "Menu"
        '
        'MenuItemMenuDiscover
        '
        Me.MenuItemMenuDiscover.MenuItems.Add(Me.MenuItemDiscoverRememberedOnly)
        Me.MenuItemMenuDiscover.MenuItems.Add(Me.MenuItemDiscoverAuthenticatedOnly)
        Me.MenuItemMenuDiscover.MenuItems.Add(Me.MenuItemDiscoverAll)
        Me.MenuItemMenuDiscover.MenuItems.Add(Me.MenuItemDiscoverNewOnly)
        Me.MenuItemMenuDiscover.MenuItems.Add(Me.MenuItemDiscoverDiscoverableOnly)
        Me.MenuItemMenuDiscover.MenuItems.Add(Me.MenuItem1)
        Me.MenuItemMenuDiscover.MenuItems.Add(Me.MenuItemDiscoverDumpsRssi)
        Me.MenuItemMenuDiscover.Text = "Discover"
        '
        'MenuItemDiscoverRememberedOnly
        '
        Me.MenuItemDiscoverRememberedOnly.Text = "&Remembered only"
        '
        'MenuItemDiscoverAuthenticatedOnly
        '
        Me.MenuItemDiscoverAuthenticatedOnly.Text = "&Authenticated only"
        '
        'MenuItemDiscoverAll
        '
        Me.MenuItemDiscoverAll.Text = "Discover &All"
        '
        'MenuItemDiscoverNewOnly
        '
        Me.MenuItemDiscoverNewOnly.Text = "&New only"
        '
        'MenuItemDiscoverDiscoverableOnly
        '
        Me.MenuItemDiscoverDiscoverableOnly.Text = "&Discoverable Only"
        '
        'MenuItemMenuSdp
        '
        Me.MenuItemMenuSdp.MenuItems.Add(Me.MenuItemQueryOpp)
        Me.MenuItemMenuSdp.MenuItems.Add(Me.MenuItemQueryInstalled)
        Me.MenuItemMenuSdp.MenuItems.Add(Me.MenuItemQueryAllL2cap)
        Me.MenuItemMenuSdp.MenuItems.Add(Me.MenuItemQuerySelectedClass)
        Me.MenuItemMenuSdp.MenuItems.Add(Me.MenuItem6Sep)
        Me.MenuItemMenuSdp.MenuItems.Add(Me.MenuItemDumpRawRecords)
        Me.MenuItemMenuSdp.MenuItems.Add(Me.MenuItemDumpRecordsNameChannel)
        Me.MenuItemMenuSdp.MenuItems.Add(Me.MenuItem7Sep)
        Me.MenuItemMenuSdp.MenuItems.Add(Me.MenuItemMenuTestsSdp)
        Me.MenuItemMenuSdp.MenuItems.Add(Me.MenuItem4Sep)
        Me.MenuItemMenuSdp.MenuItems.Add(Me.MenuItemSdpSaveText)
        Me.MenuItemMenuSdp.MenuItems.Add(Me.MenuItemSdpCopy)
        Me.MenuItemMenuSdp.Text = "SDP"
        '
        'MenuItemQueryOpp
        '
        Me.MenuItemQueryOpp.Text = "OPP record"
        '
        'MenuItemQueryInstalled
        '
        Me.MenuItemQueryInstalled.Text = "InstalledServices"
        '
        'MenuItemQueryAllL2cap
        '
        Me.MenuItemQueryAllL2cap.Text = "All Services (over L2CAP)"
        '
        'MenuItemQuerySelectedClass
        '
        Me.MenuItemQuerySelectedClass.Text = "Selected Service Class"
        '
        'MenuItem6Sep
        '
        Me.MenuItem6Sep.Text = "-"
        '
        'MenuItemDumpRecordsNameChannel
        '
        Me.MenuItemDumpRecordsNameChannel.Text = "Name and Channel of last records"
        '
        'MenuItem7Sep
        '
        Me.MenuItem7Sep.Text = "-"
        '
        'MenuItemMenuTestsSdp
        '
        Me.MenuItemMenuTestsSdp.MenuItems.Add(Me.MenuItemTestRecordSdp)
        Me.MenuItemMenuTestsSdp.MenuItems.Add(Me.MenuItemTestRecordOpp)
        Me.MenuItemMenuTestsSdp.MenuItems.Add(Me.MenuItemSeMmv100)
        Me.MenuItemMenuTestsSdp.Text = "Tests SDP"
        '
        'MenuItemTestRecordSdp
        '
        Me.MenuItemTestRecordSdp.Text = "XP Sdp"
        '
        'MenuItemTestRecordOpp
        '
        Me.MenuItemTestRecordOpp.Text = "XP Opp"
        '
        'MenuItemSeMmv100
        '
        Me.MenuItemSeMmv100.Text = "MMV Bip etc"
        '
        'MenuItem4Sep
        '
        Me.MenuItem4Sep.Text = "-"
        '
        'MenuItemSdpSaveText
        '
        Me.MenuItemSdpSaveText.Text = "Save..."
        '
        'MenuItemSdpCopy
        '
        Me.MenuItemSdpCopy.Text = "Copy"
        '
        'MenuItemMenuLocal
        '
        Me.MenuItemMenuLocal.MenuItems.Add(Me.MenuItemRadioInfo)
        Me.MenuItemMenuLocal.MenuItems.Add(Me.MenuItemMenuSetService)
        Me.MenuItemMenuLocal.Text = "Local"
        '
        'MenuItemRadioInfo
        '
        Me.MenuItemRadioInfo.Text = "Radio info"
        '
        'MenuItemMenuSetService
        '
        Me.MenuItemMenuSetService.MenuItems.Add(Me.MenuItemSetSvcT)
        Me.MenuItemMenuSetService.MenuItems.Add(Me.MenuItemSetSvcF)
        Me.MenuItemMenuSetService.Text = "SetService"
        '
        'MenuItemSetSvcT
        '
        Me.MenuItemSetSvcT.Text = "Enable"
        '
        'MenuItemSetSvcF
        '
        Me.MenuItemSetSvcF.Text = "Disable"
        '
        'MenuItemMenuSecurity
        '
        Me.MenuItemMenuSecurity.MenuItems.Add(Me.MenuItemSecurityPairRequest)
        Me.MenuItemMenuSecurity.MenuItems.Add(Me.MenuItemSecurityRemoveDevice)
        Me.MenuItemMenuSecurity.Text = "Security"
        '
        'MenuItemSecurityPairRequest
        '
        Me.MenuItemSecurityPairRequest.Text = "Pair Request"
        '
        'MenuItemSecurityRemoveDevice
        '
        Me.MenuItemSecurityRemoveDevice.Text = "Remove Device"
        '
        'MenuItem3
        '
        Me.MenuItem3.MenuItems.Add(Me.MenuItemClientConnect)
        Me.MenuItem3.MenuItems.Add(Me.MenuItemClientDisconnect)
        Me.MenuItem3.MenuItems.Add(Me.MenuItem6)
        Me.MenuItem3.Text = "Client"
        '
        'MenuItemClientConnect
        '
        Me.MenuItemClientConnect.Text = "Connect"
        '
        'MenuItemClientDisconnect
        '
        Me.MenuItemClientDisconnect.Text = "Disconnect"
        '
        'MenuItem6
        '
        Me.MenuItem6.Text = "Send"
        '
        'MenuItemMenuServer
        '
        Me.MenuItemMenuServer.MenuItems.Add(Me.MenuItemServerListen)
        Me.MenuItemMenuServer.MenuItems.Add(Me.MenuItemServerDisconnect)
        Me.MenuItemMenuServer.MenuItems.Add(Me.MenuItem2)
        Me.MenuItemMenuServer.Text = "Server"
        '
        'MenuItemServerListen
        '
        Me.MenuItemServerListen.Text = "Listen"
        '
        'MenuItemServerDisconnect
        '
        Me.MenuItemServerDisconnect.Text = "Disconnect"
        '
        'MenuItem2
        '
        Me.MenuItem2.Text = "Send"
        '
        'MenuItemMenuTestsOther
        '
        Me.MenuItemMenuTestsOther.MenuItems.Add(Me.MenuItemTestRssi)
        Me.MenuItemMenuTestsOther.MenuItems.Add(Me.MenuItemTestDiscoveryUi)
        Me.MenuItemMenuTestsOther.MenuItems.Add(Me.MenuItemAddTestDevices)
        Me.MenuItemMenuTestsOther.MenuItems.Add(Me.MenuItem3Sep)
        Me.MenuItemMenuTestsOther.MenuItems.Add(Me.MenuItemAopcBug)
        Me.MenuItemMenuTestsOther.MenuItems.Add(Me.MenuItemNewBtCli)
        Me.MenuItemMenuTestsOther.MenuItems.Add(Me.MenuItemBtCliDiscover)
        Me.MenuItemMenuTestsOther.MenuItems.Add(Me.MenuItem1Sepa)
        Me.MenuItemMenuTestsOther.MenuItems.Add(Me.MenuItemSetRadioName)
        Me.MenuItemMenuTestsOther.Text = "Tests other"
        '
        'MenuItemTestRssi
        '
        Me.MenuItemTestRssi.Enabled = False
        Me.MenuItemTestRssi.Text = "Repro Rssi errors"
        '
        'MenuItemTestDiscoveryUi
        '
        Me.MenuItemTestDiscoveryUi.Text = "SelectDialog"
        '
        'MenuItemAddTestDevices
        '
        Me.MenuItemAddTestDevices.Text = "Add dummy devices"
        '
        'MenuItem3Sep
        '
        Me.MenuItem3Sep.Text = "-"
        '
        'MenuItemAopcBug
        '
        Me.MenuItemAopcBug.Text = "AoPC bug"
        '
        'MenuItemNewBtCli
        '
        Me.MenuItemNewBtCli.Text = "new BtCli"
        '
        'MenuItemBtCliDiscover
        '
        Me.MenuItemBtCliDiscover.Text = "BtCli.Discover"
        '
        'MenuItem1Sepa
        '
        Me.MenuItem1Sepa.Text = "-"
        '
        'MenuItemQuit
        '
        Me.MenuItemQuit.Text = "Exit"
        '
        'LabelTabSdp
        '
        Me.LabelTabSdp.BackColor = System.Drawing.SystemColors.Control
        Me.LabelTabSdp.Location = New System.Drawing.Point(0, 217)
        Me.LabelTabSdp.Size = New System.Drawing.Size(50, 20)
        Me.LabelTabSdp.Text = "SDP"
        '
        'PanelSdp
        '
        Me.PanelSdp.Controls.Add(Me.TextBox1)
        Me.PanelSdp.Controls.Add(Me.LabelTabSdp)
        Me.PanelSdp.Location = New System.Drawing.Point(0, 0)
        Me.PanelSdp.Size = New System.Drawing.Size(240, 237)
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.TextBox1.Multiline = True
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(233, 211)
        Me.TextBox1.Text = "TextBox1"
        '
        'PanelClient
        '
        Me.PanelClient.Controls.Add(Me.ComboBoxServices)
        Me.PanelClient.Controls.Add(Me.CheckBoxAuthenticate)
        Me.PanelClient.Controls.Add(Me.CheckBoxEncrypt)
        Me.PanelClient.Controls.Add(Me.CheckBoxUsePin)
        Me.PanelClient.Controls.Add(Me.TextBoxPin)
        Me.PanelClient.Controls.Add(Me.comboBoxEncoding)
        Me.PanelClient.Controls.Add(Me.textBoxSend)
        Me.PanelClient.Controls.Add(Me.textBoxReceive)
        Me.PanelClient.Controls.Add(Me.LabelTabClient)
        Me.PanelClient.Controls.Add(Me.Label3)
        Me.PanelClient.Controls.Add(Me.labelState)
        Me.PanelClient.Controls.Add(Me.label8)
        Me.PanelClient.Location = New System.Drawing.Point(20, 20)
        Me.PanelClient.Size = New System.Drawing.Size(240, 237)
        '
        'ComboBoxServices
        '
        Me.ComboBoxServices.Location = New System.Drawing.Point(3, 3)
        Me.ComboBoxServices.Size = New System.Drawing.Size(226, 22)
        '
        'CheckBoxAuthenticate
        '
        Me.CheckBoxAuthenticate.Location = New System.Drawing.Point(3, 31)
        Me.CheckBoxAuthenticate.Size = New System.Drawing.Size(55, 17)
        Me.CheckBoxAuthenticate.Text = "&Authenticate"
        '
        'CheckBoxEncrypt
        '
        Me.CheckBoxEncrypt.Location = New System.Drawing.Point(64, 31)
        Me.CheckBoxEncrypt.Size = New System.Drawing.Size(62, 17)
        Me.CheckBoxEncrypt.Text = "&Encrypt"
        '
        'CheckBoxUsePin
        '
        Me.CheckBoxUsePin.Location = New System.Drawing.Point(132, 31)
        Me.CheckBoxUsePin.Size = New System.Drawing.Size(45, 17)
        Me.CheckBoxUsePin.Text = "&Pin"
        '
        'TextBoxPin
        '
        Me.TextBoxPin.Enabled = False
        Me.TextBoxPin.Location = New System.Drawing.Point(183, 27)
        Me.TextBoxPin.Size = New System.Drawing.Size(46, 21)
        '
        'comboBoxEncoding
        '
        Me.comboBoxEncoding.Items.Add("x-IA5")
        Me.comboBoxEncoding.Items.Add("iso-8859-1")
        Me.comboBoxEncoding.Items.Add("utf-8")
        Me.comboBoxEncoding.Items.Add("ASCII")
        Me.comboBoxEncoding.Location = New System.Drawing.Point(3, 54)
        Me.comboBoxEncoding.Size = New System.Drawing.Size(83, 22)
        '
        'textBoxSend
        '
        Me.textBoxSend.Location = New System.Drawing.Point(3, 98)
        Me.textBoxSend.Multiline = True
        Me.textBoxSend.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textBoxSend.Size = New System.Drawing.Size(174, 23)
        '
        'textBoxReceive
        '
        Me.textBoxReceive.Location = New System.Drawing.Point(3, 127)
        Me.textBoxReceive.Multiline = True
        Me.textBoxReceive.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textBoxReceive.Size = New System.Drawing.Size(226, 83)
        '
        'LabelTabClient
        '
        Me.LabelTabClient.BackColor = System.Drawing.SystemColors.Control
        Me.LabelTabClient.Location = New System.Drawing.Point(0, 217)
        Me.LabelTabClient.Size = New System.Drawing.Size(50, 20)
        Me.LabelTabClient.Text = "Client"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(183, 101)
        Me.Label3.Size = New System.Drawing.Size(46, 20)
        Me.Label3.Text = ": Send"
        '
        'labelState
        '
        Me.labelState.Location = New System.Drawing.Point(48, 82)
        Me.labelState.Size = New System.Drawing.Size(172, 13)
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(3, 82)
        Me.label8.Size = New System.Drawing.Size(39, 13)
        Me.label8.Text = "State:"
        '
        'PanelServer
        '
        Me.PanelServer.Controls.Add(Me.LabelTabServer)
        Me.PanelServer.Controls.Add(Me.Label1)
        Me.PanelServer.Controls.Add(Me.ComboBoxServerServices)
        Me.PanelServer.Controls.Add(Me.CheckBoxServerAuthenticate)
        Me.PanelServer.Controls.Add(Me.CheckBoxServerEncrypt)
        Me.PanelServer.Controls.Add(Me.CheckBoxServerUsePin)
        Me.PanelServer.Controls.Add(Me.TextBoxServerPin)
        Me.PanelServer.Controls.Add(Me.ComboBoxServerEncoding)
        Me.PanelServer.Controls.Add(Me.CheckBoxServerLoopback)
        Me.PanelServer.Controls.Add(Me.TextBoxServerSend)
        Me.PanelServer.Controls.Add(Me.TextBoxServerReceive)
        Me.PanelServer.Controls.Add(Me.LabelServerState)
        Me.PanelServer.Controls.Add(Me.Label2)
        Me.PanelServer.Location = New System.Drawing.Point(40, 40)
        Me.PanelServer.Size = New System.Drawing.Size(240, 237)
        '
        'LabelTabServer
        '
        Me.LabelTabServer.BackColor = System.Drawing.SystemColors.Control
        Me.LabelTabServer.Location = New System.Drawing.Point(0, 217)
        Me.LabelTabServer.Size = New System.Drawing.Size(50, 20)
        Me.LabelTabServer.Text = "Server"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(185, 101)
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.Text = ": Send"
        '
        'ComboBoxServerServices
        '
        Me.ComboBoxServerServices.Location = New System.Drawing.Point(5, 4)
        Me.ComboBoxServerServices.Size = New System.Drawing.Size(226, 22)
        '
        'CheckBoxServerAuthenticate
        '
        Me.CheckBoxServerAuthenticate.Location = New System.Drawing.Point(5, 32)
        Me.CheckBoxServerAuthenticate.Size = New System.Drawing.Size(55, 17)
        Me.CheckBoxServerAuthenticate.Text = "&Authenticate"
        '
        'CheckBoxServerEncrypt
        '
        Me.CheckBoxServerEncrypt.Location = New System.Drawing.Point(66, 32)
        Me.CheckBoxServerEncrypt.Size = New System.Drawing.Size(62, 17)
        Me.CheckBoxServerEncrypt.Text = "&Encrypt"
        '
        'CheckBoxServerUsePin
        '
        Me.CheckBoxServerUsePin.Location = New System.Drawing.Point(134, 32)
        Me.CheckBoxServerUsePin.Size = New System.Drawing.Size(45, 17)
        Me.CheckBoxServerUsePin.Text = "&Pin"
        '
        'TextBoxServerPin
        '
        Me.TextBoxServerPin.AcceptsReturn = True
        Me.TextBoxServerPin.Enabled = False
        Me.TextBoxServerPin.Location = New System.Drawing.Point(185, 28)
        Me.TextBoxServerPin.Size = New System.Drawing.Size(46, 21)
        '
        'ComboBoxServerEncoding
        '
        Me.ComboBoxServerEncoding.Items.Add("x-IA5")
        Me.ComboBoxServerEncoding.Items.Add("iso-8859-1")
        Me.ComboBoxServerEncoding.Items.Add("utf-8")
        Me.ComboBoxServerEncoding.Items.Add("ASCII")
        Me.ComboBoxServerEncoding.Location = New System.Drawing.Point(5, 55)
        Me.ComboBoxServerEncoding.Size = New System.Drawing.Size(83, 22)
        '
        'CheckBoxServerLoopback
        '
        Me.CheckBoxServerLoopback.Location = New System.Drawing.Point(131, 57)
        Me.CheckBoxServerLoopback.Size = New System.Drawing.Size(100, 20)
        Me.CheckBoxServerLoopback.Text = "Loopback"
        '
        'TextBoxServerSend
        '
        Me.TextBoxServerSend.Location = New System.Drawing.Point(5, 99)
        Me.TextBoxServerSend.Multiline = True
        Me.TextBoxServerSend.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxServerSend.Size = New System.Drawing.Size(174, 23)
        '
        'TextBoxServerReceive
        '
        Me.TextBoxServerReceive.AcceptsReturn = True
        Me.TextBoxServerReceive.Location = New System.Drawing.Point(5, 128)
        Me.TextBoxServerReceive.Multiline = True
        Me.TextBoxServerReceive.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxServerReceive.Size = New System.Drawing.Size(226, 83)
        '
        'LabelServerState
        '
        Me.LabelServerState.Location = New System.Drawing.Point(50, 83)
        Me.LabelServerState.Size = New System.Drawing.Size(172, 13)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 83)
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.Text = "State:"
        '
        'ComboBoxDevices
        '
        Me.ComboBoxDevices.Location = New System.Drawing.Point(82, 243)
        Me.ComboBoxDevices.Size = New System.Drawing.Size(155, 22)
        '
        'LabelDiscoveringState
        '
        Me.LabelDiscoveringState.Location = New System.Drawing.Point(0, 245)
        Me.LabelDiscoveringState.Size = New System.Drawing.Size(76, 20)
        '
        'MenuItem1
        '
        Me.MenuItem1.Text = "-"
        '
        'MenuItemDiscoverDumpsRssi
        '
        Me.MenuItemDiscoverDumpsRssi.Text = "Include RSSI lookup"
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.PanelServer)
        Me.Controls.Add(Me.PanelClient)
        Me.Controls.Add(Me.PanelSdp)
        Me.Controls.Add(Me.LabelDiscoveringState)
        Me.Controls.Add(Me.ComboBoxDevices)
        Me.Menu = Me.MainMenu1
        Me.Text = "SdpBrowser"

    End Sub

#End Region

    '===================================================================
    Const NewLine As String = vbCrLf

#If FX1_1 Then
    ReadOnly Property InvokeRequired() As Boolean
        Get
            Return True
        End Get
    End Property
#End If

    Function MessageBox_Show(ByVal owner As Form, ByVal text As String, ByVal caption As String, _
    ByVal buttons As MessageBoxButtons, ByVal icon As MessageBoxIcon, ByVal defaultButton As MessageBoxDefaultButton) _
    As System.Windows.Forms.DialogResult
        Return MessageBox.Show(text, caption, buttons, icon, defaultButton)
    End Function

    Sub MessageBox_Show(ByVal owner As Form, ByVal text As String, ByVal caption As String)
        MessageBox.Show(text, caption)
    End Sub

    Sub MessageBox_Show(ByVal owner As Form, ByVal text As String)
        MessageBox.Show(text)
    End Sub


    Function TryCast_SocketException(ByVal obj As Object) As SocketException
        Try
            Dim sex As SocketException = DirectCast(obj, SocketException)
            Return sex
        Catch ex As InvalidCastException
            Return Nothing
        End Try
    End Function

    '===================================================================
    Private m_noBluetooth As Boolean
    Private m_devices() As BluetoothDeviceInfo
    Private m_startTime, m_endTime As DateTime
    Private m_skipGetSvcRcdsUnparsed As Boolean
    Private m_lastRecords()() As Byte
    Private m_lastRecordsParsed() As ServiceRecord
    Private m_lastRecordsParseError() As String
    Private m_lock As New Object 'To apply 'volatile' access to the m_devices shared field.
    Private m_saveDlg As SaveFileDialog
    Private _notSaveDlg As Boolean

    '--------------------
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
#If DEBUG Then
        Me.MenuItemTestRssi.Enabled = True
#End If
#If FX1_1 Then
        Me.Text += " CF1"
#Else
        Me.Text += " CF2"
#End If
        ' Fill the list of devices with on the local device (fake from radio info)
        Dim devices() As BluetoothDeviceInfo = {} ' Want a zero length array
        FillDevicesFill(devices)
        '----
        Form1Connect_Load(sender, e)
        Form1Server_Load(sender, e)
        '
        Me.PanelSdp.Location = New Point(0, 0)
        Me.PanelClient.Location = New Point(0, 0)
        Me.PanelServer.Location = New Point(0, 0)
        SetView(ViewMode.Sdp)
    End Sub

    Private Sub Form1_Closing(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Form1Connect_FormClosing()
    End Sub

    Private Sub MenuItemQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemQuit.Click
        Dim rslt As DialogResult = MessageBox_Show(Me, "Confirm quit?", "Confirm quit?", _
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If rslt = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    '===========================================================================
    Private Sub MenuItemAopcBug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemAopcBug.Click
        Dim t As Type = GetType(BluetoothClient).Assembly.GetType("InTheHand.Net.GCHandleHelper")
        Dim fi As System.Reflection.FieldInfo = t.GetField("v1", _
            Reflection.BindingFlags.GetField Or Reflection.BindingFlags.Static Or Reflection.BindingFlags.NonPublic)
        If fi Is Nothing Then
            MessageBox_Show(Me, "N/A — not using CF1 library.")
            Return
        End If
        Dim x As Object = fi.GetValue(Nothing)
        Dim broken As Boolean = CBool(x)
        'Dim broken As Boolean = GCHandleUtilities.TestIfBrokenAddrOfPinnedObject()
        MessageBox_Show(Me, "bug=" + broken.ToString())
    End Sub

    Private Sub MenuItemNewBtCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemNewBtCli.Click
        Try
            Dim foo As New BluetoothClient
        Catch sex As SocketException
            MessageBox_Show(Me, sex.NativeErrorCode & " / " & sex.Message, "New BluetoothClient")
        End Try
    End Sub

    Private Sub MenuItemBtCliDiscover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemBtCliDiscover.Click
        Dim cli As BluetoothClient
        Try
            cli = New BluetoothClient
        Catch sex As SocketException
            MessageBox_Show(Me, sex.NativeErrorCode & " / " & sex.Message, "New BluetoothClient")
            Return
        End Try
        Try
            Dim arr() As BluetoothDeviceInfo = cli.DiscoverDevices()
            MessageBox_Show(Me, "Discovered " & arr.Length.ToString() & " devices.")
        Catch sex As SocketException
            MessageBox_Show(Me, sex.NativeErrorCode & " / " & sex.Message, "New BluetoothClient")
        End Try
    End Sub

    Private Sub MenuItemSetRadioName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSetRadioName.Click
        Dim radio As BluetoothRadio = BluetoothRadio.PrimaryRadio
        Dim newName As String = InputBox("Passcode/PIN", "Set Radio Name", radio.Name)
        If newName.Length = 0 Then
            MessageBox_Show(Me, "Cancelled", "Set Radio Name")
            Return
        End If
        radio.Name = newName
    End Sub

    Private Sub MenuItemSecurityRemoveDevice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSecurityRemoveDevice.Click
        Dim bdi As BluetoothDeviceInfo = GetSelectedDeviceInfo()
        If bdi Is Nothing Then
            MessageBox_Show(Me, "No device selected", "Remove Device")
        Else
            Dim rslt As DialogResult _
                = MessageBox_Show(Me, "Device: " & NewLine & bdi.DeviceName & NewLine & bdi.DeviceAddress.ToString(), _
                    "Remove Device", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If rslt = Windows.Forms.DialogResult.Yes Then
                Dim result As Boolean = BluetoothSecurity.RemoveDevice(bdi.DeviceAddress)
                MessageBox_Show(Me, "Result: " & result, "Remove Device")
            End If
        End If
    End Sub

    Private Sub MenuItemSecurityPairRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSecurityPairRequest.Click
        Dim bdi As BluetoothDeviceInfo = GetSelectedDeviceInfo()
        If bdi Is Nothing Then
            MessageBox_Show(Me, "No device selected", "Pair Request")
        Else
            Dim rslt As DialogResult _
                = MessageBox_Show(Me, "Device: " & NewLine & bdi.DeviceName & NewLine & bdi.DeviceAddress.ToString(), _
                    "Pair Request", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If rslt = Windows.Forms.DialogResult.Yes Then
                Dim passcode As String = InputBox("Passcode/PIN", "Pair Request", "0000")
                If passcode.Length = 0 Then
                    MessageBox_Show(Me, "Cancelled", "Pair Request")
                    Return
                End If
                Dim result As Boolean = BluetoothSecurity.PairRequest(bdi.DeviceAddress, passcode)
                MessageBox_Show(Me, "Result: " & result, "Pair Request")
            End If
        End If
    End Sub

    '===========================================================================
#Region "Discovery"
    Private Sub ButtonDiscoverDevices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemDiscoverAll.Click
        Dim newOnly As Boolean = False
        System.Threading.ThreadPool.QueueUserWorkItem(AddressOf BackgroundDiscoverAndFill, newOnly)
        Me.LabelDiscoveringState.Text = "Discovering..."
    End Sub

    Private Sub ButtonDiscoverDevicesNewOnly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemDiscoverNewOnly.Click
        Dim newOnly As Boolean = True
        System.Threading.ThreadPool.QueueUserWorkItem(AddressOf BackgroundDiscoverAndFill, newOnly)
        Me.LabelDiscoveringState.Text = "Discovering..."
    End Sub

    Private Sub ButtonDiscoverDevicesAuthenticatedOnly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemDiscoverAuthenticatedOnly.Click
        Dim flags As New DiscoveryFlags(True, False, False, False)
        System.Threading.ThreadPool.QueueUserWorkItem(AddressOf BackgroundDiscoverAndFill3, flags)
        Me.LabelDiscoveringState.Text = "Discovering..."
    End Sub

    Private Sub ButtonDiscoverDevicesRememberedOnly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemDiscoverRememberedOnly.Click
        Dim flags As New DiscoveryFlags(False, True, False, False)
        System.Threading.ThreadPool.QueueUserWorkItem(AddressOf BackgroundDiscoverAndFill3, flags)
        Me.LabelDiscoveringState.Text = "Discovering..."
    End Sub

    Private Sub ButtonDiscoverDevicesDiscoverableOnly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemDiscoverDiscoverableOnly.Click
        Dim flags As New DiscoveryFlags(False, False, False, True)
        System.Threading.ThreadPool.QueueUserWorkItem(AddressOf BackgroundDiscoverAndFill3, flags)
        Me.LabelDiscoveringState.Text = "Discovering..."
    End Sub

    Structure DiscoveryFlags
        Friend ReadOnly m_authenticated, m_remembered, m_unknown, m_discoOnly As Boolean

        Sub New(ByVal authenticated As Boolean, ByVal remembered As Boolean, ByVal unknown As Boolean, ByVal discoverableOnly As Boolean)
            m_authenticated = authenticated
            m_remembered = remembered
            m_unknown = unknown
            m_discoOnly = discoverableOnly
        End Sub
    End Structure

    Private Sub BackgroundDiscoverAndFill(ByVal dummy As Object)
        Dim newOnly As Boolean = CBool(dummy)
        Dim flags As New DiscoveryFlags(Not newOnly, Not newOnly, True, False)
        BackgroundDiscoverAndFill3(flags)
    End Sub

    Private Sub BackgroundDiscoverAndFill3(ByVal dummy As Object)
        Dim flags As DiscoveryFlags = CType(dummy, DiscoveryFlags)
        If m_noBluetooth Then
            Beep()
            Return
        End If
        Dim cli As New BluetoothClient()
        Dim startTime As DateTime = DateTime.UtcNow
        Dim devices() As BluetoothDeviceInfo = cli.DiscoverDevices(255, flags.m_authenticated, _
            flags.m_remembered, flags.m_unknown, flags.m_discoOnly)
        Dim endTime As DateTime = DateTime.UtcNow
        SyncLock m_lock
            m_startTime = startTime
            m_endTime = endTime
            m_devices = devices
        End SyncLock
        Dim handler As EventHandler = AddressOf FillDevices
        Me.Invoke(handler)
    End Sub

    Private Sub FillDevices(ByVal sender As Object, ByVal e As EventArgs)
        'System.Diagnostics.Debug.Assert(Not Me.InvokeRequired)
        Dim devices() As BluetoothDeviceInfo = Nothing
        Dim startTime, endTime As DateTime
        ' Get the device list set by the background thread.
        SyncLock m_lock
            devices = m_devices
            startTime = m_startTime
            endTime = m_endTime
        End SyncLock
        System.Diagnostics.Debug.Assert(Not devices Is Nothing)
        '
        Me.LabelDiscoveringState.Text = "Discovered"
        FillDevicesFill(devices)
        Me.LabelDiscoveringState.Text = "RSSI & Display..."
        DumpDeviceInfo(devices, startTime, endTime)
        Me.LabelDiscoveringState.Text = String.Empty
    End Sub

    Private Sub FillDevicesFill(ByVal devices() As BluetoothDeviceInfo)
        ' Add a special device entry for the local device.
        devices = AppendLocalDeviceInfo(devices)
        '
        FillDevicesFillNoAddLocal(devices)
    End Sub

    Private Sub FillDevicesFillNoAddLocal(ByVal devices() As BluetoothDeviceInfo)
        ' Apply to the combobox
        Me.ComboBoxDevices.DataSource = Nothing
        Me.ComboBoxDevices.DisplayMember = "DeviceName"
        Me.ComboBoxDevices.DataSource = devices
        Beep()
    End Sub

    ' Adds a special device entry for the local device.
    Private Function AppendLocalDeviceInfo(ByVal devices() As BluetoothDeviceInfo) As BluetoothDeviceInfo()
        Dim localRadio As BluetoothRadio = BluetoothRadio.PrimaryRadio
        If localRadio Is Nothing Then
            m_noBluetooth = True
            Dim rslt As System.Windows.Forms.DialogResult = MessageBox_Show(Me, _
                "There is no Bluetooth hardware, or it uses unsupported software. Quit?", _
                "No Bluetooth support", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            If rslt <> Windows.Forms.DialogResult.No Then
                Application.Exit()
            End If
        End If
        System.Diagnostics.Debug.Assert(Not (localRadio Is Nothing And devices.Length <> 0), "PrimaryRadio is null -- but DiscoverDevices worked!")
        '
        If Not localRadio Is Nothing Then ' Handle gracefully anyway!
            If localRadio.Mode = RadioMode.PowerOff Then
                Dim rslt As System.Windows.Forms.DialogResult = MessageBox_Show(Me, _
                    "The Bluetooth hardware is disabled, enable it?", _
                    "Bluetooth radio powered-off", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                If rslt = Windows.Forms.DialogResult.Yes Then
                    localRadio.Mode = RadioMode.Connectable
                Else
                    m_noBluetooth = True
                End If
            End If
            ' Now add the local device dummy device, after re-checking the radio status
            If localRadio.Mode <> RadioMode.PowerOff Then
                ' Get the local MAC Address and create a device object. 
                Dim localAddr As BluetoothAddress = localRadio.LocalAddress
                Dim localBdi As New BluetoothDeviceInfo(localAddr)
                localBdi.DeviceName = "- local device -"
                ' Copy the entries into a new array with the 'local' item at the front.
                Dim devicesPlusLocal(devices.Length) As BluetoothDeviceInfo
                devices.CopyTo(devicesPlusLocal, 1)
                devicesPlusLocal(0) = localBdi
                devices = devicesPlusLocal
            End If
        End If
        Return devices
    End Function

    Private Sub DumpDeviceInfo(ByVal devices() As BluetoothDeviceInfo, _
            ByVal startTime As DateTime, ByVal endTime As DateTime)
        Dim sb As New System.Text.StringBuilder
        Me.TextBox1.Text = String.Empty
        Dim localTime As DateTime = startTime.ToLocalTime
        sb.AppendFormat(System.Globalization.CultureInfo.InvariantCulture, _
            "Discovery process started at {0} UTC, {1} local, and ended at {2} UTC.", _
            startTime, localTime, endTime)
        sb.Append(vbCrLf + vbCrLf)
        Me.TextBox1.Text += sb.ToString()
        Dim doRssi As Boolean = MenuItemDiscoverDumpsRssi.Checked
        For Each curDevice As BluetoothDeviceInfo In devices
            sb.Length = 0
            sb.AppendFormat(System.Globalization.CultureInfo.InvariantCulture, _
                "* {0}", curDevice.DeviceName)
            sb.Append(vbCrLf)
            sb.AppendFormat(System.Globalization.CultureInfo.InvariantCulture, _
                "Address: {0}", curDevice.DeviceAddress)
            sb.Append(vbCrLf)
            sb.AppendFormat(System.Globalization.CultureInfo.InvariantCulture, _
                "Remembered: {2}, Authenticated: {0}, Connected: {1}", _
                curDevice.Authenticated, curDevice.Connected, curDevice.Remembered)
            sb.Append(vbCrLf)
            sb.AppendFormat(System.Globalization.CultureInfo.InvariantCulture, _
                "LastSeen: {0}, LastUsed: {1}", _
                curDevice.LastSeen, curDevice.LastUsed)
            sb.Append(vbCrLf)
            DumpCodInfo(curDevice.ClassOfDevice, sb)
            If doRssi Then
                Dim rssi As Int32 = curDevice.Rssi
                If rssi <> Int32.MinValue Then
                    sb.AppendFormat(System.Globalization.CultureInfo.InvariantCulture, _
                        "Rssi: {0} (0x{0:X})", rssi)
                Else
                    sb.AppendFormat(System.Globalization.CultureInfo.InvariantCulture, _
                        "Rssi: failed")
                End If
                sb.Append(vbCrLf)
            End If
            sb.Append(vbCrLf)
            Me.TextBox1.Text += sb.ToString()
        Next
    End Sub

    Shared Sub DumpCodInfo(ByVal cod As ClassOfDevice, ByVal sb As System.Text.StringBuilder)
        sb.AppendFormat(System.Globalization.CultureInfo.InvariantCulture, _
            "CoD: (0x{0:X6})", cod.Value, cod)
        sb.Append(vbCrLf)
        sb.AppendFormat(System.Globalization.CultureInfo.InvariantCulture, _
            " Device:  {0} (0x{1:X2}) / {2} (0x{3:X4})", cod.MajorDevice, CInt(cod.MajorDevice), cod.Device, CInt(cod.Device))
        sb.Append(vbCrLf)
        sb.AppendFormat(System.Globalization.CultureInfo.InvariantCulture, _
            " Service: {0} (0x{1:X2})", cod.Service, CInt(cod.Service))
        sb.Append(vbCrLf)
    End Sub

    Private Sub MenuItemDiscoverDumpsRssi_Click(ByVal o As Object, ByVal e As EventArgs) Handles MenuItemDiscoverDumpsRssi.Click
        MenuItemDiscoverDumpsRssi.Checked = Not MenuItemDiscoverDumpsRssi.Checked
    End Sub

    Private Function GetSelectedDeviceInfo() As BluetoothDeviceInfo
        Dim selectedDevice As BluetoothDeviceInfo = DirectCast(Me.ComboBoxDevices.SelectedItem, BluetoothDeviceInfo)
        If selectedDevice Is Nothing Then
            MessageBox_Show(Me, "No Device selected.")
        End If
        Return selectedDevice
    End Function

#End Region 'Discovery

    '===========================================================================
#Region "SDP"
    '----------------
    Private Sub ButtonGetOppRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemQueryOpp.Click
        Dim searchUuid As Guid = BluetoothService.ObexObjectPush
        DisplayAllRecordsWithUuid(searchUuid, GetType(ObexAttributeId))
    End Sub

    Private Sub ButtonGetInstalledServices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemQueryInstalled.Click
        Dim bdi As BluetoothDeviceInfo = GetSelectedDeviceInfo()
        If bdi Is Nothing Then Exit Sub
        Dim svcUuids() As Guid = bdi.InstalledServices
        If svcUuids.Length = 0 Then
            Me.TextBox1.Text = "InstalledServices returned no services."
            Exit Sub
        End If
        Me.TextBox1.Text = String.Empty
        Dim i As Integer
        For Each curUuid As Guid In svcUuids
            Me.TextBox1.Text += ChrW(&H2022) + " " + curUuid.ToString() + NewLine
            Dim svcName As String = BluetoothService.GetName(curUuid)
            If Not svcName Is Nothing Then
                Me.TextBox1.Text += svcName + NewLine
            End If
            Me.TextBox1.Text += NewLine
            i += 1
        Next
    End Sub

    Private Sub ButtonAllOverL2cap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemQueryAllL2cap.Click
        Dim searchUuid As Guid = BluetoothService.L2CapProtocol
        DisplayAllRecordsWithUuid(searchUuid)
    End Sub

    Private Sub MenuItemQuerySelectedClass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemQuerySelectedClass.Click
        Dim searchUuid As Guid = GetSelectedService()
        If Guid.Empty.Equals(searchUuid) Then
            MessageBox_Show(Me, "Invalid Service UUID.")
            Return
        End If
        DisplayAllRecordsWithUuid(searchUuid)
    End Sub

    '----------------

    Private Sub DisplayAllRecordsWithUuid(ByVal searchUuid As Guid, ByVal ParamArray attributeIdDefiningClasses() As Type)
        Dim bdi As BluetoothDeviceInfo = GetSelectedDeviceInfo()
        If bdi Is Nothing Then Exit Sub
        Dim rawRecords()() As Byte
        Dim actualRecords() As ServiceRecord
        Dim startTicks, elapsedQuery, elapsedParse, elapsedDisplay As Integer
        Try
            startTicks = Environment.TickCount
            ' shut up compiler
            rawRecords = Nothing
            actualRecords = Nothing
            If Not m_skipGetSvcRcdsUnparsed Then
                Try
                    rawRecords = bdi.GetServiceRecordsUnparsed(searchUuid)
                    actualRecords = Nothing
                Catch ex As NotSupportedException
                    ' GetServiceRecordsUnparsed not supported by Widcomm
                    m_skipGetSvcRcdsUnparsed = True
                End Try
            End If
            If m_skipGetSvcRcdsUnparsed Then
                ' GetServiceRecordsUnparsed not supported by Widcomm
                rawRecords = Nothing
                actualRecords = bdi.GetServiceRecords(searchUuid)
            End If
            elapsedQuery = Environment.TickCount - startTicks
            Me.TextBox1.Text = "Query complete"
        Catch sex As System.Net.Sockets.SocketException
            Me.TextBox1.Text = String.Format(System.Globalization.CultureInfo.InvariantCulture, _
                "Failed to read ServiceRecord with: {0} (0x{0:X}) '{1}'", _
                sex.ErrorCode, sex.Message)
            Exit Sub
        End Try
        startTicks = Environment.TickCount
        ParseRecords(rawRecords, actualRecords)
        elapsedParse = Environment.TickCount - startTicks
        startTicks = Environment.TickCount
        DisplayRecords(attributeIdDefiningClasses)
        elapsedDisplay = Environment.TickCount - startTicks
        Me.TextBox1.Text += String.Format(System.Globalization.CultureInfo.InvariantCulture, _
            "Elapsed (ms): Query: {0}, Parse: {1}, Display: {2}" + NewLine + NewLine, _
            elapsedQuery, elapsedParse, elapsedDisplay)
    End Sub

    Private Sub ParseRecords(ByVal rawRecords()() As Byte, ByVal recordsPreParsed() As ServiceRecord)
        If rawRecords Is Nothing Then
            ' Some platforms don't support getting the raw record bytes
            Debug.Assert(Not recordsPreParsed Is Nothing, "nothing for both raw and parsed!!!")
            Me.m_lastRecords = Nothing
            Me.m_lastRecordsParsed = recordsPreParsed
            Me.m_lastRecordsParseError = Nothing
            Return
        End If
        '
        Me.m_lastRecords = rawRecords
        ReDim Me.m_lastRecordsParsed(Me.m_lastRecords.Length - 1)
        System.Diagnostics.Debug.Assert(Me.m_lastRecords.Length = Me.m_lastRecordsParsed.Length)
        ReDim Me.m_lastRecordsParseError(Me.m_lastRecords.Length - 1)
        System.Diagnostics.Debug.Assert(Me.m_lastRecords.Length = Me.m_lastRecordsParseError.Length)
        '
        If rawRecords.Length = 0 Then
            Return
        End If
        '
        Dim i As Integer = 0
        Dim parser As New ServiceRecordParser
        parser.SkipUnhandledElementTypes = True ' display what we can of the record
        For Each rawRecord As Byte() In rawRecords
            Try
                Dim record As ServiceRecord = parser.Parse(rawRecord)
                Me.m_lastRecordsParsed(i) = record
            Catch ex As Exception
                Me.m_lastRecordsParseError(i) = "Parse failed with: " & ex.ToString
            End Try
            i += 1
        Next
    End Sub

    Private Sub DisplayRecords(ByVal ParamArray attributeIdDefiningClasses() As Type)
        Debug.Assert(Not m_lastRecordsParsed Is Nothing, "why called when not inited?")
        If m_lastRecordsParsed.Length = 0 Then
            Me.TextBox1.Text = "Search returned zero services." + NewLine + NewLine
            Exit Sub
        End If
        Me.TextBox1.Text = String.Empty
        '
        Dim i As Integer = 0
        Dim parser As New ServiceRecordParser
        parser.SkipUnhandledElementTypes = True ' display what we can of the record
        For Each record As ServiceRecord In m_lastRecordsParsed
            Me.TextBox1.Text += ChrW(&H2022) + " Record:" + NewLine + NewLine
            '
            If record Is Nothing Then
                Debug.Assert(Not Me.m_lastRecordsParseError Is Nothing, "null record and errors!")
                Debug.Assert(Not Me.m_lastRecordsParseError(i) Is Nothing, "null record and error item!")
                Me.TextBox1.Text += Me.m_lastRecordsParseError(i)
            Else
                Try
                    Dim text As String = ServiceRecordUtilities.Dump(record, attributeIdDefiningClasses)
                    Me.TextBox1.Text += text
                Catch ex As Exception
                    Me.TextBox1.Text += "Dump failed with: " & ex.ToString
                End Try
            End If
            Me.TextBox1.Text += NewLine + NewLine
            i += 1
        Next
    End Sub

    Private Sub ButtonBytesOfLastRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemDumpRawRecords.Click
        If m_lastRecords Is Nothing Then Exit Sub
        'Append, or clear before appending...? Me.TextBox1.Text = String.Empty
        For Each curRecord As Byte() In m_lastRecords
            Dim bytes() As Byte = curRecord
            Dim text As String = MakeArrayContent(bytes)
            Me.TextBox1.Text += text
            Me.TextBox1.Text += NewLine + NewLine
        Next
    End Sub

    Private Shared Function MakeArrayContent(ByVal buffer() As Byte) As String
        Dim bldr As New System.Text.StringBuilder
        Dim i As Integer
        For Each cur As Byte In buffer
            bldr.AppendFormat(System.Globalization.CultureInfo.InvariantCulture, "0x{0:x2}, ", cur)
            '
            i += 1
            If i Mod 16 = 0 Then
                bldr.Append(NewLine)
            ElseIf i Mod 8 = 0 Then
                bldr.Append(" ")
            End If
        Next
        Return bldr.ToString()
    End Function


    '--------------------------------------
    Private Sub DisplayXp1(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemTestRecordSdp.Click
        Dim foo As Byte()()
        ReDim foo(0)
        foo(0) = XxxxxData_CompleteThirdPartyRecords.Xp1Sdp
        DisplayTestRecords(foo)
    End Sub

    Private Sub DisplayXpOpp(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemTestRecordOpp.Click
        Dim foo As Byte()()
        ReDim foo(0)
        foo(0) = XxxxxData_CompleteThirdPartyRecords.XpFsquirtOpp
        DisplayTestRecords(foo)
    End Sub

    Private Sub DisplaySeMmv100(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemTestRecordOpp.Click, MenuItemSeMmv100.Click
        Dim foo As Byte()()
        ReDim foo(2)
        foo(0) = XxxxxData_CompleteThirdPartyRecords.SonyEricssonMv100_Opp
        foo(1) = XxxxxData_CompleteThirdPartyRecords.SonyEricssonMv100_Ftp
        foo(2) = XxxxxData_CompleteThirdPartyRecords.SonyEricssonMv100_Imaging_hasUint64
        DisplayTestRecords(foo)
    End Sub

    Private Sub DisplayTestRecords(ByVal record As Byte()())
        Dim startTicks, elapsedQuery, elapsedParse, elapsedDisplay As Integer
        elapsedQuery = -1
        startTicks = Environment.TickCount
        ParseRecords(record, Nothing)
        elapsedParse = Environment.TickCount - startTicks
        startTicks = Environment.TickCount
        DisplayRecords()
        elapsedDisplay = Environment.TickCount - startTicks
        Me.TextBox1.Text += String.Format(System.Globalization.CultureInfo.InvariantCulture, _
            "Elapsed (ms): Query: {0}, Parse: {1}, Display: {2}" + NewLine + NewLine, _
            elapsedQuery, elapsedParse, elapsedDisplay)
    End Sub

    '---------------------------------------------------------------------------
    Public Function GetServiceName(ByVal record As ServiceRecord) As String
        Dim primaryLang As LanguageBaseItem = record.GetPrimaryLanguageBaseItem()
        If primaryLang Is Nothing Then
            ' Primary multi-language not set, would have to guess strings' encoding,
            ' what LanguageBase would have been added to it.
            ' Lets assume the 0x0100 value.
            Dim attrId As ServiceAttributeId = ServiceRecord.CreateLanguageBasedAttributeId( _
                UniversalAttributeId.ServiceName, LanguageBaseItem.PrimaryLanguageBaseAttributeId)
            If record.Contains(attrId) Then
                Dim attr As ServiceAttribute = record.GetAttributeById(attrId)
                Dim element As ServiceElement = attr.Value
                If element.ElementType = ElementType.TextString Then
                    ' Lets guess UTF-8/ASCII/Windows-1252 ASCII range, and not UTF-16 etc
                    Dim sn As String = element.GetValueAsStringUtf8()
                    Console.WriteLine("ServiceName (guessed encoding): " & sn)
                    Return sn
                End If
            End If
        ElseIf record.Contains(UniversalAttributeId.ServiceName, primaryLang) Then
            Dim sn As String = record.GetMultiLanguageStringAttributeById(UniversalAttributeId.ServiceName, primaryLang)
            Console.WriteLine("ServiceName: " & sn)
            Return sn
        End If
        ' Failed, return null
        Return Nothing
    End Function

    Public Function GetServiceClasses(ByVal record As ServiceRecord) As String
        Dim bldr As New System.Text.StringBuilder
        If Not record.Contains(UniversalAttributeId.ServiceClassIdList) Then
            Return "no class list!"
        End If
        Dim attr As ServiceAttribute = record.GetAttributeById(UniversalAttributeId.ServiceClassIdList)
        Dim seq As ServiceElement = attr.Value
        If Not seq.ElementType = ElementType.ElementSequence Then
            Return "attribute not a seq!"
        End If
        Const Sep As String = ", "
        For Each e As ServiceElement In seq.GetValueAsElementList()
            Dim name As String = Nothing
            If e.ElementType = ElementType.Uuid16 Then
                name = BluetoothService.GetName(CType(e.Value, UInt16))
                bldr.AppendFormat(System.Globalization.CultureInfo.InvariantCulture, _
                    "0x{0:X4}", e.Value)
            ElseIf e.ElementType = ElementType.Uuid32 Then
                name = BluetoothService.GetName(CType(e.Value, UInt32))
                bldr.AppendFormat(System.Globalization.CultureInfo.InvariantCulture, _
                    "0x{0:X8}", e.Value)
            ElseIf e.ElementType = ElementType.Uuid128 Then
                name = BluetoothService.GetName(e.GetValueAsUuid)
                bldr.AppendFormat(System.Globalization.CultureInfo.InvariantCulture, _
                    "{0}", e.GetValueAsUuid)
            End If
            If Not name Is Nothing Then
                bldr.AppendFormat(System.Globalization.CultureInfo.InvariantCulture, _
                    " {0}", name)
            End If
            bldr.Append(Sep)
        Next
        bldr.Length -= Sep.Length
        Return bldr.ToString()
    End Function

    Private Sub ButtonNameAndChannelOfLastRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemDumpRecordsNameChannel.Click
        If m_lastRecordsParsed Is Nothing Then Exit Sub
        Me.TextBox1.Text += "--------------------------------" & NewLine
        For Each record As ServiceRecord In m_lastRecordsParsed
            If record Is Nothing Then
                ' Parse of that record failed...
                Me.TextBox1.Text += "N/A" + NewLine
            Else
                Dim name As String = GetServiceName(record)
                Dim classes As String = GetServiceClasses(record)
                Dim channelNumber As Integer = ServiceRecordHelper.GetRfcommChannelNumber(record)
                '
                If name Is Nothing Then
                    Me.TextBox1.Text += "ServiceName: " & "<none>" & NewLine
                Else
                    Me.TextBox1.Text += "ServiceName: '" & name & "'" & NewLine
                End If
                Me.TextBox1.Text += "ServiceClasses: " & classes & NewLine
                If channelNumber = -1 Then
                    Me.TextBox1.Text += "Channel Num: " & "<not assigned>" & NewLine
                Else
                    Me.TextBox1.Text += "Channel Num: " & channelNumber & NewLine
                End If
            End If
            Me.TextBox1.Text += NewLine
        Next
    End Sub

    Private Sub MenuItemSdpSaveText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSdpSaveText.Click
        Dim str As String = Me.TextBox1.Text
        ' SaveFileDialog not supported on SmartPhone
        If m_saveDlg Is Nothing AndAlso Not _notSaveDlg Then
            Try
                m_saveDlg = New SaveFileDialog
            Catch ex As NotSupportedException
                _notSaveDlg = True
                MessageBox.Show("SaveFileDialog not supported," _
                    & " will write to a pre-defined filename.")
            End Try
        End If
        '
        Dim rslt As DialogResult
        Dim pathname As String
        If _notSaveDlg Then
            pathname = DateTime.Now.ToString("yyyy-MM-ddTHH-mm-ss")
            pathname = "sdp" & pathname & ".txt"
            Dim folder As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal)
            pathname = System.IO.Path.Combine(folder, pathname)
            rslt = DialogResult.OK
        Else
            rslt = m_saveDlg.ShowDialog
            If rslt = DialogResult.OK Then
                pathname = m_saveDlg.FileName
            Else
                pathname = Nothing
            End If
        End If
        If rslt = Windows.Forms.DialogResult.OK Then
            Dim wtr As System.IO.TextWriter
            wtr = IO.File.CreateText(pathname)
            Try
                wtr.Write(str)
                wtr.Close() 'Dispose below seems not to flush...!?
            Catch ex As Exception
                CType(wtr, IDisposable).Dispose()
            End Try
        End If
    End Sub

    Private Sub MenuItemSdpCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSdpCopy.Click
        Clipboard.Copy(Me.TextBox1)
    End Sub


    Private Function CreateDummyDevices() As BluetoothDeviceInfo()
        Dim devices(2) As BluetoothDeviceInfo
        Const FakeOuiCiscoBaseUser As String = "02:00:0C:"
        devices(0) = New BluetoothDeviceInfo(BluetoothAddress.Parse(FakeOuiCiscoBaseUser & "00:00:00"))
        devices(1) = New BluetoothDeviceInfo(BluetoothAddress.Parse(FakeOuiCiscoBaseUser & "00:00:01"))
        devices(2) = New BluetoothDeviceInfo(BluetoothAddress.Parse(FakeOuiCiscoBaseUser & "00:00:02"))
        Return devices
    End Function

    Private Sub MenuItemTestRssi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemTestRssi.Click
        Dim devices() As BluetoothDeviceInfo = CreateDummyDevices()
        DumpDeviceInfo(devices, DateTime.UtcNow, DateTime.UtcNow)
    End Sub

    Private Sub MenuItemAddTestDevices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemAddTestDevices.Click
        Dim devices() As BluetoothDeviceInfo = CreateDummyDevices()
        FillDevicesFillNoAddLocal(devices)
    End Sub

    Private Sub MenuItemRadioInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemRadioInfo.Click
        Dim using1 As IDisposable = Nothing
        Try
            Dim wtr As New IO.StringWriter : using1 = wtr
            wtr.WriteLine("Primary radio:")
            DisplayPrimaryBluetoothRadio(wtr)
            wtr.WriteLine()
            wtr.WriteLine("All radios:")
            DisplayAllBluetoothRadios(wtr)
            Me.TextBox1.Text = wtr.ToString()
        Finally
            ' StringWriter doesn't use any native resources but 
            If Not using1 Is Nothing Then
                using1.Dispose()
            End If
        End Try
    End Sub

    Public Shared Sub DisplayPrimaryBluetoothRadio(ByVal wtr As System.IO.TextWriter)
        Dim myRadio As BluetoothRadio = BluetoothRadio.PrimaryRadio
        If myRadio Is Nothing Then
            wtr.WriteLine("No radio hardware or unsupported software stack")
            Return
        End If
        Dim mode As RadioMode = myRadio.Mode
        ' Warning: LocalAddress is null if the radio is powered-off.
        wtr.WriteLine("* Radio, address: {0:C}", myRadio.LocalAddress)
        wtr.WriteLine("Mode: " & mode.ToString())
        wtr.WriteLine("Name: " & myRadio.Name _
            & ", LmpSubversion: " & myRadio.LmpSubversion)
        wtr.WriteLine("ClassOfDevice: " & myRadio.ClassOfDevice.ToString() _
            & ", device: " & myRadio.ClassOfDevice.Device.ToString() _
            & " / service: " & myRadio.ClassOfDevice.Service.ToString())
        '
        ' Enable discoverable mode
        'wtr.WriteLine()
        'myRadio.Mode = RadioMode.Discoverable
        'wtr.WriteLine("Radio Mode now: " & myRadio.Mode.ToString())
    End Sub

    Public Shared Sub DisplayAllBluetoothRadios(ByVal wtr As System.IO.TextWriter)
        Dim radios() As BluetoothRadio = BluetoothRadio.AllRadios
        If radios.Length = 0 Then
            wtr.WriteLine("No radio hardware or unsupported software stack")
            Return
        End If
        Dim tmpSb As New System.Text.StringBuilder
        For Each curRadio As BluetoothRadio In radios
            wtr.WriteLine("* Radio, address: {0:C}", curRadio.LocalAddress)
            wtr.WriteLine("Mode: " & curRadio.Mode.ToString())
            wtr.WriteLine("Name: " & curRadio.Name _
                & ", LmpSubversion: " & curRadio.LmpSubversion)
            tmpSb.Length = 0
            DumpCodInfo(curRadio.ClassOfDevice, tmpSb)
            wtr.Write(tmpSb.ToString)
            wtr.WriteLine()
        Next
    End Sub

    '==
    Enum ViewMode
        Sdp
        Client
        Server
    End Enum

    Private Sub SetView(ByVal mode As ViewMode)
        Me.PanelSdp.Visible = False
        Me.PanelClient.Visible = False
        Me.PanelServer.Visible = False
        Select Case mode
            Case ViewMode.Client
                Me.PanelClient.Visible = True
            Case ViewMode.Server
                Me.PanelServer.Visible = True
            Case Else
                Debug.Assert(mode = ViewMode.Sdp, "unknown view: " & mode)
                Me.PanelSdp.Visible = True
        End Select
        '
        If mode = ViewMode.Sdp Then
            Me.MenuItemMenuSdp.Enabled = True
            Me.MenuItemMenuTestsSdp.Enabled = True
            Me.MenuItemMenuSetService.Enabled = False
        Else
            Me.MenuItemMenuSdp.Enabled = False
            Me.MenuItemMenuTestsSdp.Enabled = False
            Me.MenuItemMenuSetService.Enabled = True
        End If
    End Sub

    Private Sub MenuItemViewSdp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemViewSdp.Click
        SetView(ViewMode.Sdp)
    End Sub

    Private Sub MenuItemViewClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemViewClient.Click
        SetView(ViewMode.Client)
    End Sub

    Private Sub MenuItemViewServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemViewServer.Click
        SetView(ViewMode.Server)
    End Sub

#End Region '"SDP"

    '===========================================================================
#Region "Client"
    Private m_cli As BluetoothClient
    Private m_lockCli As New Object 'To apply 'volatile' access to the m_devices shared field.
    '
    Private m_strm As System.Net.Sockets.NetworkStream
    Private m_wtr As System.IO.StreamWriter
    Private m_encoding As System.Text.Encoding
    Private m_connecting As Boolean
    Private m_disconnecting As Boolean

    '--------------------------------------------------------------
    Sub Form1Connect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)        ''====
        Me.ComboBoxServices.ValueMember = "Value"
        Me.ComboBoxServices.DisplayMember = "Name"
        Me.ComboBoxServices.DataSource = BluetoothServiceItem.GetWellKnownServices
        Me.ComboBoxServices.SelectedItem = New BluetoothServiceItem(BluetoothService.SerialPort, "tmp")
        '
        If Environment.OSVersion.Platform = PlatformID.Win32NT _
        OrElse Environment.OSVersion.Platform = PlatformID.Win32Windows Then
            ' Only the full framework supports encoding x-IA5, NETCF and Mono don't.
            comboBoxEncoding.SelectedIndex = 0
        Else
            comboBoxEncoding.SelectedIndex = 3
        End If
        '
        labelState.Text = "Disconnected"
        'labelSendPduLength.Text = ""
        '
        If Not m_noBluetooth Then
            m_cli = New BluetoothClient
        End If
    End Sub

    '--------------------------------------------------------------
    Private Sub newBluetoothClient()
        m_connecting = False
        m_disconnecting = True
        newBluetoothClientUpdateLabelStatus("Disconnecting...")
        If Not m_wtr Is Nothing Then
            'If m_wtr.BaseStream IsNot Nothing Then
            'If m_wtr.BaseStream.CanRead OrElse m_wtr.BaseStream.CanWrite Then
            m_wtr.Close()
            'End If
            ' Closing the writer should have closed this too.
            System.Diagnostics.Debug.Assert(Not m_cli.Connected)
            ' But we'll close anyway...
        End If
        If m_noBluetooth Then
            System.Diagnostics.Debug.Assert(m_cli Is Nothing, "newBluetoothClient, m_noBluetooth but m_cli is set!")
        Else
            System.Diagnostics.Debug.Assert(Not m_cli Is Nothing, "newBluetoothClient, m_cli should not be null as m_noBluetooth=false")
            m_cli.Close()
            m_cli = New BluetoothClient()
        End If
        newBluetoothClientUpdateLabelStatus("Disconnected")
    End Sub
    Sub newBluetoothClientUpdateLabelStatus(ByVal text As String)
        If Me.InvokeRequired Then
            Dim d As EventHandler = New EventHandler(AddressOf newBluetoothClientUpdateLabelStatus__Invokee)
            m_IR_newBluetoothClientUpdateLabelStatus = text
            Me.Invoke(d) '..., New Object() {text})
        Else
            newBluetoothClientUpdateLabelStatus__Invokee(Me, EventArgs.Empty)
        End If
    End Sub
    Sub newBluetoothClientUpdateLabelStatus__Invokee(ByVal sender As Object, ByVal e As EventArgs)
        Dim text As String
        text = m_IR_newBluetoothClientUpdateLabelStatus
        labelState.Text = text
    End Sub
    Private m_IR_newBluetoothClientUpdateLabelStatus As String

    '--------------------------------------------------------------
    Sub Form1Connect_FormClosing()
        m_disconnecting = True
        If Not m_wtr Is Nothing Then
            m_wtr.Close()
            ' Closing the writer should have closed this too.
            System.Diagnostics.Debug.Assert(Not m_cli.Connected)
            ' But we'll close anyway...
        End If
        If Not m_cli Is Nothing Then
            m_cli.Close()
        End If
    End Sub

    '--------------------------------------------------------------
    Private Sub ButtonDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemClientDisconnect.Click
        If m_connecting Then
            ' During asynchronous Connect let the disconnect button be used 
            ' to cancel the connect attempt.  We must not delete the extant 
            ' IrDAClient until the connect attempt has completed (so don't
            ' use newIrdaClient()). It will instead be called in the 
            ' EndConnect callback when the cancel is actioned.
            m_cli.Close()
        Else
            m_disconnecting = True
            'labelState.Text = "Disconnecting..."
            newBluetoothClient()
            'labelState.Text = "Disconnected"
        End If
    End Sub

    Sub zzzzDump(ByVal obj As Object)
        Dim type As String
        If obj Is Nothing Then
            type = "null"
        Else
            type = obj.GetType().Name
        End If
        Console.WriteLine("[" & type & "]: " & zzzzToString(obj))
    End Sub


    Function zzzzToString(ByVal obj As Object) As String
        If obj Is Nothing Then
            Return "null"
        Else
            Return obj.ToString()
        End If
    End Function

    ''==
    Function GetSelectedService() As Guid
        Dim svc As Guid
        '
        If Not Me.ComboBoxServices.SelectedItem Is Nothing Then
            Dim btStdSvc As BluetoothServiceItem
            btStdSvc = CType(Me.ComboBoxServices.SelectedItem, BluetoothServiceItem)
            svc = btStdSvc.Uuid
            Return svc
        End If
        '
        Dim svcText As String = Me.ComboBoxServices.Text
        Try
            svc = New Guid(svcText) ' Parse!
            Return svc
        Catch ofex As OverflowException
        Catch fmtex As FormatException
            ' TODO if users types space e.g. on selecting a standard service then 
            ' SelectedItem is null, we should find the last whitespace-separated
            ' piece of text and try and parse it...
        End Try
        Return Guid.Empty
    End Function
    ''==


    Private Sub ButtonTestDiscoveryUi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemTestDiscoveryUi.Click
        'Dim cod As ClassOfDevice = New ClassOfDevice(1776)
        ''
        ''
        'InTheHand.Windows.Forms.SelectBluetoothDeviceDialog.Internal___useOwnImpl = True
        Dim x As New InTheHand.Windows.Forms.SelectBluetoothDeviceDialog()
        Dim rslt As DialogResult = x.ShowDialog()
        Console.WriteLine("sbdd.ShowDialog returned")
        Dim txt As String = "rslt: " & rslt.ToString() & ", device: "
        If x.SelectedDevice Is Nothing Then
            txt &= "<null>"
        Else
            txt &= x.SelectedDevice.DeviceName
        End If
        MessageBox_Show(Me, txt)
    End Sub


    Private Sub ButtonSetSvcF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSetSvcF.Click
        SetServiceState(False)
    End Sub
    Private Sub ButtonSetSvcT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSetSvcT.Click
        SetServiceState(True)
    End Sub
    Private Sub SetServiceState(ByVal state As Boolean)
        '----------------------------------------------
        ' Gather input from user controls
        '----------------------------------------------
        ' Device
        Dim selectedDevice As BluetoothDeviceInfo = GetSelectedDeviceInfo()
        If selectedDevice Is Nothing Then Exit Sub
        ' Service
        Dim svc As Guid = GetSelectedService()
        If Guid.Empty.Equals(svc) Then
            Beep()
            MessageBox_Show(Me, "Invalid Service UUID.")
            Return
        End If
        '--------
        Try
            selectedDevice.SetServiceState(svc, state, True)
        Catch pnsex As PlatformNotSupportedException
            MessageBox_Show(Me, pnsex.ToString(), "SetServiceState")
        Catch ex As System.ComponentModel.Win32Exception
            MessageBox_Show(Me, ex.ToString(), "SetServiceState")
        End Try
    End Sub

    Private Sub ButtonConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemClientConnect.Click
        If m_noBluetooth Then
            Beep()
            Return
        End If
        If m_cli.Connected Then
            MessageBox_Show(Me, "Already connected.")
            Return
        End If
        If m_connecting Then
            Beep()
            MessageBox_Show(Me, "Already connected..")
            Return
        End If
        '----------------------------------------------
        ' Gather input from user controls
        '----------------------------------------------
        ' Device
        Dim selectedDevice As BluetoothDeviceInfo = GetSelectedDeviceInfo()
        If selectedDevice Is Nothing Then Exit Sub
        ' Service
        Dim svc As Guid = GetSelectedService()
        If Guid.Empty.Equals(svc) Then
            Beep()
            MessageBox_Show(Me, "Invalid Service UUID.")
            Return
        End If
        ' Settings
        System.Diagnostics.Debug.Assert(Not m_cli.Authenticate, "should have not been set directly...")
        If Me.CheckBoxAuthenticate.Checked Then
            m_cli.Authenticate = Me.CheckBoxAuthenticate.Checked
        End If
        System.Diagnostics.Debug.Assert(Not m_cli.Encrypt, "should have not been set directly...")
        If Me.CheckBoxEncrypt.Checked Then
            m_cli.Encrypt = Me.CheckBoxEncrypt.Checked
        End If
        If Me.CheckBoxUsePin.Checked Then
            m_cli.SetPin(TextBoxPin.Text)
        End If
        '
        Try
            m_encoding = System.Text.Encoding.GetEncoding(comboBoxEncoding.Text)
        Catch ex As ArgumentException
            MessageBox_Show(Me, "Unknown Encoding.")
            newBluetoothClient()
            Return
        End Try
        '
        '----------------------------------------------
        ' Prepare the UI
        '----------------------------------------------
        textBoxReceive.Text = String.Empty

        '----------------------------------------------
        ' Connect etc
        '----------------------------------------------
        m_disconnecting = False
        labelState.Text = "Connecting..."
        Try
#If NON_ASYNC_CONNECT Then
            m_cli.Connect(selectedDevice.DeviceAddress, svc)
            DoneConnect()
#Else
            Dim cbk As AsyncCallback = New AsyncCallback(AddressOf ConnectCallback)
            m_connecting = True
            m_cli.BeginConnect(selectedDevice.DeviceAddress, svc, cbk, Nothing)
#End If
        Catch sex As System.Net.Sockets.SocketException
            Dim msg As String = "Connect failed: " _
                    + sex.ErrorCode.ToString() _
                    + " (" + sex.ErrorCode.ToString("D") + "); " _
                    + sex.Message
            MessageBox_Show(Me, msg)
            labelState.Text = msg
            newBluetoothClient()
            Return
        End Try
    End Sub

    Sub ConnectCallback(ByVal ar As IAsyncResult)
        Dim uiUpdate As New EventHandler(AddressOf ConnectCallback__Invokee)
        m_IR_ar = ar
        If Me.InvokeRequired Then
            labelState.Invoke(uiUpdate) ', ar)
        Else
            uiUpdate(Me, EventArgs.Empty)
        End If
    End Sub
    Private m_IR_ar As IAsyncResult
    Private Sub ConnectCallback__Invokee(ByVal sender As Object, ByVal e As EventArgs)
        Dim ar As IAsyncResult
        ar = m_IR_ar
        'DLGTDim uiUpdate As EventHandler
        Try
            m_cli.EndConnect(ar)
            m_connecting = False
            ' Using goto is ok in error handling situations...
            GoTo connectSuccess
        Catch nrex As NullReferenceException
            ' Close() on IrDAClient sets its socket to null, so EndConnect throws...
            'System.Diagnostics.Debug.Assert(nrex.Message == "foo")
            'DLGTuiUpdate = delegate {
            labelState.Text = "Connect cancelled."
            'DLGT}
        Catch odEx As ObjectDisposedException
            ' Just before the client's internal socket instance is set to null 
            ' (see the catch above) is is Disposes so catch the resultant error.
            'DLGTuiUpdate = delegate {
            labelState.Text = "Connect cancelled."
            'DLGT}
        Catch sex As System.Net.Sockets.SocketException
            'DLGTuiUpdate = delegate {
            Dim msg As String = "Connect failed: " _
                + sex.ErrorCode.ToString() _
                + " (" + sex.ErrorCode.ToString("D") + ") " _
                + sex.Message
            MessageBox_Show(Me, msg)
            labelState.Text = msg
            'DLGT}
        End Try
        ' Dropped out of one of the exception handlers, exit after updating...
        'UI thread-safe
        'DLGTIf labelState.InvokeRequired Then
        'DLGT    labelState.Invoke(uiUpdate)
        'DLGTElse
        'DLGT    uiUpdate(labelState, Nothing)
        'DLGTEnd If
        newBluetoothClient()
        Return
        '-------------------------------
        ' Successful Connection.
connectSuccess:
        'Dim selectedMode as IrProtocol = CType(ar.AsyncState, IrProtocol)
        DoneConnect()
    End Sub

    Private Sub DoneConnect()
        Dim uiUpdate As New EventHandler(AddressOf DoneConnect__Invokee)
        If Me.InvokeRequired Then
            labelState.Invoke(uiUpdate)
        Else
            uiUpdate(Me, New EventArgs())
        End If
    End Sub
    Private Sub DoneConnect__Invokee(ByVal sender As Object, ByVal e As EventArgs)
        m_strm = m_cli.GetStream()
        m_wtr = New System.IO.StreamWriter(m_strm, m_encoding)

        '----------------------------------------------
        ' Update the UI
        '----------------------------------------------
        'DLGTDim uiUpdate as EventHandler = delegate {
        labelState.Text = "Connected"
        ' Display the maximum send size where relevant.
        'if selectedMode == IrProtocol.IrLMP then
        '    Dim objValue As Object = m_cli.Client.GetSocketOption( _
        '        IrDASocketOptionLevel.IrLmp, IrDASocketOptionName.SendPduLength)
        '    int sendPduLength = (int)objValue
        '    labelSendPduLength.Text = sendPduLength.ToString()
        '    else {
        'labelSendPduLength.Text = "N/A"
        '    }
        textBoxSend.Focus()
        'DLGT}
        'UI thread-safe
        'DLGTIf labelState.InvokeRequired Then
        'DLGT    labelState.Invoke(uiUpdate)
        'DLGTElse
        'DLGT    uiUpdate(Me, New EventArgs())
        'DLGTEnd If

        '----------------------------------------------
        ' Start the receive thread.
        '----------------------------------------------
        System.Threading.ThreadPool.QueueUserWorkItem(AddressOf receiveThreadFn)
    End Sub


    Private Sub CheckBoxAuthenticate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxAuthenticate.CheckStateChanged
        If (Not m_cli Is Nothing) AndAlso m_cli.Connected Then
            m_cli.Authenticate = Me.CheckBoxAuthenticate.Checked
        End If
    End Sub

    Private Sub CheckBoxEncrypt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxEncrypt.CheckStateChanged
        If (Not m_cli Is Nothing) AndAlso m_cli.Connected Then
            m_cli.Encrypt = Me.CheckBoxEncrypt.Checked
        End If
    End Sub

    Private Sub CheckBoxUsePin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxUsePin.CheckStateChanged
        Debug.Assert(Me.CheckBoxUsePin.Checked <> Me.TextBoxPin.Enabled)
        Me.TextBoxPin.Enabled = Me.CheckBoxUsePin.Checked
    End Sub

    ''------------------------------------------------------------------
    Private Sub buttonSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        If m_wtr Is Nothing _
                OrElse m_wtr.BaseStream Is Nothing _
                OrElse Not m_wtr.BaseStream.CanWrite Then
            MessageBox_Show(Me, "Not connected.")
        Else
            ' Assume v.25ter, so use a CR.
            Dim str As String = textBoxSend.Text + vbCr
            Try
                m_wtr.Write(str)
                m_wtr.Flush()
            Catch ioex As System.IO.IOException
                Dim sex As SocketException = TryCast_SocketException(ioex.InnerException)
                If Not sex Is Nothing Then
                    Dim Err As Integer = sex.ErrorCode
                    receiveAppend("!! Send SocketException: " _
                        + Err.ToString() + " (" + Err.ToString("D") _
                        + ") " + ioex.Message)
                Else
                    receiveAppend("!! Send IOException: " + ioex.Message)
                End If
                newBluetoothClient()
            End Try
        End If
    End Sub

    Sub receiveThreadFn(ByVal state As Object)
        receiveThreadFn()
    End Sub
    Sub receiveThreadFn()
        If Not m_cli.Connected _
                OrElse m_strm Is Nothing _
                OrElse Not m_strm.CanRead Then
            Beep()
            Return
        End If

        Dim rdr As System.IO.StreamReader = New System.IO.StreamReader(m_strm, m_encoding)
        Dim buf(99) As Char
        Try
            While True
                ' We don't use ReadLine because we then don't get to see the 
                ' CR and LF characters.  And we often get the series \r\r\n 
                ' which should appear as one new line, but would appear as two 
                ' if we did textBox.Append("\n") each ReadLine.
                Dim numRead As Integer = rdr.Read(buf, 0, buf.Length)
                If numRead = 0 Then
                    newBluetoothClient()
                    Return
                End If
                Dim str As String = New String(buf, 0, numRead)
                receiveAppend(str)
            End While
        Catch ioex As System.IO.IOException
            If Not m_disconnecting Then
                Dim sex As SocketException = TryCast_SocketException(ioex.InnerException)
                If Not sex Is Nothing Then
                    Dim Err As Integer = sex.ErrorCode
                    receiveAppend("!! SocketException: " _
                            + Err.ToString() + " (" + Err.ToString("D") _
                            + ") " + ioex.Message)
                Else
                    receiveAppend("!! IOException: " + ioex.Message)
                End If
            End If
            newBluetoothClient()
        End Try
    End Sub

    Delegate Sub ReceiveAppendCallback___NOT_CFv1(ByVal str As String)

    ' UI thread-safe updating.
    Sub receiveAppend(ByVal str As String)
        If Me.InvokeRequired Then
            Dim d As EventHandler = New EventHandler(AddressOf receiveAppend__Invokee)
            m_IR_receiveAppend = str
            Me.Invoke(d) '..., New Object() {str})
        Else
            receiveAppend__Invokee(Me, EventArgs.Empty)
        End If
    End Sub
    Sub receiveAppend__Invokee(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String
        str = m_IR_receiveAppend
        textBoxReceive.Text += str
    End Sub
    Private m_IR_receiveAppend As String

#End Region '"Client"

#Region "Server"
    Private m_serverListener As BluetoothListener
    Private m_serverCli As BluetoothClient
    'Private m_serverLockCli As New Object 'To apply 'volatile' access to the m_devices shared field.
    '
    Private m_serverStrm As System.Net.Sockets.NetworkStream
    Private m_serverWtr As System.IO.StreamWriter
    Private m_serverEncoding As System.Text.Encoding
    Private m_serverAccepting As Boolean
    Private m_serverDisconnecting As Boolean
    '
    ' Its a [Flag] attribute, so multiple value can be combined
    Private m_selectedScs As ServiceClass
#If WinXP Then
    Dim m_ServerCodServiceClassesDialog As New FormSelectServiceClasses
#End If

    '--------------------------------------------------------------
    Sub newBluetoothServer()
        newBluetoothServerUpdateLabelStatus("Disconnecting...")
        If Not m_serverListener Is Nothing Then
            m_serverListener.Stop()
        End If
        If Not m_serverCli Is Nothing Then
            m_serverCli.Close()
            ' After Close() calling Connect fails with NRE, so delete the client itself.
            m_serverCli = Nothing
        End If
        newBluetoothServerUpdateLabelStatus("Disconnected")
    End Sub
    Sub newBluetoothServerUpdateLabelStatus(ByVal text As String)
        If Me.InvokeRequired Then
            Dim d As EventHandler = New EventHandler(AddressOf newBluetoothServerUpdateLabelStatus__Invokee)
            m_IR_newBluetoothServerUpdateLabelStatus = text
            Me.Invoke(d) '..., New Object() {text})
        Else
            LabelServerState.Text = text
        End If
    End Sub
    Sub newBluetoothServerUpdateLabelStatus__Invokee(ByVal sender As Object, ByVal e As EventArgs)
        Dim text As String
        text = m_IR_newBluetoothServerUpdateLabelStatus
        LabelServerState.Text = text
    End Sub
    Private m_IR_newBluetoothServerUpdateLabelStatus As String

    '--------------------------------------------------------------
    Sub Form1Server_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ComboBoxServerServices.ValueMember = "Value"
        Me.ComboBoxServerServices.DisplayMember = "Name"
        Me.ComboBoxServerServices.DataSource = BluetoothServiceItem.GetWellKnownServices
        Me.ComboBoxServerServices.SelectedItem = New BluetoothServiceItem(BluetoothService.SerialPort, "tmp")
        '
        If Environment.OSVersion.Platform = PlatformID.Win32NT _
        OrElse Environment.OSVersion.Platform = PlatformID.Win32Windows Then
            ' Only the full framework supports encoding x-IA5, NETCF and Mono don't.
            ComboBoxServerEncoding.SelectedIndex = 0
        Else
            ComboBoxServerEncoding.SelectedIndex = 3
        End If
        '
        LabelServerState.Text = "Disconnected"
        '
        m_serverCli = New BluetoothClient
#If HAVE_ServerCodServices Then
        RefreshServerCodServicesUi()
#End If
    End Sub

    '--------------------------------------------------------------
    Function GetServerSelectedService() As Guid
        Dim svc As Guid
        '
        If Not Me.ComboBoxServerServices.SelectedItem Is Nothing Then
            Dim btStdSvc As BluetoothServiceItem
            btStdSvc = CType(Me.ComboBoxServerServices.SelectedItem, BluetoothServiceItem)
            svc = btStdSvc.Uuid
            Return svc
        End If
        '
        Dim svcText As String = Me.ComboBoxServerServices.Text
        Try
            svc = New Guid(svcText) ' Parse!
            Return svc
        Catch ofex As OverflowException
        Catch fmtex As FormatException
            ' TODO if users types space e.g. on selecting a standard service then 
            ' SelectedItem is null, we should find the last whitespace-separated
            ' piece of text and try and parse it...
        End Try
        Return Guid.Empty
    End Function

    Private Sub ButtonServerListen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemServerListen.Click
        If (Not m_serverCli Is Nothing) AndAlso m_serverCli.Connected Then
            MessageBox_Show(Me, "Already connected.")
            Return
        End If
        If m_serverAccepting Then
            Beep()
            MessageBox_Show(Me, "Already connected..")
            Return
        End If
        '----------------------------------------------
        ' Gather input from user controls
        '----------------------------------------------
        ' Service
        Dim svc As Guid = GetServerSelectedService()
        If Guid.Empty.Equals(svc) Then
            Beep()
            MessageBox_Show(Me, "Invalid Service UUID.")
            Return
        End If
        '
        m_serverDisconnecting = False
        LabelServerState.Text = "Listening..."
        Dim phase As String = "Pre!"
        phase = "Init"
        m_serverListener = New BluetoothListener(svc)
        m_serverListener.ServiceClass = m_selectedScs
        m_serverListener.ServiceName = "32feet.NET SdpBrowser"
        ' Settings
        System.Diagnostics.Debug.Assert(Not m_serverListener.Authenticate, "should have not been set directly...")
        If Me.CheckBoxServerAuthenticate.Checked Then
            m_serverListener.Authenticate = Me.CheckBoxServerAuthenticate.Checked
        End If
        System.Diagnostics.Debug.Assert(Not m_serverListener.Encrypt, "should have not been set directly...")
        If Me.CheckBoxServerEncrypt.Checked Then
            m_serverListener.Encrypt = Me.CheckBoxServerEncrypt.Checked
        End If
        If Me.CheckBoxUsePin.Checked Then
            'TODO m_serverListener.Pin = Me.TextBoxServerPin.Text
        End If
        '
        Try
            m_serverEncoding = System.Text.Encoding.GetEncoding(ComboBoxServerEncoding.Text)
        Catch ex As ArgumentException
            MessageBox_Show(Me, "Unknown Encoding.")
            newBluetoothServer()
            Return
        End Try
        '
        '----------------------------------------------
        ' Prepare the UI
        '----------------------------------------------
        TextBoxServerReceive.Text = String.Empty

        '----------------------------------------------
        ' Connect etc
        '----------------------------------------------
        'm_serverDisconnecting = False
        'LabelServerState.Text = "Connecting..."
        'Dim phase As String = "Pre!"
        Try
            'phase = "Init"
            'm_serverListener = New BluetoothListener(svc)
            phase = "Bind"
            m_serverListener.Start()
            '
            phase = "Begin Accept"
            Dim cbk As AsyncCallback = New AsyncCallback(AddressOf ServerAcceptCallback)
            m_serverAccepting = True
            m_serverListener.BeginAcceptBluetoothClient(cbk, Nothing)
        Catch sex As System.Net.Sockets.SocketException
            Dim msg As String = phase + " failed: " _
                    + " (" + sex.ErrorCode.ToString("D") + "); " _
                    + sex.Message
            ' ...+ sex.SocketErrorCode.ToString() _ ...
            MessageBox_Show(Me, msg)
            LabelServerState.Text = msg
            newBluetoothServer()
            Return
        End Try
    End Sub

    Private Sub ButtonServerDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemServerDisconnect.Click
        m_serverDisconnecting = True
        newBluetoothServer()
    End Sub

    Sub ServerAcceptCallback(ByVal ar As IAsyncResult)
        Dim uiUpdate As New EventHandler(AddressOf ServerAcceptCallback__Invokee)
        m_ServerAcceptCallback_ar = ar
        If InvokeRequired Then
            labelState.Invoke(uiUpdate) '..., ar)
        Else
            uiUpdate(Nothing, Nothing)
        End If
    End Sub
    Private m_ServerAcceptCallback_ar As IAsyncResult
    Private Sub ServerAcceptCallback__Invokee(ByVal sender As Object, ByVal e As EventArgs)
        Dim ar As IAsyncResult = m_ServerAcceptCallback_ar
        'DLGTDim uiUpdate As EventHandler
        Try
            m_serverAccepting = False
            m_serverCli = m_serverListener.EndAcceptBluetoothClient(ar)
            ' Using goto is ok in error handling situations...
            GoTo acceptSuccess
        Catch odex As ObjectDisposedException
            'hack !!!! wrong BtLsnr exit exception type on Widcomm !!!!
            If m_serverDisconnecting Then
                Debug.Assert(-1 <> odex.Message.IndexOf( _
                        "Network"), _
                    "Unexpected ArgEx")
            Else
                Throw
            End If
        Catch argex As ArgumentException
            If m_serverDisconnecting Then
                ' When lsnr.Stop() is called, it creates a new socket internally and
                ' therefor calling EndAccept fails...
                Debug.Assert(argex.Message.StartsWith( _
                        "The IAsyncResult object was not returned from the corresponding asynchronous method on this class."), _
                    "Unexpected ArgEx")
            Else
                Throw
            End If
            'Catch nrex As NullReferenceException
            '    ' Close() on IrDAClient sets its socket to null, so EndConnect throws...
            '    'System.Diagnostics.Debug.Assert(nrex.Message == "foo")
            '    'DLGTuiUpdate = delegate {
            '    LabelServerState.Text = "Connect cancelled."
            '    'DLGT}
            'Catch odEx As ObjectDisposedException
            '    ' Just before the client's internal socket instance is set to null 
            '    ' (see the catch above) is is Disposes so catch the resultant error.
            '    'DLGTuiUpdate = delegate {
            '    LabelServerState.Text = "Listening cancelled."
            '    'DLGT}
        Catch sex As System.Net.Sockets.SocketException
            'DLGTuiUpdate = delegate {
            Dim msg As String = "Accept failed: " _
                + " (" + sex.ErrorCode.ToString("D") + ") " _
                + sex.Message
            '...+ sex.SocketErrorCode.ToString() _...
            MessageBox_Show(Me, msg)
            LabelServerState.Text = msg
            'DLGT}
        End Try
        ' Dropped out of one of the exception handlers, exit after updating...
        'UI thread-safe
        'DLGTIf labelState.InvokeRequired Then
        'DLGT    labelState.Invoke(uiUpdate)
        'DLGTElse
        'DLGT    uiUpdate(labelState, Nothing)
        'DLGTEnd If
        newBluetoothServer()
        Return
        '-------------------------------
        ' Successful Connection.
acceptSuccess:
        ' Just accept one connection then stop listening.
        m_serverListener.Stop()
        m_serverListener = Nothing
        ServerDoneAccept()
    End Sub

    Private Sub ServerDoneAccept()
        Dim uiUpdate As New EventHandler(AddressOf ServerDoneAccept__Invokee)
        If InvokeRequired Then
            LabelServerState.Invoke(uiUpdate)
        Else
            uiUpdate(Me, New EventArgs())
        End If
    End Sub
    Private Sub ServerDoneAccept__Invokee(ByVal sender As Object, ByVal e As EventArgs)
        m_serverStrm = m_serverCli.GetStream()
        m_serverWtr = New System.IO.StreamWriter(m_serverStrm, m_serverEncoding)

        '----------------------------------------------
        ' Update the UI
        '----------------------------------------------
        'DLGTDim uiUpdate as EventHandler = delegate {
        LabelServerState.Text = "Connected"
        TextBoxServerSend.Focus()
        'DLGT}
        'UI thread-safe
        'DLGTIf labelState.InvokeRequired Then
        'DLGT    labelState.Invoke(uiUpdate)
        'DLGTElse
        'DLGT    uiUpdate(Me, New EventArgs())
        'DLGTEnd If

        '----------------------------------------------
        ' Start the receive thread.
        '----------------------------------------------
        System.Threading.ThreadPool.QueueUserWorkItem(AddressOf serverReceiveThreadFn)
    End Sub


    Private Sub CheckBoxServerAuthenticate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxServerAuthenticate.CheckStateChanged
        If Not m_serverCli Is Nothing AndAlso m_serverCli.Connected Then
            m_serverCli.Authenticate = Me.CheckBoxServerAuthenticate.Checked
        End If
    End Sub

    Private Sub CheckBoxServerEncrypt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxServerEncrypt.CheckStateChanged
        If Not m_serverCli Is Nothing AndAlso m_serverCli.Connected Then
            m_serverCli.Encrypt = Me.CheckBoxServerEncrypt.Checked
        End If
    End Sub

    Private Sub CheckBoxServerUsePin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxServerUsePin.CheckStateChanged
        Debug.Assert(Me.CheckBoxServerUsePin.Checked <> Me.TextBoxServerPin.Enabled)
        Me.TextBoxServerPin.Enabled = Me.CheckBoxServerUsePin.Checked
        ' When listening, set/reset the Pin immediately
        If (Not m_serverListener Is Nothing) AndAlso m_serverListener.Pending Then
            If Me.TextBoxPin.Enabled Then
                'TODO m_serverListener.Pin = Me.TextBoxPin.Text
            Else
                'TODO m_serverListener.Pin = Nothing
            End If
        End If
        ' When connected, set/reset the Pin immediately
        If (Not m_serverCli Is Nothing) AndAlso m_serverCli.Connected Then
            If Me.TextBoxPin.Enabled Then
                BluetoothSecurity.SetPin(CType(m_serverCli.Client.RemoteEndPoint, BluetoothEndPoint).Address, TextBoxPin.Text)
            Else
                'm_serverCli.Pin = Nothing
            End If
        End If
    End Sub

    ''------------------------------------------------------------------
    Private Sub buttonServerSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        If m_serverWtr Is Nothing _
                OrElse m_serverWtr.BaseStream Is Nothing _
                OrElse Not m_serverWtr.BaseStream.CanWrite Then
            MessageBox_Show(Me, "Not connected.")
        Else
            ' Assume v.25ter, so use a CR.
            Dim str As String = TextBoxServerSend.Text + vbCr
            Try
                m_serverWtr.Write(str)
                m_serverWtr.Flush()
            Catch ioex As System.IO.IOException
                Dim sex As SocketException = TryCast_SocketException(ioex.InnerException)
                If Not sex Is Nothing Then
                    'Dim Err As SocketError = sex.SocketErrorCode
                    serverReceiveAppend("!! Send SocketException: " _
                        & "(" + sex.ErrorCode.ToString("D") _
                        & ") " & ioex.Message)
                    '... + Err.ToString() + " (" + Err.ToString("D") _
                Else
                    serverReceiveAppend("!! Send IOException: " + ioex.Message)
                End If
                newBluetoothServer()
            End Try
        End If
    End Sub

    Sub serverReceiveThreadFn(ByVal state As Object)
        serverReceiveThreadFn()
    End Sub
    Sub serverReceiveThreadFn()
        If Not m_serverCli.Connected _
                OrElse m_serverStrm Is Nothing _
                OrElse Not m_serverStrm.CanRead Then
            Beep()
            Return
        End If
        '
#If Not FX1_1 And Debug Then
        System.Threading.Thread.CurrentThread.Name = "serverReceiveThreadFn"
#End If
        '
        Dim rdr As System.IO.StreamReader = New System.IO.StreamReader(m_serverStrm, m_serverEncoding)
        Dim buf(99) As Char
        Try
            While True
                ' We don't use ReadLine because we then don't get to see the 
                ' CR and LF characters.  And we often get the series \r\r\n 
                ' which should appear as one new line, but would appear as two 
                ' if we did textBox.Append("\n") each ReadLine.
                Dim numRead As Integer = rdr.Read(buf, 0, buf.Length)
                If numRead = 0 Then
                    newBluetoothServer()
                    Return
                End If
                Dim str As String = New String(buf, 0, numRead)
                serverReceiveAppend(str)
#If False Then
                try ' TODO !!!!! CheckBoxServerLoopback.Checked cross-thread UI access
                    If CheckBoxServerLoopback.Checked Then
                        ' !! What's the thread-safety of this?
                        m_serverWtr.Write(buf, 0, numRead)
                        m_serverWtr.Flush()
                    End If
                catch ex as notsupportedexception
                    '
                    Debug.Fail(ex.tostring)
                end try
#End If
            End While
        Catch ioex As System.IO.IOException
            If Not m_serverDisconnecting Then
                Dim sex As SocketException = TryCast_SocketException(ioex.InnerException)
                If Not sex Is Nothing Then
                    'Dim Err As SocketError = sex.SocketErrorCode
                    serverReceiveAppend("!! SocketException: " _
                        & "( " + sex.ErrorCode.ToString("D") _
                        & ") " + ioex.Message)
                    '...& Err.ToString() & " (" + Err.ToString("D") _
                Else
                    serverReceiveAppend("!! IOException: " + ioex.Message)
                End If
            End If
            newBluetoothClient()
        End Try
    End Sub

    'Delegate Sub ReceiveAppendCallback(ByVal str As String)

    ' UI thread-safe updating.
    Sub serverReceiveAppend(ByVal str As String)
        m_IR_serverReceiveAppend = str
        If Me.InvokeRequired Then
            Dim d As EventHandler = New EventHandler(AddressOf serverReceiveAppend__Invokee)
            Me.Invoke(d) '..., New Object() {str})
        Else
            serverReceiveAppend__Invokee(Nothing, Nothing)
        End If
    End Sub
    Sub serverReceiveAppend__Invokee(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String
        str = m_IR_serverReceiveAppend
        TextBoxServerReceive.Text += str
    End Sub
    Private m_IR_serverReceiveAppend As String

#If HAVE_ServerCodServices Then
    Private Sub TextBoxServerCodServices_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxServerCodServices.DoubleClick
        m_ServerCodServiceClassesDialog.SelectedServiceClasses = m_selectedScs
        Dim rslt As DialogResult = m_ServerCodServiceClassesDialog.ShowDialog(Me)
        'MessageBox.Show( _
        '    String.Format("rslt: {0}, val: {1}", rslt, m_ServerCodServiceClassesDialog.SelectedServiceClasses))
        If rslt = Windows.Forms.DialogResult.OK Then
            m_selectedScs = m_ServerCodServiceClassesDialog.SelectedServiceClasses
        End If
        RefreshServerCodServicesUi()
    End Sub

    Sub RefreshServerCodServicesUi()
        If m_selectedScs.ToString() = "Unknown" Then 'hack m_selectedScs.ToString() = "Unknown"
            Me.TextBoxServerCodServices.Text = "None" & " ..."
        Else
            Me.TextBoxServerCodServices.Text = m_selectedScs.ToString() & " ..."
        End If
    End Sub
#End If

#End Region '"Server"

End Class


Class XxxxxData_CompleteThirdPartyRecords

    Public Shared ReadOnly Xp1Sdp As Byte() = { _
        &H35, &H98, &H9, &H0, &H0, &HA, &H0, &H0, &H0, &H0, &H9, &H0, &H1, &H35, &H3, &H19, _
        &H10, &H0, &H9, &H0, &H4, &H35, &HD, &H35, &H6, &H19, &H1, &H0, &H9, &H0, &H1, &H35, _
        &H3, &H19, &H0, &H1, &H9, &H0, &H5, &H35, &H3, &H19, &H10, &H2, &H9, &H0, &H6, &H35, _
        &H9, &H9, &H65, &H6E, &H9, &H0, &H6A, &H9, &H1, &H0, &H9, &H1, &H0, &H25, &H12, &H53, _
        &H65, &H72, &H76, &H69, &H63, &H65, &H20, &H44, &H69, &H73, &H63, &H6F, &H76, &H65, &H72, &H79, _
        &H0, &H9, &H1, &H1, &H25, &H25, &H50, &H75, &H62, &H6C, &H69, &H73, &H68, &H65, &H73, &H20, _
        &H73, &H65, &H72, &H76, &H69, &H63, &H65, &H73, &H20, &H74, &H6F, &H20, &H72, &H65, &H6D, &H6F, _
        &H74, &H65, &H20, &H64, &H65, &H76, &H69, &H63, &H65, &H73, &H0, &H9, &H1, &H2, &H25, &HA, _
        &H4D, &H69, &H63, &H72, &H6F, &H73, &H6F, &H66, &H74, &H0, &H9, &H2, &H0, &H35, &H3, &H9, _
        &H1, &H0, &H9, &H2, &H1, &HA, &H0, &H0, &H0, &H1 _
    }

    Public Shared ReadOnly XpFsquirtOpp As Byte() = { _
        &H35, &H4A, &H9, &H0, &H0, &HA, &H0, &H1, &H0, &HB, &H9, &H0, &H1, &H35, &H3, &H19, _
        &H11, &H5, &H9, &H0, &H4, &H35, &H11, &H35, &H3, &H19, &H1, &H0, &H35, &H5, &H19, &H0, _
        &H3, &H8, &H1, &H35, &H3, &H19, &H0, &H8, &H9, &H0, &H5, &H35, &H3, &H19, &H10, &H2, _
        &H9, &H1, &H0, &H25, &H10, &H4F, &H42, &H45, &H58, &H20, &H4F, &H62, &H6A, &H65, &H63, &H74, _
        &H20, &H50, &H75, &H73, &H68, &H9, &H3, &H3, &H35, &H2, &H8, &HFF _
    }

    Public Shared ReadOnly SonyEricssonMv100_Opp As Byte() = { _
        &H35, &H34, &H9, &H0, &H0, &HA, &H0, &H1, &H0, &H0, &H9, &H0, &H1, &H35, &H3, &H19, _
        &H11, &H5, &H9, &H0, &H4, &H35, &H11, &H35, &H3, &H19, &H1, &H0, &H35, &H5, &H19, &H0, _
        &H3, &H8, &H1, &H35, &H3, &H19, &H0, &H8, &H9, &H1, &H0, &H25, &H3, &H4F, &H50, &H50, _
        &H9, &H3, &H3, &H35, &H1, &H0 _
    }
    Public Shared ReadOnly SonyEricssonMv100_Ftp As Byte() = { _
        &H35, &H2E, &H9, &H0, &H0, &HA, &H0, &H1, &H0, &H1, &H9, &H0, &H1, &H35, &H3, &H19, _
        &H11, &H6, &H9, &H0, &H4, &H35, &H11, &H35, &H3, &H19, &H1, &H0, &H35, &H5, &H19, &H0, _
        &H3, &H8, &H2, &H35, &H3, &H19, &H0, &H8, &H9, &H1, &H0, &H25, &H3, &H46, &H54, &H50 _
    }
    Public Shared ReadOnly SonyEricssonMv100_Imaging_hasUint64 As Byte() = { _
        &H35, &H5A, &H9, &H0, &H0, &HA, &H0, &H1, &H0, &H2, &H9, &H0, &H1, &H35, &H3, &H19, _
        &H11, &H1B, &H9, &H0, &H4, &H35, &H11, &H35, &H3, &H19, &H1, &H0, &H35, &H5, &H19, &H0, _
        &H3, &H8, &H3, &H35, &H3, &H19, &H0, &H8, &H9, &H0, &H9, &H35, &H8, &H35, &H6, &H19, _
        &H11, &H1A, &H9, &H1, &H0, &H9, &H1, &H0, &H25, &H3, &H42, &H49, &H50, &H9, &H3, &H10, _
        &H8, &H1, &H9, &H3, &H11, &H9, &H0, &H1, &H9, &H3, &H12, &HA, &H0, &H0, &H0, &H3, _
        &H9, &H3, &H13, &HB, &H80, &H96, &H98, &H0, &H0, &H0, &H0, &H0 _
    }

End Class
