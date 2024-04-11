namespace BlazorApp1
{
    public class TodoItem
    {
        public string? Title { get; set; }
        public bool IsDone { get; set; }
    }

    public static class TodoItemExtensions
    {
        public static string TitlePlaceHolderText(this TodoItem item)
        {
            if (string.IsNullOrEmpty(item.Title))
            {
                return "Something todo";
            } else
            {
                return "";
            }
        }
    }
}
