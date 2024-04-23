using System;
using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentRepositories.Entities;

public class ComponentRepository<T> : IComponentRepository<T>
{
    private readonly List<T> _storage = new List<T>();

    public IReadOnlyCollection<T> Storage => _storage;

    public void AddItem(T item)
    {
        if (item is null)
        {
            throw new ArgumentNullException(nameof(item));
        }

        _storage.Add(item);
    }

    public void DeleteItem(T item)
    {
        if (item is null)
        {
            throw new ArgumentNullException(nameof(item));
        }

        _storage.Remove(item);
    }

    public T? FindItem(T item)
    {
        return _storage.Find(x => EqualityComparer<T>.Default.Equals(x, item));
    }
}