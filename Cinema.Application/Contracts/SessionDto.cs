﻿using Cinema.Models;

namespace Cinema.Contracts
{
    public record SessionDto
    {
        public int HallId { get; set; }
        public int MovieId { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Price { get; set; }
    }
}
