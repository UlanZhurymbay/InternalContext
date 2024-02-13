namespace WebApplication1
{
    internal interface IRepository<T> where T : class
    { 
        Task<T> GetUserAsync();
        void GetEntity();
    }
}
