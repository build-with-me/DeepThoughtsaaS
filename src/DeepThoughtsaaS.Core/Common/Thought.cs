using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DeepThoughtsaaS.Core;
public class Thought
{
    [Key]
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public int Views { get; set; }
    public int Upvotes { get; set; }
    public int Downvotes { get; set; }
}
