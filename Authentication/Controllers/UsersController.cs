﻿using System;
using System.Collections.Generic;
using Authentication.Models;
using Microsoft.AspNetCore.Mvc;

namespace Authentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            var users = new[] {
                new User() { FirstName = "Allan", LastName = "Chua", UserId = Guid.Parse("539bf338-e5de-4fc4-ac65-4a91324d8111") },
                new User() { FirstName = "Burr", LastName = "Sutter", UserId = Guid.Parse("6b2c4788-e1d5-4ef4-8edf-e7d57e31bf4f") },
                new User() { FirstName = "Josh", LastName = "Long", UserId = Guid.Parse("3a4149fa-32e9-4d4a-a051-5c49b7ed2fca") }
            };
            return Ok(users);
        }
    }
}
