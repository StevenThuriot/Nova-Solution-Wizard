using Nova.Controls;
using $safeprojectname$.ViewModel;

namespace $safeprojectname$.Views
{
	/// <summary>
	/// The main view.
	/// This is used as an inbetween class so we don't have to use generics in xaml.
	/// </summary>
	public abstract class MainView : BorderlessWindow<MainWindow, MainViewModel>
	{
	}
}
