using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamsPlatform.ClientWPF.ViewModels
{
	internal class ModelVM : INotifyPropertyChanged
	{
		public ModelVM()
		{
		}
		// event that handle updating the gui when a binded property is changing.
		public event PropertyChangedEventHandler? PropertyChanged;
		/// <summary>
		/// update the gui that uses a property as Context. will be used when a property was changed.
		/// </summary>
		/// <param name="propertyName"> the name of the property that changed. when this methode is invoked, from the set of the property that
		/// has been changed, then there is no need to set value in propertyName, it will automaticly take the name of the propety
		/// (thank to [CallerMemberName]).
		/// </param>
		protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

