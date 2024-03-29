﻿using System.ComponentModel.DataAnnotations.Schema;
using JobNet.CoreApi.Data.Entities;

namespace JobNet.CoreApi.Models.Response;

public class GetJobsApiResponse
{
    public int JobId { get; set; }
    
    public string JobTitle { get; set; }
    
    public string Description { get; set; }
    
    public string Location { get; set; }
    
    public DateTime PostedAt { get; set; }
    
    public DateTime Deadline { get; set; }
    
    public int PublisherId { get; set; }
    public UserTalentManagerResponse PublisherUser { get; set; }
    
    [ForeignKey("CompanyId")]
    public int? CompanyId { get; set; }
    public GetCompanyApiResponse? Company { get; set; }

    public ICollection<UserSimpleWithSimpleCompanyResponse>? AppliedUsers { get; set; } = new List<UserSimpleWithSimpleCompanyResponse>();
}