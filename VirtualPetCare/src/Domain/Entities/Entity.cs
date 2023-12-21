namespace Domain.Entities;

public class Entity<TId>
{
    public TId Id { get; set; }

    public Entity()
    {
        Id = default!;
    }

    public Entity(TId id)
    {
        Id = id;
    }
}