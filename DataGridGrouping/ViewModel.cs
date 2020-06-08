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
        //public ReactiveCollection<Grouping<User, Todo>> Todos { get; set; } = new ReactiveCollection<Grouping<User, Todo>>();
        public GroupedCollection<User, Todo> Todos { get; set; } = new GroupedCollection<User, Todo>();
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

            
            //Todos.Add(new Grouping<User, Todo>(user1, user1.Todos));
            //Todos.Add(new Grouping<User, Todo>(user2, user2.Todos));
            Todos.Add(user1,changePassword);
            Todos.Add(user2,changePassword);
            //CollectionViewSourceを作成
            CollectionView.IsSourceGrouped = true;

            //collectionBinding.SetB
            CollectionView.Source = Todos;
            //CollectionView.ItemsPath = new Windows.UI.Xaml.PropertyPath("Todos");
        }
        public void AddUser()
        {
            Todo changePassword = new Todo();
            changePassword.Name.Value = "Change Password2";
            
            changePassword.Content.Value = "change your password. init password is \"hack me\"";

            User user = new User();
            user.Todos.Add(changePassword);
            Users.Add(user);
            Todos.Add(user,changePassword);
            //Todos.Add(new Grouping<User, Todo>(user, user.Todos));
        }
    }
}
