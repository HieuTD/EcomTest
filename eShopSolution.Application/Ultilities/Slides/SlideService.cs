using eShopSolution.Data.EF;
using eShopSolution.ViewModels.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Ultilities.Slides
{
    public class SlideService : ISlideService
    {
        private readonly EShopDbcontext _context;

        public SlideService(EShopDbcontext context)
        {
            _context = context;
        }
        public async Task<List<SlideVm>> GetAll()
        {
            var slides = await _context.Slides
                .OrderBy(x => x.SortOrder)
                .Select(x => new SlideVm()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Url = x.Url,
                    Image = x.Image
                }).ToListAsync();
            return new List<SlideVm>(slides);
        }
    }
}
