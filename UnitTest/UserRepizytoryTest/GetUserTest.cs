using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.UserRepizytoryTest
{
    public class GetUserTest
    {
        [Fact]
        public void GetUser_ReturnsUserWithSuccess_WhenUserExistsInDatabase()
        {
            /// 
            var userRepository = new UserRepository();
        
        }
        [Fact]
        public void GetUser_ReturnsNull_WhenUserDoesNotExistInDatabase()
        {
            ///

        }

    }
}
