using Ardalis.Result;
using Ardalis.SharedKernel;

namespace AuctionSite.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
