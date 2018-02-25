﻿using System;

namespace BookStore.Grains.Events.BookStore
{
    [Serializable]
    public class BookStoreInitializedEvent : Event
    {
        public BookStoreInitializedEvent(Guid id, string name, AddressEventData address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
        
        public Guid Id { get; private set; }
        
        public string Name { get; private set; }
        
        public AddressEventData Address { get; private set; }
    }
}