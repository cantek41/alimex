
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.Themes
Imports Telerik.WinControls.UI
Imports Telerik.Windows.Diagrams.Core
Imports System

Namespace DiagramFirstLook

    Partial Public Class Form1
        Inherits RadRibbonForm

        Private timer As New Timer()

        Public Sub New()
            InitializeComponent()
            CustomizeExampleAppearance()
        End Sub



        Private Sub CustomizeExampleAppearance()
            Me.radDropDownList1.SelectedIndex = 0

            If Program.themeName <> "" Then
                'set the example theme to the same theme QSF uses
                ThemeResolutionService.ApplicationThemeName = Program.themeName
            Else
                ThemeResolutionService.ApplicationThemeName = "TelerikMetro"
            End If

            Select Case Program.exampleName
                Case "Gap"
                    Me.radDropDownList1.SelectedIndex = 4
                    Me.toolWindow3.Hide()
                    Me.radDropDownList1.Visible = False
                    Me.diagramRibbonBar1.dropDownGapMode.SelectedIndex = 2
                    Exit Select
                Case "Routing"
                    Me.radDropDownList1.SelectedIndex = 3
                    Me.radDropDownList1.Visible = False
                    Me.toolWindow3.Hide()
                    Exit Select
                Case "Databinding"
                    Me.radDropDownList1.SelectedIndex = 5
                    Me.radDropDownList1.Visible = False
                    Me.toolWindow3.Hide()
                    Exit Select
            End Select

            Me.diagramRibbonBar1.RibbonBarElement.ApplicationButtonElement.Visibility = ElementVisibility.Collapsed
            Me.diagramRibbonBar1.RibbonBarElement.TabStripElement.ItemContainer.Margin = New Padding(0)
            AddHandler Me.radPropertyGrid1.PropertyValueChanging, AddressOf radPropertyGrid1_PropertyValueChanging
        End Sub

        Private Sub radPropertyGrid1_PropertyValueChanging(sender As Object, e As PropertyGridItemValueChangingEventArgs)
            If DirectCast(e.Item, PropertyGridItem).[ReadOnly] OrElse TypeOf DirectCast(e.Item, PropertyGridItem).Accessor Is Telerik.WinControls.UI.PropertyGridData.ImmutableItemAccessor Then
                Return
            End If

            Dim item As PropertyGridItemBase = e.Item
            Dim propertyName As String = item.Name
            While item.Parent IsNot Nothing
                propertyName = item.Parent.Name & "." & propertyName
                item = item.Parent
            End While

            Telerik.WinControls.UI.Diagrams.UndoRedoHelper.ValueChanged(DirectCast(Me.radDiagram1.DiagramElement.SelectedItem, IDiagramItem), propertyName, e.NewValue, e.OldValue)
        End Sub

        Private Sub DiagramElement_SelectionChanged(sender As Object, e As EventArgs)
            Me.radPropertyGrid1.SelectedObject = Me.radDiagram1.DiagramElement.SelectedItem
        End Sub

        Private Sub radDropDownList1_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            If Me.radDropDownList1.SelectedIndex <> -1 Then
                Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
                Me.radDiagram1.DataSource = Nothing
                Me.radDiagram1.Items.Clear()
                Me.radDiagram1.SerializedXml = resources.GetString(Me.radDropDownList1.SelectedItem.Tag.ToString())

                RemoveHandler timer.Tick, AddressOf timer_TickGap
                RemoveHandler timer.Tick, AddressOf timer_Tick
                Me.timer.[Stop]()
                Me.radDiagram1.ConnectionBridge = BridgeType.None

                If Me.radDropDownList1.SelectedIndex = 3 Then
                    Me.PrepareRoutingExample()
                ElseIf Me.radDropDownList1.SelectedIndex = 4 Then
                    Me.PrepareGapExample()
                ElseIf Me.radDropDownList1.SelectedIndex = 5 Then
                    Me.SetupDataBindindngs()

                End If
            Else
                Me.radDiagram1.SerializedXml = ""
            End If
        End Sub

        Private Sub PrepareGapExample()
            Me.radDiagram1.ConnectionBridge = BridgeType.Bow
            timer.Interval = 30
            AddHandler timer.Tick, AddressOf timer_TickGap
            timer.Start()
        End Sub

        Private Sub PrepareRoutingExample()
            Me.radDiagram1.RouteConnections = False
            Me.radDiagram1.RoutingService.Router = New Telerik.Windows.Diagrams.Core.AStarRouter(Me.radDiagram1.DiagramElement) With { _
                .AvoidShapes = True _
            }
            Me.radDiagram1.RoutingService.AutoUpdate = True
            Me.radDiagram1.RouteConnections = True


            timer.Interval = 30
            AddHandler timer.Tick, AddressOf timer_Tick
            timer.Start()
        End Sub

        Private [step] As Integer = 1
        Private step1 As Integer = -1

        Private Sub timer_Tick(sender As Object, e As EventArgs)
            Dim shape As RadDiagramShape = DirectCast(Me.radDiagram1.Shapes(3), RadDiagramShape)
            Dim shape1 As RadDiagramShape = DirectCast(Me.radDiagram1.Shapes(4), RadDiagramShape)

            shape.Position = New Telerik.Windows.Diagrams.Core.Point(shape.Position.X - [step], shape.Position.Y)
            shape1.Position = New Telerik.Windows.Diagrams.Core.Point(shape1.Position.X - step1, shape1.Position.Y)
            If shape.Position.X < 380 OrElse shape.Position.X > 620 Then
                [step] = -[step]
            End If
            If shape1.Position.X < 380 OrElse shape1.Position.X > 620 Then
                step1 = -step1
            End If
        End Sub

        Private connectionStep As Integer = 1
        Private Sub timer_TickGap(sender As Object, e As EventArgs)
            Dim connection1 As RadDiagramShape = DirectCast(Me.radDiagram1.Shapes(4), RadDiagramShape)
            Dim connection2 As RadDiagramShape = DirectCast(Me.radDiagram1.Shapes(5), RadDiagramShape)
            connection1.Position = New Telerik.Windows.Diagrams.Core.Point(connection1.Position.X - [step], connection1.Position.Y)
            connection2.Position = New Telerik.Windows.Diagrams.Core.Point(connection2.Position.X - [step], connection2.Position.Y)


            If connection1.Position.X < 250 OrElse connection1.Position.X > 440 Then
                [step] = -[step]
            End If

        End Sub

        Protected Overrides Sub OnClosing(e As CancelEventArgs)
            Me.timer.Dispose()
            MyBase.OnClosing(e)
        End Sub
    End Class
End Namespace

