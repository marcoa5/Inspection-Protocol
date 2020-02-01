Imports Microsoft.SharePoint.Client
Imports System.Net
Imports Microsoft.Office.Interop
Module Module1
    ReadOnly Macchine(500, 4) As String
    ReadOnly Tech(100) As String
    ReadOnly Path As String = "https://home.intranet.epiroc.com/sites/cc/iyc/MRProductsalessupport/SED/"
    Sub Main()
        Macc()
        Tec()
        Inter()
    End Sub


    Sub Macc()

        Dim I As Integer
        Dim context As New ClientContext(Path)
        Dim testList As List = context.Web.Lists.GetByTitle("IP_rigs")
        Dim query As CamlQuery = CamlQuery.CreateAllItemsQuery(10000)
        Dim items As ListItemCollection = testList.GetItems(query)
        context.Load(items)
        context.ExecuteQuery()
        On Error Resume Next
        I = 0
        Form1.Macchine.Items.Add("Please Select...")
        For Each listItem As ListItem In items
            Macchine(I, 0) = listItem("Title")
            Macchine(I, 1) = listItem("lwjr")
            Macchine(I, 2) = listItem("_x0069_ik4")
            Macchine(I, 3) = listItem("_x007a_th3")
            Macchine(I, 4) = listItem("z4jv")
            Form1.Macchine.Items.Add(listItem("lwjr") & " - " & listItem("_x0069_ik4") & " - " & listItem("z4jv"))
            I += 1
        Next
        Form1.Macchine.SelectedIndex = 0

    End Sub
    Sub Tec()

        Dim I As Integer
        Dim context As New ClientContext(Path)
        Dim testList As List = context.Web.Lists.GetByTitle("IP_tech")
        Dim query As CamlQuery = CamlQuery.CreateAllItemsQuery(10000)
        Dim items As ListItemCollection = testList.GetItems(query)
        context.Load(items)
        context.ExecuteQuery()
        On Error Resume Next
        I = 0

        For Each listItem As ListItem In items
            Tech(I) = listItem("Title")
            Form1.Tech.Items.Add(listItem("Title"))
            I += 1
        Next

    End Sub

    Sub Inter()

        Dim I As Integer
        Dim context As New ClientContext(Path)
        Dim testList As List = context.Web.Lists.GetByTitle("IP_SED_THInt")
        Dim query As CamlQuery = CamlQuery.CreateAllItemsQuery(10000)
        Dim items As ListItemCollection = testList.GetItems(query)
        context.Load(items)
        context.ExecuteQuery()
        On Error Resume Next
        I = 0
        For Each listItem As ListItem In items
            Form1.Interval.Items.Add(listItem("Title"))
            I += 1
        Next

    End Sub


    Sub Compila()
        With Form1
            If .Macchine.SelectedIndex > 0 Then
                Dim Indice As Integer = .Macchine.SelectedIndex - 1
                .PN.Text = Macchine(Indice, 0)
                .SN.Text = Macchine(Indice, 1)
                .RIG.Text = Macchine(Indice, 2)
                .CUSNR.Text = Macchine(Indice, 3)
                .CUSNAME.Text = Macchine(Indice, 4)
            Else
                .PN.Text = ""
                .SN.Text = ""
                .RIG.Text = ""
                .CUSNR.Text = ""
                .CUSNAME.Text = ""
            End If

        End With
    End Sub


    Sub Abilita()
        If Form1.Macchine.SelectedIndex > 0 And Form1.Tech.SelectedIndex > -1 And Form1.Interval.SelectedIndex > -1 Then
            Form1.Button1.Enabled = True
        Else
            Form1.Button1.Enabled = False
        End If
    End Sub






    Sub AddRig(ByVal SN As String, ByVal PN As String, ByVal Model As String, ByVal CusNr As String, ByVal CusName As String)

        Using context As New ClientContext(Path)
            Dim testList As List = context.Web.Lists.GetByTitle("IP_rigs")
            Dim itemCreateInfo As New ListItemCreationInformation
            Dim oListItem As ListItem
            oListItem = testList.AddItem(itemCreateInfo)
            oListItem("Title") = UCase(PN)
            oListItem("lwjr") = UCase(SN)
            oListItem("_x0069_ik4") = UCase(Model)
            oListItem("_x007a_th3") = UCase(CusNr)
            oListItem("z4jv") = UCase(CusName)
            oListItem.Update()
            context.ExecuteQuery()
        End Using
        Form2.Close()
        Form1.Macchine.Items.Clear()
        Macc()
    End Sub

    Sub Contr()
        With Form2
            If .TextBox1.Text = "" Or .TextBox2.Text = "" Or .TextBox3.Text = "" Or .TextBox4.Text = "" Or .TextBox5.Text = "" Then
                .Button1.Enabled = False
            Else
                .Button1.Enabled = True
            End If
        End With
    End Sub

    Sub AddTech()
        Dim Nome As String = InputBox("Type name (format: NAME SURNAME)", "New Technician")
        Nome = UCase(Nome)
        If Nome <> "" Then

            Using context As New ClientContext(Path)
                Dim testList As List = context.Web.Lists.GetByTitle("IP_tech")
                Dim itemCreateInfo As New ListItemCreationInformation
                Dim oListItem As ListItem
                oListItem = testList.AddItem(itemCreateInfo)
                oListItem("Title") = Nome
                oListItem.Update()
                context.ExecuteQuery()
            End Using

        End If
        Form1.Tech.Items.Clear()
        Tec()
    End Sub


    Sub DelRig(ByVal SN As String)


        Using context As New ClientContext(Path)
            Dim oList As List = context.Web.Lists.GetByTitle("IP_rigs")
            Dim oListItemCol As ListItemCollection = oList.GetItems(CamlQuery.CreateAllItemsQuery())
            Dim O As Integer = 0
            context.Load(oListItemCol)
            context.ExecuteQuery()
            For Each ITem As ListItem In oListItemCol
                If ITem.Item("lwjr") = SN Then

                    Dim oListItem As ListItem = oList.GetItemById(ITem.Id)
                    oListItem.DeleteObject()
                    context.ExecuteQuery()
                    Exit For
                End If
                O += 1
            Next
        End Using
        Form1.Macchine.Items.Clear()
        Macc()
    End Sub

    Sub DelTec(ByVal Nome As String)

        Using context As New ClientContext(Path)
            Dim oList As List = context.Web.Lists.GetByTitle("IP_tech")
            Dim oListItemCol As ListItemCollection = oList.GetItems(CamlQuery.CreateAllItemsQuery())
            Dim O As Integer = 0
            context.Load(oListItemCol)
            context.ExecuteQuery()
            For Each ITem As ListItem In oListItemCol
                If ITem.Item("Title") = Nome Then
                    Dim oListItem As ListItem = oList.GetItemById(ITem.Id)
                    oListItem.DeleteObject()
                    context.ExecuteQuery()
                    Exit For
                End If
                O += 1
            Next
        End Using
        Form1.Tech.Items.Clear()
        Form1.Tech.Text = ""
        Tec()
    End Sub


    Sub EditRig(ByVal SN As String)
        Form1.Enabled = False
        With Form2
            .Show()
            .Text = "Edit Rig"
            .TextBox1.Enabled = True
            .TextBox2.Enabled = True
            .TextBox3.Enabled = True
            .TextBox4.Enabled = True
            .TextBox5.Enabled = True
        End With

        Using context As New ClientContext(Path)
            Dim oList As List = context.Web.Lists.GetByTitle("IP_rigs")
            Dim oListItemCol As ListItemCollection = oList.GetItems(CamlQuery.CreateAllItemsQuery())
            Dim O As Integer = 0
            context.Load(oListItemCol)
            context.ExecuteQuery()
            For Each ITem As ListItem In oListItemCol
                If ITem.Item("lwjr") = SN Then

                    Dim oListItem As ListItem = oList.GetItemById(ITem.Id)
                    oListItem("Title") = UCase(Form2.TextBox1.Text)
                    oListItem("lwjr") = UCase(Form2.TextBox2.Text)
                    oListItem("_x0069_ik4") = UCase(Form2.TextBox3.Text)
                    oListItem("_x007a_th3") = UCase(Form2.TextBox4.Text)
                    oListItem("z4jv") = UCase(Form2.TextBox5.Text)
                    oListItem.Update()
                    context.ExecuteQuery()
                    Exit For
                End If
                O += 1
            Next
        End Using
        Form2.Close()
        Form1.Macchine.Items.Clear()
        Macc()
    End Sub


    Sub LoadRig(ByVal SN As String, ByVal PN As String, ByVal Model As String, ByVal CusNr As String, ByVal CusName As String)
        Form1.Enabled = False
        With Form2
            .Show()
            .Text = "Edit Rig"
            .TextBox1.Text = SN
            .TextBox2.Text = PN
            .TextBox3.Text = Model
            .TextBox4.Text = CusNr
            .TextBox5.Text = CusName
            .TextBox1.Enabled = True
            .TextBox2.Enabled = True
            .TextBox3.Enabled = True
            .TextBox4.Enabled = True
            .TextBox5.Enabled = True
            .TextBox1.Select()
        End With
    End Sub



    Sub OKTH(ByVal Cart As String, ByVal Sn As String, ByVal Pn As String, ByVal Customer As String, ByVal Rig As String, ByVal Interval As String, ByVal TEch As String)
        Dim Elenco As String = ""
        For R As Integer = 0 To Form1.Tech.Items.Count - 1

            If Elenco = "" Then
                Elenco = Form1.Tech.Items.Item(R).ToString
            Else
                Elenco &= "; " & Form1.Tech.Items.Item(R).ToString
            End If
        Next
        Using client As New WebClient()
            client.UseDefaultCredentials = True
            client.DownloadFile("https://home.intranet.epiroc.com/sites/cc/iyc/MRProductsalessupport/SED/IP_xls/ipth.xlsx", Cart)
        End Using
        Dim I As Integer = 14
        Dim C As Integer = 1
        Dim D As Integer = 2
        Dim mEx As Excel.Application
        Dim mWb As Excel.Workbook
        Dim msWb As Excel.Workbooks
        Dim mWs As Excel.Worksheet

        mEx = CreateObject("Excel.Application")
        mEx.Visible = False
        msWb = mEx.Workbooks
        mWb = msWb.Open(Cart)
        mWs = mWb.Sheets("Protocollo TH")
        mWs.Cells(5, 3).value = Customer
        mWs.Cells(6, 3).value = Rig
        Dim mPN As String = Left(Pn, 4) & "." & Mid(Pn, 5, 4) & "." & Right(Pn, 2)
        mWs.Cells(7, 3).value = Sn & " (" & mPN & ")"
        mWs.Cells(8, 3).value = Interval & " ORE"
        mWs.Cells(11, 3).value = TEch
        mWs.Cells(11, 3).select

        With mWs.Range("C11").Validation
            .Delete()
            .Add(Type:=Excel.XlDVType.xlValidateList, AlertStyle:=Excel.XlDVAlertStyle.xlValidAlertStop, Operator:=Excel.XlFormatConditionOperator.xlBetween, Formula1:=Elenco)
            .IgnoreBlank = True
            .InCellDropdown = True
            .InputTitle = ""
            .ErrorTitle = ""
            .InputMessage = ""
            .ErrorMessage = ""
            .ShowInput = True
            .ShowError = True
        End With
        mWs.Cells(4, 3).select
        Form3.ProgressBar1.Minimum = I
        Form3.ProgressBar1.Maximum = 105


        With mWs
            Do While .Cells(I, 4).Value <> Nothing
                Form3.ProgressBar1.Value = I
                If .Cells(8, 3).Value <> "" Then

                    If .Cells(I, 4).Value > Interval Then
                        .Cells(I, 3).Font.Color = RGB(186, 193, 198)
                        .Cells(I, 4).Font.Color = RGB(255, 192, 0)
                        .OLEObjects("CheckBox" & C).Visible = False
                        .OLEObjects("CheckBox" & D).Visible = False
                    End If
                Else
                    .Cells(I, 3).Font.Color = RGB(35, 31, 32)
                    .Cells(I, 4).Font.Color = RGB(35, 31, 32)
                    .OLEObjects("CheckBox" & C).Visible = True
                    .OLEObjects("CheckBox" & D).Visible = True
                End If
                C += 2
                D += 2
                I += 1

            Loop

        End With
        mWs.Protect("IYCFUM64")
        mEx.Visible = True
        mWb.Save()
        Form3.Close()
        Form1.Close()



    End Sub

End Module


