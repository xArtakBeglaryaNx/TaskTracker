using System.ComponentModel.DataAnnotations;

namespace TaskTracker.Models;

/// <summary>
/// Properties of Project Entity
/// </summary>
public class Project
{
    public int Id { get; set; }
    
    [Required]
    public string? Name { get; set; }
    public DateTime StartDate { get; set; } = DateTime.Now.Date;
    public DateTime CompletionDate { get; set; } = DateTime.Today.Date;
    
    //This property need for get selected status from ProjectStatus[Required]
    public ProjectStatus ProjectStatus { get; set; }
    public int Priority { get; set; }

    
}