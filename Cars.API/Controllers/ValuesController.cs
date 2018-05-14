using System;
using System.Threading.Tasks;
using Cars.Services;
using System.Web.Http;

namespace Cars.API.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly CarsService _service;

        public ValuesController()
        {
            var repo = RepoFactory.Repos.GetCarRepo();
            var service = new CarsService(repo);
            _service = service;
        }

        [HttpGet, Route("api/users")]
        public async Task<IHttpActionResult> GetUsers()
        {
            try
            {
                var data = await _service.GetUsersAsync().ConfigureAwait(false);

                if (data != null)
                    return Ok(data);

                return NotFound();
            }
            catch (Exception ex)
            {
                //Logging here
                return InternalServerError();
            }
        }

        [HttpGet, Route("api/manufacturers")]
        public async Task<IHttpActionResult> GetManufacturers()
        {
            try
            {
                var data = await _service.GetManufacturersAsync().ConfigureAwait(false);

                if (data != null)
                    return Ok(data);

                return NotFound();
            }
            catch (Exception ex)
            {
                //Logging here
                return InternalServerError();
            }
        }

        [HttpGet, Route("api/user/{id}")]
        public async Task<IHttpActionResult> GetUserInfoById(int id)
        {
            try
            {
                var data = await _service.GetUserDetailsByIdAsync(id).ConfigureAwait(false);

                if (data != null)
                    return Ok(data);

                return NotFound();
            }
            catch (Exception ex)
            {
                //Logging here
                return InternalServerError();
            }
        }
    }
}
