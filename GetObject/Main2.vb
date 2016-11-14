Public Class Main2
    Function killProcessById(ByVal ProcessId As Integer, ByVal DelState As Boolean) As ArrayList

        'Creating Information source
        Dim Responce As New ArrayList
        Responce.Clear()
        Dim P As System.Diagnostics.Process

        Try
            'Taking Process Control and alloting variable to it as process
            P = System.Diagnostics.Process.GetProcessById(ProcessId)
        Catch ex As Exception
            Responce.Add("Process with ID: " + ProcessId.ToString + " Not Runing")
            Return Responce
        End Try


        'Checking For critical process 
        If KillProcessClass.DangerListOfProcess(P) = False Then
            Responce.Add(P.ProcessName.ToUpper + " with Id :" + P.Id.ToString + " is a critical process. Tremination Skiped.")
            Responce.Add("To Terminate this process Uncheck 'Enable Process Filter' in Options Tab.")
            'this tab will work at DangerListOfProcess Function and return true if unchecked
            Return Responce
        Else
            Try
                Dim path As String = P.MainModule.FileName.ToString
                Responce.Add("Attemp To Kill Process : " + P.ProcessName + "  With Id : " + P.Id.ToString + "  Started")
                '*************************************************************************
                'killing process
                Try
                    P.Kill()
                    Responce.Add(P.ProcessName + " ID : " + P.Id.ToString + "  Terminated..")
                Catch ex As Exception
                    Responce.Add(ex.Message)
                End Try

                '**************************************************************************
                'deleteing file if DelState is true
                If DelState = True Then
                    If System.IO.File.Exists(path) Then
                        Try
                            'First we wait for Complite Process Exit from memory 
                            'So that we can delete file associated with it
                            P.WaitForExit()

                            'First Attempt to delte the file ' 
                            'Actualy We uses P.WaitForExit() So there is no need For second attemp but for safe
                            'Side we also use second attemp
                            '
                            'Here also need of NTFS  Security privilage but it is not neccessory to do so.


                            'setting file attribute
                            System.IO.File.SetAttributes(path, IO.FileAttributes.Normal)
                            System.IO.File.Delete(path)
                            Responce.Add("Finaly File Deleted : " + path)
                        Catch 'exa As Exception
                            'killProcessById.Add(exa.Message)

                            Try
                                'Second Attempt
                                System.Threading.Thread.Sleep(100)
                                System.IO.File.SetAttributes(path, IO.FileAttributes.Normal)
                                System.IO.File.Delete(path)
                                Responce.Add("Finaly File Deleted : " + path)
                                'Return EventArrayList
                            Catch exb As Exception
                                Responce.Add("Can not delete File : " + exb.Message)
                                'Return EventArrayList
                            End Try
                        End Try
                    Else
                        Responce.Add("File Not found : " + path)
                    End If
                End If
                '***************************************************************************
            Catch ex As Exception
                Responce.Add(ex.Message + vbNewLine)
            End Try
        End If
        Return Responce

    End Function
End Class
Public Class KillProcessClass

    'setting windir to c:\windows  here c:\windows is installed xp drive
    Public Shared windir As String = My.Application.GetEnvironmentVariable("WinDir")

