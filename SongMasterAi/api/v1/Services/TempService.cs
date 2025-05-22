namespace api.v1.Services;

public interface ITempservices{
    string GetTemp();
    string PostTemp();
    string PutTemp();
    string DeleteTemp();
}

public class TempServices : ITempservices
{
    public string DeleteTemp()
    {
        throw new NotImplementedException();
    }

    public string GetTemp()
    {
        throw new NotImplementedException();
    }

    public string PostTemp()
    {
        throw new NotImplementedException();
    }

    public string PutTemp()
    {
        throw new NotImplementedException();
    }
}