﻿
// Add services to the container.


// Configure the HTTP request pipeline.


public class TodoItem
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool IsComplete { get; set; }
}