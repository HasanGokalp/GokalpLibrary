Imports GökalpLibrary.Modules.GetAllBook
Imports Prism.Ioc
Imports Prism.Modularity
Imports Prism.Unity

Class Application
    Inherits PrismApplication

    Protected Overrides Sub ConfigureModuleCatalog(moduleCatalog As IModuleCatalog)
        MyBase.ConfigureModuleCatalog(moduleCatalog)
        moduleCatalog.AddModule(Of GetAllBookModule)
    End Sub

    Protected Overrides Sub RegisterTypes(containerRegistry As IContainerRegistry)
        containerRegistry.RegisterForNavigation(Of ViewGetAllBook)
        containerRegistry.RegisterForNavigation(Of MainWindow, MainVM)
    End Sub

    Protected Overrides Function CreateShell() As Window
        Return Container.Resolve(Of MainWindow)
    End Function


End Class
