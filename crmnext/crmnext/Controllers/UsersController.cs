using System.Collections.Generic;
using APP.Messages;
using IDAL.IUser;
using Microsoft.AspNetCore.Mvc;
using MODEL.User;

namespace APP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUser _user;
        public UsersController(IUser user)
        {
            _user = user;
        }

        [HttpGet]
        public ActionResult GetAllUsers()
        {
            List<User> users = _user.GetAllUsers();

            return Ok(users);
        }

        [HttpPost]
        public ActionResult CreateUser(User user)
        {
            string errorStatus = _user.CreateUser(user);
            Message message = new Message(errorStatus);

            return Ok(message.ErrorMessage(user.UserId));
        }

        [HttpPost]
        public ActionResult DeleteUser(User user)
        {
            string errorStatus = _user.DeleteUser(user);
            Message message = new Message(errorStatus);
            return Ok(message.ErrorMessage(user.UserId));
        }

        [HttpGet("{UserId}", Name = "GetUserById")]
        public ActionResult GetUserById(int UserId)
        {
            User user = _user.GetUserById(UserId);

            return Ok(user);
        }

    }

}
