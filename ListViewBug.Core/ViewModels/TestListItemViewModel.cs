using System;
using Cirrious.MvvmCross.ViewModels;

namespace ListViewBug.Core
{
	public class TestListItemViewModel : MvxViewModel
	{
		public TestListItemViewModel ()
		{
		}

		private string _title;
		public string Title {
			get { return _title; }
			set { _title = value; RaisePropertyChanged (() => Title); }
		}
	}
}

