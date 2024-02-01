Imports GökalpLibrary.Modules.CreateBook
Imports GökalpLibrary.Modules.GetAllBook
Imports Prism.Ioc
Imports Prism.Modularity
Imports Prism.Regions

Public Class MainModule
    Implements IModule

    Private ReadOnly _regionManager As IRegionManager

    Public Sub New(regionManager As IRegionManager)
        _regionManager = regionManager
    End Sub

    Public Sub RegisterTypes(containerRegistry As IContainerRegistry) Implements IModule.RegisterTypes
        containerRegistry.RegisterForNavigation(Of ViewGetAllBook, GetAllBookVM)
        containerRegistry.RegisterForNavigation(Of ViewMain, ViewMainVM)
    End Sub

    Public Sub OnInitialized(containerProvider As IContainerProvider) Implements IModule.OnInitialized
        _regionManager.RegisterViewWithRegion("ViewMain", GetType(ViewMain))
    End Sub
End Class
