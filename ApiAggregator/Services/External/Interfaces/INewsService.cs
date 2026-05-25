using ApiAggregatorService.Models.Enums;
using ApiAggregatorService.Models.News;

namespace ApiAggregator.Services.External.Interfaces
{
	public interface INewsService
	{
		Task<NewsResponse> GetLatestHeadlinesAsync(NewsCategory category);
	}

}
