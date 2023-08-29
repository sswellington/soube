namespace Infrastructure.DataAccess.Repositories;

public abstract class BaseRepository<TEntity> where TEntity : class
{
	public virtual IEnumerable<TEntity> GetAll()
	{
		return new List<TEntity>();
	}
}