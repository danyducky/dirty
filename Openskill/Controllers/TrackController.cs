using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Openskill.DataAccess;
using Openskill.Helpers.Enums;
using Openskill.Helpers.Filters;
using Openskill.ViewModels.Shared;
using Openskill.ViewModels.Track;

namespace Openskill.Controllers
{
    [Authorize]
    [Menu(MenuItem.Tracks)]
    [Route("track")]
    public class TrackController : Controller
    {
        private readonly AppDbContext dbContext;

        public TrackController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var tracks = await dbContext.Tracks
                .OrderBy(track => track.Id)
                .ToListAsync();

            return View(new TrackIndexViewModel
            {
                Tracks = tracks.Where(track => !track.IsAdditional)
                               .Select(track => new TrackViewModel(track.Title, track.Description, track.Id)),
                AdditionalTracks = tracks.Where(track => track.IsAdditional)
                                         .Select(track => new TrackViewModel(track.Title, track.Description, track.Id))
            });
        }

        [HttpGet("info/{id:int}")]
        public async Task<IActionResult> Info(int id)
        {
            var track = await dbContext.Tracks
                .Include(track => track.TrackModules)
                .ThenInclude(tm => tm.Module)
                .FirstOrDefaultAsync(track => track.Id == id);

            var viewmodel = new TrackInfoViewModel
            {
                Id = track.Id,
                Title = track.Title,
                Description = track.Description,
                Modules = track.TrackModules.Select(x => new ModuleViewModel(x.Module.Id, x.Module.Title, x.Module.Content))
            };

            return View(viewmodel);
        }

        [HttpGet("{id:int}/module/{moduleId:int}")]
        public async Task<IActionResult> Module(int id, int moduleId)
        {
            var track = await dbContext.Tracks
                .Include(track => track.TrackModules)
                .ThenInclude(tm => tm.Module)
                .FirstOrDefaultAsync(track => track.Id == id);

            var hasTrackRequestedModule = track.TrackModules.Any(x => x.ModuleId == moduleId);
            if (!hasTrackRequestedModule)
            {
                return RedirectToAction(nameof(Info), id);
            }

            var module = await dbContext.Modules.FindAsync(moduleId);
            var maxModuleId = track.TrackModules.Max(tm => tm.ModuleId);

            var viewmodel = new TrackModuleViewModel
            {
                Id = track.Id,
                Title = track.Title,
                Description = track.Description,
                Modules = track.TrackModules.Select(x => new ModuleViewModel(x.Module.Id, x.Module.Title, x.Module.Content)),
                ModuleId = module.Id,
                Caption = module.Title,
                Content = module.Content,
                VideoPath = module.VideoPath,
                IsLast = module.Id == maxModuleId
            };
            return View(viewmodel);
        }
    }
}
