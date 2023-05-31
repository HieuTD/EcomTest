using eShopSolution.ViewModels.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ApiIntergration
{
    public interface ISlideApiClient
    {
        Task<List<SlideVm>> GetAll();
    }
}
