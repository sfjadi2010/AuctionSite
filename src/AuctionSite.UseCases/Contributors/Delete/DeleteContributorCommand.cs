using Ardalis.Result;
using Ardalis.SharedKernel;

namespace AuctionSite.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
