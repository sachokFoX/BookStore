﻿namespace BookStore.Client.Requests.BookStore
{
    public class AddressRequest
    {
        public string Country { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string Building { get; set; }
    }
}