'Program:
'Purpose:
'Date:
'Author:


Public Class frmCookies

    Dim cpc As Integer = 1 'cookies per click
    Dim cps As Integer 'cookies per second
    Dim cookies As Integer

    Dim Up1Owned As Integer
    Dim Up1Cost As Integer = 100

    Dim Up2Owned As Integer
    Dim Up2Cost As Integer = 250

    Dim Up3Owned As Integer
    Dim Up3Cost As Integer = 300

    Dim Up4Owned As Integer
    Dim Up4Cost As Integer = 500

    Dim Up5Owned As Integer
    Dim Up5Cost As Integer = 1000

    Dim Up6Owned As Integer
    Dim Up6Cost As Integer = 3000


    Private Async Sub frmCookies_LoadAsync(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim infinite As String = 1
        Dim timeElapsed As Decimal = 1

        While infinite = 1
            timeElapsed = timeElapsed + 1
            lblTimer.Text = timeElapsed.ToString("N0") + " seconds have passed since the program opened"

            cookies += cps

            lblCPS.Text = "Cookies Per Second: " + cps.ToString("N0")
            lblCPC.Text = "Cookies Per Click:" + cpc.ToString("N0")
            lblCookies.Text = "Cookies: " + cookies.ToString("N0")

            Await Task.Delay(1000)

        End While

    End Sub

    Private Sub btnCookie_Click(sender As Object, e As EventArgs) Handles btnCookie.Click

        cookies += cpc

        lblCookies.Text = "Cookies: " + cookies.ToString("N0")

    End Sub

    Private Sub btnUpgrade1_Click(sender As Object, e As EventArgs) Handles btnUpgrade1.Click

        If cookies >= Up1Cost Then
            cps += 1
            Up1Owned += 1
            Up1Cost = Up1Cost + (Up1Cost * 0.05)
            cookies -= Up1Cost
        Else
            MsgBox("Please get " + Up1Cost.ToString("N0") + " cookies to buy this upgrade", , "Error")
        End If

        lblCPS.Text = "Cookies Per Second: " + cps.ToString("N0")
        lblUp1Owned.Text = "Owned: " + Up1Owned.ToString("N0")
        lblUp1Cost.Text = "Cost: " + Up1Cost.ToString("N0")


    End Sub

    Private Sub btnUpgrade2_Click(sender As Object, e As EventArgs) Handles btnUpgrade2.Click

        If cookies >= Up2Cost Then
            cps += 5
            Up2Owned += 1
            Up2Cost = Up2Cost + (Up2Cost * 0.05)
            cookies -= Up2Cost
        Else
            MsgBox("Please get " + Up2Cost.ToString("N0") + " cookies to buy this upgrade", , "Error")
        End If

        lblCPS.Text = "Cookies Per Second: " + cps.ToString("N0")
        lblUp2Owned.Text = "Owned: " + Up2Owned.ToString("N0")
        lblUp2Cost.Text = "Cost: " + Up2Cost.ToString("N0")


    End Sub

    Private Sub btnUpgrade3_Click(sender As Object, e As EventArgs) Handles btnUpgrade3.Click

        If cookies >= Up3Cost Then
            cpc += 5
            Up3Owned += 1
            Up3Cost = Up3Cost + (Up3Cost * 0.05)
            cookies -= Up3Cost
        Else
            MsgBox("Please get " + Up3Cost.ToString("N0") + " cookies to buy this upgrade", , "Error")
        End If

        lblCPS.Text = "Cookies Per Second: " + cps.ToString("N0")
        lblUp3Owned.Text = "Owned: " + Up3Owned.ToString("N0")
        lblUp3Cost.Text = "Cost: " + Up3Cost.ToString("N0")


    End Sub

    Private Sub btnUpgrade4_Click(sender As Object, e As EventArgs) Handles btnUpgrade4.Click

        If cookies >= Up4Cost Then
            cps += 10
            Up4Owned += 1
            Up4Cost = Up4Cost + (Up4Cost * 0.05)
            cookies -= Up4Cost
        Else
            MsgBox("Please get " + Up4Cost.ToString("N0") + " cookies to buy this upgrade", , "Error")
        End If

        lblCPS.Text = "Cookies Per Second: " + cps.ToString("N0")
        lblUp4Owned.Text = "Owned: " + Up4Owned.ToString("N0")
        lblUp4Cost.Text = "Cost: " + Up4Cost.ToString("N0")


    End Sub

    Private Sub btnUpgrade5_Click(sender As Object, e As EventArgs) Handles btnUpgrade5.Click

        If cookies >= Up5Cost Then
            cps += 20
            Up5Owned += 1
            Up5Cost = Up5Cost + (Up5Cost * 0.05)
            cookies -= Up5Cost
        Else
            MsgBox("Please get " + Up5Cost.ToString("N0") + " cookies to buy this upgrade", , "Error")
        End If

        lblCPS.Text = "Cookies Per Second: " + cps.ToString("N0")
        lblUp5Owned.Text = "Owned: " + Up5Owned.ToString("N0")
        lblUp5Cost.Text = "Cost: " + Up5Cost.ToString("N0")


    End Sub

    Private Sub btnUpgrade6_Click(sender As Object, e As EventArgs) Handles btnUpgrade6.Click

        If cookies >= Up6Cost Then
            cps += 50
            cpc += 10
            Up6Owned += 1
            Up6Cost = Up6Cost + (Up6Cost * 0.05)
            cookies -= Up6Cost
        Else
            MsgBox("Please get " + Up6Cost.ToString("N0") + " cookies to buy this upgrade", , "Error")
        End If

        lblCPS.Text = "Cookies Per Second: " + cps.ToString("N0")
        lblUp6Owned.Text = "Owned: " + Up6Owned.ToString("N0")
        lblUp6Cost.Text = "Cost: " + Up6Cost.ToString("N0")


    End Sub

End Class

