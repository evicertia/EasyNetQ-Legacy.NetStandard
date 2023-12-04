using System;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace EasyNetQ
{
    public interface IPublisherConfirms
    {
        void RegisterCallbacks(IModel channel, Action successCallback, Action failureCallback);
        void SuccessfulPublish(object channel, BasicAckEventArgs args);
        void FailedPublish(object channel, BasicNackEventArgs args);
    }
}