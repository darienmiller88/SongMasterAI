using api.v1.Models;

namespace api.v1.Services;

public interface ITempservices
{
    Task<TempModel> GetTemp();
    Task<TempModel> PostTemp();
    Task<TempModel> PutTemp();
    Task<TempModel> DeleteTemp();
}

public class TempServices : ITempservices
{
    public Task<TempModel> DeleteTemp()
    {
        throw new NotImplementedException();
    }

    public Task<TempModel> GetTemp()
    {
        throw new NotImplementedException();
    }

    public Task<TempModel> PostTemp()
    {
        throw new NotImplementedException();
    }

    public Task<TempModel> PutTemp()
    {
        throw new NotImplementedException();
    }
}