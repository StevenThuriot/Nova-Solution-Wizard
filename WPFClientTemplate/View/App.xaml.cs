using Ninject;
using Nova;

namespace $safeprojectname$
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App
	{
		private static IKernel _Kernel;

		/// <summary>
		/// Gets an instance of the specified type T.
		/// </summary>
		/// <typeparam name="T">The type of instance you want to get.</typeparam>
		/// <returns>An instance of type T.</returns>
		internal static T Get<T>()
		{
			if (_Kernel == null)
			{
				_Kernel = new StandardKernel();
				_Kernel.Load("$safesolutionname$.*.dll");
			}

			return _Kernel.Get<T>();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="App"/> class.
		/// </summary>
		/// <exception cref="T:System.InvalidOperationException">More than one instance of the <see cref="T:System.Windows.Application"/> class is created per <see cref="T:System.AppDomain"/>.</exception>
		public App()
		{
			Startup += NovaFramework.Start;
			//Nova.Base.ExceptionHandler.ShowStackTrace = true;
		}
	}
}
