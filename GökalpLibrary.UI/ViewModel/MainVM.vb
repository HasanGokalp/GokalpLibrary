Imports Prism.Commands
Imports Prism.Mvvm
Imports Prism.Regions

Public Class MainVM
    Inherits BindableBase

    Public Property NavigeteCommand As DelegateCommand
    Public Property _regionManager As IRegionManager

    Public Sub New(regionManager As IRegionManager)
        _regionManager = regionManager
        NavigeteCommand = New DelegateCommand(AddressOf Navigete)
    End Sub

    Public Sub Navigete()
        _regionManager.RequestNavigate("MainContent", "ViewGetAllBook")
    End Sub

End Class
