Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class MusoftwareGetobject

    Public lvitemCollection As New ArrayList
    Public PressValue As Double
    Public Function GetX(imagelist2 As ImageList) As Object
        Dim colProcesses = GetObject("winmgmts:").ExecQuery("Select * from Win32_Process")


        'Dim imagelist2 As New ImageList

        lvitemCollection.Clear()
        imagelist2.Images.Clear()
        Dim mcnt As Long = colProcesses.count
        Dim icnt As Long
        For Each objProcess In colProcesses
            icnt += 1
            PressValue = icnt / mcnt * 100

            Dim lvitem As New ListViewItem
            With lvitem
                Dim sngProcessTime = (CSng(objProcess.KernelModeTime) + _
                    CSng(objProcess.UserModeTime)) / 10000000

                'Add Process Name & process ID
                .Text = (objProcess.Name)
                .SubItems.Add(objProcess.ProcessID)
                .SubItems.Add(objProcess.executablepath.ToString)


                .SubItems.Add(objProcess.ParentProcessId)
                .SubItems.Add(NameByID(objProcess.ParentProcessId))


                'Add Process time Pagefile DETAIL , Pagefaults, Working Size
                .SubItems.Add(objProcess.ThreadCount)
                .SubItems.Add(objProcess.Priority)
                .SubItems.Add(sngProcessTime)
                .SubItems.Add(objProcess.PageFileUsage)
                .SubItems.Add(objProcess.PageFaults)
                .SubItems.Add(objProcess.WorkingSetSize)
                .SubItems.Add(objProcess.CreationDate.ToString)
                .SubItems.Add(objProcess.Caption)
                .SubItems.Add(objProcess.CreationClassName)
                .SubItems.Add(objProcess.CSCreationClassName)
                .SubItems.Add(objProcess.CSName)
                .SubItems.Add(objProcess.Description)
                .SubItems.Add(objProcess.Handle)
                .SubItems.Add(objProcess.HandleCount)
                .SubItems.Add(objProcess.InstallDate.ToString)
                .SubItems.Add(objProcess.KernelModeTime)
                .SubItems.Add(objProcess.MaximumWorkingSetSize.ToString)
                .SubItems.Add(objProcess.MinimumWorkingSetSize.ToString)
                .SubItems.Add(objProcess.Name)
                .SubItems.Add(objProcess.OSCreationClassName)
                .SubItems.Add(objProcess.OSName)
                .SubItems.Add(objProcess.OtherOperationCount)
                .SubItems.Add(objProcess.OtherTransferCount)
                .SubItems.Add(objProcess.PeakPageFileUsage)
                .SubItems.Add(objProcess.PeakVirtualSize)
                .SubItems.Add(objProcess.PeakWorkingSetSize)

                .SubItems.Add(objProcess.PrivatePageCount)
                .SubItems.Add(objProcess.QuotaNonPagedPoolUsage)
                .SubItems.Add(objProcess.QuotaPagedPoolUsage)
                .SubItems.Add(objProcess.QuotaPeakNonPagedPoolUsage)
                .SubItems.Add(objProcess.QuotaPeakPagedPoolUsage)
                .SubItems.Add(objProcess.ReadOperationCount)
                .SubItems.Add(objProcess.ReadTransferCount)
                .SubItems.Add(objProcess.SessionId)
                .SubItems.Add(objProcess.Status.ToString)

                .SubItems.Add(objProcess.UserModeTime)
                .SubItems.Add(objProcess.VirtualSize)
                .SubItems.Add(objProcess.WindowsVersion)
                .SubItems.Add(objProcess.WriteOperationCount)
                .SubItems.Add(objProcess.WriteTransferCount)


                'now collecting Icon
                Dim PID As Integer = objProcess.ProcessID
                Dim PPath As String = objProcess.executablepath.ToString

                Try
                    For Each key In imagelist2.Images.Keys
                        If key = PID.ToString Then
                            Exit Try
                        End If
                    Next
                    imagelist2.Images.Add(PID.ToString, GetICON.GetFileIcon(PPath, 1).ToBitmap)
                Catch
                    'do nothing
                Finally
                    'Now adding icon to List
                    .ImageKey = PID.ToString
                End Try
            End With
            lvitemCollection.Add(lvitem)
        Next
    End Function


    Function NameByID(ByVal id As String) As String
        'On Error Resume Next
        Dim pro = Nothing
        Dim colpro
        colpro = GetObject("winmgmts:").ExecQuery("Select * from Win32_Process where processid=" & id)

        If colpro.count = 1 Then
            For Each pro In colpro
                Return pro.name.ToString
            Next
            Return Nothing
        Else
            Return Nothing
        End If
    End Function
