using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiWithDockerCompose.Data;
using WebApiWithDockerCompose.Model;

namespace WebApiWithDockerCompose.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        /// <summary>
        /// Database context
        /// </summary>
        private readonly DatabaseContext _context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public UsersController(DatabaseContext context)
        {
            _context = context;
        }

        /// <summary>
        /// GET requests to retrieve all users
        /// </summary>
        /// <returns>retrieve all users</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        /// <summary>
        /// GET request that retrieves a user by its ID
        /// </summary>
        /// <param name="id">the id of the user</param>
        /// <returns>retrieve a specific user based on the given ID</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        /// <summary>
        /// PUT Request for updating an existing user by ID
        /// </summary>
        /// <param name="id">id of the user</param>
        /// <param name="user">user object that is going to be updated</param>
        /// <returns>the updated user object</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.ID)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        /// <summary>
        /// POST request to create a new user object.
        /// </summary>
        /// <param name="user">the object that is going to be created</param>
        /// <returns>the newly created user object</returns>
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.ID }, user);
        }

        /// <summary>
        /// DELETE request to remove a specific user by its ID
        /// </summary>
        /// <param name="id">the ID of the user</param>
        /// <returns>the deleted object</returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return user;
        }

        /// <summary>
        /// Checks if the user already exists within the database.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.ID == id);
        }
    }
}
