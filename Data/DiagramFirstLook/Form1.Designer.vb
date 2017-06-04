
Namespace DiagramFirstLook
    Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim radListDataItem1 As New Telerik.WinControls.UI.RadListDataItem()
            Dim radListDataItem2 As New Telerik.WinControls.UI.RadListDataItem()
            Me.radPropertyGrid1 = New Telerik.WinControls.UI.RadPropertyGrid()
            Me.radDiagramToolbox1 = New Telerik.WinControls.UI.RadDiagramToolbox()
            Me.radDiagram1 = New Telerik.WinControls.UI.RadDiagram()
            Me.diagramRibbonBar1 = New Telerik.WinControls.UI.DiagramRibbonBar()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
            Me.dropDownExample = New Telerik.WinControls.UI.RadDropDownListElement()
            Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
            DirectCast(Me.radPropertyGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radDiagramToolbox1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.diagramRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.diagramRibbonBar1.SuspendLayout()
            DirectCast(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            DirectCast(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox2.SuspendLayout()
            DirectCast(Me.dropDownExample, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' radPropertyGrid1
            ' 
            Me.radPropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPropertyGrid1.Location = New System.Drawing.Point(2, 18)
            Me.radPropertyGrid1.Name = "radPropertyGrid1"
            Me.radPropertyGrid1.Size = New System.Drawing.Size(196, 524)
            Me.radPropertyGrid1.TabIndex = 2
            Me.radPropertyGrid1.Text = "radPropertyGrid1"
            Me.radPropertyGrid1.ToolbarVisible = True
            ' 
            ' radDiagramToolbox1
            ' 
            Me.radDiagramToolbox1.AllowDragDrop = True
            Me.radDiagramToolbox1.AllowDrop = True
            Me.radDiagramToolbox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radDiagramToolbox1.FullRowSelect = False
            Me.radDiagramToolbox1.ItemSize = New System.Drawing.Size(80, 80)
            Me.radDiagramToolbox1.ItemSpacing = 10
            Me.radDiagramToolbox1.Location = New System.Drawing.Point(2, 18)
            Me.radDiagramToolbox1.Name = "radDiagramToolbox1"
            Me.radDiagramToolbox1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
            Me.radDiagramToolbox1.Size = New System.Drawing.Size(194, 524)
            Me.radDiagramToolbox1.TabIndex = 1
            Me.radDiagramToolbox1.Text = "radDiagramToolbox1"
            Me.radDiagramToolbox1.ViewType = Telerik.WinControls.UI.ListViewType.IconsView
            DirectCast(Me.radDiagramToolbox1.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).TextAlignment = System.Drawing.ContentAlignment.TopCenter
            DirectCast(Me.radDiagramToolbox1.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).Padding = New System.Windows.Forms.Padding(5, 10, 0, 0)
            ' 
            ' radDiagram1
            ' 
            Me.radDiagram1.Anchor = DirectCast((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radDiagram1.DisplayMemberPath = Nothing
            Me.radDiagram1.Location = New System.Drawing.Point(194, 162)
            Me.radDiagram1.Name = "radDiagram1"
            Me.radDiagram1.SerializedXml = resources.GetString("radDiagram1.SerializedXml")
            Me.radDiagram1.Size = New System.Drawing.Size(793, 544)
            Me.radDiagram1.TabIndex = 3
            Me.radDiagram1.Text = "radDiagram1"
            ' 
            ' diagramRibbonBar1
            ' 
            Me.diagramRibbonBar1.AssociatedDiagram = Me.radDiagram1
            Me.diagramRibbonBar1.Controls.Add(Me.radDropDownList1)
            Me.diagramRibbonBar1.IsInDesignTime = False
            Me.diagramRibbonBar1.Location = New System.Drawing.Point(0, 0)
            Me.diagramRibbonBar1.Name = "diagramRibbonBar1"
            Me.diagramRibbonBar1.Size = New System.Drawing.Size(1185, 162)
            Me.diagramRibbonBar1.TabIndex = 0
            Me.diagramRibbonBar1.Text = "Form1"
            ' 
            ' radGroupBox1
            ' 
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.Controls.Add(Me.radDiagramToolbox1)
            Me.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Left
            Me.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
            Me.radGroupBox1.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Center
            Me.radGroupBox1.HeaderText = "Toolbox"
            Me.radGroupBox1.Location = New System.Drawing.Point(0, 162)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Size = New System.Drawing.Size(198, 544)
            Me.radGroupBox1.TabIndex = 4
            Me.radGroupBox1.Text = "Toolbox"
            ' 
            ' radGroupBox2
            ' 
            Me.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox2.Controls.Add(Me.radPropertyGrid1)
            Me.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Right
            Me.radGroupBox2.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
            Me.radGroupBox2.HeaderText = "Properties"
            Me.radGroupBox2.Location = New System.Drawing.Point(985, 162)
            Me.radGroupBox2.Name = "radGroupBox2"
            Me.radGroupBox2.Size = New System.Drawing.Size(200, 544)
            Me.radGroupBox2.TabIndex = 5
            Me.radGroupBox2.Text = "Properties"
            ' 
            ' dropDownExample
            ' 
            Me.dropDownExample.AutoCompleteAppend = Nothing
            Me.dropDownExample.AutoCompleteDataSource = Nothing
            Me.dropDownExample.AutoCompleteSuggest = Nothing
            Me.dropDownExample.DataMember = ""
            Me.dropDownExample.DataSource = Nothing
            Me.dropDownExample.DefaultValue = Nothing
            Me.dropDownExample.DisplayMember = ""
            Me.dropDownExample.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InQuad
            Me.dropDownExample.DropDownAnimationEnabled = True
            Me.dropDownExample.EditableElementText = ""
            Me.dropDownExample.EditorElement = Me.dropDownExample
            Me.dropDownExample.EditorManager = Nothing
            Me.dropDownExample.Filter = Nothing
            Me.dropDownExample.FilterExpression = ""
            Me.dropDownExample.Focusable = True
            Me.dropDownExample.FormatString = ""
            Me.dropDownExample.FormattingEnabled = True
            Me.dropDownExample.ItemHeight = 18
            Me.dropDownExample.MaxDropDownItems = 0
            Me.dropDownExample.MaxLength = 32767
            Me.dropDownExample.MaxValue = Nothing
            Me.dropDownExample.MinValue = Nothing
            Me.dropDownExample.Name = "dropDownExample"
            Me.dropDownExample.NullValue = Nothing
            Me.dropDownExample.OwnerOffset = 0
            Me.dropDownExample.ShowImageInEditorArea = True
            Me.dropDownExample.SortStyle = Telerik.WinControls.Enumerations.SortStyle.None
            Me.dropDownExample.Value = Nothing
            Me.dropDownExample.ValueMember = ""
            ' 
            ' radDropDownList1
            ' 
            Me.radDropDownList1.Anchor = DirectCast((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            radListDataItem1.Tag = "radDiagram1.SerializedXml"
            radListDataItem1.Text = "Example 1"
            radListDataItem2.Tag = "String1"
            radListDataItem2.Text = "Example 2"
            Me.radDropDownList1.Items.Add(radListDataItem1)
            Me.radDropDownList1.Items.Add(radListDataItem2)
            Me.radDropDownList1.Location = New System.Drawing.Point(970, 35)
            Me.radDropDownList1.Name = "radDropDownList1"
            Me.radDropDownList1.Size = New System.Drawing.Size(196, 20)
            Me.radDropDownList1.TabIndex = 4

            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1185, 706)
            Me.Controls.Add(Me.radGroupBox2)
            Me.Controls.Add(Me.radGroupBox1)
            Me.Controls.Add(Me.radDiagram1)
            Me.Controls.Add(Me.diagramRibbonBar1)
            Me.Name = "Form1"
            ' 
            ' 
            ' 
            Me.RootElement.ApplyShapeToControl = True
            Me.Text = "Form1"
            DirectCast(Me.radPropertyGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radDiagramToolbox1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.diagramRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.diagramRibbonBar1.ResumeLayout(False)
            Me.diagramRibbonBar1.PerformLayout()
            DirectCast(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            DirectCast(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox2.ResumeLayout(False)
            DirectCast(Me.dropDownExample, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private diagramRibbonBar1 As Telerik.WinControls.UI.DiagramRibbonBar
        Private radDiagramToolbox1 As Telerik.WinControls.UI.RadDiagramToolbox
        Private radPropertyGrid1 As Telerik.WinControls.UI.RadPropertyGrid
        Private radDiagram1 As Telerik.WinControls.UI.RadDiagram
        Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
        Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
        Private dropDownExample As Telerik.WinControls.UI.RadDropDownListElement
        Private radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
    End Class
End Namespace


'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
