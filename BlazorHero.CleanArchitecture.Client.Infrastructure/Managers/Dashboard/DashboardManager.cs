﻿using BlazorHero.CleanArchitecture.Application.Features.Dashboard.GetData;
using BlazorHero.CleanArchitecture.Client.Infrastructure.Extensions;
using BlazorHero.CleanArchitecture.Shared.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorHero.CleanArchitecture.Client.Infrastructure.Managers.Dashboard
{
    public class DashboardManager : IDashboardManager
    {
        private readonly HttpClient _httpClient;

        public DashboardManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult<DashboardDataResponse>> GetDataAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync(Routes.DashboardEndpoint.GetData);
                var data = await response.ToResult<DashboardDataResponse>();
                return data;
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
}
