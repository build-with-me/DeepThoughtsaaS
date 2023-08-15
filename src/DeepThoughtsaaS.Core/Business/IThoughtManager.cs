namespace DeepThoughtsaaS.Core;
public interface IThoughtManager
{
    Task<Thought> GetRandomThoughtAsync();
    Task<Thought?> GetThoughtAsync(int id);
    Task<List<Thought>> GetThoughtsAsync();
    Task<Thought> VoteAsync(int id, bool isUpvote);
}
