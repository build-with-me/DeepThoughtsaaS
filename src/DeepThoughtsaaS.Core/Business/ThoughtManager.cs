using Microsoft.EntityFrameworkCore;

namespace DeepThoughtsaaS.Core;
public class ThoughtManager : IThoughtManager
{
    private ThoughtDbContext _context;

    public ThoughtManager(ThoughtDbContext context)
    {
        _context = context;
    }

    public async Task<Thought> GetRandomThoughtAsync()
    {
        Thought thought = await _context.Thoughts
                                .OrderBy(r => Guid.NewGuid())
                                .Take(1)
                                .FirstAsync();

        thought.Views++;
        await _context.SaveChangesAsync();

        return thought;
    }

    public async Task<Thought?> GetThoughtAsync(int id)
    {
        return await _context.Thoughts.FindAsync(id);
    }

    public async Task<List<Thought>> GetThoughtsAsync()
    {
        return await _context.Thoughts.ToListAsync();
    }

    public async Task<Thought> VoteAsync(int id, bool isUpvote)
    {
        var thought = await _context.Thoughts.FindAsync(id);
        if (thought == null)
        {
            throw new ArgumentException("Thought not found");
        }

        if (isUpvote)
        {
            thought.Upvotes++;
        }
        else
        {
            thought.Downvotes++;
        }

        await _context.SaveChangesAsync();
        return thought;
    }
}
