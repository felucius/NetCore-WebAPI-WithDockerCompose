using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWithDockerCompose.Data
{
	public interface IUser
	{
		/// <summary>
		/// ID
		/// </summary>
		int ID { get; set; }

		/// <summary>
		/// Name
		/// </summary>
		string Name { get; set; }

		/// <summary>
		/// Email
		/// </summary>
		string Email { get; set; }

		/// <summary>
		/// Get the ID of a user
		/// </summary>
		/// <returns></returns>
		int GetID();

		/// <summary>
		/// Get the name of a user
		/// </summary>
		/// <returns></returns>
		string GetName();

		/// <summary>
		/// Get the email of a user
		/// </summary>
		/// <returns></returns>
		string GetEmail();
	}
}
