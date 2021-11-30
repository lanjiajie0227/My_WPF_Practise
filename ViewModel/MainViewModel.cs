using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using WpfApp2.Models;
using WpfApp2.Pages;

namespace WpfApp2.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            pageModel = new List<PageButtonModel>
            {
                new PageButtonModel() { Name = "��ҳ" },
                new PageButtonModel() { Name = "����" },
                new PageButtonModel() { Name = "��Ϣ" },
                new PageButtonModel() { Name = "�ҵ�" },
                new PageButtonModel() { Name = "����" }
            };

            OpenCommand = new RelayCommand<string>(OpenPage);
        }

        public List<PageButtonModel> pageModel { get; private set; }

        public RelayCommand<string> OpenCommand { get; private set; }

        private object page;
        public object Page
        {
            get { return page; }
            set { page = value; RaisePropertyChanged(); }
        }

        public void OpenPage(string Name)
        {
            switch (Name)
            {
                case "��ҳ":
                    Page = new Page1();
                    break;
                case "����":
                    Page = new Page2();
                    break;
                case "��Ϣ":
                    Page = new Page3();
                    break;
                case "�ҵ�":
                    Page = new Page4();
                    break;
                case "����":
                    Page = new Page5();
                    break;
            }
        }
    }
}