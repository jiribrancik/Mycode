using Microsoft.AspNetCore.Mvc;
using Reddit2.Database;
using Reddit2.Model;
using Reddit2.Services;
using Reddit2.ViewModel;

namespace Reddit2.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private UserService userService;
        private PostService service;
        private ApplicationDbContext context;
        private CurrentUserService currentUserService;
        public HomeController(PostService service, ApplicationDbContext context, UserService userService, CurrentUserService currentUserService)
        {
            this.service = service;
            this.context = context;
            this.userService = userService;
            this.currentUserService = currentUserService;
        }

        [HttpGet("index")]
        public IActionResult Index()
        {
            if(currentUserService.User == null)
            {
                return View("login");
            }
            else
            {
                var vm = new IndexViewModel();
                vm.ListOfPosts = service.GetPosts();
                vm.CurrentUser = currentUserService.User;
                vm.ListOfUsers = context.Users.ToList();

                return View("index", vm);
            }
            
        }

        [HttpGet("submitpost")]
        public IActionResult SubmitPost()
        {
            return View("SubmitPost");
        }

        [HttpPost("submitpost")]
        public IActionResult SubmitPost(string title, string url)
        {
            service.AddPost(title, url);
            return RedirectToAction("index");
        }

        [HttpGet("registration")]
        public IActionResult RegisterUser()
        {
            return View("Registration");
        }

        [HttpPost("registration")]
        public IActionResult RegisterUser(string userName, string userPassword)
        {
            userService.AddUser(userName, userPassword);
            return RedirectToAction("index");
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost("login")]
        public IActionResult Login(User u)
        {

             User? user = userService.Authentication(u.UserName, u.UserPassword);

            currentUserService.User = user ?? currentUserService.User;
            return RedirectToAction("index");
        }

        [HttpGet("vote")]
        public IActionResult Vote()
        {
            return View();
        }

        [HttpPost("vote")]
        public IActionResult Vote(int votevalue, int postId)
        {
            int userId = currentUserService.User.Id;

            service.Vote(votevalue, userId, postId);
            return RedirectToAction("index");
        }
    }
}
