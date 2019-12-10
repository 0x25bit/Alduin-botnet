using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Alduin.Logic.Interfaces.Managers;
using Alduin.Logic.Interfaces.Repositories;
using Alduin.Shared.DTOs;
using Alduin.Shared.Enums;

namespace Alduin.Logic.Identity
{
    public class AppIdentityUserStore : UserStoreBase<AppIdentityUser, int, AppIdentityUserClaim, IdentityUserLogin<int>, IdentityUserToken<int>>
    {
        private readonly IUserManager _userManager;
        private readonly IUserRepository _userRepository;
        private readonly IUserClaimManager _userClaimManager;
        private readonly IUserClaimRepository _userClaimRepository;
        private readonly IMapper _mapper;

        public AppIdentityUserStore(
            AppIdentityErrorDescriber describer,
            IUserManager userManager,
            IUserRepository userRepository,
            IUserClaimManager userClaimManager,
            IUserClaimRepository userClaimRepository,
            IMapper mapper)
            : base(describer)
        {
            _userManager = userManager;
            _userRepository = userRepository;
            _userClaimManager = userClaimManager;
            _userClaimRepository = userClaimRepository;
            _mapper = mapper;
        }

        #region User Management

        public override IQueryable<AppIdentityUser> Users => _userRepository.GetAll().Select(_mapper.Map<AppIdentityUser>).ToList().AsQueryable();

        public override async Task<IdentityResult> CreateAsync(AppIdentityUser identityUser, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            if (identityUser == null)
                throw new ArgumentNullException(nameof(identityUser));

            identityUser.UserName = identityUser.Email;

            var newUser = new UserDTO();
            _mapper.Map(identityUser, newUser);

            var result = _userManager.Save(newUser);

            if (!result.Succeeded)
                return IdentityResult.Failed(new IdentityError
                {
                    Code = "user_save_error",
                    Description = "Couldn't save User."
                });

            newUser.Id = result.Id.Value;
            _mapper.Map(newUser, identityUser);

            var claims = new List<Claim>
            {
                new AppIdentityUserClaim(identityUser, Role.User).ToClaim(),
                new AppIdentityUserClaim
                {
                    UserId = identityUser.Id,
                    ClaimType = "UserId",
                    ClaimValue = identityUser.Id.ToString()
                }.ToClaim()
            };

            await AddClaimsAsync(identityUser, claims, cancellationToken);

            return IdentityResult.Success;
        }

        public override Task<IdentityResult> DeleteAsync(AppIdentityUser identityUser, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            if (identityUser == null)
            {
                throw new ArgumentNullException(nameof(identityUser));
            }

            _userManager.Delete(identityUser.Id);

            return Task.FromResult(IdentityResult.Success);
        }

        public override Task<AppIdentityUser> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            var user = _userRepository.Get(int.Parse(userId));
            return Task.FromResult(_mapper.Map<AppIdentityUser>(user));
        }

