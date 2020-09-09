namespace Infrastructure
{
    public interface IDbSeed
    {
        void SeedDb(TodoContext ctx);
    }
}