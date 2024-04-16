﻿namespace Newsletter.Domain.Entities;

public sealed class Blog
{
    public Blog()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
    public string Url { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty; //dolu ya da boş olmalı
    public string Summary { get; set; } = string.Empty;
    public DateOnly? PublishDate { get; set; }
    public bool IsPublish { get; set; }
}

