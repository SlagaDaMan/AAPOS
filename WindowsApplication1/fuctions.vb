Public Class fuctions

    Public Shared Function GetDiscountPrice(ByVal barcode As String) As String
        Form1.PromotionsTableAdapter.FillByBarcode(Form1.AAPOSDataSet1.Promotions, barcode)

        Dim Promotionstatus = Form1.AAPOSDataSet1.Promotions.Rows(0)("Status").ToString()
        Dim TODAY = DateTime.Now.ToString("ddd")
        Dim TodaysStatus
        Dim todaysDate = Format(Now(), "yyyy/MM/dd  hh:mm:ss tt")
        Dim DiscountResults = "False"
        Dim DiscountPrice = 0

        If Not Promotionstatus = "OFF" Then
            If TODAY = "Mon" Then
                TodaysStatus = Form1.AAPOSDataSet1.Promotions.Rows(0)("Mon").ToString()
            ElseIf TODAY = "Tue" Then
                TodaysStatus = Form1.AAPOSDataSet1.Promotions.Rows(0)("Tues").ToString()
            ElseIf TODAY = "Wed" Then
                TodaysStatus = Form1.AAPOSDataSet1.Promotions.Rows(0)("Wed").ToString()
            ElseIf TODAY = "Thu" Then
                TodaysStatus = Form1.AAPOSDataSet1.Promotions.Rows(0)("Thurs").ToString()
            ElseIf TODAY = "Fri" Then
                TodaysStatus = Form1.AAPOSDataSet1.Promotions.Rows(0)("Fri").ToString()
            ElseIf TODAY = "Sat" Then
                TodaysStatus = Form1.AAPOSDataSet1.Promotions.Rows(0)("Sat").ToString()
            ElseIf TODAY = "Sun" Then
                TodaysStatus = Form1.AAPOSDataSet1.Promotions.Rows(0)("Sun").ToString()
            Else

            End If

            If Not TodaysStatus = "OFF" Then
                If todaysDate = "" Then

                    Dim StartPromotionOn As DateTime = Form1.AAPOSDataSet1.Promotions.Rows(0)("Timefrom").ToString()
                    Dim EndPromotionOn As DateTime = Form1.AAPOSDataSet1.Promotions.Rows(0)("Timeto").ToString()

                    'Dim startTime As New DateTime(StartPromotionOn.ToString("yyyy"), StartPromotionOn.ToString("M"), StartPromotionOn.ToString("d"), StartPromotionOn.ToString("hh"), StartPromotionOn.ToString("mm"), 0)     ' 10:30 AM today
                    'Dim endTime As New DateTime(EndPromotionOn.ToString("yyyy"), StartPromotionOn.ToString("M"), StartPromotionOn.ToString("d"), StartPromotionOn.ToString("hh"), StartPromotionOn.ToString("mm"), 0)     ' 2:00 AM tomorrowd

                    Dim TODAYTime = DateTime.Now.ToString("HH")

                    If Val(StartPromotionOn.ToString("HH")) >= TODAYTime Or Val(EndPromotionOn.ToString("HH")) <= TODAYTime Then
                        DiscountResults = "True"
                    Else
                        DiscountResults = "False"
                    End If
                End If
            End If
        End If
        If DiscountResults = "True" Then
            DiscountPrice = Form1.AAPOSDataSet1.Promotions.Rows(0)("Status").ToString()
        End If
        DiscountResults = "False"
        Return DiscountPrice

    End Function
    ' Protected Function GetFocusControl() As Control
    '    Dim focusControl As Control = Nothing

    '    ' Use this to get the Focused Control: 
    '    Dim focusHandle As IntPtr = GetFocus()
    '    If IntPtr.Zero.Equals(focusHandle) Then
    '        focusControl = Control.FromHandle(focusHandle)
    '    End If

    '    ' Note that it returns NOTHING if there is not a .NET control with focus 
    '    Return focusControl
    'End Function
End Class
