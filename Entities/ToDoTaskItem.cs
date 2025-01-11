namespace ToDoList.Entities
{
    public class ToDoTaskItem
    {
        public string Title { get; set; }
        public DateTime DateCreated { get; init; }
        public DateTime DueDate { get; set; }
        public bool Priority { get; set; }
        public Status CurrentStatus { get; set; }


        public ToDoTaskItem(string title)
        {
            Title = title;
            DateCreated = DateTime.Now;
            CurrentStatus = Status.Open;
        }

        public enum Status
        {
            Completed,
            Open,
            Blocked
        }
    }
}
