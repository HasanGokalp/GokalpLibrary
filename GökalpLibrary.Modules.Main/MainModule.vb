Imports GökalpLibrary.Modules.CreateBook
Imports GökalpLibrary.Modules.GetAllBook
Imports Prism.Ioc
Imports Prism.Modularity
Imports Prism.Regions

Public Class MainModule
    Implements IModule

    Public Sub RegisterTypes(containerRegistry As IContainerRegistry) Implements IModule.RegisterTypes
        containerRegistry.RegisterForNavigation(Of CreateBookModule)
        containerRegistry.RegisterForNavigation(Of GetAllBookModule)
    End Sub

    Public Sub OnInitialized(containerProvider As IContainerProvider) Implements IModule.OnInitialized
        Dim deneme = containerProvider.Resolve(Of IRegionManager)
        deneme.RegisterViewWithRegion("ViewMain", GetType(ViewMain))
    End Sub
End Class
