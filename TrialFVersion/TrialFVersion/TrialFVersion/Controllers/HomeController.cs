using Microsoft.AspNetCore.Mvc;
using TrialFVersion.Model;
using TrialFVersion.Service;
using TrialFVersion.ViewModel;

namespace TrialFVersion.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private IAliasersService aliasersService { get; set; }

        public HomeController(IAliasersService aliasersService)
        {
            this.aliasersService = aliasersService;
        }

        [HttpGet("/")]
        public IActionResult Index(int aliaserId, bool inUse)
        {
            IndexViewModel vm = new IndexViewModel
            {
                Aliaser = aliasersService.GetAlias(aliaserId)!,
                InUse = inUse,
            };
            return View("Index",vm);
        }

        [HttpPost("savelink")]
        public IActionResult SaveLink(string url, string alias)
        {
            if (aliasersService.IsAliasInUse(alias))
            {
                return RedirectToAction("Index", new { inUse = true });
            }
            else
            {
                Aliaser aliaser = aliasersService.AddAlias(url, alias);
                return RedirectToAction("index", new { aliaserId = aliaser.Id });
            }
            return RedirectToAction("Index");
        }

        [HttpGet("/a/{alias}")]
        public IActionResult RedirectToAlias(string alias)
        
        {
            if (aliasersService.IsAliasInUse(alias))
            {
                var searchAlias = aliasersService.FindAliasersByAlias(alias);
                aliasersService.HitCountIncrease(alias);
                return Redirect(searchAlias.Url);
            }
            else
            {
                return StatusCode(404);
            }
        }

        [HttpGet("/api/links")]
        public IActionResult Links()
        {
            return Ok(aliasersService.GetList());
        }

        [HttpDelete("/api/links/{id}")]
        public IActionResult Delete(int id, [FromBody] SecretCodeModel scode)
        {
            Aliaser r = aliasersService.GetAlias(id)!;

            if (r is null)
                return NotFound();
            else if (r.SecretCode != scode.SecretCode)
                return StatusCode(403);

            aliasersService.DeleteAliaser(id);
            return Ok();
        }
    }
}
