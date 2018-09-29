Public Class winMain

    Shared count As Integer

    Private Sub BtnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        If DataInImage() Then
            Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
            saveFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif"
            saveFileDialog.Title = "Save Image As"
            saveFileDialog.ShowDialog()

            If Not saveFileDialog.FileName.Equals("") Then
                Dim fileStream As IO.FileStream = CType(saveFileDialog.OpenFile, System.IO.FileStream)
                Select Case (saveFileDialog.FilterIndex)
                    Case 1
                        pbxImage.Image.Save(fileStream, Imaging.ImageFormat.Jpeg)
                    Case 2
                        pbxImage.Image.Save(fileStream, Imaging.ImageFormat.Bmp)
                    Case 3
                        pbxImage.Image.Save(fileStream, Imaging.ImageFormat.Gif)
                End Select
            End If

        Else
            MsgBox("Sorry, there was an error while processing the image")
        End If
    End Sub

    Private Sub BtnChooseImage_Click(sender As Object, e As EventArgs) Handles btnChooseImage.Click
        Dim fileDialog As OpenFileDialog = New OpenFileDialog()
        Dim strFilePath As String

        fileDialog.Title = "Choose an Image"
        fileDialog.Filter = "JPEGs|*.jpg|GIFs|*.gif|Bitmaps|*.bmp|AllFiles|*.*"
        fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        fileDialog.RestoreDirectory = True

        If fileDialog.ShowDialog = DialogResult.OK Then
            strFilePath = fileDialog.FileName
            pbxImage.Image = Image.FromFile(strFilePath)
            pbxImage.SizeMode = PictureBoxSizeMode.Zoom
        End If

    End Sub

    Private Function DataInImage() As Boolean
        Dim textToEmbedded As String = txtDataInput.Text
        Dim listOfBits As New List(Of Integer)
        Dim data(textToEmbedded.Length) As String
        Dim bmpImage As New Bitmap(pbxImage.Image)

        listOfBits.Clear()

        count = 0

        For i = 0 To textToEmbedded.Length
            If i <> textToEmbedded.Length Then
                data(i) = Convert.ToString(Asc(textToEmbedded.Substring(i, 1)), 2).PadLeft(8, "0")
            Else
                data(i) = "00000000"
            End If
        Next

        For i = 0 To data.Length - 1
            For j = 0 To data(i).Length - 1
                listOfBits.Add(data(i).Substring(j, 1))
            Next
        Next

        For x = 0 To bmpImage.Width - 1
            For y = 0 To bmpImage.Height - 1
                Dim color As Color = bmpImage.GetPixel(x, y)
                Dim red = Convert.ToString(color.R, 2).PadLeft(8, "0")
                Dim stegRed = red.Substring(0, 7) & listOfBits(count)
                count = count + 1
                bmpImage.SetPixel(x, y, Color.FromArgb(Convert.ToInt16(stegRed, 2), color.G, color.B))
                Return True
            Next
        Next
        Return False
    End Function

End Class
