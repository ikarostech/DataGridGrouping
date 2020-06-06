using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridGrouping
{
    public class Todo
    {
        public ReactiveProperty<string> Name { get; set; } = new ReactiveProperty<string>("TaskName");
        public ReactiveProperty<string> Content { get; set; } = new ReactiveProperty<string>("TaskContent");
    }
}
