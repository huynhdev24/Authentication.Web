using Authentication.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Authentication.Web.Controllers
{
    [Authorize]
    [Route("api/address")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<AddressModel> Get()
        {
            List<AddressModel> addresses = new()
            {
                new AddressModel { Name = "Nguyen Van Huynh", HouseName = "Wscenco", City = "HCM City", State = "HCM", Pin = 7100000 },
                new AddressModel { Name = "Duong An", HouseName = "Gaming House", City = "HCM", State = "Kerala", Pin = 7100000 },
                new AddressModel { Name = "Thanh An", HouseName = "Tiem Net", City = "Oachira", State = "HCM", Pin = 7100000 },
            };
            return addresses;
        }
    }
}
