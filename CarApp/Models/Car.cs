using System;

namespace CarApp.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; } 
        public string Model { get; set; } 
        public int Year { get; set; } 
        public string Description { get; set; } 
        public string ImagePath { get; set; 
        public DateTime CreatedAt { get; set; } 
        public DateTime ModifiedAt { get; set; } 
    }
}
