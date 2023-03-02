namespace WebMVC.Models
{
    public class ResponseViewModel<T> where T : class
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
