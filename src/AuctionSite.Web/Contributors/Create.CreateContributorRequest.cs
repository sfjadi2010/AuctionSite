﻿using System.ComponentModel.DataAnnotations;

namespace AuctionSite.Web.Endpoints.ContributorEndpoints;

public class CreateContributorRequest
{
  public const string Route = "/Contributors";

  [Required]
  public string? Name { get; set; }
}
