using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace DataGridGrouping
{
    public class ViewModel
    {
        public CollectionViewSource CollectionView { get; set; } = new CollectionViewSource();
        public ReactiveCollection<User> Users { get; set; } = new ReactiveCollection<User>();
        public ViewModel()
        {
            // 初期データを作成
            Todo changePassword = new Todo();
            changePassword.Name.Value = "Change Password";
            changePassword.Content.Value = "change your password. init password is \"hack me\"";
            User user1 = new User();
            user1.Todos.Add(changePassword);
            User user2 = new User();
            user2.Todos.Add(changePassword);

            Users.Add(user1);
            Users.Add(user2);

            //CollectionViewSourceを作成
            CollectionView.IsSourceGrouped = true;
            CollectionView.Source = Users;
            CollectionView.ItemsPath = new Windows.UI.Xaml.PropertyPath("Todos");
        }
        public void AddUser()
        {
            Todo changePassword = new Todo();
            changePassword.Name.Value = "Change Password";
            changePassword.Content.Value = "change your password. init password is \"hack me\"";

            User user = new User();
            user.Todos.Add(changePassword);
            Users.Add(user);
        }
    }
}
