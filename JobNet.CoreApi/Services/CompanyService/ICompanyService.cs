﻿using JobNet.CoreApi.Models.Request;
using JobNet.CoreApi.Models.Response;
using JobNet.CoreApi.Data.Entities;
namespace JobNet.CoreApi.Services;

public interface ICompanyService
{
    Task<List<Company>> GetAllCompanies();
    Task<Company> CreateCompany(CreateCompanyApiRequest createCompanyApiRequest);
}