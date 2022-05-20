using HotChocolateWithIdentity.Domain.Common;
using System;
using System.Collections.Generic;

namespace HotChocolateWithIdentity.Domain.Entities
{
    public class TodoList : AuditableEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Colour { get; set; }

        public IList<TodoItem> Items { get; set; }
            = new List<TodoItem>();
    }
}
