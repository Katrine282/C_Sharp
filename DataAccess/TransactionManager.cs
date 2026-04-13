using DataAccess.Context;

namespace DataAccess;

public class TransactionManager
{
    private StuderendeContext context = new StuderendeContext();
    
    public void ExecuteTransaction(Action work)
    {

        using var transaction = context.Database.BeginTransaction();

        try
        {
            work();

            context.SaveChanges();

            transaction.Commit();
        }
        catch (Exception)
        {
            transaction.Rollback();
            throw;
        } finally
        {
            context.Dispose();
        }
    }

    internal StuderendeContext GetCurrentContext()
    {
        return context;
    }
}