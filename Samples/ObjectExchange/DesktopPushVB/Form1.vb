Imports InTheHand.Net
Imports InTheHand.Windows.Forms


Public Class Form1

    Private Sub btnBeam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBeam.Click

        Dim sbdd As New SelectBluetoothDeviceDialog
        sbdd.ShowAuthenticated = True
        sbdd.ShowRemembered = True
        sbdd.ShowUnknown = True

        If sbdd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            If ofdFileToBeam.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

                Cursor.Current = Cursors.WaitCursor
                Dim theuri As New Uri("obex://" + sbdd.SelectedDevice.DeviceAddress.ToString() + "/" + System.IO.Path.GetFileName(ofdFileToBeam.FileName))
                Dim request As New ObexWebRequest(theuri)
                request.ReadFile(ofdFileToBeam.FileName)

                Dim response As ObexWebResponse = CType(request.GetResponse(), ObexWebResponse)
                MessageBox.Show(response.StatusCode.ToString())
                response.Close()

                Cursor.Current = Cursors.Default
            End If

        End If

    End Sub

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        Dim br As Bluetooth.BluetoothRadio = Bluetooth.BluetoothRadio.PrimaryRadio
        If Not br Is Nothing Then
            If br.Mode = Bluetooth.RadioMode.PowerOff Then
                br.Mode = Bluetooth.RadioMode.Connectable
            End If
        Else
            MessageBox.Show("Your device uses an unsupported Bluetooth software stack")
            btnBeam.Enabled = False
        End If
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim s As System.IO.Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("ThirtyTwoFeet.32feetback.jpg")
        Dim i As Image = New Bitmap(s)
        Dim attr As New System.Drawing.Imaging.ImageAttributes
        attr.SetColorKey(Color.White, Color.White)
        e.Graphics.DrawImage(i, New Rectangle(0, 0, i.Width, i.Height), 0, 0, i.Width, i.Height, GraphicsUnit.Pixel, attr)

    End Sub
End Class
