using AutoMapper;
using System;
using Alduin.DataAccess.Entities;
using Alduin.Logic.Identity;
using Alduin.Shared.DTOs;

namespace Alduin.Logic.Mapping
{
    public class AutoMapperBaseProfile : Profile
    {
        public AutoMapperBaseProfile()
        {
            CreateMap<CreditCardEntity, CreditCardDTO>().ReverseMap();

            CreateMap<UserEntity, UserDTO>();
            CreateMap<UserDTO, UserEntity>()
                .ForMember(dest => dest.UserName, m => m.MapFrom(src => src.Email))
                .ForMember(dest => dest.NormalizedUserName, m => m.MapFrom(src => src.Email.ToUpper()));

            CreateMap<UserDTO, AppIdentityUser>()
                .ForMember(dest => dest.LockoutEnd, m => m.MapFrom(src => src.LockoutEnd))
                .ForMember(dest => dest.UserName, m => m.MapFrom(src => src.Email))
                .ForMember(dest => dest.NormalizedUserName, m => m.MapFrom(src => src.Email.ToUpper()));
            CreateMap<AppIdentityUser, UserDTO>()
                .ForMember(dest => dest.LockoutEnd, m => m.MapFrom(src => src.LockoutEnd.HasValue ? (DateTime?)DateTime.Parse(src.LockoutEnd.ToString()) : null));

            CreateMap<UserEntity, AppIdentityUser>()
                .ForMember(dest => dest.LockoutEnd, m => m.MapFrom(src => src.LockoutEnd));
            CreateMap<AppIdentityUser, UserEntity>()
                .ForMember(dest => dest.LockoutEnd, m => m.MapFrom(src => src.LockoutEnd.HasValue ? (DateTime?)DateTime.Parse(src.LockoutEnd.ToString()) : null));

            CreateMap<UserClaimEntity, UserClaimDTO>()
                .ForMember(dest => dest.UserId, m => m.MapFrom(src => src.User != null ? src.User.Id : (int?)null));
            CreateMap<UserClaimDTO, UserClaimEntity>()
                .ForMember(dest => dest.User, m => m.MapFrom(src => src.UserId.HasValue ?  new UserEntity { Id = src.UserId.Value } : null));

            CreateMap<UserClaimDTO, AppIdentityUserClaim>().ReverseMap();

            //Record
            //CreateMap<RecordEntity, RecordDTO>().ReverseMap();
            CreateMap<RecordEntity, RecordDTO>()
                .ForMember(dest => dest.AccountId, m => m.MapFrom(src => src.Account != null ? src.Account.Id : (int?)null))
                .ForMember(dest => dest.RecordCategoryId, m => m.MapFrom(src => src.RecordCategory != null ? src.RecordCategory.Id : (int?)null));
            CreateMap<RecordDTO, RecordEntity>()
                .ForMember(dest => dest.Account, m => m.MapFrom(src => src.AccountId.HasValue ? new AccountEntity { Id = src.AccountId.Value } : null))
                .ForMember(dest => dest.RecordCategory, m => m.MapFrom(src => src.RecordCategoryId.HasValue ? new RecordCategoryEntity { Id = src.RecordCategoryId.Value } : null));

            //Account
            CreateMap<AccountEntity, AccountDTO>()
                .ForMember(dest => dest.UserId, m => m.MapFrom(src => src.User != null ? src.User.Id : (int?)null));
            CreateMap<AccountDTO, AccountEntity>()
                .ForMember(dest => dest.User, m => m.MapFrom(src => src.UserId.HasValue ? new UserEntity { Id = src.UserId.Value } : null));

            //RecordCategory
            CreateMap<RecordCategoryEntity, RecordCategoryDTO>()
                .ForMember(dest => dest.ParentCategoryId, m => m.MapFrom(src => src.ParentCategory != null ? src.ParentCategory.Id : (int?)null));
            CreateMap<RecordCategoryDTO, RecordCategoryEntity>()
                .ForMember(dest => dest.ParentCategory, m => m.MapFrom(src => src.ParentCategoryId.HasValue ? new UserEntity { Id = src.ParentCategoryId.Value } : null));

            //RecordTemplate
            CreateMap<RecordTemplateEntity, RecordTemplateDTO>()
                .ForMember(dest => dest.AccountId, m => m.MapFrom(src => src.Account != null ? src.Account.Id : (int?)null))
                .ForMember(dest => dest.RecordCategoryId, m => m.MapFrom(src => src.RecordCategory != null ? src.RecordCategory.Id : (int?)null));
            CreateMap<RecordTemplateDTO, RecordTemplateEntity>()
                .ForMember(dest => dest.Account, m => m.MapFrom(src => src.AccountId.HasValue ? new AccountEntity { Id = src.AccountId.Value } : null))
                .ForMember(dest => dest.RecordCategory, m => m.MapFrom(src => src.RecordCategoryId.HasValue ? new RecordCategoryEntity { Id = src.RecordCategoryId.Value } : null));
        }
    }
}
