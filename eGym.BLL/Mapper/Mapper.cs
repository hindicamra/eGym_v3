using System;
using AutoMapper;
using eGym.BLL.Models;
using eGym.BLL.Models.Requests;
using eGym.Domain;

namespace eGym.BLL.Mapper;

public class Mapper : Profile
{
    public Mapper()
    {
        CreateMap<AccountDTO, Account>();
        CreateMap<Account, AccountDTO>();
        CreateMap<CreateAccountRequest, Account>();
        CreateMap<UpdateAccountRequest, AccountDTO>()
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

        CreateMap<EmployeeDTO, Employee>();
        CreateMap<Employee, EmployeeDTO>();
        CreateMap<CreateEmployeeRequest, Employee>();
        CreateMap<UpdateAccountRequest, EmployeeDTO>()
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

        CreateMap<FeedbackDTO, Feedback>();
        CreateMap<Feedback, FeedbackDTO>();
        CreateMap<CreateFeedbackRequest, Feedback>();
        CreateMap<UpdateFeedbackRequest, FeedbackDTO>()
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

        CreateMap<DietDTO, Diet>();
        CreateMap<Diet, DietDTO>();
        CreateMap<CreateDietRequest, Diet>();
        CreateMap<UpdateDietRequest, DietDTO>()
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

        CreateMap<ReservationDTO, Reservation>();
        CreateMap<Reservation, ReservationDTO>();
        CreateMap<CreateReservationRequest, Reservation>();
        CreateMap<UpdateReservationRequest, ReservationDTO>()
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

        CreateMap<PaymentRequest, Payment>();

        CreateMap<Models.Requests.Card, Domain.Card>();
        CreateMap<Domain.Card, Models.Requests.Card>();

        CreateMap<CustomerRequest, Customer>();

        CreateMap<TrainingDTO, Training>();
        CreateMap<Training, TrainingDTO>();
        CreateMap<CreateTrainingRequest, Training>();
        CreateMap<UpdateTrainingRequest, TrainingDTO>()
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

        CreateMap<ServiceDTO, Service>();
        CreateMap<Service, ServiceDTO>();
        CreateMap<CreateServiceRequest, Service>();
        CreateMap<UpdateServiceRequest, ServiceDTO>()
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
    }
}