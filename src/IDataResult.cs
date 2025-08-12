namespace MyResults
{
    //eğer dönüş olarak data modelini dönmek istersek.
    //IDataResult IResult'daki succes ve message ifadelerini içerir.
    public interface IDataResult<out T>:IResult
    {
        T Data { get; }
    }
}
