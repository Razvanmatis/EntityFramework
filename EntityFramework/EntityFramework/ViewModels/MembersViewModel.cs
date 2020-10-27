using EntityFramework.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.ViewModels
{
    public class MembersViewModel : ViewModelBase
    {
        private DelegateCommand saveCommand;

        public MembersViewModel()
        {
            SaveCommand = new DelegateCommand((x) => SaveValue(), (x) => true);
        }

        public DelegateCommand SaveCommand { get { return saveCommand; } set { SetValue(ref saveCommand, value, nameof(SaveCommand)); } }

        private void SaveValue()
        {
            DatabaseHelper.SaveMember("test");
        }
    }
}
