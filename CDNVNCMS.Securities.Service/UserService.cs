using System.Linq;
using CDNVNCMS.Securities.Data;
using CDNVNCMS.Securities.Repository;
using CDNVNONE;
using CDNVNONE.Service;

namespace CDNVNCMS.Securities.Service
{
    [RegisterType(typeof(IUserService))]
    public class UserService:EntityService<User,SecurityContext>, IUserService
    {
        private ISecurityUOW _unitOfWork;
        private IUserRopository _userRopository;
        public UserService(ISecurityUOW unitOfWork, IUserRopository repository) : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _userRopository = repository;
        }

        public bool Exist(string username)
        {
            return _userRopository.GetAll().Any(u => u.Username.Equals(username));
        }
        public User GetUser(string username)
        {
            return _userRopository.FindBy(u => u.Username.Equals(username)).SingleOrDefault();
        }
    }
}
