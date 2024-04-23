using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab3.Messages.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees.Entities;

public class AddresseeGroup : IAddressee
{
    private readonly List<AddresseeUser> _observers;

    public AddresseeGroup(IEnumerable<AddresseeUser> observers)
    {
        _observers = observers.ToList();
    }

    public IEnumerable<AddresseeUser> Observers => _observers;
    public void Subscribe(AddresseeUser observer)
    {
        AddresseeUser? subscribedObserver = _observers.FirstOrDefault(observerInGroup => observerInGroup.Equals(observer));
        if (subscribedObserver is not null)
        {
            throw new InvalidOperationException("The user is already subscribed");
        }

        _observers.Add(observer);
    }

    public void Unsubscribe(AddresseeUser observer)
    {
        AddresseeUser? subscribedObserver = _observers.FirstOrDefault(observerInGroup => observerInGroup.Equals(observer));
        if (subscribedObserver is null)
        {
            throw new InvalidOperationException("The user is not subscribed to become unsubscribed");
        }

        _observers.Remove(observer);
    }

    public void NotifyObservers(IMessage message)
    {
        foreach (AddresseeUser observer in _observers)
        {
            observer.ReceiveMessage(message);
        }
    }

    public void ReceiveMessage(IMessage message)
    {
        NotifyObservers(message);
    }
}