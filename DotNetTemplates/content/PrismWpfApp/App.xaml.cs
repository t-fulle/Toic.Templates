using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace ROOT_NAMESPACE
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindowView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            IModuleCatalog moduleCatalog = new DirectoryModuleCatalog() { ModulePath = @"." };
            //#if DEBUG
            //            moduleCatalog.Initialize();
            //#endif
            return moduleCatalog;
        }
    }
}

