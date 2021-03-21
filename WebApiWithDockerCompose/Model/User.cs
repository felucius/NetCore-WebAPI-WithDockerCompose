
using WebApiWithDockerCompose.Data;

namespace WebApiWithDockerCompose.Model
{
	/// <summary>
	/// The User class that contains information regarding a user.
	/// </summary>
	public class User : IUser
	{
		/// <summary>
		/// ID
		/// </summary>
		public int ID { get; set; }

		/// <summary>
		/// Name
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Email
		/// </summary>
		public string Email { get; set; }

		/// <summary>
		/// Get the email of a user.
		/// </summary>
		/// <returns></returns>
		public string GetEmail()
		{
			return this.Email;
		}

		/// <summary>
		/// Get the ID of a user
		/// </summary>
		/// <returns></returns>
		public int GetID()
		{
			return this.ID;
		}

		/// <summary>
		///  Get the name of a user.
		/// </summary>
		/// <returns></returns>
		public string GetName()
		{
			return this.Name;
		}
	}
}
