Imports Prism.Commands

Public Class GetAllBookVM

    Public Property ClickCommand As DelegateCommand
    Public Property _service As CarService

    Public Sub New(service As CarService)
        _service = service
        ClickCommand = New DelegateCommand(AddressOf DII)
    End Sub

    Public Sub DII()
        _service.DenemeFunc()
    End Sub
End Class
