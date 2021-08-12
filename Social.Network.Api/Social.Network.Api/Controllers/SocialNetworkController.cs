using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Social.Network.Domain.Commands;
using Social.Network.Domain.Models;
using Social.Network.Domain.Models.Auths;
using Social.Network.Domain.Queries;
using Social.Network.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Social.Network.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SocialNetworkController : ControllerBase
    {
        #region Private Members

        /// <summary>
        /// A single instance from <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<SocialNetworkController> logger;

        /// <summary>
        /// A single instance from <see cref="IQueryRepository"/>
        /// </summary>
        private readonly IQueryRepository query;

        /// <summary>
        /// A single instance from <see cref="ICommandRepository"/>
        /// </summary>
        private readonly ICommandRepository command;

        /// <summary>
        /// A single instance from <see cref="IUserService"/>
        /// </summary>
        private readonly IUserService user;

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="query"></param>
        /// <param name="command"></param>
        public SocialNetworkController(ILogger<SocialNetworkController> logger, IQueryRepository query, ICommandRepository command, IUserService user)
        {
            this.logger = logger;
            this.query = query;
            this.command = command;
            this.user = user;
        }

        #endregion

        [AllowAnonymous]
        [HttpPost("Authenticate")]
        public IActionResult Authenticate(AuthRequest model)
        {
            var response = user.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }


        [HttpGet, Route("Users")]
        public ActionResult FetchUsers()
        {
            return Ok(query.GetUsers());
        }


        [HttpGet, Route("People")]
        public ActionResult FetchPeople()
        {
            //var reqAt = DateTime.Now;
            //var result = query.GetPeople();

            //var response = new RestResponse<People>()
            //{
            //    Message = "Success",
            //    StatusCode = (int)HttpStatusCode.OK,
            //    Data = result.ToList(),
            //    RequestAt = reqAt,
            //    ResponseAt = DateTime.Now,
            //};

            return Ok(query.GetPeople());
        }

        [HttpGet, Route("Channels")]
        public ActionResult FetchChannels()
        {
            //var reqAt = DateTime.Now;
            //var result = query.GetChannels();

            //var response = new RestResponse<Channels>()
            //{
            //    Message = "Success",
            //    StatusCode = (int)HttpStatusCode.OK,
            //    Data = result.ToList(),
            //    RequestAt = reqAt,
            //    ResponseAt = DateTime.Now,
            //};

            return Ok(query.GetChannels());
        }

        [HttpGet, Route("Activities")]
        public ActionResult FetchActivities()
        {
            //var reqAt = DateTime.Now;
            //var result = query.GetActivities();

            //var response = new RestResponse<Activities>()
            //{
            //    Message = "Success",
            //    StatusCode = (int)HttpStatusCode.OK,
            //    Data = result.ToList(),
            //    RequestAt = reqAt,
            //    ResponseAt = DateTime.Now,
            //};

            return Ok(query.GetActivities());
        }

        [HttpGet, Route("Documents")]
        public ActionResult FetchDocuments()
        {
            //var reqAt = DateTime.Now;
            //var result = query.GetDocuments();

            //var response = new RestResponse<Documents>()
            //{
            //    Message = "Success",
            //    StatusCode = (int)HttpStatusCode.OK,
            //    Data = result.ToList(),
            //    RequestAt = reqAt,
            //    ResponseAt = DateTime.Now,
            //};

            return Ok(query.GetDocuments());
        }

        [HttpGet, Route("Videos")]
        public ActionResult FetchVideos()
        {
            //var reqAt = DateTime.Now;
            //var result = query.GetVideos();

            //var response = new RestResponse<Videos>()
            //{
            //    Message = "Success",
            //    StatusCode = (int)HttpStatusCode.OK,
            //    Data = result.ToList(),
            //    RequestAt = reqAt,
            //    ResponseAt = DateTime.Now,
            //};

            return Ok(query.GetVideos());
        }
    }
}
