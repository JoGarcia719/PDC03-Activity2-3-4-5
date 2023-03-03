using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace PDC03_MODULE02NEW
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity5 : ContentPage
    {
        ObservableCollection<employee> employees = new ObservableCollection<employee>();
        public ObservableCollection<employee> Employees { get { return employees; } }
        public activity5()
        {
            InitializeComponent();

            {
                lst.ItemsSource = employees;

                employees.Add(new employee { DisplayName = "Juan Dela Cruz", Position = "President", profileimage= "image1.jpg"});
                employees.Add(new employee { DisplayName = "Peter", Position = "Vice President", profileimage = "image2.jpg" });
                employees.Add(new employee { DisplayName = "Mary", Position = "Secretary", profileimage = "image3.jpg" });
            }
        }
    }
}