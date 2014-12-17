using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;

namespace ListViewBug.Core.ViewModels
{
    public class TestListViewModel : MvxViewModel
    {

		int offset = 100;
		int batchSize = 10;

		private List<TestListItemViewModel> _items = new List<TestListItemViewModel> ();
		public List<TestListItemViewModel> Items {
			get { return _items; }
			set {
				_items = value;
				RaisePropertyChanged (() => Items);
			}
		}

		public ICommand AppendCommand {
			get {
				return new MvxCommand (() => AppendItems () );
			}
		}

		public ICommand ReplaceCommand {
			get {
				return new MvxCommand (() => ReplaceItems () );
			}
		}

		public void Init() {
			ReplaceItems ();
		}

		private void ReplaceItems() {
			Items = GenerateWithCurrentOffset ();
			AfterLoad ();
		}

		public void AppendItems ()
		{
			var newItems = GenerateWithCurrentOffset ();
			Items.AddRange (newItems);
			AfterLoad ();
		}

		private List<TestListItemViewModel> GenerateWithCurrentOffset() {
			var res = Generator.Generate (offset, batchSize);
			return res.Select((s) => new TestListItemViewModel() { Title = s }).ToList ();
		}

		private void AfterLoad() {
			RaisePropertyChanged (() => Items);
			offset += batchSize;
		}

    }
}