#Region "Danger process protection"


    'Danger process of windows which should not killed.
    Public DangerousNames() As String = {"csrss.exe", "dwm.exe", "lsass.exe", "lsm.exe", "services.exe", _
                                      "smss.exe", "wininit.exe", "winlogon.exe"}


    'this function return false if process is critical and return true if process is not critical 
    'detection of  same name process is done by root path .
    'two root path of csrss and winlogon contain   /??/  at starting 

    Shared Function DangerListOfProcess(ByVal P As Process) As Boolean

        'Dont check if filter checkbox is unchecked

        Return True



        'setting process path to propath
        Dim propath As String

        'many critical process do not return process path
        Try
            propath = P.MainModule.FileName.ToLower()
        Catch ex As Exception
            Return False
        End Try


        Select Case P.ProcessName.ToLower
            Case "csrss"
                Try
                    If propath = (("\??\" + windir + "\system32\csrss.exe").ToLower) Then
                        Return False
                    Else
                        Return True
                    End If
                Catch
                    Return False
                End Try

            Case "services"
                Try
                    If propath = ((windir + "\system32\services.exe").ToLower) Then
                        Return False
                    Else
                        Return True
                    End If
                Catch
                    Return False
                End Try

            Case "svchost"
                Try
                    If propath = ((windir + "\system32\svchost.exe").ToLower) Then
                        Return False
                    Else
                        Return True
                    End If
                Catch
                    Return False
                End Try
            Case "lsass"
                Try
                    If propath = ((windir + "\system32\lsass.exe").ToLower) Then
                        Return False
                    Else
                        Return True
                    End If
                Catch
                    Return False
                End Try
            Case "smss"
                Try
                    If propath = ((windir + "\system32\smss.exe").ToLower) Then
                        Return False
                    Else
                        Return True
                    End If
                Catch
                    Return False
                End Try
            Case "winlogon"
                Try
                    If propath = (("\??\" + windir + "\system32\winlogon.exe").ToLower) Then
                        Return False
                    Else
                        Return True
                    End If
                Catch
                    Return False
                End Try


            Case "system"
                Try
                    If P.Id = 4 Then
                        Return False
                    Else
                        Return True
                    End If
                Catch
                    Return False
                End Try
            Case "idle"
                Try
                    If P.Id = 0 Then
                        Return False
                    Else
                        Return True
                    End If
                Catch
                    Return False
                End Try

            Case Else
                Return True
        End Select
    End Function
#End Region

#Region "Process termination"


    ' this function is defined as killprocessbyid(  pid , will_file_delete) as boolean
    ' will_file_delete = false -> not delete
    ' Will_file_delete = true -> delete attached file

    Shared Function killProcessById(ByVal ProcessId As Integer, ByVal DelState As Boolean) As ArrayList

        'Creating Information source
        Dim Responce As New ArrayList
        Responce.Clear()
        Dim P As System.Diagnostics.Process

        Try
            'Taking Process Control and alloting variable to it as process
            P = System.Diagnostics.Process.GetProcessById(ProcessId)
        Catch ex As Exception
            Responce.Add("Process with ID: " + ProcessId.ToString + " Not Runing")
            Return Responce
        End Try


        'Checking For critical process 
        If KillProcessClass.DangerListOfProcess(P) = False Then
            Responce.Add(P.ProcessName.ToUpper + " with Id :" + P.Id.ToString + " is a critical process. Tremination Skiped.")
            Responce.Add("To Terminate this process Uncheck 'Enable Process Filter' in Options Tab.")
            'this tab will work at DangerListOfProcess Function and return true if unchecked
            Return Responce
        Else
            Try
                Dim path As String = P.MainModule.FileName.ToString
                Responce.Add("Attemp To Kill Process : " + P.ProcessName + "  With Id : " + P.Id.ToString + "  Started")
                '*************************************************************************
                'killing process
                Try
                    P.Kill()
                    Responce.Add(P.ProcessName + " ID : " + P.Id.ToString + "  Terminated..")
                Catch ex As Exception
                    Responce.Add(ex.Message)
                End Try

                '**************************************************************************
                'deleteing file if DelState is true
                If DelState = True Then
                    If System.IO.File.Exists(path) Then
                        Try
                            'First we wait for Complite Process Exit from memory 
                            'So that we can delete file associated with it
                            P.WaitForExit()

                            'First Attempt to delte the file ' 
                            'Actualy We uses P.WaitForExit() So there is no need For second attemp but for safe
                            'Side we also use second attemp
                            '
                            'Here also need of NTFS  Security privilage but it is not neccessory to do so.


                            'setting file attribute
                            System.IO.File.SetAttributes(path, IO.FileAttributes.Normal)
                            System.IO.File.Delete(path)
                            Responce.Add("Finaly File Deleted : " + path)
                        Catch 'exa As Exception
                            'killProcessById.Add(exa.Message)

                            Try
                                'Second Attempt
                                System.Threading.Thread.Sleep(100)
                                System.IO.File.SetAttributes(path, IO.FileAttributes.Normal)
                                System.IO.File.Delete(path)
                                Responce.Add("Finaly File Deleted : " + path)
                                'Return EventArrayList
                            Catch exb As Exception
                                Responce.Add("Can not delete File : " + exb.Message)
                                'Return EventArrayList
                            End Try
                        End Try
                    Else
                        Responce.Add("File Not found : " + path)
                    End If
                End If
                '***************************************************************************
            Catch ex As Exception
                Responce.Add(ex.Message + vbNewLine)
            End Try
        End If
        Return Responce

    End Function


#End Region
End Class
