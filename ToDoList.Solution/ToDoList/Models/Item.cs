namespace ToDoList.Models
{
    ...
    {
        ...
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}