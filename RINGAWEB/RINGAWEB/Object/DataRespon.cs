namespace RINGAWEB.Object
{
    public class DataRespon<T>
    {
        public T Data { get; set; }
        public int status { get; set; }
        public string message { get; set; }
    }
}
