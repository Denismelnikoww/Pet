﻿namespace Cinema.Contracts
{
    public record RegisterRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}


