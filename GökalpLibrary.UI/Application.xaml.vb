﻿Imports GökalpLibrary.Modules.Main
Imports Prism.Ioc
Imports Prism.Modularity
Imports Prism.Unity

Class Application
    Inherits PrismApplication

    Protected Overrides Sub ConfigureModuleCatalog(moduleCatalog As IModuleCatalog)
        MyBase.ConfigureModuleCatalog(moduleCatalog)
        moduleCatalog.AddModule(Of MainModule)
    End Sub

    Protected Overrides Sub RegisterTypes(containerRegistry As IContainerRegistry)
        containerRegistry.RegisterForNavigation(Of ViewMain)
    End Sub

    Protected Overrides Function CreateShell() As Window
        Return Container.Resolve(Of MainWindow)
    End Function


End Class
