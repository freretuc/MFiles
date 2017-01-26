Public MFClient As New MFilesAPI.MFilesClientApplication
Public MFServer As New MFilesAPI.MFilesServerApplication
Public MFVault As New MFilesAPI.Vault

Public Function MFGetVaults() As MFilesAPI.VaultsOnServer

    MFConnect()
    Return MFServer.GetVaults()

End Function

Public Sub MFConnect()

    MFServer.Connect(AuthType:=MFilesAPI.MFAuthType.MFAuthTypeSpecificMFilesUser, UserName:="_USER_", Password:="_PASSWORD_", NetworkAddress:="_SERVER_")

End Sub

Public Sub MFConnectToVault(ByVal VaultGUID As String)

    MFVault = MFServer.LogInToVault(VaultGUID)

End Sub
