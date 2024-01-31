Imports Prism.Commands
Imports Prism.Mvvm
Imports Prism.Regions

Public Class ViewMainVM
    Inherits BindableBase

    Public Property NavigateCommand As DelegateCommand

    Private Property _regionManager As IRegionManager

    Public Sub New(regionManager As IRegionManager)
        _regionManager = regionManager
        NavigateCommand = New DelegateCommand(AddressOf Navigate)
    End Sub

    Public Sub Navigate()
        _regionManager.RequestNavigate("MainContent", "ViewGetAllBook")
    End Sub

End Class
