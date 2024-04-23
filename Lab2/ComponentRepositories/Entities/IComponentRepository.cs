using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentRepositories.Entities;

public interface IComponentRepository<T>
{
    IReadOnlyCollection<T> Storage { get; }
    public void AddItem(T item);
    void DeleteItem(T item);
    T? FindItem(T item);
}