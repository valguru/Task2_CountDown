using System;
using NUnit.Framework;
using Task2;

namespace Task2
{
    public class CountDownTest
    {
        [Test]
        public void SubscribeOne()
        {
            CountDown timer = new CountDown();
            var subscriber = new Subscriber(timer, "subscriber");
            timer.Skip(1000, "event");
        }
        [Test]
        public void UnsubscribeOne()
        {
            CountDown timer = new CountDown();
            var subscriber = new Subscriber(timer, "subscriber");
            subscriber.Ubsubscribe();
            timer.Skip(1000, "event");
        }
        [Test]
        public void SubscribeOneFullCycle()
        {
            CountDown timer = new CountDown();
            var subscriber = new Subscriber(timer, "subscriber");
            timer.Skip(1000, "event_1");
            timer.Skip(1000, "event_2");
            subscriber.Ubsubscribe();
            timer.Skip(1000, "event_3");
        }
        [Test]
        public void SubscribeSeveral()
        {
            CountDown timer = new CountDown();
            Subscriber[] subscribers = {
                new Subscriber(timer, "subscriber_1"),
                new Subscriber(timer, "subscriber_2"),
                new Subscriber(timer, "subscriber_3"),
            };
            timer.Skip(1000, "event_1");
        }
        [Test]
        public void SubscribeSeveralFullCycle()
        {
            CountDown timer = new CountDown();
            Subscriber[] subscribers = {
                new Subscriber(timer, "subscriber_1"),
                new Subscriber(timer, "subscriber_2"),
                new Subscriber(timer, "subscriber_3"),
            };
            for (int i = 0; i < subscribers.Length; i++)
            {
                timer.Skip(1000, $"event_{i}");
                subscribers[i].Ubsubscribe();
            }
        }
    }
}