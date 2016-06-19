using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Data_Entry
{
    public partial class TasksPage : ContentPage
    {
        public List<Member> Members { get; set; }
        public TasksPage(List<Member> members)
        {
            Members = members;
            BindingContext = this;
            InitializeComponent();
        }

        public async void OnSelected(object obj, ItemTappedEventArgs args)
        {
            var member = args.Item as Member;
            await DisplayAlert("You selected", member.FirstName + " " + member.MiddleName + " " + member.LastName, "OK");
        }
    }
}
