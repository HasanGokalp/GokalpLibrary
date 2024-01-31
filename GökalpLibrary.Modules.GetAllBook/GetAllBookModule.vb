Imports Prism.Ioc
Imports Prism.Modularity
Imports Prism.Regions

Public Class GetAllBookModule
    Implements IModule

    Private ReadOnly _regionManager As IRegionManager

    Public Sub New(regionManager As IRegionManager)
        _regionManager = regionManager
    End Sub


    Public Sub RegisterTypes(containerRegistry As IContainerRegistry) Implements IModule.RegisterTypes
        containerRegistry.RegisterForNavigation(Of ViewGetAllBook)
    End Sub

    Public Sub OnInitialized(containerProvider As IContainerProvider) Implements IModule.OnInitialized
        _regionManager.RegisterViewWithRegion("GetAllBookRegion", GetType(ViewGetAllBook))
    End Sub
End Class
