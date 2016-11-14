Imports System.Windows.Forms
Imports System.Drawing

Public Class ListViewEX
    Inherits ListView

    'Structure needed to set the listviews background watermark image
    Public Structure LVBKIMAGE
        Public ulFlags As Int32
        Public hbm As IntPtr
        Public pszImage As String
        Public cchImageMax As Int32
        Public xOffsetPercent As Int32
        Public yOffsetPercent As Int32
    End Structure


    'Constant Declarations
    Private Const LVM_FIRST As Int32 = &H1000
    Private Const LVM_SETBKIMAGEW As Int32 = (LVM_FIRST + 138)
    Private Const LVBKIF_TYPE_WATERMARK As Int32 = &H10000000

    'API Declarations
    Private Declare Sub CoInitialize Lib "ole32.dll" (ByVal pvReserved As Int32)
    Private Declare Sub CoUninitialize Lib "ole32.dll" ()
    Private Declare Function SendMessage Lib "user32.dll" Alias "SendMessageA" (ByVal hwnd As Int32, ByVal wMsg As Int32, ByVal wParam As Int32, ByVal lParam As Int32) As Int32


    Dim vWatermarkImage As Bitmap
    Dim vWatermarkAlpha As Integer

    <Configuration.DefaultSettingValue("200")> _
    Public Property WatermarkAlpha() As Integer
        Get
            Return vWatermarkAlpha
        End Get
        Set(ByVal value As Integer)
            vWatermarkAlpha = value
            SetBkImage()
        End Set
    End Property

    Public Property WatermarkImage() As Bitmap
        Get
            Return vWatermarkImage
        End Get
        Set(ByVal value As Bitmap)
            vWatermarkImage = value
            SetBkImage()
        End Set
    End Property

    Private Sub SetBkImage()
        If Not WatermarkImage Is Nothing Then
            Dim hBMP As IntPtr = GetBMP(WatermarkImage)
            If Not hBMP = IntPtr.Zero Then
                Dim lv As New LVBKIMAGE
                lv.hbm = hBMP
                lv.ulFlags = LVBKIF_TYPE_WATERMARK
                Dim lvPTR As IntPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(System.Runtime.InteropServices.Marshal.SizeOf(lv))
                System.Runtime.InteropServices.Marshal.StructureToPtr(lv, lvPTR, False)
                SendMessage(Me.Handle, LVM_SETBKIMAGEW, 0, lvPTR)
                System.Runtime.InteropServices.Marshal.FreeCoTaskMem(lvPTR)
            End If
        Else
            Dim lv As New LVBKIMAGE
            lv.hbm = IntPtr.Zero
            lv.ulFlags = LVBKIF_TYPE_WATERMARK
            Dim lvPTR As IntPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(System.Runtime.InteropServices.Marshal.SizeOf(lv))
            System.Runtime.InteropServices.Marshal.StructureToPtr(lv, lvPTR, False)
            SendMessage(Me.Handle, LVM_SETBKIMAGEW, 0, lvPTR)
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(lvPTR)
        End If
    End Sub


    Private Function GetBMP(ByVal FromImage As Image) As IntPtr
        Dim bmp As Bitmap = New Bitmap(FromImage.Width, FromImage.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)
        g.Clear(Me.BackColor)
        g.DrawImage(FromImage, 0, 0, bmp.Width, bmp.Height)
        g.FillRectangle(New SolidBrush(Color.FromArgb(WatermarkAlpha, Me.BackColor.R, Me.BackColor.G, Me.BackColor.B)), New RectangleF(0, 0, bmp.Width, bmp.Height))
        g.Dispose()
        Return bmp.GetHbitmap
        bmp.Dispose()
    End Function

    Public Sub New()
        Me.WatermarkAlpha = 200
        MyBase.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        CoInitialize(IntPtr.Zero)
        SetBkImage()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        CoUninitialize()
    End Sub

    Private Sub cListView_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleCreated
        SetBkImage()
    End Sub
End Class
