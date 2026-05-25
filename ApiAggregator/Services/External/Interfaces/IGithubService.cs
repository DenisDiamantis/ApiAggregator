using ApiAggregatorService.Models;
using ApiAggregatorService.Models.Enums;

namespace ApiAggregator.Services.External.Interfaces
{
	public interface IGithubService
	{
		Task<List<GithubRepo>> GetUserReposAsync(
			string username,
			RepoSortMode? sort = null,
			bool ascending = false,
			int limit = 3,
			CancellationToken ct = default);
	}
}
