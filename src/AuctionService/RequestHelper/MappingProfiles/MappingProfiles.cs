using System;
using AuctionService.DTOs;
using AuctionService.Entities;
using AutoMapper;

namespace Company.ClassLibrary1;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Auction, AuctionDto>()
            .IncludeMembers(x => x.Item); // Include the Item properties in the AuctionDto
        CreateMap<Item, AuctionDto>();
        CreateMap<CreateAuctionDto, Auction>()
            .ForMember(x => x.Item, opt => opt.MapFrom(src => src));
        CreateMap<CreateAuctionDto, Item>();
    }
}
