using Moq;
using WebApiWithDockerCompose.Data;
using Xunit;

namespace XUnitTests
{
	public class UserUnitTest
	{
		[Fact]
		public void TestUserProperties()
		{
			// Mock object 
			var userMock = new Mock<IUser>();

			// Test the ID property
			userMock.Setup(user => user.ID).Returns(1);

			// Test the Name property
			userMock.Setup(user => user.Name).Returns("Maxime de Lange");

			// Test the Email property
			userMock.Setup(user => user.Email).Returns("MaximeDeLange@email.com");
		}

		[Fact]
		public void TestUserMethods()
		{
			// Mock object
			var userMock = new Mock<IUser>();

			// Test GetID method
			userMock.Setup(user => user.GetID()).Returns(1);

			// Test GetName method
			userMock.Setup(user => user.GetName()).Returns("Maxime de Lange");

			// Test GetEmail method
			userMock.Setup(user => user.GetEmail()).Returns("MaximeDeLange@email.com");
		}
	}
}