End Class
Public Class GetICON
    Private Structure SHFILEINFO
        Public hIcon As IntPtr ' : icon
        Public iIcon As Integer ' : icondex
        Public dwAttributes As Integer ' : SFGAO_ flags
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)> _
        Public szDisplayName As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=80)> _
        Public szTypeName As String
    End Structure

    Private Declare Ansi Function SHGetFileInfo Lib "shell32.dll" (ByVal pszPath As String, _
    ByVal dwFileAttributes As Integer, ByRef psfi As SHFILEINFO, ByVal cbFileInfo As Integer, _
    ByVal uFlags As Integer) As IntPtr

    Private Const SHGFI_ICON = &H100
    Private Const SHGFI_SMALLICON = &H1         ' Samll Icon
    Private Const SHGFI_LARGEICON = &H0         ' Large icon
    Private nIndex = 0

    'zero for  Large 
    'one for small
    Shared Function GetFileIcon_(ByVal FilePath As String, ByVal IconSize As Boolean) As Icon
        Try


            If Not My.Computer.FileSystem.FileExists(FilePath) Then
                Return My.Resources.Play1NormalRed
            End If

            Dim hImgSmall As IntPtr  'The handle to the system image list.
            Dim hImgLarge As IntPtr  'The handle to the system image list.
            'Dim fName As String      'The file name to get the icon from.
            Dim shinfo As SHFILEINFO
            shinfo = New SHFILEINFO()

            shinfo.szDisplayName = New String(Chr(0), 260)
            shinfo.szTypeName = New String(Chr(0), 80)

            If IconSize = 1 Then
                'Use this to get the small icon.
                hImgSmall = SHGetFileInfo(FilePath, 0, shinfo, Marshal.SizeOf(shinfo), _
                 SHGFI_ICON Or SHGFI_SMALLICON)
            Else
                'Use this to get the Large icon.
                hImgLarge = SHGetFileInfo(FilePath, 0, shinfo, Marshal.SizeOf(shinfo), _
                  SHGFI_ICON Or SHGFI_LARGEICON)
            End If



            'Use this to get the small icon.
            'hImgSmall = SHGetFileInfo(FilePath, 0, shinfo, Marshal.SizeOf(shinfo), _
            ' SHGFI_ICON Or SHGFI_SMALLICON)


            'Use this to get the large icon.
            'hImgLarge = SHGetFileInfo(fName, 0, 
            'ref shinfo, (uint)Marshal.SizeOf(shinfo), 
            'SHGFI_ICON | SHGFI_LARGEICON);

            'The icon is returned in the hIcon member of the shinfo struct.
            Dim myIcon As System.Drawing.Icon
            myIcon = System.Drawing.Icon.FromHandle(shinfo.hIcon)
            Return myIcon
        Catch ex As Exception
            Return My.Resources.Play1NormalRed
        End Try

    End Function

    Shared Function GetFileIcon(ByVal FilePath As String, ByVal IconSize As Boolean) As Icon
        Try
            Return Drawing.Icon.ExtractAssociatedIcon(FilePath)
            'Return My.Resources.Play1NormalRed1
        Catch ex As Exception
            Return My.Resources.Play1NormalRed
        End Try
    End Function

End Class
