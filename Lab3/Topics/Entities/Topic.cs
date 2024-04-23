using Itmo.ObjectOrientedProgramming.Lab3.Addressees.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Messages.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Topics.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Topics.Entities;

public class Topic
{
    public Topic(TopicTitle title, IAddressee recipient)
    {
        Title = title;
        Recipient = recipient;
    }

    public TopicTitle Title { get;  }
    public IAddressee Recipient { get;  }
    public void SendMessage(IMessage message)
    {
        Recipient.ReceiveMessage(message);
    }
}
