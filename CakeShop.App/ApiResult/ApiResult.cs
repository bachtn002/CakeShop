namespace CakeShop.Service.ApiResult
{
    public class ApiResult<T>
    {


        private bool isSuccessed;
        private string message;
        private T resultObj;

        public bool IsSuccessed { get => isSuccessed; set => isSuccessed = value; }
        public string Message { get => message; set => message = value; }
        public T ResultObj { get => resultObj; set => resultObj = value; }
    }
}
