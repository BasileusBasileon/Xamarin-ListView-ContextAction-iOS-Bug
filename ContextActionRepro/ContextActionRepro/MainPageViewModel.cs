using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace ContextActionRepro
{
	public class MainPageViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected bool SetProperty<T>(ref T storage, T value,
									  [CallerMemberName] string propertyName = null)
		{
			if (Object.Equals(storage, value))
				return false;

			storage = value;
			OnPropertyChanged(propertyName);
			return true;
		}

		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		private Command _contextCommand;
		public ICommand ContextCommand => _contextCommand ?? (_contextCommand = new Command(ContextMethod, CanContextCommand));

		private bool CanContextCommand(object arg)
		{
			return false;
		}

		private void ContextMethod(object obj)
		{
			// ...
		}
	}
}
