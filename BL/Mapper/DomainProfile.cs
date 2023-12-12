using AutoMapper;
using BankSystem.DAL.Entities;
using BankSystem.Models;

namespace BankSystem.BL.Mapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Account_VM, Account>();
            CreateMap<Account, Account_VM>();
            CreateMap<Customer, Customer_VM>();
            CreateMap<Customer_VM, Customer>();
        }
    }
}