        public override Task<AppIdentityUser> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            var user = _userRepository.FindByUserName(normalizedUserName);
            return Task.FromResult(_mapper.Map<AppIdentityUser>(user));
        }

        public override Task<AppIdentityUser> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken)
        {
            return FindByNameAsync(normalizedEmail, cancellationToken);
        }

        protected override Task<AppIdentityUser> FindUserAsync(int userId, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            var user = _userRepository.Get(userId);
            return Task.FromResult(_mapper.Map<AppIdentityUser>(user));
        }

        public override Task<string> GetNormalizedUserNameAsync(AppIdentityUser identityUser, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            if (identityUser == null)
            {
                throw new ArgumentNullException(nameof(identityUser));
            }

            return Task.FromResult(identityUser.NormalizedUserName);
        }

        public override Task<string> GetUserIdAsync(AppIdentityUser identityUser, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            if (identityUser == null)
            {
                throw new ArgumentNullException(nameof(identityUser));
            }

            return Task.FromResult(identityUser.Id.ToString());
        }

        public override Task<string> GetUserNameAsync(AppIdentityUser identityUser, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            if (identityUser == null)
            {
                throw new ArgumentNullException(nameof(identityUser));
            }

            return Task.FromResult(identityUser.UserName);
        }

        public override Task SetNormalizedUserNameAsync(AppIdentityUser identityUser, string normalizedName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            if (identityUser == null)
            {
                throw new ArgumentNullException(nameof(identityUser));
            }

            return Task.FromResult(identityUser.NormalizedUserName = normalizedName);
        }

        public override Task SetUserNameAsync(AppIdentityUser identityUser, string userName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            if (identityUser == null)
            {
                throw new ArgumentNullException(nameof(identityUser));
            }

            return Task.FromResult(identityUser.UserName = userName);
        }

        public override Task<IdentityResult> UpdateAsync(AppIdentityUser identityUser, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            if (identityUser == null)
            {
                throw new ArgumentNullException(nameof(identityUser));
            }

            var user = identityUser.Id > 0
                ? _userRepository.Get(identityUser.Id)
                : new UserDTO();
            _mapper.Map(identityUser, user);

            _userManager.Save(user);

            return Task.FromResult(IdentityResult.Success);
        }
        #endregion

        #region Password Management
        public override Task<string> GetPasswordHashAsync(AppIdentityUser identityUser, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            if (identityUser == null)
            {
                throw new ArgumentNullException(nameof(identityUser));
            }

            return Task.FromResult(identityUser.PasswordHash);
        }

        public override Task<bool> HasPasswordAsync(AppIdentityUser identityUser, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            if (identityUser == null)
            {
                throw new ArgumentNullException(nameof(identityUser));
            }

            return Task.FromResult(!string.IsNullOrEmpty(identityUser.PasswordHash) && string.IsNullOrWhiteSpace(identityUser.PasswordHash) && identityUser.PasswordHash.Length > 0);
        }

        public override Task SetPasswordHashAsync(AppIdentityUser identityUser, string passwordHash, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            if (identityUser == null)
            {
                throw new ArgumentNullException(nameof(identityUser));
            }

            return Task.FromResult(identityUser.PasswordHash = passwordHash);
        }
        #endregion

        #region Claim Management
        public override Task<IList<Claim>> GetClaimsAsync(AppIdentityUser identityUser, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            if (identityUser == null)
            {
                throw new ArgumentNullException(nameof(identityUser));
            }

            var claims = _userClaimRepository.GetByUserId(identityUser.Id)
                .Select(_mapper.Map<AppIdentityUserClaim>)
                .Select(x => x.ToClaim())
                .ToList() as IList<Claim>;

            return Task.FromResult(claims);
        }

        public override Task AddClaimsAsync(AppIdentityUser identityUser, IEnumerable<Claim> claims, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            if (identityUser == null)
            {
                throw new ArgumentNullException(nameof(identityUser));
            }
            if (claims == null)
            {
                throw new ArgumentNullException(nameof(claims));
            }

            var user = _userRepository.Get(identityUser.Id);
            if (user == null)
            {
                return Task.FromResult(IdentityResult.Failed(
                    new IdentityError { Code = "user_not_found", Description = $"Cannot find User with id {user.Id}!" }));
            }

            foreach (var claim in claims)
            {
                var existingClaims = _userClaimRepository.GetSpecificClaimsByUserId(identityUser.Id, claim.Type, claim.Value);
                if (existingClaims.Length == 0)
                {
                    var newClaim = CreateUserClaim(identityUser, claim);
                    var userClaim = _mapper.Map<UserClaimDTO>(newClaim);
                    userClaim.Id = 0;
                    userClaim.UserId = user.Id;
                    _userClaimManager.Save(userClaim);
                }
            }

            return Task.FromResult(IdentityResult.Success);
        }

        public override Task ReplaceClaimAsync(AppIdentityUser identityUser, Claim claim, Claim newClaim, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            if (identityUser == null)
            {
                throw new ArgumentNullException(nameof(identityUser));
            }
            if (claim == null)
            {
                throw new ArgumentNullException(nameof(claim));
            }
            if (newClaim == null)
            {
                throw new ArgumentNullException(nameof(newClaim));
            }

            var matchedClaims = _userClaimRepository.GetSpecificClaimsByUserId(identityUser.Id, claim.Type, claim.Value);

            foreach (var matchedClaim in matchedClaims)
            {
                matchedClaim.ClaimType = newClaim.Type;
                matchedClaim.ClaimValue = newClaim.Value;
                _userClaimManager.Save(matchedClaim);
            }

            return Task.FromResult(IdentityResult.Success);
        }

        public override Task RemoveClaimsAsync(AppIdentityUser identityUser, IEnumerable<Claim> claims, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            if (identityUser == null)
            {
                throw new ArgumentNullException(nameof(identityUser));
            }
            if (claims == null)
            {
                throw new ArgumentNullException(nameof(claims));
            }

            foreach (var claim in claims)
            {
                var userClaims = _userClaimRepository.GetSpecificClaimsByUserId(identityUser.Id, claim.Type, claim.Value);
                foreach (var userClaim in userClaims)
                {
                    _userClaimManager.Delete(userClaim.Id);
                }
            }

            return Task.FromResult(IdentityResult.Success);
        }

        public override Task<IList<AppIdentityUser>> GetUsersForClaimAsync(Claim claim, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            if (claim == null)
            {
                throw new ArgumentNullException(nameof(claim));
            }

            var users = _userRepository.GetByClaim(claim.Type, claim.Value);
            return Task.FromResult(_mapper.Map<IList<AppIdentityUser>>(users));
        }
        #endregion

        #region External Login Management
        protected override Task<IdentityUserLogin<int>> FindUserLoginAsync(int userId, string loginProvider, string providerKey, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        protected override Task<IdentityUserLogin<int>> FindUserLoginAsync(string loginProvider, string providerKey, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public override Task AddLoginAsync(AppIdentityUser user, UserLoginInfo login, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task RemoveLoginAsync(AppIdentityUser user, string loginProvider, string providerKey, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task<IList<UserLoginInfo>> GetLoginsAsync(AppIdentityUser user, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Token Management
        protected override Task<IdentityUserToken<int>> FindTokenAsync(AppIdentityUser user, string loginProvider, string name, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        protected override Task AddUserTokenAsync(IdentityUserToken<int> token)
        {
            throw new NotImplementedException();
        }

        protected override Task RemoveUserTokenAsync(IdentityUserToken<int> token)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
